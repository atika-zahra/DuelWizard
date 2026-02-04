public class Wizard
{
    public string Name;
    public int Energy;
    public int Damage;

    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    public void Attack(Wizard enemy)
    {
        enemy.Energy -= Damage;

        if (enemy.Energy < 0) 
            enemy.Energy = 0; 

        Console.WriteLine($"{Name} menyerang {enemy.Energy}!");
        Console.WriteLine($"Energi {enemy.Name} tersisa: {enemy.Energy}");
    }

    public void showStats()
    {
        Console.WriteLine($"Nama Wizard  : {Name}");
        Console.WriteLine($"Energy       : {Energy}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard1 = new Wizard("Eden", 20);
            Wizard wizard2 = new Wizard("Loe", 15);


            wizard1.showStats();
            wizard2.showStats();

            wizard1.Attack(wizard2);
            wizard2.Attack(wizard1);
            wizard1.Attack(wizard2);

            Console.WriteLine("=== Statistik Akhir ===");
            wizard1.showStats();
            wizard2.showStats();

            Console.ReadLine();
        }

    }
}

