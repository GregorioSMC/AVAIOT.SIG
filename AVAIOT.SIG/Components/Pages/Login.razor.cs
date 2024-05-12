using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Radzen;

namespace AVAIOT.SIG.Components.Pages
{
    public partial class Login
    {
        string userName = "admin";
        string password = "admin";
        bool rememberMe = true;
        

        void OnLogin(LoginArgs args, string name)
        {
            Console.WriteLine($"{name} -> Username: {args.Username}, password: {args.Password}, remember me: {args.RememberMe}");
            
        }

        void OnRegister(string name)
        {
            Console.WriteLine($"{name} -> Register");
        }

        void OnResetPassword(string value, string name)
        {
            Console.WriteLine($"{name} -> ResetPassword for user: {value}");
        }
    }
}
