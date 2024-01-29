namespace PreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta gigio = new Atleta();
            gigio.Greet();
            gigio.HowMuchTo100();
            gigio.TellResult();
            Dipendente pippo = new Dipendente();
            pippo.Greet();
            pippo.ChangeName();
            pippo.Greet();
            Animale brownie = new Animale();
            brownie.Greet();
            brownie.ChangeWeight();
            brownie.Greet();
            Veicolo fiat500 = new Veicolo();
            fiat500.Greet();
            fiat500.ChangeCar();
            fiat500.Greet();
        }
    }

    class Atleta
    {
        public string Name = "Gigio";
        public int Height = 180;
        public int Weight = 75;
        public string Sport = "Soccer";

        public void Greet()
        {
            Console.WriteLine("Hi, my name is " + Name + " and I play " + Sport + ", I weight " + Weight + "kg and I'm " + Height + "cm tall");
        }
        public int HowMuchTo100()
        {
            return 100 - Weight;
        }

        public void TellResult()
        {
            Console.WriteLine("Per raggiungere 100kg ne mancano " + HowMuchTo100() + "kg");
        }
    }
    class Dipendente
    {
        public string Name = "Pippo";
        public string Company = "Epicode";
        public string JobType = "Fullstack developer";

        public void Greet()
        {
            Console.WriteLine("Hi, my name is " + Name + " and I'm a " + JobType + " for " + Company);
        }

        public string ChangeName()
        {
            return Name = "Pinco (NOME CAMBIATO)";
        }
    }

    class Animale
    {
        public string Name = "Brownie";
        public string Type = "Dog";
        public string Race = "Pomeranian";
        public double Weight = 3.5;

        public double ChangeWeight()
        {
            return Weight = 0.4 + Weight;
        }

        public void Greet()
        {
            Console.WriteLine("Hi, my name is " + Name + " and I'm a " + Race + " " + Type + " and I weight " + Weight + "kg");
        }
    }

    class Veicolo
    {
        public string Name = "Fiat500";
        public string Brand = "Fiat";
        public string Type = "Car";

        public string ChangeCar()
        {
            return Name = "Fiat Panda";
        }
        public void Greet()
        {
            Console.WriteLine("This " + Type + " is a " + Name + " from " + Brand);
        }
    }
}
