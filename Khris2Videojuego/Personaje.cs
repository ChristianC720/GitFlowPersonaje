public class Personaje
{
    public string Nombre { get; set; } = "";
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }
    public int Nivel { get; set; }

    public void Attack()
    {
        Console.WriteLine("Ataque Loli AHHHHH!");
        Console.WriteLine("Player dealt {0} points of damage!", Ataque);
    }

    public void TakeDamage(int damageTaken)
    {
        Console.WriteLine("Player received {0} points of damage!", damageTaken);
        Vida -= damageTaken;
    }

    public bool CheckHealth()
    {
        if (Vida <= 0)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("         GAME OVER         ");
            Console.WriteLine("===========================");
            return true;
        }
        else if (Vida <= 30)
        {
            Console.WriteLine("Critical Health!!");
        }

        Console.WriteLine("Remaining PS: {0}", Vida);

        return false;
    }
}
