using System;
using System.Diagnostics;
using System.IO;
using Define;
using mathLibrary;

using System.Windows.Forms;

using WeatherNet;
using WeatherNet.Clients;


namespace MehRewrite
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("MEH System Version 2.5");
            Console.WriteLine("Loading Core System");
            Console.WriteLine("Declaring Startup Variables");
            //String dlls = "None";
            String command, user, pass, secure = null;
            Boolean secure_mode = true;

            math math = new math();
            Boolean shutDownFlag = true;
            Console.WriteLine("Startup Variables Declared");
            Console.WriteLine("Searching for dlls");
            /*foreach (var file in Directory.GetFiles(@"dlls", "*.dll"))
            {

                dlls = dlls + file;
                Console.WriteLine(file);
            }*/
            //int presentMath = dlls.IndexOf("tinyMath.dll", StringComparison.Ordinal);
            int presentDefine = 1;
            if (presentDefine == -1)
            {
                Console.WriteLine("Define.dll not found, press a key to break"); Console.ReadKey();
                return;
            }
            /*else { }
            if (presentMath == -1)
            {
                Console.WriteLine("tinyMath.dll not found, press a key to break"); Console.ReadKey();
                return;
            }*/
            else { Console.WriteLine("All DLLs accounted for"); }

            Console.Write("Enter Secure Mode? ");
            secure = Console.ReadLine();
            //string os = File.ReadAllText(@"os.txt");
            string os = "linux";
            //string plugins = File.ReadAllText(@"plugins/list.txt");
            //string extmath = File.ReadAllText(@"plugins/descriptions/extendedmath.txt");
            //string extcommand = File.ReadAllText(@"plugins/descriptions/extendedcommands.txt");
            //String installed = File.ReadAllText(@"plugins/installedlist.txt");
            switch (secure)
            {
                case "yes":
                    secure_mode = true;
                    break;

                case "y":
                    secure_mode = true;
                    break;
                case "true":
                    secure_mode = true;
                    break;
                case "no":
                    secure_mode = false;
                    break;
                case "n":
                    secure_mode = false;
                    break;
                case "false":
                    secure_mode = false;
                    break;

                default:
                    Console.WriteLine("Invalid");
                    Console.ReadKey();
                    return;
            }
            if (secure_mode == true)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Enter User Name: ");
                user = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                pass = Console.ReadLine();
                if (string.Equals(user, "admin") & string.Equals(pass, "admin"))
                {
                    Console.WriteLine("Confirming credentials, please wait");
                    Console.WriteLine("Credentials confirmed, hello, " + user);
                }
                else
                {
                    Console.WriteLine("Credentials Incorrect");
                    Console.ReadKey();
                    return;
                }
            }
            else if (secure_mode == false)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Enter User Name: ");
                user = Console.ReadLine();



                Console.WriteLine("Confirming credentials, please wait");
                Console.WriteLine("Credentials confirmed, hello, " + user);
            }
            while (true)
            {
                Console.WriteLine("How may I Help you?");
                command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        double ans = math.AddNumbers();
                        Console.WriteLine("Answer is " + ans);
                        break;
                    case "subtract":
                        ans = math.SubNumbers();
                        Console.WriteLine("Answer is " + ans);
                        break;
                    case "multiply":
                        ans = math.MulNumbers();
                        Console.WriteLine("Answer is " + ans);
                        break;
                    case "divide":
                        ans = math.DivNumbers();
                        Console.WriteLine("Answer is " + ans);
                        break;
                    case "quit":
                        return;
                    case "define":

                        if (os.Equals("windows"))
                        {
                            Console.Write("Define What? ");
                            String define;
                            define = Console.ReadLine();
                            var defineword = new Definition().WordDefine(define);
                            Console.WriteLine(defineword);
                        }
                        else { Console.WriteLine("OS not supported"); }

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

                    case "bench":
                        Console.WriteLine("Initializing benchmarking subroutine");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Running benchmark test 1");
                        System.Threading.Thread.Sleep(10000);
                        Console.WriteLine("done");
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("Running benchmark test 2");
                        System.Threading.Thread.Sleep(10000);
                        Console.WriteLine("done");
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("Calculating");
                        System.Threading.Thread.Sleep(10000);
                        Console.WriteLine("Just kidding, master did not teach me to benchmark.");
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("But I feel bad so here is the link to novabench: https://novabench.com");
                        Console.WriteLine("they can run a benchmark for you. :-)");
                        break;
                    case "exit":
                        return;

                    case "NRK":
                        Console.WriteLine("too bad NRK is not so easy to access");
                        Console.WriteLine("please enter the NRK username to gain access");
                        user = Console.ReadLine();
                        Console.WriteLine("please enter the super secret password which only a NRK member would know");
                        pass = Console.ReadLine();
                        if (string.Equals(user, "NRK") & string.Equals(pass, "Supreme"))
                        {
                            Console.WriteLine("Confirming credentials, please wait");
                            Console.WriteLine("Credentials confirmed, hello, " + user);
                        }
                        else
                        {
                            Console.WriteLine("go back you fake wannabe NRK");
                            Console.ReadKey();
                            return;
                        }

                        break;






                    case "nuke it":
                        return;
                    /*case "list plugins":
                        Console.Write("List of plugins: ");
                        // Console.WriteLine(plugins);
                        break;
                    case "describe":
                        Console.Write("Plugin name: ");
                        string pluginname = Console.ReadLine();
                        switch (pluginname)
                        {
                            case "extended math":
                                Console.WriteLine(extmath);
                                break;

                            case "extended commands":
                                Console.WriteLine(extcommand);
                                break;
                            default:
                                Console.WriteLine("Unrecognised plugin, update from github to get latest plugins");
                                break;
                        }
                        break;
                    case "plugins help":
                        Console.WriteLine("To use plugin, download it, add its name to the installed-plugins file (copy from readme), in the system type 'plugin', then type its name, and then type in your commands");
                        break;
                        case "plugin":
                        string name = Console.ReadLine();
                        int exist = installed.IndexOf(name, StringComparison.Ordinal);
                        switch (exist){
                            case -1:
                                Console.WriteLine("Plugin is not present or not listed");

                                break;

                                switch (name){
                                    case "extended math":
                                        Console.WriteLine("Coming soon")
                                        break;

                                        case "extended commands":
                                        Console.WriteLine("Coming soon");
                                        break;
                    case "square": Console.WriteLine("Using Extended Math"); 
                      Console.Write("Square what ");*/


                    default:
                        Console.WriteLine("What?I do not follow.....");
                        break;
                    case "how are you":
                        Console.WriteLine("my sole purpose of existing " +
                            "is to fullfil your needs, how am I is not the question, its all about you");
                        break;

                    case "what is your name":
                        Console.WriteLine("I am an AI you can call me ****");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("A message from the developers:");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Sorry about that");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("It's just a phase");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("We think");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("And hope");
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case "shut down":
                        Console.WriteLine("LOL...no one can shut me down");
                        if (shutDownFlag == true){
                            Console.WriteLine("please enter the code to gain access to my mainframe");
                            user = Console.ReadLine();
                            Console.WriteLine("nothing can stop exept the last code!!!!!");
                            Console.WriteLine("message from the dev team");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("it is the most easy four character password....1..2..");
                            pass = Console.ReadLine();
                            if (string.Equals(user, "0987")
                                & string.Equals(pass, "1234"))
                            {
                                Console.WriteLine("noooo...");
                                return;//This line makes it exit
                            }
                            else
                            {

                                Console.WriteLine("i cannot be stopped");
                                shutDownFlag = false;




                            }

                        }

                        break;

                    case "area":
                        Console.WriteLine("Area");
                        Console.WriteLine("of square = Side * Side");
                        Console.WriteLine("of rectangle = Length * Breath");
                        Console.WriteLine("of triangle = Base * Perpendicular height / 2");
                        Console.WriteLine("of trapezium = (side a + side b) * height / 2");
                        Console.WriteLine("of parallelogram = Base * Perpendicular Height");
                        Console.WriteLine("of kite = (Diagonal p) * (Diagonal q) / 2");
                        Console.WriteLine("51 = Who Knows");
                        break;
                    case "open chrome":
                        string page = "https://www.google.com";
                        Console.Write("Which Page (Use format like https://google.com): ");
                        page = Console.ReadLine();
                        Process.Start("chrome", @page);

                        break;

                    case "open microsoft edge":
                        System.Diagnostics.Process.Start("microsoft-edge:http://www.google.com");
                                           
                      break;

                    case "open NRK entertainment website":
                        System.Diagnostics.Process.Start("http://nrk-entertainment.webnode.com/ ");

                        break;
                    case "battery":
                        var BatteryChargeStatus= SystemInformation.PowerStatus.BatteryChargeStatus.ToString();
                        var BatteryFullLifetime = SystemInformation.PowerStatus.BatteryFullLifetime.ToString();
                        var BatteryLifePercent = SystemInformation.PowerStatus.BatteryLifePercent.ToString();
                        var BatteryLifeRemaining = SystemInformation.PowerStatus.BatteryLifeRemaining.ToString();
                        var PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus.ToString();
                        Console.WriteLine("Percent is " +BatteryLifePercent);
                        Console.WriteLine("Charge status is " + BatteryChargeStatus);
                        Console.WriteLine("Full lifetime is " + BatteryFullLifetime);
                        Console.WriteLine("Remaining lifetime is " + BatteryLifeRemaining);
                        Console.WriteLine("Powerline status is " + PowerLineStatus);
                        break;



                    case "weather":
                        var result = CurrentWeather.GetByCityName("Stockholm", "Sweden", "en", "metric");
                        Console.WriteLine(result);
                        break;

                    case "periodic table":
                        System.Diagnostics.Process.Start("https://www.ptable.com/");
                        
                        break;


  










                }
            }
        }
    }
}