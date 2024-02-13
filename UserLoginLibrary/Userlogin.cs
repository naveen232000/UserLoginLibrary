namespace UserLoginLibrary
{
    public class Userlogin
    {
        public string Login(string username, string password)
        {
            string result = "";
            if (username == "naveen" & password == "n@123")
            {
                result = "Login Success";
            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}
