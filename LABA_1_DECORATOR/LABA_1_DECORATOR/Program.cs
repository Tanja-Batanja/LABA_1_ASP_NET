using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_1_DECORATOR
{
    interface IDrink
    {
        void cost();
    }

    class Coffe:IDrink
    {
        private string data;
        public Coffe(string data) => this.data = data; // конструктор
        public void cost() => Console.Write("Вы заказали " + data);
    }

    abstract class Shell : IDrink //decoraeor
    {
        protected IDrink processor;
        public Shell(IDrink pr) => processor = pr;   // конструктор
        public virtual void cost() => processor.cost();
    }

    class Milk : Shell
    {
        public Milk(IDrink pr) : base(pr) { } //конструктор
        public override void cost()
        {
            processor.cost();
            Console.Write(" с молоком");
            
        }
    }

    class Sugar : Shell
    {
        public Sugar(IDrink pr) : base(pr) { } //конструктор
        public override void cost()
        {
            processor.cost();
            Console.Write(" с сахаром");

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            IDrink amer = new Coffe("Amerikano");
            amer.cost();
            Console.WriteLine();

            Shell milk = new Milk(amer);
            milk.cost();
            Console.WriteLine();

            Shell sugar = new Sugar(amer);
            sugar.cost();
            Console.WriteLine();

            Shell XL = new Sugar(new Milk(amer));
            XL.cost();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
} 
