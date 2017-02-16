﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Bankomat
{
    using Client;
    class Program
    {
        static void Main(string[] args)
        {
           Client client = new Client();

            try
           {
               client.NewDeposit();
               client.NewMenuOfBankomat();
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }
               
        }

    }
}
