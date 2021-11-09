using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class DiceTests
    {
        Dice dice0;
        Dice dice1;
        Dice dice2;
        Dice dice3;
        Dice dice4;
        Dice dice5;
        Dice[] diceList;

        public DiceTests(){
            this.dice0 = new Dice(1,6);
            this.dice1 = new Dice(1,1);
            this.dice2 = new Dice(0,5);
            this.dice3 = new Dice(-5,5);
            this.dice4 = new Dice(-5,0);
            this.dice5 = new Dice(-1,-1);
            this.diceList = new Dice[]{ this.dice0, this.dice1, this.dice2, this.dice3, this.dice4, this.dice5 };
        }

        [Theory]
        [InlineData(0,1,6)]
        [InlineData(1,1,1)]
        [InlineData(2,0,5)]
        [InlineData(3,-5,5)]
        [InlineData(4,-5,0)]
        [InlineData(5,-1,-1)]
        public void DiceValueTests(int diceIndex, int diceValueMin, int diceValueMax)
        {
            int diceValue;
            for(int i=0; i<100; i++){
                diceValue = this.diceList[diceIndex].Roll();
                Assert.InRange(diceValue, diceValueMin, diceValueMax);
            }
        }
    }
}
