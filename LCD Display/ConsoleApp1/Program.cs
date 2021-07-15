using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lcd(2, "12345");
            Lcd(3, "67890");
            Lcd(0, "0");
        }
        static void Lcd(int s, string n)
        {
            if (s != 0 && int.Parse(n) != 0)
            {
                for (int column = 1; column <= 2 * s + 3; column++)
                {
                    if (column == 1)
                    {
                        for (int i = 0; i < n.Length; i++)
                        {
                            if (int.Parse(n[i].ToString()) == 1 || int.Parse(n[i].ToString()) == 4)
                            {
                                Console.Write(" ");
                                for (int row = 0; row < s; row++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write("  ");
                            }
                            else
                            {
                                Console.Write(" ");
                                for (int row = 0; row < s; row++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("  ");

                            }

                        }
                        Console.WriteLine();
                    }
                    else if (column == Math.Ceiling((2 * s + 3) / 2.0))
                    {
                        for (int i = 0; i < n.Length; i++)
                        {
                            if (int.Parse(n[i].ToString()) == 1 || int.Parse(n[i].ToString()) == 0 || int.Parse(n[i].ToString()) == 7)
                            {
                                Console.Write(" ");
                                for (int row = 0; row < s; row++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write("  ");
                            }
                            else
                            {
                                Console.Write(" ");
                                for (int row = 0; row < s; row++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("  ");

                            }

                        }
                        Console.WriteLine();
                    }
                    else if (column == 2 * s + 3)
                    {
                        for (int i = 0; i < n.Length; i++)
                        {
                            if (int.Parse(n[i].ToString()) == 1 || int.Parse(n[i].ToString()) == 4 || int.Parse(n[i].ToString()) == 7)
                            {
                                Console.Write(" ");
                                for (int row = 0; row < s; row++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write("  ");
                            }
                            else
                            {
                                Console.Write(" ");
                                for (int row = 0; row < s; row++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("  ");

                            }

                        }
                        Console.WriteLine();

                    }
                    else
                    {
                        if (column < Math.Ceiling((2 * s + 3) / 2.0))
                        {
                            for (int i = 0; i < n.Length; i++)
                            {
                                if (int.Parse(n[i].ToString()) == 1 || int.Parse(n[i].ToString()) == 2 || int.Parse(n[i].ToString()) == 3 || int.Parse(n[i].ToString()) == 7)
                                {
                                    for (int e = 0; e < s + 1; e++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write("|");

                                    Console.Write(" ");
                                }
                                else if (int.Parse(n[i].ToString()) == 6 || int.Parse(n[i].ToString()) == 5)
                                {
                                    Console.Write("|");

                                    for (int e = 0; e < s + 1; e++)
                                    {
                                        Console.Write(" ");
                                    }

                                    Console.Write(" ");

                                }
                                else
                                {
                                    Console.Write("|");
                                    for (int e = 0; e < s; e++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write("|");

                                    Console.Write(" ");

                                }
                            }
                            Console.WriteLine();

                        }
                        else
                        {
                            for (int i = 0; i < n.Length; i++)
                            {
                                if (int.Parse(n[i].ToString()) == 6 || int.Parse(n[i].ToString()) == 8 || int.Parse(n[i].ToString()) == 0)
                                {
                                    Console.Write("|");
                                    for (int e = 0; e < s; e++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write("|");
                                    Console.Write(" ");
                                }
                                else if (int.Parse(n[i].ToString()) == 2)
                                {
                                    Console.Write("|");

                                    for (int e = 0; e < s + 1; e++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write(" ");

                                }
                                else
                                {
                                    for (int e = 0; e < s + 1; e++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write("|");
                                    Console.Write(" ");

                                }
                            }
                            Console.WriteLine();

                        }
                    }
                }
            }
        }
    }
}
