IUser user = new User();
user.IsAuthenticated("user1", "p4ssw0rd");
var authenication = new Authentication(user);
var result = authenication.LoginUser("user1", "p4ssw0rd");
Console.WriteLine(result);