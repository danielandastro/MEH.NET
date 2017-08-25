using System;
namespace MehRewrite
{
    public class equations
    {

        public static decimal AddNumbers()
		{
			Console.Write("What to add? ");
			string input1 = Console.ReadLine();
			decimal add1 = decimal.Parse(input1);
			Console.Write("And what? ");
			string input2 = Console.ReadLine();
			decimal add2 = decimal.Parse(input2);
		    decimal result = add1+ add2;
			Console.WriteLine("The answer is " + result);

			return result;
		}
        public static decimal SubNumbers(){
			Console.Write("What to subtract?");
			String input1 = Console.ReadLine();
			decimal sub1 = decimal.Parse(input1);
			Console.Write("And what? ");
			String input2 = Console.ReadLine();
			decimal sub2 = decimal.Parse(input2);
			decimal result = sub1 - sub2;
			Console.WriteLine("The answer is " + result);
            return result;
        }
        public static decimal DivNumbers()
		{
			Console.Write("What to divide? ");
			String input1 = Console.ReadLine();
			decimal div1 = decimal.Parse(input1);
			Console.Write("And what? ");
			String input2 = Console.ReadLine();
			decimal div2 = decimal.Parse(input2);
			decimal result = div1 / div2;
			Console.WriteLine("The answer is " + result);
           
			return result;
		}
		public static decimal mulNumbers()
		{
			Console.Write("What to multiply? ");
			String input1 = Console.ReadLine();
			decimal mul1 = decimal.Parse(input1);
			Console.Write("And what? ");
			String input2 = Console.ReadLine();
			decimal mul2 = decimal.Parse(input2);
			decimal result = mul1 * mul2;
			Console.WriteLine("The answer is " + result);
			
			return result;
		}

	}
        }




