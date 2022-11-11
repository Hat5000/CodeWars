using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Finder
    {
        public static int PathFinder(string maze)
        {
            var dimension = (int)Math.Sqrt(maze.Length);
            var charArray = maze.Replace('.', '0').Replace("/n","").ToCharArray();
            PathFinder(charArray,dimension);
            return charArray.Last() == '0' ? -1 : charArray.Last();
        }
        public static void PathFinder(Char[] maze,int dimension ,int kolom = 0, int row = 0, int currentDistance = 0)
        {
            
            if(kolom<0 || row<0 ||dimension <= kolom || dimension <= row)
            {
                return;
            }
            else
            {
                int current = row * (dimension) + kolom;
                if (maze[current] == 'W' || maze[current] < currentDistance)
                {
                    return;
                }
                else
                {
                    maze[current] = (char)currentDistance;
                    Console.WriteLine($"{kolom} {row} {currentDistance}");
                    currentDistance++;
                    PathFinder(maze, dimension, kolom + 1, row, currentDistance);
                    PathFinder(maze, dimension, kolom - 1, row, currentDistance);
                    PathFinder(maze, dimension, kolom, row + 1, currentDistance);
                    PathFinder(maze, dimension,kolom, row - 1, currentDistance);
                }
            }
        }
    }
}
