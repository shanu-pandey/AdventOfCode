/*
--- Day 6:  ---

--- Part One ---

You still have to be careful of time paradoxes, and so it will be important to avoid anyone from 1518 while The Historians search for the Chief. 
Unfortunately, a single guard is patrolling this part of the lab.
Maybe you can work out where the guard will go ahead of time so that The Historians can search safely?

You start by making a map (your puzzle input) of the situation. For example:

....#.....
.........#
..........
..#.......
.......#..
..........
.#..^.....
........#.
#.........
......#...
The map shows the current position of the guard with ^ (to indicate the guard is currently facing up from the perspective of the map). Any obstructions - crates, desks, alchemical reactors, etc. - are shown as #.

Lab guards in 1518 follow a very strict patrol protocol which involves repeatedly following these steps:

If there is something directly in front of you, turn right 90 degrees.
Otherwise, take a step forward.
Following the above protocol, the guard moves up several times until she reaches an obstacle (in this case, a pile of failed suit prototypes):

....#.....
....^....#
..........
..#.......
.......#..
..........
.#........
........#.
#.........
......#...
Because there is now an obstacle in front of the guard, she turns right before continuing straight in her new facing direction:

....#.....
........>#
..........
..#.......
.......#..
..........
.#........
........#.
#.........
......#...
Reaching another obstacle (a spool of several very long polymers), she turns right again and continues downward:

....#.....
.........#
..........
..#.......
.......#..
..........
.#......v.
........#.
#.........
......#...
This process continues for a while, but the guard eventually leaves the mapped area (after walking past a tank of universal solvent):

....#.....
.........#
..........
..#.......
.......#..
..........
.#........
........#.
#.........
......#v..
By predicting the guard's route, you can determine which specific positions in the lab will be in the patrol path. Including the guard's starting position, the positions visited by the guard before leaving the area are marked with an X:

....#.....
....XXXXX#
....X...X.
..#.X...X.
..XXXXX#X.
..X.X.X.X.
.#XXXXXXX.
.XXXXXXX#.
#XXXXXXX..
......#X..
In this example, the guard will visit 41 distinct positions on your map.

Predict the path of the guard. How many distinct positions will the guard visit before leaving the mapped area?

--- Part Two ---

In the above example, there are only 6 different positions where a new obstruction would cause the guard to get stuck in a loop. 
The diagrams of these six situations use O to mark the new obstruction, 
| to show a position where the guard moves up/down, 
- to show a position where the guard moves left/right, 
and + to show a position where the guard moves both up/down and left/right.

Option one, put a printing press next to the guard's starting position:
....#.....
....+---+#
....|...|.
..#.|...|.
....|..#|.
....|...|.
.#.O^---+.
........#.
#.........
......#...

Option two, put a stack of failed suit prototypes in the bottom right quadrant of the mapped area:
....#.....
....+---+#
....|...|.
..#.|...|.
..+-+-+#|.
..|.|.|.|.
.#+-^-+-+.
......O.#.
#.........
......#...

Option three, put a crate of chimney-squeeze prototype fabric next to the standing desk in the bottom right quadrant:
....#.....
....+---+#
....|...|.
..#.|...|.
..+-+-+#|.
..|.|.|.|.
.#+-^-+-+.
.+----+O#.
#+----+...
......#...

Option four, put an alchemical retroencabulator near the bottom left corner:
....#.....
....+---+#
....|...|.
..#.|...|.
..+-+-+#|.
..|.|.|.|.
.#+-^-+-+.
..|...|.#.
#O+---+...
......#...

Option five, put the alchemical retroencabulator a bit to the right instead:
....#.....
....+---+#
....|...|.
..#.|...|.
..+-+-+#|.
..|.|.|.|.
.#+-^-+-+.
....|.|.#.
#..O+-+...
......#...

Option six, put a tank of sovereign glue right next to the tank of universal solvent:
....#.....
....+---+#
....|...|.
..#.|...|.
..+-+-+#|.
..|.|.|.|.
.#+-^-+-+.
.+----++#.
#+----++..
......#O..

It doesn't really matter what you choose to use as an obstacle so long as you and The Historians can put it into position without the guard noticing. 
The important thing is having enough options that you can find one that minimizes time paradoxes, and in this example, there are 6 different positions you could choose.

You need to get the guard stuck in a loop by adding a single new obstruction. How many different positions could you choose for this obstruction?

*/

namespace AdventOfCode._2025
{
    public class Day06
    {
        char[][] grid;
        Tuple<int, int>[] directions;
        int rows;
        int columns;
        public Day06()
        {

            string filePath = "C:\\Users\\shant\\Documents\\Repos\\AdventOfCode\\2025\\Input\\day6_input.txt";
            //string filePath = "C:\\Users\\shant\\Documents\\Repos\\AdventOfCode\\2025\\Input\\day6_testInput.txt";
            string[] lines = File.ReadAllLines(filePath);
            rows = lines.Length;            
            columns = lines[0].Length;

            grid = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                var currLine = lines[i];
                grid[i] = new char[columns];

                for (int j=0; j< columns; j++)
                    grid[i][j] = currLine[j];
            }

            directions = new Tuple<int, int>[4];
            directions[0] = new Tuple<int, int>(-1, 0);
            directions[1] = new Tuple<int, int>(0, 1);
            directions[2] = new Tuple<int, int>(1, 0);
            directions[3] = new Tuple<int, int>(0, -1);
        }
        
        private Tuple<int, int> GetGuardPosition()
        {
            for (int i=0; i< rows; i++)
            {
                for (int j=0; j< columns; j++)
                {
                    if (grid[i][j] == '^')
                    {
                        var pos = new Tuple<int, int>(i, j);
                        return pos;
                    }                        
                }
            }
            return null;
        }

        private void PrintGrid()
        {
            for (int i=0; i< rows;i++)
            {
                for (int j=0; j< columns;j++)
                {
                    Console.Write(grid[i][j] + "   ");
                }
                Console.WriteLine();
            }
        }

        public long DistinctPositions()
        {
            long steps = 0;
            var startPosition = GetGuardPosition();
            
            var x = startPosition.Item1;
            var y = startPosition.Item2;

            int directionIndex = 0;
           
            while (x < rows && x > 0 && y < columns && y > 0)
            {
                if (x == rows - 1 || x == 0 || y == columns - 1 || y == 0)
                {
                    steps++;
                    break;

                }
                    

                int dirX = directions[directionIndex % 4].Item1;
                int dirY = directions[directionIndex % 4].Item2;

                x = x + dirX;
                y = y + dirY;
                
                if (grid[x][y] == '#' )
                {
                    directionIndex++;
                    x -= dirX;
                    y -= dirY;
                }
                else if (grid[x][y] == '.')
                {
                    grid[x][y] = 'X';
                    steps++;
                }                    
            }
            
            return steps;
        }
    }
}
