﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 2. Создание и использование размерных типов данных*/
/*Упражнение 1. Создание перечисления.*/

namespace ITMO.CSCourse2021.Labs.Lab02.E1.Enum
{
    public enum AccountType 
    { 
        Checking,
        Deposit
    }

    class Enum
    {
        static void Main(string[] args)
        {                
            /*Упражнение 01 - Создать перечисление*/
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
            Console.ReadKey();


        }
}
}
