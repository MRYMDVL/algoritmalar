namespace ClassOfCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", 2023);
            car1.StepGas(100);
            car1.StepBrake(50);
            car1.StepBrake(500);

            
        }
    }
    class Car
    {
        
        public string Brand;
        public int Year;
        private int Speed;
        
        public Car(string Brand, int Year) 
        {
            this.Brand = Brand;
            this.Year = Year;
        }
        public void StepGas(int gas)
        {
            this.Speed += gas;
            Console.WriteLine($"Current speed is {this.Speed}");
        }
        public void StepBrake(int brake)
        {
            if(Speed -  brake < 0)
            {
                Speed = 0;
                Console.WriteLine($"Current speed is {Speed}");
            }
            else
            {
                Speed -= brake;
                Console.WriteLine($"Current speed is {Speed}");
            }
        }
        
    }
}
