﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    interface IAccount
    {
            // Положить деньги на счет
            void Put(decimal sum);
            // Взять со счета
            decimal Withdraw(decimal sum);
        

    }
}
