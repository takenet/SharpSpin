using System;
using SharpSpin;
using Xunit;

namespace UnitTests
{    
    public class RandomizerTests
    {
        /// <summary>
        /// Instance of the "real" randomizer
        /// </summary>
        private static RealRandom randomizer;

        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        
        public RandomizerTests()
        {
            //init spinner
            randomizer = new RealRandom();
        }

        [Fact]
        public void InvalidMaxParam()
        {
            //arrange
            int max = -1;

            //act

            Assert.Throws<ArgumentOutOfRangeException>(() => randomizer.Generate(max));
        }

        [Fact]
        public void GenerateInt()
        {
            //arrange
            int max = 2;

            //act
            var result = randomizer.Generate(max);

            //assert
            Assert.IsType<int>(result);
            Assert.True(result < max, "Should be less than the max");
        }
    }
}
