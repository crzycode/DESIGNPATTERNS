﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class primenumber
    {
        public static bool prime()
        {
            int num = 7;
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if(num%i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
