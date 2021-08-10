using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
      
        

         
 namespace rock_paper_siser
    {
        class Program
        {
            static void Main(string[] args)
            {
                string rock = "rock";
                string paper = "paper";
                string siser = "siser";

                Console.WriteLine("rock paper siser");
                Console.WriteLine("your chios");
                string useransewr = Convert.ToString(Console.Read());

                if (useransewr == rock || useransewr == siser || useransewr == paper)
                {
                    Console.WriteLine("you chois is" + useransewr);
                }
                else { Console.WriteLine("you did not chois coractle "); }

                Random random = new System.Random();
                int a = random.Next(2);










                Console.ReadKey();
            }
        }
    }



    
