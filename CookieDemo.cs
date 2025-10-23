using System;
using static System.Console;
using System.Globalization;

namespace CookieDemo
{
    class CookieOrder
    {
        private int order;
        private string customer;
        private string type;
        private int dozen;
        private double price;

        public CookieOrder(int order, string customer, string type, int dozen)
        {
            this.order = order;
            this.customer = customer;
            this.type = type;
            this.dozen = dozen;
        }

        public int Order
        {
            set { order = value; }
            get { return order; }
        }

        public string Customer
        {
            set { customer = value; }
            get { return customer; }
        }

        public string Type
        {
            set { type = value; }
            get { return type; }
        }

        public int Dozen
        {
            set { dozen = value; }
            get { return dozen; }
        }

        public virtual double calcPrice()
        {
            double cost;
            if (dozen <= 2)
                cost = 15 * dozen;
            else
                cost = 30 + 13 * (dozen - 2);
            return cost;
        }
    }

    class SpecialCookieOrder : CookieOrder
    {
        private string specialOrder;

        public SpecialCookieOrder(int order, string customer, string type, int dozens, string specialOrder)
            : base(order, customer, type, dozens)
        {
            this.specialOrder = specialOrder;
        }

        public override double calcPrice()
        {
            double cost;
            if (Dozen <= 2)
                cost = 15 * Dozen;
            else
                cost = 30 + 13 * (Dozen - 2);

            if (cost <= 40)
                cost += 10;
            else
                cost += 8;

            return cost;
        }

        public string getSpecial()
        {
            return specialOrder;
        }
    }

    class CookieDemo
    {
        static void Main()
        {
            CookieOrder c1 = new SpecialCookieOrder(101, "Arthur", "chocolate chip", 1, "gluten-free");
            CookieOrder c2 = new SpecialCookieOrder(102, "Brown", "peanut butter", 2, "sugar-free");
            CookieOrder c3 = new SpecialCookieOrder(103, "Cooper", "iced sugar", 3, "special");

            WriteLine($"Order #{c1.Order}      {c1.Customer}");
            WriteLine($"   type: {(c1 as SpecialCookieOrder).getSpecial()} {c1.Type}");
            WriteLine($"   {c1.Dozen} dozen --- {c1.calcPrice().ToString("C", CultureInfo.GetCultureInfo("en-US"))}");

            WriteLine($"Order #{c2.Order}      {c2.Customer}");
            WriteLine($"   type: {(c2 as SpecialCookieOrder).getSpecial()} {c2.Type}");
            WriteLine($"   {c2.Dozen} dozen --- {c2.calcPrice().ToString("C", CultureInfo.GetCultureInfo("en-US"))}");

            WriteLine($"Order #{c3.Order}      {c3.Customer}");
            WriteLine($"   type: {(c3 as SpecialCookieOrder).getSpecial()} {c3.Type}");
            WriteLine($"   {c3.Dozen} dozen --- {c3.calcPrice().ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        }
    }
}