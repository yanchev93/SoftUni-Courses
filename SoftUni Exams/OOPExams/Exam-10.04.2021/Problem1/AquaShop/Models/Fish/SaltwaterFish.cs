using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private const int INITIAL_SIZE = 5;

        public SaltwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            this.Size = INITIAL_SIZE;
        }

        // not sure for this.Size does increas size

        public override void Eat()
        {
            int increaseSize = 2;

            this.Size += increaseSize;
        }
    }
}
