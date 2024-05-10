using System;

public class SkywardWeapon
{
    public string WeaponType { get; set; }
    public int BaseAttack { get; set; }
    public int AttackPercent { get; set; }
    public int CriticalDamage { get; set; }
    public int CriticalRate { get; set; }
    public int EnergyRecharge { get; set; }
    public int Level { get; set; }
    public string Refinement { get; set; }

    private string _rarity;

    public SkywardWeapon(string weaponType, int baseAttack, int attackPercent, int criticalDamage, int criticalRate, int energyRecharge)
    {
        WeaponType = weaponType;
        BaseAttack = baseAttack;
        AttackPercent = attackPercent;
        CriticalDamage = criticalDamage;
        CriticalRate = criticalRate;
        EnergyRecharge = energyRecharge;
        Level = 90; 
        Refinement = "R5"; 
        _rarity = "5 star standard weapon";
    }

    public SkywardWeapon(string weaponType, int attack, int criticalDamage)
        : this(weaponType, attack, 0, criticalDamage, 0, 0)
    {
    }

    public SkywardWeapon()
    {
    }

    public void DisplayWeaponInfo()
    {
        Console.WriteLine($"Weapon Type: {WeaponType}");
        Console.WriteLine($"MAIN STAT: Base ATK");
        Console.WriteLine($"2ND STAT: Attack%");

        Console.WriteLine($"------------------------------");

        Console.WriteLine($"Base Attack: {BaseAttack}");
        Console.WriteLine($"Attack%: {AttackPercent}%");
        Console.WriteLine($"Critical Damage: {CriticalDamage}%");
        Console.WriteLine($"Critical Rate: {CriticalRate}%");
        Console.WriteLine($"Energy Recharge: {EnergyRecharge}%");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Refinement: {Refinement}");
        Console.WriteLine($"Rarity: {_rarity}");
    }

    private void Enhance()
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects using constructors
        SkywardWeapon sword = new SkywardWeapon("Sword: Skyward Blade", 608, 0, 44, 20, 8);
        SkywardWeapon claymore = new SkywardWeapon("Claymore: Skyward Pride", 674, 0, 45, 0, 8);
        SkywardWeapon polearm = new SkywardWeapon("Polearm: Skyward Spine", 674, 0, 45, 16, 8);
        SkywardWeapon bow = new SkywardWeapon("Bow: Skyward Harp", 674, 40, 44, 22, 0);
        SkywardWeapon catalyst = new SkywardWeapon("Catalyst: Skyward Atlas", 674, 33, 45, 0, 0);

        // Displaying weapon info
        Console.WriteLine("Sword Info:");
        sword.DisplayWeaponInfo();

        Console.WriteLine("\nClaymore Info:");
        claymore.DisplayWeaponInfo();

        Console.WriteLine("\nPolearm Info:");
        polearm.DisplayWeaponInfo();

        Console.WriteLine("\nBow Info:");
        bow.DisplayWeaponInfo();

        Console.WriteLine("\nCatalyst Info:");
        catalyst.DisplayWeaponInfo();
    }
}
