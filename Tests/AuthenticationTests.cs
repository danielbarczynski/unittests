using NUnit.Framework;
using Moq;
using FluentAssertions;

public class AuthenticationTests
{
    [Test]
    public void AssertMoq_ForUsernameAndPassword_ReturnsTrue()
    {
        var user = new Mock<IUser>();
        user.Setup(x => x.IsAuthenticated("user1", "p4ssw0rd")).Returns(true);
        // user.Setup(x => x.IsAuthenticated(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
        
        var authenication = new Authentication(user.Object);
        var result = authenication.LoginUser("user1", "p4ssw0rd");
        result.Should().BeTrue();
    }

    [Test]
    public void Assert_ForUsernameAndPassword_ReturnsTrue()
    {
        IUser user = new User(); // only works when class is created
        var authenication = new Authentication(user);
        var result = authenication.LoginUser("user1", "p4ssw0rd");
        result.Should().BeTrue();
    }
}