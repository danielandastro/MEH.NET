using System;
using System.Diagnostics;

using System.Windows.Forms;


namespace Meh_Library
{
    public class MehLoad
    {



        public static string Mehtriggger(string command)
        {

            switch (command)

            {


                /*case "define":

                    if (os.Equals("windows"))
                    {
                        Console.Write("Define What? ");
                        String define;
                        define = Console.ReadLine();
                        var defineword = new Definition().WordDefine(define);
                        Console.WriteLine(defineword);
                    }
                    else { Console.WriteLine("OS not supported"); }

                    break;*/
                case "time":
                    string time = DateTime.Now.ToString("h:mm:ss tt");
                    return time;

                case "what is the time":
                    time = DateTime.Now.ToString("h:mm:ss tt");
                    return time;

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
                    string re = "Time is Up";
                    return re;







                default:
                    String dnf = "What?I do not follow.....";
                    return dnf;






                case "area":
                    string ret = "";
                    ret =
                    "Area" + Environment.NewLine +
                    "of square = Side * Side" + Environment.NewLine +
                    "of rectangle = Length * Breath" + Environment.NewLine +
                    "of triangle = Base * Perpendicular height / 2" + Environment.NewLine +
                    "of trapezium = (side a + side b) * height / 2" + Environment.NewLine +
                    "of parallelogram = Base * Perpendicular Height" + Environment.NewLine +
                    "of kite = (Diagonal p) * (Diagonal q) / 2" + Environment.NewLine;

                    return ret;
                case "open chrome":
                    string page = "https://www.google.com";

                    Process.Start("chrome", @page);
                    return "done";


                case "open microsoft edge":
                    Process.Start("microsoft-edge:http://www.google.com");
                    return "done";


                case "battery":
                    var BatteryChargeStatus = SystemInformation.PowerStatus.BatteryChargeStatus.ToString();
                    var BatteryFullLifetime = SystemInformation.PowerStatus.BatteryFullLifetime.ToString();
                    var BatteryLifePercent = SystemInformation.PowerStatus.BatteryLifePercent.ToString();
                    var BatteryLifeRemaining = SystemInformation.PowerStatus.BatteryLifeRemaining.ToString();
                    var PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus.ToString();
                    string returns = "";

                    returns += "Percent is " + BatteryLifePercent + Environment.NewLine;
                    returns += "Charge status is " + BatteryChargeStatus + Environment.NewLine;
                    returns += "Full lifetime is " + BatteryFullLifetime + Environment.NewLine;
                    returns += "Remaining lifetime is " + BatteryLifeRemaining + Environment.NewLine;
                    returns += "Powerline status is " + PowerLineStatus + Environment.NewLine;
                    return returns;





                case "periodic table":
                    Process.Start("https://www.ptable.com/");
                    return "done";

            }


        }
        public static double MehMath(String command, Double math1, Double math2)
        {
            double result = 0;
            switch (command)
            {
                case "add":
                    double add1 = 0, add2 = 0;
                    result = add1 + add2;
                    return result;

                case "subtract":
                    add1 = 0;
                    add2 = 0;
                    result = add1 - add2;
                    return result;
                case "multiply":
                    add1 = 0;
                    add2 = 0;
                    result = add1 * add2;
                    return result;

                case "divide":
                    add1 = 0;
                    add2 = 0;
                    result = add1 / add2;
                    return result;
            }
            return result;
        }
    }
}