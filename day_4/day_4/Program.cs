using System;

namespace day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int mainigais = 3;
             string convertes = mainigais.ToString();
             mainigais. = Convert.ToInt16(convertes);

             // <
             // >
             // == 
             // !=
             // <=
             // >=

             if (mainigais < 5)
             {
                 Console.WriteLine("mazaks");
             }

             else
             {
                 Console.WriteLine("lielaks");
             }

             string mainigais2 = "si ir virkne";

             if(mainigais2 == "si ir virkne")
             {
                 Console.WriteLine("vienads");
             }
             else
             {
                 Console.WriteLine("nav vienads");
             }
             */
            /*
            string skaitlis;
            int skaitlis1 = 2;
            skaitlis = Console.ReadLine();
            skaitlis1 = Convert.ToInt16(skaitlis);
            /*
            if(skaitlis1 > 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("#");
            }
 
            Console.ReadLine();
            */

            /* string skaitlis;
             int skaitlis1 = 2;
             skaitlis = Console.ReadLine();
             skaitlis1 = Convert.ToInt16(skaitlis);

             if(skaitlis1 == 4)
             {
                 Console.WriteLine("četrstūris");
             }
             else
             {
                 if (skaitlis1 == 3)
                 {
                     Console.WriteLine("trijstūris");
                 }
                 else
                 {
                     if (skaitlis1 == 6)
                     {
                         Console.WriteLine("sešturis");
                     }
                     else
                     {
                         if (skaitlis1 == 5)
                         {
                             Console.WriteLine("piecstūris");
                         }
                         else
                         {
                             Console.WriteLine("out of range");
                         }
                     }
                 }
             }
             */
            /*
            switch (skaitlis1)
            {
                case 3:
                    Console.WriteLine("trijsturis");
                    break;

                case 4:
                    Console.WriteLine("četrsturis");
                    break;

                case 5:
                    Console.WriteLine("piecsturis");
                    break;

                default:
                    Console.WriteLine("kluda!");
                    break;
            }
            */

            Console.WriteLine("please enter value 1,2,5,10,20,50,100");
            string skaitlis;
            int skaitlis1 = 2;
            skaitlis = Console.ReadLine();
            skaitlis1 = Convert.ToInt16(skaitlis);

            

            switch (skaitlis1)
            {

                case 1:
                    Console.WriteLine("George Washington");
                    break;

                case 2:
                    Console.WriteLine("Thomas Jefferson");
                    break;

                case 5:
                    Console.WriteLine("Abraham Lincoln");
                    break;

                case 10:
                    Console.WriteLine("Alexander Hamilton");
                    break;

                case 20:
                    Console.WriteLine("Andrew Jackson");
                    break;

                case 50:
                    Console.WriteLine("Ulysses S.Grant");
                    break;

                case 100:
                    Console.WriteLine("Benjamin Franklin");
                    break;

                default:
                    Console.WriteLine("You entered a wrong value");
                    break;
            }


            Console.ReadLine();
        }

    }
}
