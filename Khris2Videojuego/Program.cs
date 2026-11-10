Personaje personaje = new Personaje
{
    Nombre = "Guerrero",
    Vida = 100,
    Ataque = 50,
    Defensa = 30,
    Nivel = 1
};

Console.WriteLine("Nombre: {0}", personaje.Nombre);
Console.WriteLine("Vida: {0}", personaje.Vida);
Console.WriteLine("Ataque: {0}", personaje.Ataque);
Console.WriteLine("Defensa: {0}", personaje.Defensa);
Console.WriteLine("Nivel: {0}", personaje.Nivel);

personaje.Attack();
personaje.CheckHealth();
personaje.TakeDamage(100);
personaje.CheckHealth();
