using System;

namespace MyClass
{
    public class Item
    {
        protected long invNumber;
        protected bool taken;

        public bool IsAvaliable()
        {
            return taken;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        public void Take()
        {
            taken = false;
        }

        public void Return()
        {
            taken = true;
        }

        public void Show()
        {
            Console.WriteLine("Состояние единицы хранения:");
            Console.WriteLine("Инвентарный номер: {0}", invNumber);
            Console.WriteLine("Наличие: {0}", taken);
        }
    }
}
