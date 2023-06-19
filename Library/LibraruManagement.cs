using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraruManagement : LibraryManagementCore
    {
        public void RegisterUser(string firstName, string lastName)
        {

        }

        public void RegisterUser(string firstName, string lastName, string userName)
        {
            var foundUser = false;

            foreach(var user in Store.Users)
            {
                if(user.UserName == userName)
                {
                    foundUser = true;
                    break;
                }

                if (foundUser)
                    return;

                Store.Users.Add(new User(firstName, lastName, userName));
            }
        }




    }
}
