namespace MyClass;

class Program
{
    static void Main(string[] args)
    {
        Magazine m = new Magazine(
            "О природе",
            5,
            "Земля и мы",
            2014,
            1235,
            true
        );
        m.TakeItem();
        m.Show();
        m.IfSubs = true;
        m.Subs();
    }
}
