using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternExample
{
    public class DigitFactory
    {
        private readonly Dictionary<char, Digit> digits = new Dictionary<char, Digit>();

        public int NumberOfObjects
        {
            get
            {
                return this.digits.Count;
            }
        }

        public Digit GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Digit digit = null;
            if (this.digits.ContainsKey(key))
            {
                digit = this.digits[key];
            }
            else
            {
                switch (key)
                {
                    case '0':
                        digit = new DigitZero();
                        break;
                    case '1':
                        digit = new DigitOne();
                        break;
                    case '2':
                        digit = new DigitTwo();
                        break;
                    case '3':
                        digit = new DigitThree();
                        break;
                    case '4':
                        digit = new DigitFour();
                        break;
                    case '5':
                        digit = new DigitFive();
                        break;
                    case '6':
                        digit = new DigitSix();
                        break;
                    case '7':
                        digit = new DigitSeven();
                        break;
                }

                this.digits.Add(key, digit);
            }

            return digit;
        }
    }
}
