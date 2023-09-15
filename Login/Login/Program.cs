using System;
namespace Login
{
    public class Program
    {
        public static string SignIn(string username,string password)
        {
            string msg;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "userName and password should not null and Empty";
            }
            else
            {
                if (username == "venkatesh" && password == "venkat@123")
                {
                    msg = "Login Succesfully";
                }
                else
                {
                    msg = "invalid Details";
                }
               
            }
            return msg;
        }
        static void Main(string[] args)
        {
        }
    }
}
