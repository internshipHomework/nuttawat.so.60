using System;

namespace HomeWork5
{
  interface IHomework05
  {
        string DisplayLeOnScreen(string ledno);
    }
    public class LEDShow : IHomework05
    {
        string[] LedOnOof = {"1","2", "3", "4", "5", "6", "7", "8", "9", "A" };
        string[] list = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"};
        public string DisplayLeOnScreen(string ledNo)
        {
            int x = 1;
            while(x <= 50){
                for (int i = 0; i < 10; i++)
                {
                    if (LedOnOof[i] == ledNo & list[i] == "[!]")
                    {
                        list[i] = "[ ]";
                    }
                    else if (LedOnOof[i] == ledNo & list[i] == "[ ]")
                    {
                        list[i] = "[!]";
                    }    
                    }
                    Console.WriteLine(string.Join(" ", list));
                    Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
                    Console.Write("Please choose LED to turn On/Off:");
                    ledNo = Console.ReadLine();
                    x++;
                }
                return ledNo;
        }
}

    namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            LEDShow led = new LEDShow();
            Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
            Console.Write("Please choose LED to turn On/Off:");
            string input = Console.ReadLine();
            led.DisplayLeOnScreen(input);
        }
    }
}

}