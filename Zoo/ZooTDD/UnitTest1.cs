using System;
using Xunit;
using Zoo.Classes;

namespace ZooTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Interface Test
        /// </summary>
        [Fact]
        public void OtterTest1()
        {
            DinoOtter testOne = new DinoOtter();
            Assert.Equal("Watch me perfrom a trick back flip", testOne.Perform());
        }

        [Fact]
        public void OtterTest2()
        {
            DinoOtter testTwo = new DinoOtter();
            Assert.Equal(2_234.50m, testTwo.FeedCost);
        }
        
        /// <summary>
        /// This proves that a Concrete animal orca is an Animal class.
        /// </summary>
        [Fact]
        public void IsAnimal()
        {
            Orca testAnimal = new Orca();
            Assert.True(testAnimal is Animal);
        }
        
        /// <summary>
        /// Prove method is overridden
        /// </summary>
        [Fact]
        public void PterodactylTest1Speak()
        {
            Pterodactyl testOne = new Pterodactyl();
            Assert.Equal("Kaaaaaaaaahnnnn", testOne.Speak());
        }

        [Fact]
        public void PterodactylTest2Moving()
        {
            Pterodactyl testTwo = new Pterodactyl();
            Assert.Equal("I like to move it move it" ,testTwo.Moving());
        }

        [Fact]
        public void FlyingSpiderTest1Safe()
        {
            FlyingSpider testOne = new FlyingSpider();
            Assert.False(testOne.Safe());
        }

        [Fact]
        public void FlyingSpiderTest2FeedCost()
        {
            FlyingSpider testTwo = new FlyingSpider();
            Assert.Equal(688.25m, testTwo.FeedCost);
        }

        /// <summary>
        /// Another Interface Test
        /// </summary>
        [Fact]
        public void TrexTest1LovesHumans()
        {
            TRex testOne = new TRex();
            Assert.True(testOne.lovesHumans);
        }


        [Fact]
        public void TrexTest2()
        {
            TRex testTwo = new TRex();
            Assert.Equal("I enjoy being hugged as I myself can not reach to hug others.  That makes me a sad T-Rex...", testTwo.Hug());
        }

        [Fact]
        public void BrontosaursTest1()
        {
            Brontosaurs testOne = new Brontosaurs();
            Assert.Equal(1_987_654.50m, testOne.FeedCost);
        }

        [Fact]
        public void BrontosaursTest2()
        {
            Brontosaurs testTwo = new Brontosaurs();
            Assert.False(testTwo.Safe);
        }

        [Fact]
        public static void DinoSharkTest1()
        {
            DinoShark testOne = new DinoShark();
            Assert.True(testOne.Scales);
        }

        [Fact]
        public static void DinoSharkTest2()
        {
            DinoShark testTwo = new DinoShark();
            Assert.Equal(25, testTwo.EggsPerYear());
        }

        [Fact]
        public void OctoTest1()
        {
            Octopus testOne = new Octopus();
            Assert.Equal(44, testOne.Eyes);
        }

        [Fact]
        public void OctoTest2()
        {
            Octopus testTwo = new Octopus();
            Assert.Equal("Children's pool", testTwo.Location);
        }

        [Fact]
        public void OrcaTest1()
        {
            Orca testOne = new Orca();
            Assert.True(testOne.Safe);
        }

        [Fact]
        public void OrcaTest2()
        {
            Orca testTwo = new Orca();
            Assert.Equal(2, testTwo.GiveBirth());
        }
    }
}
