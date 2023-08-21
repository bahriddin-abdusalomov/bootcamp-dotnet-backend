using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraruManagement : LibraryManagementCore
    {

        private EmailService emailService;

        public LibraruManagement()
        {
            emailService = new EmailService();
        }

        public void RegisterUser(string firstName, string lastName)
        {

        }

        public void RegisterUser(string firstName, string lastName, string userName)
        {
            var foundUser = false;
                
            foreach(var user in Store.Users)
            {
                if(user.Email == userName)
                {
                    foundUser = true;
                    break;
                }

                if (foundUser)
                    return;

                Store.Users.Add(new User(firstName, lastName, userName));
                emailService.SendEmail(userName);
            }
        }

    }
}
