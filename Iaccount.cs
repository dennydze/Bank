﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерфейсы
{
    interface Iaccount
    {
        // Положить деньги на счет
        void put(double summa);
        // Снять деньги со счета
        void get(double summa);

        // Начислить проценты
        void percent();
    }
}
