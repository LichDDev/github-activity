using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_activity.Validator
{
    public static class UserValidator
    {
        public static bool ValidateAndGetUsername(string user)
        {
            if (string.IsNullOrEmpty(user))
            {
                Console.WriteLine("Error: No username provided.");
                
                return false;
            }

            return true;
        }
    }
}
