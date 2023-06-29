using System;

namespace D_E_U
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A1 = new string[15];
            string[] A2 = new string[15];
            string[] A3 = new string[15];
            string[] letter = { "D", "E", "U" };


            Random random = new Random();
            int randrow = 0;
            int randletter;

            int sayac = 0;
            int pointsayac = 0;
            int x = 2;
            int i = 0;
            int m = 0;
            int n = 0;
            int p1 = 120;
            int p2 = 120;
            Console.WriteLine(" ");
            Console.WriteLine("A1");
            Console.WriteLine("A2");
            Console.WriteLine("A3");
           

            while (sayac < 45)
            {
                randrow = random.Next(1, 4);      //select random column
                randletter = random.Next(0, 3);   //Generates random letters
                
                if (sayac % 2 == 0)                  // Indicates which player's turn to move.   
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Player 1");

                }
                else if (sayac % 2 == 1)                     // Indicates which player's turn to move.         
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Player 2");
                }
                ////////////////////////////////////////////////
                if (randrow == 1 & i < 15)                        //this generates one of the letters D, E, U for the randomly selected row
                                                                  //and assigns this letter to the corresponding element of the array.
                {
                    if (A1[i] != "D" & A1[i] != "E" & A1[i] != "U")
                    {
                        A1[i] = letter[randletter];
                        
                    }
                    Console.ReadKey();
                    Console.SetCursorPosition(3 + (2 * i), 1);
                    Console.Write(A1[i]);
                    i++;
                    sayac++;
                    pointsayac++;
                }
                else if (randrow == 1 & i >= 15)                        //If the related array is still selected even though it is full, the code that redirects to one of the other two arrays
                {
                    randrow = random.Next(2, 4);
                }

                else if (randrow == 2 & m < 15)
                {
                    if (A2[m] != "D" & A2[m] != "E" & A2[m] != "U")              //this generates one of the letters D, E, U for the randomly selected row
                                                                                 //and assigns this letter to the corresponding element of the array.
                    {
                        A2[m] = letter[randletter];
                        
                    }
                    Console.ReadKey();
                    Console.SetCursorPosition(3 + (2 * m), 2);
                    Console.Write(A2[m]);
                    m++;
                    sayac++;
                    pointsayac++;
                }
                else if (randrow == 2 & m >= 15)                               //If the related array is still selected even though it is full, the code that redirects to one of the other two arrays
                {
                    while (randrow != 2)
                    {
                        randrow = random.Next(2, 4);
                    }

                }

                else if (randrow == 3 & n < 15)
                {
                    if (A3[n] != "D" & A3[n] != "E" & A3[n] != "U")              //this generates one of the letters D, E, U for the randomly selected row
                                                                                 //and assigns this letter to the corresponding element of the array.
                    {
                        A3[n] = letter[randletter];
                        
                    }
                    Console.ReadKey();
                    Console.SetCursorPosition(3 + (2 * n), 3);
                    Console.Write(A3[n]);
                    n++;
                    sayac++;
                    pointsayac++;
                }
                else if (randrow == 3 & n >= 15)                               //If the related array is still selected even though it is full, the code that redirects to one of the other two arrays
                {
                    randrow = random.Next(1, 3);
                }
                ////////////////////////////////////////////////////////
                if (pointsayac % 2 == 1)
                {
                    if ((p1 - 5 >= 100))
                    {
                        Console.SetCursorPosition(39, 2);
                        Console.WriteLine("Player 1: " + (p1 - 5));
                        p1 = p1 - 5;
                    }
                    else
                    {
                        Console.SetCursorPosition(39, 2);
                        Console.WriteLine("Player 1:  " + (p1 - 5));
                        p1 = p1 - 5;
                    }
                }

                if (pointsayac % 2 == 0)                                           //This part of the code checks the scores of the players.
                {
                    if ((p2 - 5) >= 100)
                    {
                        Console.SetCursorPosition(39, 3);
                        Console.WriteLine("Player 2: " + (p2 - 5));
                        p2 = p2 - 5;
                    }
                    else
                    {
                        Console.SetCursorPosition(39, 3);
                        Console.WriteLine("Player 2:  " + (p2 - 5));
                        p2 = p2 - 5;
                    }
                }

                deu();                                                          
                x = 2;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("NAME");
            Console.SetCursorPosition(13, 12);                                   
            Console.WriteLine("SCORE");
            /////////////////////////////////////////////////////////////////////////////

            void deu() 
            {               
                while (x >= 2 & x < 15)
                {
                    if (sayac < 45)
                    {
                        if (A1[x - 2] == "D" & A1[x - 1] == "E" & A1[x] == "U")                         //Function that checks whether it writes DEU or UED vertically, horizontally or diagonally.
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("'D E U'");
                            sayac = 47;
                            break;
                        }
                        else if (A1[x - 2] == "U" & A1[x - 1] == "E" & A1[x] == "D")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("'U E D'");
                            sayac = 47;
                            break;
                        }
                        else if (A2[x - 2] == "D" & A2[x - 1] == "E" & A2[x] == "U")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("'D E U'");
                            sayac = 47;
                            break;
                        }
                        else if (A2[x - 2] == "U" & A2[x - 1] == "E" & A2[x] == "D")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("'U E D'");
                            sayac = 47;
                            break;
                        }
                        else if (A3[x - 2] == "D" & A3[x - 1] == "E" & A3[x] == "U")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("'D E U'");
                            sayac = 47;
                            break;
                        }
                        else if (A3[x - 2] == "U" & A3[x - 1] == "E" & A3[x] == "D")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("'U E D'");
                            sayac = 47;
                            break;
                        }

                        else if (A1[x - 2] == "D" & A2[x - 1] == "E" & A3[x] == "U")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("D");
                            Console.WriteLine("  E");
                            Console.WriteLine("    U");
                            sayac = 47;
                            break;
                        }
                        else if (A1[x - 2] == "U" & A2[x - 1] == "E" & A3[x] == "D")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("U");
                            Console.WriteLine("  E");
                            Console.WriteLine("    D");
                            sayac = 47;
                            break;
                        }
                        else if (A1[x] == "D" & A2[x - 1] == "E" & A3[x - 2] == "U")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("    D");
                            Console.WriteLine("  E");
                            Console.WriteLine("U");
                            sayac = 47;
                            break;
                        }
                        else if (A1[x] == "U" & A2[x - 1] == "E" & A3[x - 2] == "D")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("    U");
                            Console.WriteLine("  E");
                            Console.WriteLine("D");
                            sayac = 47;
                            break;
                        }
                        else if (A1[x - 2] == "D" & A2[x - 2] == "E" & A3[x - 2] == "U")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("D");
                            Console.WriteLine("E");
                            Console.WriteLine("U");
                            sayac = 47;
                            break;

                        }
                        else if (A1[x - 2] == "U" & A2[x - 2] == "E" & A3[x - 2] == "D")
                        {
                            Console.SetCursorPosition(0, 7);
                            score();
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("U");
                            Console.WriteLine("E");
                            Console.WriteLine("D");
                            sayac = 47;
                            break;
                        }
                    }
                    else if (sayac == 45)
                    {
                        Console.SetCursorPosition(0, 7);
                        score();
                        Console.WriteLine("There is no winner");
                        Console.WriteLine("DRAW");
                    }

                    x++;
                }
                
            }
            void score() 
            {
                if (pointsayac % 2 == 1)
                {
                    Console.WriteLine("Winner: Player 1");                                      //This function ensures that if the game is won by any player,
                                                                                                //the player's name and score are added to the score table.
                    if (p1 > 100)
                    {
                        string[] names = { "Player 1", "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { p1, 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }
                        
                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }

                    }
                    else if (p1 == 100)
                    {
                        string[] names = { "Derya", "Elife", "Player 1", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, p1, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 < 100 & p1>95)
                    {
                        string[] names = { "Derya", "Elife", "Player 1", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, p1, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 == 95)
                    {
                        string[] names = { "Derya", "Elife", "Fatih","Player 1", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, p1, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1>90 & p1<95)
                    {
                        string[] names = { "Derya", "Elife", "Fatih","Player 1", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, p1, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 == 90)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali","Player 1" , "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, p1, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1<90 & p1>85)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Player 1", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, p1, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 == 85)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra","Player 1", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan"};
                        int[] scores = { 100, 100, 95, 90, 85, p1, 80, 80, 70, 55, 50, 30, 30};
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 < 85 & p1 >80)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra","Player 1", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan"};
                        int[] scores = { 100, 100, 95, 90, 85, p1, 80, 80, 70, 55, 50, 30, 30};
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 == 80)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Player 1", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, p1, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 < 80 & p1 > 70)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Player 1", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, p1, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 == 70)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Player 1", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, p1, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 <70 & p1 > 55)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan","Player 1" , "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, p1,55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 == 55)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet","Player 1" , "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, p1, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1<55 & p1 > 50)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Player 1", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, p1, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 == 50)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil","Player 1","Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, p1, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 < 50 & p1 > 30)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil","Player 1" ,"Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, p1,30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 == 30)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan","Player 1"};
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30, p1 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p1 < 30)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                }
                else if (pointsayac % 2 == 0)
                {
                    Console.WriteLine("Winner: Player 2");
                    if (p2 > 100)
                    {
                        string[] names = { "Player 2", "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { p2, 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 100)
                    {
                        string[] names = { "Derya", "Elife", "Player 2", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, p2, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 < 100 & p2 > 95)
                    {
                        string[] names = { "Derya", "Elife", "Player 2", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, p2, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 95)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Player 2", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, p2, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 > 90 & p2 < 95)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Player 2", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, p2, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 90)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Player 2", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, p2, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 < 90 & p2 > 85)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Player 2", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, p2, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 85)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Player 2", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, p2, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 < 85 & p2 > 80)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Player 2", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, p2, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 80)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Player 2", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, p2, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 < 80 & p2 > 70)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Player 2", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, p2, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 70)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Player 2", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, p2, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 < 70 & p2 > 55)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Player 2", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, p2, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 55)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Player 2", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, p2, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 < 55 & p2 > 50)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Player 2", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, p2, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 50)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Player 2", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, p2, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 < 50 & p2 > 30)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Player 2", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, p2, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 == 30)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan", "Player 2" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30, p2 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                    else if (p2 < 30)
                    {
                        string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                        int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
                        for (int z = 0; z < 13; z++)
                        {
                            Console.SetCursorPosition(0, (13 + z));
                            Console.WriteLine(names[z]);
                        }

                        for (int t = 0; t < 13; t++)
                        {
                            Console.SetCursorPosition(13, (13 + t));
                            Console.WriteLine(scores[t]);
                        }
                    }
                }
            }

            
            
            Console.ReadKey();
        }
    }
}
