﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01StandartKullanim
{
    public class Base
    {
        public void TryCatchKullanim(Action action)
        {
            try
            {
                action();
            }
            catch (Exception)
            {
                // Nlog ile loglama işlemi yapılacak .
            }
        }
    }
}
