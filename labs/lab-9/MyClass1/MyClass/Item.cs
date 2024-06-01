using System;

namespace MyClass
{
    public abstract class Item : IComparable
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

        public abstract void Return();

        public void TakeItem()
        {
            if (IsAvaliable())
            {
                Take();
            }
        }

        public virtual void Show()
        {
            Console.WriteLine("Состояние единицы хранения:");
            Console.WriteLine("Инвентарный номер: {0}", invNumber);
            Console.WriteLine("Наличие: {0}", taken);
        }

        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (invNumber == it.invNumber)
            {
                return 0;
            }
            else if (invNumber > it.invNumber)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
