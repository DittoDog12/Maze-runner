using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MazeRunner
{
    class InputComponent
    {
        //----------Data Members
        private Player mPossessed;

        private int mSpeed = 1;
        private ConsoleKeyInfo mInput;
        private string mInputString;
        
        //----------Properties
        public string aInput
        {
            get { return mInputString; }
        }

        //----------Constructor
        // Possesses player object
        public InputComponent(Player pPossessed)
        {
            mPossessed = pPossessed;
        }


        //----------Methods
        public void Update()
        {
            mInput = Console.ReadKey();
            mPossessed.PrevCol = mPossessed.Col;  // Update previous position variables, used to clear last avatar (Blame ASCII style)
            mPossessed.PrevRow = mPossessed.Row;
            switch (mInput.Key)
            {
                case ConsoleKey.LeftArrow:
                    mPossessed.Col = mPossessed.Col - mSpeed;
                    mInputString = "Left";
                    break;

                case ConsoleKey.RightArrow:
                    mPossessed.Col = mPossessed.Col + mSpeed;
                    mInputString = "Right";
                    break;

                case ConsoleKey.UpArrow:
                    mPossessed.Row = mPossessed.Row - mSpeed;
                    mInputString = "Up";
                    break;

                case ConsoleKey.DownArrow:
                    mPossessed.Row = mPossessed.Row + mSpeed;
                    mInputString = "Down";
                    break;
            }
            mPossessed.MoveAvatar();
        }
    }
}
