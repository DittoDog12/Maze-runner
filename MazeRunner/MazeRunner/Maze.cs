using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunner
{
    class Maze
    {
        //----------Data Members
        private int mExitRow = 22;
        private int mExitCol = 1;
        private Player mPlayer1;
        private bool mGameComplete = false;
        
        //----------Constructor
        public Maze()
        {
            Draw();
            Exit();
        }

        //----------Properties
        public int ExitRow
        {
            get { return mExitRow; }
        }

        public int ExitCol
        {
            get { return mExitCol; }
        }

        public bool GameComplete
        {
            get { return mGameComplete; }
            set { mGameComplete = value; }

        }

        //----------Methods
        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            
            //for (int i = 0; i <= 22; i++)
            //{
            //    for (int j = 0; j <= 72; j++)
            //    {
            //        Console.SetCursorPosition(j, i);
            //        Console.Write("#");
            //    }
            //}

            Console.WriteLine("#####################################");
            Console.WriteLine("# #       #       #     #         # #");
            Console.WriteLine("# # ##### # ### ##### ### ### ### # #");
            Console.WriteLine("#       #   # #     #     # # #   # #");
            Console.WriteLine("##### # ##### ##### ### # # # ##### #");
            Console.WriteLine("#   # #       #     # # # # #     # #");
            Console.WriteLine("# # ####### # # ##### ### # ##### # #");
            Console.WriteLine("# #       # # #   #     #     #   # #");
            Console.WriteLine("# ####### ### ### # ### ##### # ### #");
            Console.WriteLine("#     #   # #   # #   #     # #     #");
            Console.WriteLine("# ### ### # ### # ##### # # # #######");
            Console.WriteLine("#   #   # # #   #   #   # # #   #   #");
            Console.WriteLine("####### # # # ##### # ### # ### ### #");
            Console.WriteLine("#     # #     #   # #   # #   #     #");
            Console.WriteLine("# ### # ##### ### # ### ### ####### #");
            Console.WriteLine("# #   #     #     #   # # #       # #");
            Console.WriteLine("# # ##### # ### ##### # # ####### # #");
            Console.WriteLine("# #     # # # # #     #       # #   #");
            Console.WriteLine("# ##### # # # ### ##### ##### # #####");
            Console.WriteLine("# #   # # #     #     # #   #       #");
            Console.WriteLine("# # ### ### ### ##### ### # ##### # #");
            Console.WriteLine("# #         #     #       #       # #");
            Console.WriteLine("# ###################################");
       }
       
        public void Exit()          // Hold Exit location as a separate entity, allows it to be moved and for endgame checking
        {
            Console.SetCursorPosition(mExitCol, mExitRow);
            Console.WriteLine("X");
        }

        public void Update(Player pPlayer1)
        {
            mPlayer1 = pPlayer1;   // Used to locate player location, endgame trigger
            if (mPlayer1.Col == ExitCol && mPlayer1.Row == ExitRow)
            {
                mGameComplete = true;
            }
        }
    }
}
