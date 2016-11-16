using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunner
{
    class Kernel
    {
        //----------Data Members
        public Player Player1;
        public Maze Maze1;
        private bool RunGame = false;
        private ConsoleKeyInfo mInput;
        private bool mLoop;

        //----------Methods
        public void Initialize()
        {
            Maze1 = new Maze();
            Player1 = new Player();
            RunGame = true;
            Console.SetCursorPosition(0, 23);  // Moves cursor to bottom of screen, prevents maze wall from being erased.
            Update();
        }

        public void Update()  // Main Update loop
        {
            while(RunGame == true)
            {
                Player1.Update();
                Maze1.Update(Player1);
                if (Maze1.GameComplete == true)
                {
                    RunGame = false;
                    EndGame();
                }
            }
        }
        public void EndGame()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("A Winner is You");
            Console.WriteLine("New Game Y/N?");

            mLoop = true;
            while (mLoop == true)   // Ensures New Game/Exit prompt will keep running until a correct key is pressed.
            {
                mInput = Console.ReadKey();
                switch (mInput.Key)
                {
                    case ConsoleKey.Y:
                        Reset();
                        mLoop = false;   // Stops loop from interfearing with new game
                        break;

                    case ConsoleKey.N:
                        System.Environment.Exit(0);  // No need to change loop control bool, exit command executed.
                        break;

                    default:
                        Console.WriteLine("Invalid entry, press Y or N");
                        break;
                }  
            }
                      
        }

        public void Reset()
        {
            Maze1 = null;
            Player1 = null;
            Initialize();
        }

    }
}
