using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functional Programs");
            Console.WriteLine("");
            Console.WriteLine("1. Name Replace");
            Console.WriteLine("2. Flip Coin");
            Console.WriteLine("3. Leap Year");
            Console.WriteLine("4. Power of 2");
            Console.WriteLine("5. Harmonic Number");
            Console.WriteLine("6. Factor");
            Console.WriteLine("7. Glamber");
            Console.WriteLine("8. Coupon Numbers");
            Console.WriteLine("9. 2 D Array");
            Console.WriteLine("10. Sum Of Three Number ");
            Console.WriteLine("11. Distance Between Two Point");
            Console.WriteLine("12. Permutation");
            Console.WriteLine("13. Quadratic Equation");
            Console.WriteLine("14. Stop Watch");
            Console.WriteLine("15. Wind Chill");
            Console.WriteLine("");
            Console.WriteLine("Enter which program you want to run");
            Console.WriteLine("");
            Console.WriteLine("Enter your Choice");
            Console.WriteLine(" ");
            int choice = Convert.ToInt32(Console.ReadLine());
           
            switch (choice)
            {
                case 1:
                    ReplaceString nameObj = new ReplaceString();
                    nameObj.Replace();
                    break;
                case 2:
                    FlipCoin coinObj = new FlipCoin();
                    coinObj.Flip();
                    break;
                case 3:
                    LeapYear yearObj = new LeapYear();
                    yearObj.Leap();
                    break;
                case 4:
                    PowerOf2 powerObj = new PowerOf2();
                    powerObj.Power();
                    break;
                case 5:
                    HarmonicNumber harmonicObj = new HarmonicNumber();
                    harmonicObj.Harmonic();
                    break;
                case 6:
                    Factor factorObj = new Factor();
                    factorObj.PrimeFactor();
                    break;
                case 7:
                    Gambler gamblerObj = new Gambler();
                    gamblerObj.Gamb();
                    break;
                case 8:
                    CouponNumber couponObj = new CouponNumber();
                    couponObj.Coupon();
                    break;
                case 9:
                    TwoDArray darrayObj = new TwoDArray();
                    darrayObj.TwoD();
                    break;
                case 10:
                    SumOfThree sumObj = new SumOfThree();
                    sumObj.Sum();
                    break;
                case 11:
                    Distance disObj = new Distance();
                    disObj.Dist();
                    break;
                case 12:
                    Permutation permuObj = new Permutation();
                    permuObj.permutation();
                    break;
                case 13:
                    Quadratic quadObj = new Quadratic();
                    quadObj.QuadraticEquation();
                    break;
                case 14:
                    Stopwatch stopObj = new Stopwatch();
                    stopObj.Watch();
                    break;
                case 15:
                    WindChill windObj = new WindChill();
                    windObj.Wind();
                    break;
                default:
                    break;

            }
        }

    }
}
