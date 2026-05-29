Wizard wizardA = new Wizard("Jeruk", 5);
Wizard wizardB = new Wizard("Apel", 15);

Console.WriteLine("FIGHT!");
Console.WriteLine("Statistik Awal");
wizardA.showStats();
wizardB.showStats();

string Pilihan;
while(true)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.Write("\nPilihanmu (1/2/3/4): ");
    Pilihan = Console.ReadLine();

    if (Pilihan == "1") wizardA.Attack(wizardB);
    else if (Pilihan == "2") wizardB.Attack(wizardA);
    else if (Pilihan == "3") wizardA.Heal();
    else if (Pilihan == "4") wizardB.Heal();
    else Console.WriteLine("Pilihanmu tidak valid");

    Console.Write("\nPilihanmu (1/2/3/4): ");
    Pilihan = Console.ReadLine();

    if (Pilihan == "1") wizardA.Attack(wizardB);
    else if (Pilihan == "2") wizardB.Attack(wizardA);
    else if (Pilihan == "3") wizardA.Heal();
    else if (Pilihan == "4") wizardB.Heal();
    else Console.WriteLine("Pilihanmu tidak valid");

    if (wizardA.Energy <= 0 || wizardB.Energy <= 0)
    {
        Console.WriteLine("PERMAINAN BERAKHIR!!");

        if (wizardA.Energy > wizardB.Energy)
        {
            Console.WriteLine($"{wizardB.Name} Berhasil dikalahkan!");
            Console.WriteLine($"{wizardA.Name} Keluar sebagai pemenangnya!");
        }
        else
        {
            Console.WriteLine($"{wizardA.Name} Berhasil dikalahkan!");
            Console.WriteLine($"{wizardB.Name} Keluar sebagai pemenangnya!");
        }
        break;
    }
    Console.WriteLine();

}

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

    public void Heal()
    {

        if (Energy >= 100)
        {
            Console.WriteLine("Gagal melakukan Heal. Energy sudah mencapai maksimum!");
        }
        else
        {
            if (Energy > 95)
            {
                Energy = 100;
            }
            else
            {
                Energy += 5;
            }
            Console.WriteLine($"{Name} Berhasil melakukan Heal! Energy meningkat menjadi {Energy}");
        }
    }
}



