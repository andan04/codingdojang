﻿using System;
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
            Smallest();
        }
        static void Smallest()
        {
            for(int i = 20; ; i += 20)
            {
                for (int t = 1; t <= 20; t++)
                {
                    if (i % t != 0)
                    {
                        break;
                    }
                    else if (i % t == 0 && t == 20)
                    {
                        Console.WriteLine(i);
                        goto Exit;
                    }
                }
            }
            Exit:
            ;
        }
    }
}
