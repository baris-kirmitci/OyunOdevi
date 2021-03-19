using OyunOdevi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi.Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game was added = " + game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game was deleted = " + game.Name);
        }

        public void List(List<Game> games)
        {
            Console.WriteLine("Game was Listed.");
            foreach (var game in games)
            {
                Console.WriteLine(game.Name);
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game was updated = " + game.Name);
        }
    }
}
