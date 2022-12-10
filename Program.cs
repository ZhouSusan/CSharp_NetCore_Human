namespace Human
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ninja shadowCat = new Ninja("Inkeyes");
            Wizard hermonine = new Wizard("Hermonine");
            Wizard ronald = new Wizard("Ronald Mc'Donald");
            Samurai jack = new Samurai("Jack");
            
            Console.WriteLine($"Jack's Original info:\n Name: {jack.Name}, Strength: {jack.Strength}, Intelligence: {jack.Intelligence}, Dexerity: {jack.Dexterity}, Health: {jack.Health}");
            Console.WriteLine($"Hermonie's Original info: \n Name: {hermonine.Name}, Strength: {hermonine.Strength}, Intelligence: {hermonine.Intelligence}, Dexterity: {hermonine.Dexterity}, Health: {hermonine.Health}");
            Console.WriteLine($"Inkeye's Original info: \n Name: {shadowCat.Name}, Strength: {shadowCat.Strength}, Intelligence: {shadowCat.Intelligence}, Dexterity: {shadowCat.Dexterity}, Health: {shadowCat.Health}");
            jack.Attack(shadowCat);
            shadowCat.steal(hermonine); // Expect hermonine to have 20 health
            shadowCat.get_away(); // Expect shadowCat health to be 95
            jack.death_blow(shadowCat); // Expect shadowCat Healt to still be 95
            ronald.Heal(hermonine); // Expect hermonine to have 270 health
            hermonine.Fireball(jack); // Expect jack to have between and including 150 - 180 health
            jack.meditiate(); // Expect jack to have between and including 350 - 380 health

            Console.WriteLine($"Jack's New info:\n Name: {jack.Name}, Strength: {jack.Strength}, Intelligence: {jack.Intelligence}, Dexerity: {jack.Dexterity}, Health: {jack.Health}");
            Console.WriteLine($"Hermonie's New info: \n Name: {hermonine.Name}, Strength: {hermonine.Strength}, Intelligence: {hermonine.Intelligence}, Dexterity: {hermonine.Dexterity}, Health: {hermonine.Health}");
            Console.WriteLine($"Inkeye's New info: \n Name: {shadowCat.Name}, Strength: {shadowCat.Strength}, Intelligence: {shadowCat.Intelligence}, Dexterity: {shadowCat.Dexterity}, Health: {shadowCat.Health}");
            Samurai.how_many(); // Expect 1 samurai in play.
        } 
    }
}