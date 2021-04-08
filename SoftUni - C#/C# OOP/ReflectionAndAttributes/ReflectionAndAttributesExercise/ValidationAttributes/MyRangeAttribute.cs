using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minAge;
        private int maxAge;

        public MyRangeAttribute(int minAge, int maxAge)
        {
            this.minAge = minAge;
            this.maxAge = maxAge;
        }

        public override bool IsValid(object obj)
        {
            if (obj is int valueAsInt)
            {
                if (valueAsInt >= minAge && valueAsInt <= maxAge)
                {
                    return true;
                }

                return false;
            }

            throw new ArgumentException("Invalid type!");
        }
    }
}
