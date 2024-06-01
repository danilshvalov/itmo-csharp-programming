using System;

namespace MyClass
{
    public class Item
    {
        protected long invNumber;
        protected bool taken;

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item()
        {
            this.taken = true;
        }

        public bool IsAvaliable()
        {
            return taken;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        private void Take()
        {
            taken = false;
        }

        public void Return()
        {
            taken = true;
        }

        public void TakeItem()
        {
            if (IsAvaliable())
            {
                Take();
            }
        }

        public void Show()
        {
            Console.WriteLine("Состояние единицы хранения:");
            Console.WriteLine("Инвентарный номер: {0}", invNumber);
            Console.WriteLine("Наличие: {0}", taken);
        }
    }
}
