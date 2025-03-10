namespace Exercise03_02
{
    struct Car
    {
        int mileage = 1200;//хаха, но не всегда
        public string brand;
        char ecological_class;
        public Car(int mileage, string brand, char ecological_class)
        {
            this.mileage = mileage;
            this.brand = brand;
            this.ecological_class = ecological_class;
        }
        public Car(int mileage, string brand)
        {
            this.mileage = mileage;
            this.brand = brand;
        }
        public Car(string brand)
        {
            this.brand = brand;
        }
        public void Show()
        {
            string a = "Автомобиль\n";
            a += String.Format("Марка: {0}.\n",brand);
            a += String.Format("Пробег: {0}.\n", mileage);
            a += String.Format("Экологический класс: {0}.\n", ecological_class);
            Console.WriteLine(a);
        }
        //public static double pi = 3;
        //public const double pi = 3;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] a = {
                new Car(),
                new Car(1000, "Lada", 'E'),
                new Car(2000, "Renault"),
                new Car("Dacia")
            };
            a[0].brand = "BNW";
            foreach (Car car in a)
            {
                car.Show();
            }
            //Console.WriteLine(Car.pi);
            //Car.pi = 3.14;
            //Console.WriteLine(Car.pi);
        }
    }
}
