using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
          _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
             if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else {
                Console.WriteLine("Doğrulama Başarısız.Kayıt Başarısız."); 
                 }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
