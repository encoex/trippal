using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDisplayApp.Utils
{
    public class UserProfile
    {
        public class User
        {
            public string userName;
            public ulong userId;
        }
        
        private ulong token;

        public User CurrentUser { get; set; }

        private static UserProfile userProfile;

        // singleton, so no it can be initiliazed outside
        private UserProfile()
        {
            // fix current user
        }

        public static UserProfile GetUserProfile()
        {
            if (userProfile == null)
            {
                userProfile = new UserProfile();
            }

            return userProfile;
        }

        public bool UserTryLogin()
        {
            return true;
        }
    
    }
}
