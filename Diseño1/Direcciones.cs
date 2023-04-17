using System;
using System.Collections.Generic;
using System.Text;
using Personal;

namespace Direccion
{
 public abstract class Addres
    {
        public string street;
        public string city;
        public string state;
        public int postalCode;
        public string country;
        public Person person;
        public bool validate()
        {
            return true;
        }
    }
}
