using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Example
{
    class Enemy
    {
        public string name { get; set; }
        public int health { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Enemys = new List<Enemy>()
            {
                new Enemy{name = "Sayers the stickler", health = 75},
                new Enemy{name = "Masek the meticulous", health = 80},
                new Enemy{name = "Stewart the stern", health = 105},
                new Enemy{name = "Lord Pob", health = 1000},
                new Enemy{name = "Lord Pob the second", health = 1000},
            };

            //IEnumerable<Enemy> trashmobs = from e in Enemys where e.health < 100 select e;
            //IEnumerable<Enemy> bossmobs = from e in Enemys where e.name.ToLower().StartsWith("lord") select e;

            IEnumerable<Enemy> trashmobs = Enemys.Where(p => p.health < 100);
            IEnumerable<Enemy> bossmobs = Enemys.Where(p => p.name.ToLower().StartsWith("lord"));


            IEnumerable<Enemy> trashmobssorted = Enemys.Where(p => p.name.Contains("the")).OrderBy(p2 => p2.health).ThenByDescending(p3 => p3.name.Length);


            Console.WriteLine("Trash mobs are: ");
            foreach (Enemy e in trashmobs )
            {
                Console.WriteLine("\t" + e.name);
                Console.WriteLine("\thealth: " + e.health);
            }

            Console.WriteLine("Sorted trash mobs are: ");
            foreach (Enemy e in trashmobssorted)
            {
                Console.WriteLine("\t" + e.name);
                Console.WriteLine("\thealth: " + e.health);
            }

            Console.WriteLine("Boss mobs are: ");
            foreach (Enemy e in bossmobs)
            {
                Console.WriteLine("\t" + e.name);
                Console.WriteLine("\thealth: " + e.health);
            }
            Console.ReadKey();
        }

        
    }
}
