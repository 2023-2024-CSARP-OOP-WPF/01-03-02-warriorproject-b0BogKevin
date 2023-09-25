/*
 * A feladat a github-on olvasható!
 */

using System;
using System.Security.Cryptography.X509Certificates;

namespace WarriorProject
{
    public class Position
    { 
        private int x; private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }


        public Position(int x, int y) { this.x = x; this.y = y;}

        public void ToConsole()
        {
            Console.WriteLine($"({x},{y})");
        }
    }

    public class Warrior
    {
        public string name;
        public Position position;
        public Warrior(string name, Position position)
        {
            this.name = name;
            this.position = position;
            
        }
        


        public void MoveHorizontal(int posChange)
        {
            
            position.X += posChange;
      
        }
        public void MoveVertical(int posChange)
        {
            position.Y += posChange;

        }


        public void ToConsole() 
        {
            Console.WriteLine($"{name}, position ({position.X},{position.Y})");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}
