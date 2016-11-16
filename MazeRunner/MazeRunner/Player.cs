using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunner
{
    class Player
    {
        //----------Data Members
        private int mCol = 1;
        private int mRow = 1;
        private int mPrevCol;
        private int mPrevRow;
        private string Avatar = "V";
        private InputComponent mInputComponent;
        
        //----------Properties
        public int Row
        {
            get { return mRow; }
            set { mRow = value; }
        }

        public int Col
        {
            get { return mCol; }
            set { mCol = value; }
        }
        public int PrevRow
        {
            set { mPrevRow = value; }
        }

        public int PrevCol
        {
            set { mPrevCol = value; }
        }


        //----------Constructor
        public Player()
        {
            Console.SetCursorPosition(mCol, mRow);
            Console.WriteLine(Avatar);
            mInputComponent = new InputComponent(this);
        }


        //----------Methods
        public void Update()
        {
            this.mInputComponent.Update();
        }

        public void MoveAvatar()
        {
            Console.SetCursorPosition(mPrevCol, mPrevRow);
            Console.WriteLine(" ");
            switch (this.mInputComponent.aInput)
            {
                case "Left":
                    Avatar = "<";
                    break;

                case "Right":
                    Avatar = ">";
                    break;

                case "Up":
                    Avatar = "^";
                    break;

                case "Down":
                    Avatar = "V";
                    break;
            }
            Console.SetCursorPosition(mCol, mRow);
            Console.WriteLine(Avatar);
            Console.SetCursorPosition(0, 23);
        }
    }
}
