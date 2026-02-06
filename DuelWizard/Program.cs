Wizard wizardA = new Wizard("Jeruk", 5);
Wizard wizardB = new Wizard("Apel", 15);

Console.WriteLine("Permainan dimulai...\n");
Console.WriteLine("Statistik Awal");
wizardA.showStats();
wizardB.showStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan selesai...\n");
Console.WriteLine("Statistik Akhir");
wizardA.showStats();
wizardB.showStats();

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

    public void Attack(Wizard enemyObj)
    {
        enemyObj.Energy -= Damage;

        Console.WriteLine($"{Name} menyerang {enemyObj.Name}!");
        Console.WriteLine($"Energi {enemyObj.Name} tersisa: {enemyObj.Energy}");
    }

    public void showStats()
    {
        Console.WriteLine($"Nama Wizard  : {Name}");
        Console.WriteLine($"Energy       : {Energy}\n");
    }

    
}



