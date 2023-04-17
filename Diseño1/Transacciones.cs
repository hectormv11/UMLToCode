using System;
using System.Collections.Generic;
using System.Text;
using Personal;

namespace Transacciones
{
    public abstract class Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Recuest;
        public Acount cuenta;
    }
}
