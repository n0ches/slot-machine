using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //I used the function for use main menu(entrance) efficiently and this for reason I put main game into function to display when I want.
            void entrance()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                              ");
                Console.WriteLine("                                              ");
                Console.WriteLine("                                              ");
                
                Console.WriteLine(" ╔═════╗  ╔         ╔══════╗   ═══╦═══       ╔═════╦═════╗   ╔══════╗   ╔══════   ╔      ╗   ═╦═   ╔══════╗   ╔═══════");
                Console.WriteLine(" ║        ║         ║      ║      ║          ║     ║     ║   ║      ║   ║         ║      ║    ║    ║      ║   ║");
                Console.WriteLine(" ╚═════╗  ║         ║      ║      ║          ║     ║     ║   ╠══════╣   ║         ╠══════╣    ║    ║      ║   ╠═══════");
                Console.WriteLine("       ║  ║         ║      ║      ║          ║     ║     ║   ║      ║   ║         ║      ║    ║    ║      ║   ║");
                Console.WriteLine(" ╚═════╝  ╚══════   ╚══════╝      ╚          ╚           ╝   ╚      ╝   ╚══════   ╚      ╝   ═╩═   ╚      ╝   ╚═══════");
                Console.SetCursorPosition(33, 16);
                
                Console.WriteLine("W E L C O M E  T O  T H E  S L O T  M A C H I N E");
               
                Console.SetCursorPosition(45, 17);
                
                Console.WriteLine("Press 1 to continue");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.KeyChar == '1')
                {
                    Console.Clear();                              //Here, I used keyınfo to ensure transitions between main menu and game. 
                    game();
                }
                else
                {
                    Console.Clear();
                    entrance();
                }
            }

            //I put main game into function to display when I want.
            void game()
            {

                int earn = 0;
                string piece1, piece2, piece3, piece4, piece5, piece6, piece7;
                int firs_slot = 0, secon_slot = 0, third_slot = 0;
                piece1 = "X";               //first_slot,secon_slot,third_slot=1 ----> X        
                piece2 = "x";               //first_slot,secon_slot,third_slot=2 ----> x                I definied the variables here for use to the main algorithm,
                piece3 = "Y";               //first_slot,secon_slot,third_slot=3 ----> Y              at the beginning first_slot,second_slot,third_slot is zero.This is  
                piece4 = "y";               //first_slot,secon_slot,third_slot=4 ----> y              important because we will use this at the main algorithm.
                piece5 = "Z";               //first_slot,secon_slot,third_slot=5 ----> Z
                piece6 = "z";               //first_slot,secon_slot,third_slot=6 ----> z
                piece7 = "J";               //first_slot,secon_slot,third_slot=7 ----> J


                //I used do-while loops for provide the game continuity
                do
                {


                    
                    //I used setcursorposition for write the game area where I want.



                    Console.SetCursorPosition(25, 1); Console.WriteLine("           ╔═══════════════════════════════════════════════════════════╗");
                    Console.SetCursorPosition(25, 2); Console.WriteLine("           ║                                                           ║");
                    Console.SetCursorPosition(25, 3); Console.WriteLine("           ║                                                           ║   ╔══╦══╗");
                    Console.SetCursorPosition(25, 4); Console.WriteLine("           ║                         YOUR EARN                         ║   ║  ║  ║");
                    Console.SetCursorPosition(25, 5); Console.WriteLine("           ║            ╔═════════════════════════════════╗            ║   ║     ║");
                    Console.SetCursorPosition(25, 6); Console.WriteLine(" ╔═════╗   ║            ║                                 ║            ║   ╚     ╝");
                    Console.SetCursorPosition(25, 7); Console.WriteLine(" ║         ║            ╚═════════════════════════════════╝            ║   ╔═════╗");
                    Console.SetCursorPosition(25, 8); Console.WriteLine(" ╚═════╗   ║                                                           ║   ╠═════╣");
                    Console.SetCursorPosition(25, 9); Console.WriteLine("       ║   ║                                                           ║   ║     ║");
                    Console.SetCursorPosition(25, 10); Console.WriteLine(" ══════╝   ║                                                           ║   ╚     ╝");
                    Console.SetCursorPosition(25, 11); Console.WriteLine(" ╔         ║                                                           ║   ╔══════");
                    Console.SetCursorPosition(25, 12); Console.WriteLine(" ║         ║                                                           ║   ║");
                    Console.SetCursorPosition(25, 13); Console.WriteLine(" ║         ║                                                           ║   ║");
                    Console.SetCursorPosition(25, 14); Console.WriteLine(" ║         ║                                                           ║   ╚══════");
                    Console.SetCursorPosition(25, 15); Console.WriteLine(" ╚══════   ║                                                           ║   ╔     ╗");
                    Console.SetCursorPosition(25, 16); Console.WriteLine(" ╔══════╗  ║                                                           ║   ║     ║");
                    Console.SetCursorPosition(25, 17); Console.WriteLine(" ║      ║  ║                                                           ║   ╠═════╣"); 
                    Console.SetCursorPosition(25, 18); Console.WriteLine(" ║      ║  ║                                                           ║   ║     ║");
                    Console.SetCursorPosition(25, 19); Console.WriteLine(" ║      ║  ║                                                           ║   ╚     ╝");
                    Console.SetCursorPosition(25, 20); Console.WriteLine(" ╚══════╝  ║                                                           ║     ═╦═");
                    Console.SetCursorPosition(25, 21); Console.WriteLine(" ═══╦═══   ║                                                           ║      ║");
                    Console.SetCursorPosition(25, 22); Console.WriteLine("    ║      ║                      MACHINE RULES                        ║      ║");
                    Console.SetCursorPosition(25, 23); Console.WriteLine("    ║      ║                                                           ║     ═╩═");
                    Console.SetCursorPosition(25, 24); Console.WriteLine("    ║      ║      # You can only entered 7 different letters that      ║   ╔══════╗");
                    Console.SetCursorPosition(25, 25); Console.WriteLine("    ╚      ║   X, x, Y, y, Z, z, J                                     ║   ║      ║");
                    Console.SetCursorPosition(25, 26); Console.WriteLine("           ║      #J(joker) refers to any letter that allow you to     ║   ║      ║");
                    Console.SetCursorPosition(25, 27); Console.WriteLine("           ║   earn the most money                                     ║   ╚      ╝");
                    Console.SetCursorPosition(25, 28); Console.WriteLine("           ║                                                           ║   ╔══════");
                    Console.SetCursorPosition(25, 29); Console.WriteLine("           ║  (XXX),(YYY),(ZZZ)=30$        (xyz),(yzx),(zxy)or..=22$   ║   ║");
                    Console.SetCursorPosition(25, 30); Console.WriteLine("           ║  (xxx),(yyy),(zzz)=28$        (xYz),(yZX),(Zxy)or..=20$   ║   ╠═════");
                    Console.SetCursorPosition(25, 31); Console.WriteLine("           ║  (Xxx),(yYy),(ZzZ)or..=26$    (XYX),(ZZX),(YYZ)or..=18$   ║   ║");
                    Console.SetCursorPosition(25, 32); Console.WriteLine("           ║  (XYZ),(YZX),(ZXY)or..=24$    (xyx),(zzx),(yyz)or..=16$   ║   ╚══════");
                    Console.SetCursorPosition(25, 33); Console.WriteLine("           ║                                                           ║");
                    Console.SetCursorPosition(25, 34); Console.WriteLine("           ╚═══════════════════════════════════════════════════════════╝");
                    Console.SetCursorPosition(50, 10); Console.WriteLine("╔═════════╦═════════╦═════════╗");
                    Console.SetCursorPosition(50, 11); Console.WriteLine("║         ║         ║         ║");
                    Console.SetCursorPosition(50, 12); Console.WriteLine("║         ║         ║         ║");
                    Console.SetCursorPosition(50, 13); Console.WriteLine("║         ║         ║         ║");
                    Console.SetCursorPosition(50, 14); Console.WriteLine("╚═════════╩═════════╩═════════╝");
                   
                    Console.SetCursorPosition(55, 12);
                    ConsoleKeyInfo letter1 = Console.ReadKey();
                    if (letter1.KeyChar == 'X')
                    {
                        Console.SetCursorPosition(55, 12); Console.WriteLine(piece1);
                        firs_slot = 1;
                    }
                    else if (letter1.KeyChar == 'x')
                    {
                        Console.SetCursorPosition(55, 12); Console.WriteLine(piece2);     //     I used keyınfo to take only 7 letters from user.If user enter the another
                        firs_slot = 2;                                                    // letter, this letter will not be printed to the screen.And according to user's input, any letter       
                    }                                                                     // will come to the screen and first_slot's value will change.
                    else if (letter1.KeyChar == 'Y')                                      //   ex; lets assume that user enter 'X', X will be printed to the screen and
                    {                                                                     // first_slot value will be 1 because I definied the X value as 1 at the begining.
                        Console.SetCursorPosition(55, 12); Console.WriteLine(piece3);
                        firs_slot = 3;
                    }
                    else if (letter1.KeyChar == 'y')
                    {
                        Console.SetCursorPosition(55, 12); Console.WriteLine(piece4);
                        firs_slot = 4;
                    }
                    else if (letter1.KeyChar == 'Z')
                    {
                        Console.SetCursorPosition(55, 12); Console.WriteLine(piece5);
                        firs_slot = 5;
                    }
                    else if (letter1.KeyChar == 'z')
                    {
                        Console.SetCursorPosition(55, 12); Console.WriteLine(piece6);
                        firs_slot = 6;
                    }
                    else if (letter1.KeyChar == 'J')
                    {
                        Console.SetCursorPosition(55, 12); Console.WriteLine(piece7);
                        firs_slot = 7;
                    }
                    else
                    {
                        game(); //if user dont enter any 7 letters, the game will return to the begining.
                    }

                    Console.SetCursorPosition(65, 12);
                    ConsoleKeyInfo letter2 = Console.ReadKey();
                    if (letter2.KeyChar == 'X')
                    {
                        Console.SetCursorPosition(65, 12); Console.WriteLine(piece1);
                        secon_slot = 1;
                    }
                    else if (letter2.KeyChar == 'x')
                    {
                        Console.SetCursorPosition(65, 12); Console.WriteLine(piece2);
                        secon_slot = 2;
                    }
                    else if (letter2.KeyChar == 'Y')
                    {
                        Console.SetCursorPosition(65, 12); Console.WriteLine(piece3);
                        secon_slot = 3;                                                                   //     ex; if user enter 'z', z will be printed to the screen and
                    }                                                                                     //  second_slot's value will be 6 because I definied that as 6 at the begining
                    else if (letter2.KeyChar == 'y')
                    {
                        Console.SetCursorPosition(65, 12); Console.WriteLine(piece4);
                        secon_slot = 4;
                    }
                    else if (letter2.KeyChar == 'Z')
                    {
                        Console.SetCursorPosition(65, 12); Console.WriteLine(piece5);
                        secon_slot = 5;
                    }
                    else if (letter2.KeyChar == 'z')
                    {
                        Console.SetCursorPosition(65, 12); Console.WriteLine(piece6);
                        secon_slot = 6;
                    }
                    else if (letter2.KeyChar == 'J')
                    {
                        Console.SetCursorPosition(65, 12); Console.WriteLine(piece7);
                        secon_slot = 7;
                    }
                    else
                    {
                        game(); //if user dont enter any 7 letters, the game will return to the begining.
                    }

                    Console.SetCursorPosition(75, 12);
                    ConsoleKeyInfo letter3 = Console.ReadKey();
                    if (letter3.KeyChar == 'X')
                    {
                        Console.SetCursorPosition(75, 12); Console.WriteLine(piece1);
                        third_slot = 1;
                    }
                    else if (letter3.KeyChar == 'x')
                    {
                        Console.SetCursorPosition(75, 12); Console.WriteLine(piece2);
                        third_slot = 2;
                    }
                    else if (letter3.KeyChar == 'Y')
                    {
                        Console.SetCursorPosition(75, 12); Console.WriteLine(piece3);
                        third_slot = 3;                                                         //     ex; if user enter 'J', J will be printed to the screen and
                    }                                                                           //  third_slot's value will be 7 because I definied that as 7 at the begining
                    else if (letter3.KeyChar == 'y')
                    {
                        Console.SetCursorPosition(75, 12); Console.WriteLine(piece4);
                        third_slot = 4;
                    }
                    else if (letter3.KeyChar == 'Z')
                    {
                        Console.SetCursorPosition(75, 12); Console.WriteLine(piece5);
                        third_slot = 5;
                    }
                    else if (letter3.KeyChar == 'z')
                    {
                        Console.SetCursorPosition(75, 12); Console.WriteLine(piece6);
                        third_slot = 6;
                    }
                    else if (letter3.KeyChar == 'J')
                    {
                        Console.SetCursorPosition(75, 12); Console.WriteLine(piece7);
                        third_slot = 7;
                    }
                    else
                    {
                        game();//if user dont enter any 7 letters, the game will return to the begining.
                    }


                    /*Earning money algorithm:                                                                                                              example: first_slot=1 so first letter is X
                     * I used if-else to check to the user's earn.According to first,second,third slot value, user earn money.                                       second_slot=7 so second letter is J
                     * I linked more than one conditions that providing same gain into same if or else if.                                                           third_slot=1 so third letter is X
                                                                                                                                                                                XJX gives user 30$   */

                    //30$
                    if ((firs_slot == 1  && secon_slot == 1 && third_slot == 1) || (firs_slot == 3 && secon_slot == 3 && third_slot == 3) || (firs_slot == 5 && secon_slot == 5 && third_slot == 5)) 
                    {
                        
                        earn = 30; //According to gain, I change the earn's value to display at the screen.
                    }                                                                                               //example//
                    else if ((firs_slot == 7 && secon_slot == 1  && third_slot == 1) || (firs_slot == 1/*X*/  && secon_slot == 7/*J*/ && third_slot == 1/*X*/ ) || (firs_slot == 1  && secon_slot == 1 && third_slot == 7) || (firs_slot == 7 && secon_slot == 3 && third_slot == 3) || (firs_slot == 3 && secon_slot == 7 && third_slot == 3) || (firs_slot == 3 && secon_slot == 3 && third_slot == 7) || (firs_slot == 7 && secon_slot == 5 && third_slot == 5) || (firs_slot == 5 && secon_slot == 7 && third_slot == 5) || (firs_slot == 5 && secon_slot == 5 && third_slot == 7) || (firs_slot == 7 && secon_slot == 7 && third_slot == 1) || (firs_slot == 7 && secon_slot == 7 && third_slot == 3) || (firs_slot == 7 && secon_slot == 7 && third_slot == 5) || (firs_slot == 1 && secon_slot == 7 && third_slot == 7) || (firs_slot == 3 && secon_slot == 7 && third_slot == 7) || (firs_slot == 5 && secon_slot == 7 && third_slot == 7) || (firs_slot == 7 && secon_slot == 1 && third_slot == 7) || (firs_slot == 7 && secon_slot == 3 && third_slot == 7) || (firs_slot == 7 && secon_slot == 5 && third_slot == 7) || (firs_slot == 7 && secon_slot == 7 && third_slot == 7))
                    {
                        
                        earn = 30;
                    }
                    //30$

                    //28$
                    else if ((firs_slot == 2 && secon_slot == 2 && third_slot == 2) || (firs_slot == 4 && secon_slot == 4 && third_slot == 4) || (firs_slot == 6 && secon_slot == 6 && third_slot == 6))
                    {
                        
                        earn = 28;
                    }
                    else if ((firs_slot == 2 && secon_slot == 2 && third_slot == 7) || (firs_slot == 2 && secon_slot == 7 && third_slot == 2) || (firs_slot == 7 && secon_slot == 2 && third_slot == 2) || (firs_slot == 7 && secon_slot == 7 && third_slot == 2) || (firs_slot == 7 && secon_slot == 2 && third_slot == 7) || (firs_slot == 2 && secon_slot == 7 && third_slot == 7))
                    {
                        
                        earn = 28;
                    }
                    else if ((firs_slot == 4 && secon_slot == 4 && third_slot == 7) || (firs_slot == 4 && secon_slot == 7 && third_slot == 4) || (firs_slot == 7 && secon_slot == 4 && third_slot == 4) || (firs_slot == 7 && secon_slot == 7 && third_slot == 4) || (firs_slot == 7 && secon_slot == 4 && third_slot == 7) || (firs_slot == 4 && secon_slot == 7 && third_slot == 7))
                    {
                        
                        earn = 28;
                    }
                    else if ((firs_slot == 6 && secon_slot == 6 && third_slot == 7) || (firs_slot == 6 && secon_slot == 7 && third_slot == 6) || (firs_slot == 7 && secon_slot == 6 && third_slot == 6) || (firs_slot == 7 && secon_slot == 7 && third_slot == 6) || (firs_slot == 7 && secon_slot == 6 && third_slot == 7) || (firs_slot == 6 && secon_slot == 7 && third_slot == 7))
                    {
                        
                        earn = 28;
                    }
                    //28$


                    //26$
                    else if ((firs_slot == 1 && secon_slot == 1 && third_slot == 2) || (firs_slot == 2 && secon_slot == 1 && third_slot == 1) || (firs_slot == 1 && secon_slot == 2 && third_slot == 2) || (firs_slot == 2 && secon_slot == 1 && third_slot == 2) || (firs_slot == 2 && secon_slot == 2 && third_slot == 1) || (firs_slot == 1 && secon_slot == 2 && third_slot == 1))
                    {
                        
                        earn = 26;
                    }
                    else if ((firs_slot == 3 && secon_slot == 3 && third_slot == 4) || (firs_slot == 4 && secon_slot == 3 && third_slot == 3) || (firs_slot == 3 && secon_slot == 4 && third_slot == 4) || (firs_slot == 4 && secon_slot == 3 && third_slot == 4) || (firs_slot == 4 && secon_slot == 4 && third_slot == 3) || (firs_slot == 3 && secon_slot == 4 && third_slot == 4))
                    {
                        
                        earn = 26;
                    }
                    else if ((firs_slot == 5 && secon_slot == 5 && third_slot == 6) || (firs_slot == 6 && secon_slot == 5 && third_slot == 5) || (firs_slot == 5 && secon_slot == 6 && third_slot == 6) || (firs_slot == 6 && secon_slot == 5 && third_slot == 6) || (firs_slot == 6 && secon_slot == 6 && third_slot == 5) || (firs_slot == 5 && secon_slot == 6 && third_slot == 5))
                    {
                        
                        earn = 26;
                    }
                    else if ((firs_slot == 1 && secon_slot == 2 && third_slot == 7) || (firs_slot == 2 && secon_slot == 1 && third_slot == 7) || (firs_slot == 1 && secon_slot == 7 && third_slot == 2) || (firs_slot == 2 && secon_slot == 7 && third_slot == 1) || (firs_slot == 7 && secon_slot == 2 && third_slot == 1) || (firs_slot == 7 && secon_slot == 1 && third_slot == 2))
                    {
                        
                        earn = 26;
                    }
                    else if ((firs_slot == 3 && secon_slot == 4 && third_slot == 7) || (firs_slot == 4 && secon_slot == 3 && third_slot == 7) || (firs_slot == 3 && secon_slot == 7 && third_slot == 4) || (firs_slot == 4 && secon_slot == 7 && third_slot == 3) || (firs_slot == 7 && secon_slot == 4 && third_slot == 3) || (firs_slot == 7 && secon_slot == 3 && third_slot == 4))
                    {
                        
                        earn = 26;
                    }
                    else if ((firs_slot == 5 && secon_slot == 6 && third_slot == 7) || (firs_slot == 6 && secon_slot == 5 && third_slot == 7) || (firs_slot == 5 && secon_slot == 7 && third_slot == 6) || (firs_slot == 6 && secon_slot == 7 && third_slot == 5) || (firs_slot == 7 && secon_slot == 6 && third_slot == 5) || (firs_slot == 7 && secon_slot == 5 && third_slot == 6))
                    {
                        
                        earn = 26;
                    }
                    //26$

                    //24$
                    else if ((firs_slot == 1 && secon_slot == 3 && third_slot == 5) || (firs_slot == 3 && secon_slot == 5 && third_slot == 1) || (firs_slot == 5 && secon_slot == 1 && third_slot == 3) || (firs_slot == 1 && secon_slot == 5 && third_slot == 3) || (firs_slot == 3 && secon_slot == 1 && third_slot == 5) || (firs_slot == 5 && secon_slot == 3 && third_slot == 1))
                    {
                        
                        earn = 24;
                    }
                    else if ((firs_slot == 1 && secon_slot == 3 && third_slot == 7) || (firs_slot == 3 && secon_slot == 7 && third_slot == 1) || (firs_slot == 7 && secon_slot == 1 && third_slot == 3) || (firs_slot == 1 && secon_slot == 7 && third_slot == 3) || (firs_slot == 7 && secon_slot == 3 && third_slot == 1) || (firs_slot == 3 && secon_slot == 1 && third_slot == 7))
                    {
                        
                        earn = 24;
                    }
                    else if ((firs_slot == 3 && secon_slot == 5 && third_slot == 7) || (firs_slot == 7 && secon_slot == 3 && third_slot == 5) || (firs_slot == 3 && secon_slot == 7 && third_slot == 5) || (firs_slot == 7 && secon_slot == 5 && third_slot == 3) || (firs_slot == 5 && secon_slot == 3 && third_slot == 7) || (firs_slot == 5 && secon_slot == 7 && third_slot == 3))
                    {
                        
                        earn = 24;
                    }
                    else if ((firs_slot == 1 && secon_slot == 7 && third_slot == 5) || (firs_slot == 7 && secon_slot == 5 && third_slot == 1) || (firs_slot == 7 && secon_slot == 1 && third_slot == 5) || (firs_slot == 1 && secon_slot == 5 && third_slot == 7) || (firs_slot == 5 && secon_slot == 1 && third_slot == 7) || (firs_slot == 5 && secon_slot == 7 && third_slot == 1))
                    {
                        
                        earn = 24;
                    }
                    //24$

                    //22$
                    else if ((firs_slot == 2 && secon_slot == 4 && third_slot == 6) || (firs_slot == 4 && secon_slot == 6 && third_slot == 2) || (firs_slot == 6 && secon_slot == 2 && third_slot == 4) || (firs_slot == 2 && secon_slot == 6 && third_slot == 4) || (firs_slot == 4 && secon_slot == 2 && third_slot == 6) || (firs_slot == 6 && secon_slot == 4 && third_slot == 2))
                    {
                        
                        earn = 22;
                    }
                    else if ((firs_slot == 2 && secon_slot == 4 && third_slot == 7) || (firs_slot == 4 && secon_slot == 7 && third_slot == 2) || (firs_slot == 7 && secon_slot == 2 && third_slot == 4) || (firs_slot == 2 && secon_slot == 7 && third_slot == 4) || (firs_slot == 7 && secon_slot == 4 && third_slot == 2) || (firs_slot == 4 && secon_slot == 2 && third_slot == 7))
                    {
                        
                        earn = 22;
                    }
                    else if ((firs_slot == 4 && secon_slot == 6 && third_slot == 7) || (firs_slot == 7 && secon_slot == 4 && third_slot == 6) || (firs_slot == 4 && secon_slot == 7 && third_slot == 6) || (firs_slot == 7 && secon_slot == 6 && third_slot == 4) || (firs_slot == 6 && secon_slot == 4 && third_slot == 7) || (firs_slot == 6 && secon_slot == 7 && third_slot == 4))
                    {
                        
                        earn = 22;
                    }
                    else if ((firs_slot == 2 && secon_slot == 7 && third_slot == 6) || (firs_slot == 7 && secon_slot == 6 && third_slot == 2) || (firs_slot == 7 && secon_slot == 2 && third_slot == 6) || (firs_slot == 2 && secon_slot == 6 && third_slot == 7) || (firs_slot == 6 && secon_slot == 2 && third_slot == 7) || (firs_slot == 6 && secon_slot == 7 && third_slot == 2))
                    {
                        
                        earn = 22;
                    }
                    //22$

                    //20$
                    else if ((firs_slot == 3 && secon_slot == 5 && third_slot == 2) || (firs_slot == 5 && secon_slot == 3 && third_slot == 2) || (firs_slot == 1 && secon_slot == 5 && third_slot == 4) || (firs_slot == 5 && secon_slot == 1 && third_slot == 4) || (firs_slot == 1 && secon_slot == 3 && third_slot == 6) || (firs_slot == 3 && secon_slot == 1 && third_slot == 6))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 3 && secon_slot == 2 && third_slot == 5) || (firs_slot == 5 && secon_slot == 2 && third_slot == 3) || (firs_slot == 1 && secon_slot == 4 && third_slot == 5) || (firs_slot == 5 && secon_slot == 4 && third_slot == 1) || (firs_slot == 1 && secon_slot == 6 && third_slot == 3) || (firs_slot == 3 && secon_slot == 6 && third_slot == 1))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 2 && secon_slot == 3 && third_slot == 5) || (firs_slot == 2 && secon_slot == 5 && third_slot == 3) || (firs_slot == 4 && secon_slot == 1 && third_slot == 5) || (firs_slot == 4 && secon_slot == 5 && third_slot == 1) || (firs_slot == 6 && secon_slot == 1 && third_slot == 3) || (firs_slot == 6 && secon_slot == 3 && third_slot == 1))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 4 && secon_slot == 6 && third_slot == 1) || (firs_slot == 6 && secon_slot == 4 && third_slot == 1) || (firs_slot == 2 && secon_slot == 6 && third_slot == 3) || (firs_slot == 6 && secon_slot == 2 && third_slot == 3) || (firs_slot == 2 && secon_slot == 4 && third_slot == 5) || (firs_slot == 4 && secon_slot == 3 && third_slot == 5))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 4 && secon_slot == 1 && third_slot == 6) || (firs_slot == 6 && secon_slot == 1 && third_slot == 4) || (firs_slot == 2 && secon_slot == 3 && third_slot == 6) || (firs_slot == 6 && secon_slot == 3 && third_slot == 2) || (firs_slot == 2 && secon_slot == 5 && third_slot == 4) || (firs_slot == 4 && secon_slot == 5 && third_slot == 2))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 1 && secon_slot == 4 && third_slot == 6) || (firs_slot == 1 && secon_slot == 6 && third_slot == 4) || (firs_slot == 3 && secon_slot == 2 && third_slot == 6) || (firs_slot == 3 && secon_slot == 6 && third_slot == 2) || (firs_slot == 5 && secon_slot == 2 && third_slot == 4) || (firs_slot == 5 && secon_slot == 4 && third_slot == 2))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 5 && secon_slot == 2 && third_slot == 7) || (firs_slot == 2 && secon_slot == 5 && third_slot == 7) || (firs_slot == 5 && secon_slot == 7 && third_slot == 2) || (firs_slot == 2 && secon_slot == 7 && third_slot == 5) || (firs_slot == 7 && secon_slot == 2 && third_slot == 5) || (firs_slot == 7 && secon_slot == 5 && third_slot == 2))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 3 && secon_slot == 2 && third_slot == 7) || (firs_slot == 2 && secon_slot == 3 && third_slot == 7) || (firs_slot == 3 && secon_slot == 7 && third_slot == 2) || (firs_slot == 2 && secon_slot == 7 && third_slot == 3) || (firs_slot == 7 && secon_slot == 3 && third_slot == 2) || (firs_slot == 7 && secon_slot == 2 && third_slot == 3))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 5 && secon_slot == 4 && third_slot == 7) || (firs_slot == 4 && secon_slot == 5 && third_slot == 7) || (firs_slot == 5 && secon_slot == 7 && third_slot == 4) || (firs_slot == 4 && secon_slot == 7 && third_slot == 5) || (firs_slot == 7 && secon_slot == 5 && third_slot == 4) || (firs_slot == 7 && secon_slot == 4 && third_slot == 5))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 1 && secon_slot == 4 && third_slot == 7) || (firs_slot == 4 && secon_slot == 1 && third_slot == 7) || (firs_slot == 1 && secon_slot == 7 && third_slot == 4) || (firs_slot == 4 && secon_slot == 7 && third_slot == 1) || (firs_slot == 7 && secon_slot == 1 && third_slot == 4) || (firs_slot == 7 && secon_slot == 4 && third_slot == 1))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 1 && secon_slot == 4 && third_slot == 7) || (firs_slot == 4 && secon_slot == 1 && third_slot == 7) || (firs_slot == 1 && secon_slot == 7 && third_slot == 4) || (firs_slot == 4 && secon_slot == 7 && third_slot == 1) || (firs_slot == 7 && secon_slot == 1 && third_slot == 4) || (firs_slot == 7 && secon_slot == 4 && third_slot == 1))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 1 && secon_slot == 6 && third_slot == 7) || (firs_slot == 6 && secon_slot == 1 && third_slot == 7) || (firs_slot == 1 && secon_slot == 7 && third_slot == 6) || (firs_slot == 6 && secon_slot == 7 && third_slot == 1) || (firs_slot == 7 && secon_slot == 1 && third_slot == 6) || (firs_slot == 7 && secon_slot == 6 && third_slot == 1))
                    {
                        
                        earn = 20;
                    }
                    else if ((firs_slot == 3 && secon_slot == 6 && third_slot == 7) || (firs_slot == 6 && secon_slot == 3 && third_slot == 7) || (firs_slot == 3 && secon_slot == 7 && third_slot == 6) || (firs_slot == 6 && secon_slot == 7 && third_slot == 3) || (firs_slot == 7 && secon_slot == 3 && third_slot == 6) || (firs_slot == 7 && secon_slot == 6 && third_slot == 3))
                    {
                        
                        earn = 20;
                    }
                    //20$

                    //18$
                    else if ((firs_slot == 1 && secon_slot == 3 && third_slot == 1) || (firs_slot == 1 && secon_slot == 1 && third_slot == 3) || (firs_slot == 3 && secon_slot == 1 && third_slot == 1) || (firs_slot == 3 && secon_slot == 1 && third_slot == 3) || (firs_slot == 3 && secon_slot == 3 && third_slot == 1) || (firs_slot == 1 && secon_slot == 3 && third_slot == 3))
                    {
                        
                        earn = 18;
                    }
                    else if ((firs_slot == 1 && secon_slot == 5 && third_slot == 1) || (firs_slot == 1 && secon_slot == 1 && third_slot == 5) || (firs_slot == 5 && secon_slot == 1 && third_slot == 1) || (firs_slot == 5 && secon_slot == 1 && third_slot == 5) || (firs_slot == 5 && secon_slot == 5 && third_slot == 1) || (firs_slot == 1 && secon_slot == 5 && third_slot == 5))
                    {
                        
                        earn = 18;
                    }
                    else if ((firs_slot == 3 && secon_slot == 5 && third_slot == 3) || (firs_slot == 3 && secon_slot == 3 && third_slot == 5) || (firs_slot == 5 && secon_slot == 3 && third_slot == 3) || (firs_slot == 5 && secon_slot == 3 && third_slot == 5) || (firs_slot == 5 && secon_slot == 5 && third_slot == 3) || (firs_slot == 3 && secon_slot == 5 && third_slot == 5))
                    {
                        
                        earn = 18;
                    }

                    //18$

                    //16$
                    else if ((firs_slot == 2 && secon_slot == 4 && third_slot == 2) || (firs_slot == 2 && secon_slot == 2 && third_slot == 4) || (firs_slot == 4 && secon_slot == 2 && third_slot == 2) || (firs_slot == 4 && secon_slot == 2 && third_slot == 4) || (firs_slot == 4 && secon_slot == 4 && third_slot == 2) || (firs_slot == 2 && secon_slot == 4 && third_slot == 4))
                    {
                        
                        earn = 16;
                    }
                    else if ((firs_slot == 2 && secon_slot == 6 && third_slot == 2) || (firs_slot == 2 && secon_slot == 2 && third_slot == 6) || (firs_slot == 6 && secon_slot == 2 && third_slot == 2) || (firs_slot == 6 && secon_slot == 2 && third_slot == 6) || (firs_slot == 6 && secon_slot == 6 && third_slot == 2) || (firs_slot == 2 && secon_slot == 6 && third_slot == 6))
                    {
                        
                        earn = 16;
                    }
                    else if ((firs_slot == 4 && secon_slot == 6 && third_slot == 4) || (firs_slot == 4 && secon_slot == 4 && third_slot == 6) || (firs_slot == 6 && secon_slot == 4 && third_slot == 4) || (firs_slot == 6 && secon_slot == 4 && third_slot == 6) || (firs_slot == 6 && secon_slot == 6 && third_slot == 4) || (firs_slot == 4 && secon_slot == 6 && third_slot == 6))
                    {
                        earn = 16;
                    }

                    //16$

                    else
                    {
                        earn = 0;
                    }

                    Console.SetCursorPosition(60, 6); Console.WriteLine("                     ");
                    Console.SetCursorPosition(60, 6);
                    Console.WriteLine("You earned "+ earn +"$ ");
                    Console.SetCursorPosition(54, 19);                                      //Displayin earn value to the screen and game looping.
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();



                } while (1 == 1);


            }
            entrance(); //game start from the entrance, first entrance comes to the screen and then if user press 1, game begin.
         }

    }
}
