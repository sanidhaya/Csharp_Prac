using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player : IPlayer
    {
        private string Name;
        public string name {
            get { return Name; }
        }
        private int Position;
        public int position {
            get { return Position; }
            set { Position = value; }
        }

        private readonly int MaxLength;


        public Player(string name, int position, int maxLength)
        {
            Name = name;
            Position = position;
            MaxLength = maxLength;
        }

        private void ResetPosition_()
        {
            Position = 0;
        }

        public void ResetPosition()
        {
            ResetPosition_();
        }

        private int RollDice_()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public int RollDice()
        { 
            return RollDice_();
        }

        private void DisplayPlayerName_()
        {
            Console.WriteLine($"Player : {Name}");
            Console.WriteLine($"Position : {Position}");
        }

        public void DisplayPlayerName()
        {
            DisplayPlayerName_();
        }

        public bool MovePositions(int diceRoll)
        {
            if (Position <= 5 && diceRoll == 5)
            {
                Position = 0;
                Console.WriteLine("Cannot go less than 0");
                return false;
            }
            else if (Position + diceRoll > MaxLength)
            {
                Console.WriteLine("This is exceeding the value");
                return false;
            }
            else
            {
                Position += (diceRoll == 5) ? -5 : diceRoll;
                return true;
            }
        }

        private void MovePlayer_() {
            Console.WriteLine($"Current Position: {Position} \n Try Rolling dice by pressing enter");
            Console.ReadLine();
            int diceRoll = RollDice();
            Console.WriteLine($"Rolled to num {diceRoll}");
            MovePositions(diceRoll);
        }

        public void MovePlayer()
        {
            MovePlayer_();
        }

        
    }
}
