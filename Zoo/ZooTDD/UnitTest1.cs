using System;
using Xunit;
using Zoo.Classes;

namespace ZooTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TRexTest()
        {
            TRex rex = new TRex();
            Assert.Equal("I enjoy healthy balance of vegitable and lean meats.", rex.Eat());
        }

        [Fact]
        public void OctoTest()
        {
            Octopus octopus = new Octopus();
            Assert.Equal(44, octopus.Eyes);
        }

        [Fact]
        public static void DinoShark()
        {
            DinoShark dinoShark = new DinoShark();
            Assert.True(dinoShark.Scales);
        }
    }
}
