using System;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] LED = { "1","2","3","4","5","6","7","8","9","A" };
            string[] Light = { "[ปิด]","[ปิด]","[ปิด]","[ปิด]","[ปิด]","[ปิด]","[ปิด]","[ปิด]","[ปิด]","[ปิด]" };
            for (int round = 1; round <=50 ; round++){
                Console.Write("Please choose LED to turn On/Off:");
                string input = Console.ReadLine();
                for (int i=0; i<10 ; i++){
                    if( LED[i] == input & Light[i] == "[ปิด]" ){
                        Light[i] = "[ไฟเปิด]";
                    }
                    else if (LED[i] == input & Light[i] == "[ไฟเปิด]"){
                        Light[i] = "[ปิด]";
                    }
                
                }
                Console.WriteLine("  1    2    3    4    5    6    7    8    9    A ");
                Console.WriteLine(string.Join(" ", Light)) ;
             
            }

        }
    }
}
