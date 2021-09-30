using System;

namespace FightSimIILorens
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter blueGoblin = new Fighter();
            Fighter redGoblin = new Fighter();

            blueGoblin.hp -= redGoblin.ak47.Attack();
            redGoblin.hp -= blueGoblin.ak47.Attack();
            // if ()

            while (blueGoblin.hp > 0 || redGoblin.hp > 0)
            {
                Console.WriteLine("Zero Deaths! Keep fighting! ");
                Console.WriteLine("Blue Goblins health: " + blueGoblin.hp);
                Console.WriteLine("Red Goblins health: " + redGoblin.hp);
            }
        }
    }
}
