using System;
using System.Collections.Generic;
using System.Text;
using Direccion;
using Transacciones;

namespace Personal
{
    public class Person
    {
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;
        public Addres adres;
    }
    
    public class Costumer : Person
    {
        public DateTime Registration;
        int CreditScore;
    }

    public class Employee : Person
    {
        public Enum Departament;
        float Salary;
    }

    public abstract class Acount
    {
        public string IBAN;
        protected float Amount;
        public Transaction transacciones;
        public bool MetotodoA(string transaccion)
        {
            return true;
        }
    }

    public abstract class Investing
    {
        public float Interest;

        public string ApplyInterest()
        {
            return "";
        }
    }

    public abstract class Savings
    {
        protected float ProtectedAmount;

        public string LiberateSavings()
        {
            return "";
        }
    }
}
