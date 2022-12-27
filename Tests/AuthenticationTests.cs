using NUnit.Framework;
using Moq;
using FluentAssertions;

public class AuthenticationTests
{
    [Test]
    public void Assert_ForUsernameAndPassword_ReturnsTrue()
    {
        var user = new Mock<IUser>();
        user.Setup(x => x.Login("user1", "p4ssw0rd")).Returns(true);
        // user.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
        
        var authenication = new Authentication(user.Object);
        var result = authenication.LoginUser("user1", "p4ssw0rd");
        result.Should().BeTrue();
    }
}