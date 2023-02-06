using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance4
{
    public class Game
    {
        private char[][] _grid;

        public Game()
        {
            _grid = new char[][]{
                new char[]{'.','.','.','.'},
                new char[]{'.','.','.','.'},
                new char[]{'.','.','.','.'},
                new char[]{'.','.','.','.'}
            };
        }
        public void Display()
        {
            Console.Write("1234");
            Console.WriteLine("");

            for (int i = 0; i < _grid.Length; i++)
            {
                for (int j = 0; j < _grid[i].Length; j++)
                {
                    Console.Write(_grid[i][j]);
                }
                Console.WriteLine("");
            }
        }
        //public bool Play(int color)
        //{
        //    if ()
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool Win()
        //{
        //    if ()
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool IsFull()
        //{
        //    if ()
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
