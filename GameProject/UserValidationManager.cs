using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear ==1993 && gamer.FirstName=="GÖZDE" && gamer.LastName=="TOZ" && gamer.IdentityNumber==12345678901)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
