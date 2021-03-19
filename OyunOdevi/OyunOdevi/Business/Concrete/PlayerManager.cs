using OyunOdevi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi.Business.Concrete
{
    public class PlayerManager : IPlayerService 

    {

        bool checkService = false ;
        public void Add(Player player)
        {
            if ((checkService == true))
             
            {
                Console.WriteLine("Player Added : " + player.FirstName);
                
            }
            else
            {
                Console.WriteLine("Player validation error. ");
            }


        }

     

        public void Delete(Player player)
        {
            
        }

        public void Update(Player player)
        {
           
        }
    }
}
