using System.Security.Cryptography.X509Certificates;
using System;

namespace FightSimIILorens
{
    public class Weapon
    {
        public string weaponName;
        Random generator = new Random();


        public int Attack()
        {
            return generator.Next(1, 100);
        }
    }
}