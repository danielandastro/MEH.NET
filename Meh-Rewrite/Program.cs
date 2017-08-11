using System;
using System.Diagnostics;

namespace MehRewrite
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("MEH System Version 1.0");
            Console.WriteLine("Loading Core System");
            Console.WriteLine("Declaring Startup Variables");
            Console.WriteLine("Startup Variables Declared");
            Console.Write("Enter Secure Mode? ");
            variables.secure = Console.ReadLine();

            switch (variables.secure)
            {
                case "yes":
                    variables.secure_mode = true;
                    break;

                case "y":
                    variables.secure_mode = true;
                    break;
                case "true":
                    variables.secure_mode = true;
                    break;
                case "no":
                    variables.secure_mode = false;
                    break;
                case "n":
                    variables.secure_mode = false;
                    break;
                case "false":
                    variables.secure_mode = false;
                    break;

                default:
                    Console.WriteLine("Invalid");
                    Console.ReadKey();
                    return;
            }
            if (variables.secure_mode == true)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Enter User Name: ");
                variables.user = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                variables.pass = Console.ReadLine();
                if (string.Equals(variables.user, "admin") & string.Equals(variables.pass, "admin"))
                {
                    Console.WriteLine("Confirming credentials, please wait");
                    Console.WriteLine("Credentials confirmed, hello, " + variables.user);
                }
                else
                {
                    Console.WriteLine("Credentials Incorrect");
                    Console.ReadKey();
                    return;
                }
            }
            else if (variables.secure_mode == false)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Enter User Name: ");
                variables.user = Console.ReadLine();



                Console.WriteLine("Confirming credentials, please wait");
                Console.WriteLine("Credentials confirmed, hello, " + variables.user);
            }
            while (true)
            {
                Console.WriteLine("How may I Help you?");
                variables.command = Console.ReadLine();
                switch (variables.command)
                { 
                    case "add":
					Console.Write("What to add? ");
				string input1 = Console.ReadLine();
				variables.add1 = decimal.Parse(input1);
				Console.Write("And what? ");
				string input2 = Console.ReadLine();
				variables.add2 = decimal.Parse(input2);
                        decimal ans = variables.add1 + variables.add2;
				Console.WriteLine("The answer is " + ans);
                break;
					case "subtract":
						Console.Write("What to subtract?");
						input1 = Console.ReadLine();
						variables.add1 = decimal.Parse(input1);
						Console.Write("And what? ");
						input2 = Console.ReadLine();
						variables.add2 = decimal.Parse(input2);
						ans = variables.add1 - variables.add2;
						Console.WriteLine("The answer is " + ans);
						break;
					case "multiply":
						Console.Write("What to multiply? ");
						input1 = Console.ReadLine();
						variables.add1 = decimal.Parse(input1);
						Console.Write("And what? ");
						input2 = Console.ReadLine();
						variables.add2 = decimal.Parse(input2);
						ans = variables.add1 * variables.add2;
						Console.WriteLine("The answer is " + ans);
						break;
					case "divide":
						Console.Write("What to divide? ");
						input1 = Console.ReadLine();
						variables.add1 = decimal.Parse(input1);
						Console.Write("And what? ");
						input2 = Console.ReadLine();
						variables.add2 = decimal.Parse(input2);
						ans = variables.add1 / variables.add2;
						Console.WriteLine("The answer is " + ans);
						break;
                    case "quit":
                        return;
                    case"define":
						Console.Write("Define What? ");
						String define;
						define = Console.ReadLine();
						Process p = new Process();
						p.StartInfo.FileName = "wn.exe";
						p.StartInfo.Arguments = define + " -synsn -g";
						p.StartInfo.UseShellExecute = false;
						p.StartInfo.RedirectStandardOutput = true;
						p.Start();

						string output = p.StandardOutput.ReadToEnd();
						p.WaitForExit();
						define = null;
						Console.WriteLine("Output:");
						Console.WriteLine(output);
                        break;
                    case "time":
						string time = DateTime.Now.ToString("h:mm:ss tt");
						Console.WriteLine(time);
                        break;
                    case "what is the time":
						time = DateTime.Now.ToString("h:mm:ss tt");
						Console.WriteLine(time);
                        break;
                        case "timer":
						int min, sec, totalsec, mintosec, milli;
						string strmin, strsec;
						Console.Write("Minutes: ");
						strmin = Console.ReadLine();
						Console.Write("Seconds: ");
						strsec = Console.ReadLine();
						sec = Int32.Parse(strsec);
						min = Int32.Parse(strmin);
						mintosec = min * 60;
						totalsec = mintosec + sec;
						milli = totalsec * 1000;
						System.Threading.Thread.Sleep(milli);
						Console.WriteLine("Time is Up");
                        break;

                    default:
                        Console.WriteLine("What");
                        break;


                }
            }
        }
    }
}