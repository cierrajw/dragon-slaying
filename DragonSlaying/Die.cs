using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlaying
{
    public class Die
    {
        Random random;
        //Random random = new Random(); //specific value for random number

        public int NumberOfSides { get; set; } //public variable within the class

        //get
        //    {
        //    return numberOfSides;
        //    }
        //set 
        //{

        //    numberOfSides = value;
        //}

        //set number

        //Die testDie = new Die();
        Die myDie = new Die(20);
        public Die() : this(20) //On this instance of the class the die = 20 sides
        {       
        }

        /// <summary>
        /// Constructs a Die with the specified number of sides.
        /// </summary>
        /// <param name="numberOfSides">The number of sides on the Die</param>
        public Die(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
            random = new Random();
        }

        /// <summary>
        /// Rolls the die.
        /// </summary>
        /// <returns>A random number between 1 and <see cref="NumberOfSides"/></returns>
        public int Roll()
        {
            Random roll = new Random();
            roll.Next();
            Console.ReadLine();
            Console.ReadKey();
            return roll.Next(NumberOfSides + 1);           
        }
    }
}
