/*
--- Day 4: Ceres Search ---

--- Part One ---

As the search for the Chief continues, a small Elf who lives on the station tugs on your shirt; she'd like to know if you could help her with her word search (your puzzle input). 
She only has to find one word: XMAS.
This word search allows words to be horizontal, vertical, diagonal, written backwards, or even overlapping other words. 
It's a little unusual, though, as you don't merely need to find one instance of XMAS - you need to find all of them. 
Here are a few ways XMAS might appear, where irrelevant characters have been replaced with .:

..X...
.SAMX.
.A..A.
XMAS.S
.X....
The actual word search will be full of letters instead. For example:

MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX
In this word search, XMAS occurs a total of 18 times; here's the same word search again, but where letters not involved in any XMAS have been replaced with .:

....XXMAS.
.SAMXMS...
...S..A...
..A.A.MS.X
XMASAMX.MM
X.....XA.A
S.S.S.S.SS
.A.A.A.A.A
..M.M.M.MM
.X.X.XMASX
Take a look at the little Elf's word search. How many times does XMAS appear?


--- Part Two ---

Looking for the instructions, you flip over the word search to find that this isn't actually an XMAS puzzle; it's an X-MAS puzzle in which you're supposed to find two MAS in the shape of an X. One way to achieve that is like this:

M.S
.A.
M.S
Irrelevant characters have again been replaced with . in the above diagram. Within the X, each MAS can be written forwards or backwards.

Here's the same example from before, but this time all of the X-MASes have been kept instead:

.M.S......
..A..MSMS.
.M.S.MAA..
..A.ASMSM.
.M.S.M....
..........
S.S.S.S.S.
.A.A.A.A..
M.M.M.M.M.
..........
In this example, an X-MAS appears 9 times.

Flip the word search from the instructions back over to the word search side and try again. How many times does an X-MAS appear?

*/

namespace AdventOfCode._2025
{
    public class Day04
    {
        char[][] input;
        int[,] directions;
        int rows;
        int cols;

        public Day04()
        {
            string filePath = "C:\\Users\\shant\\Documents\\Repos\\AdventOfCode\\2025\\Input\\day4_input.txt";
            string[] lines = File.ReadAllLines(filePath);
            input = lines.Select(s => s.ToCharArray()).ToArray();

            directions = new int[,] { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 }, { 1, 1 }, { 1, -1 }, { -1, 1 }, { -1, -1 } };

            rows = input.Length; 
            cols = input[0].Length;
        }
        
        public long CountXmas()
        {            
            long res = 0;

            for (int i=0; i< rows; i++)
            {
                //check wach character
                for (int j=0; j< cols; j++)
                {
                    //go each direction
                    for (int d = 0; d<8; d++)
                    {
                        int dirRow = directions[d, 0];
                        int dirCol = directions[d, 1];

                        if (IsWordPresent(i, j, dirRow, dirCol))
                            res++;
                    }
                }
            }                        
            return res;
        }

        bool IsWordPresent(int row, int col, int dirRow, int dirCol)
        {
            //4 = length of xmas
            string word = "XMAS";
            for (int i = 0; i < 4; i++)
            {
                int newRow = row + i * dirRow;
                int newCol = col + i * dirCol;

                // Check boundaries
                if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols)
                    return false;

                // Check character match
                if (input[newRow][newCol] != word[i])
                    return false;
            }
            return true;
        }
    }
}
