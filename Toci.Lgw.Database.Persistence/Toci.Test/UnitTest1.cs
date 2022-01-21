using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Lgw.Database;
using Toci.Lgw.Database.Persistence.Models;

namespace Toci.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Repository<Game> repository = new Repository<Game>();

            Game LoL = new Game()
            {
                Name = "Leauge of Legends"
            };
            
            repository.Insert(LoL);
            
        }

        [TestMethod]
        public void Gamer()
        {
            Repository<Gamer> gamerrepository = new Repository<Gamer>();

            gamerrepository.Insert(new Gamer()
            {
                Nick = "Wiktor 14"
            });
        }
    }
}