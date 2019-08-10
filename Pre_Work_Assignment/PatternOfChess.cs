using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Pre_Work_Assignment
{
    class PatternOfChess
    {
       
        public void PrintChessPattern(int linesToPrint)
        {
            for(int i = 1; i <= linesToPrint; i++ )
            {
                if(i%2 != 0)
                {
                    Console.WriteLine("XOXOXOXO");
                }
                else
                {
                    Console.WriteLine("OXOXOXOX");
                }
            }
        }

    }
}
