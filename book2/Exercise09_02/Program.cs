namespace Execution
{
    using NSThree;
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 3;
            Derivative[] objs = new Derivative[count];
            for (int i = 0; i < count; i++)
            {
                objs[i] = new Derivative();
            }
            foreach (Derivative obj in objs)
            {
                obj.Show();
            }
        }
    }
}
namespace NSOne
{
    internal class Base
    {
        public int ID;
        public Base()
        {
            ID = 1;
        }
    }
}
namespace NSTwo
{
    internal interface IShow
    {
        void Show();
    }
}
namespace NSThree
{
    using NSOne;
    using NSTwo;
    internal class Derivative: Base, IShow
    {
        public Derivative()
        {
            ID = new Random().Next(100);
        }
        public void Show()
        {
            Console.WriteLine("ID:{0,3}", ID);
        }
    }
}