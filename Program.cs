using AdventOfCode._2025;

internal class Program
{
    private static void Main(string[] args)
    {
        //Day 1
        {
            Day1 day1 = new Day1();

            var day1_part1_res = day1.TotalDistance_Part1();
            Console.WriteLine($"Day 1 Part 1 Result is : {day1_part1_res}");

            var day1_part2_res = day1.SimilarityScore_Part2();
            Console.WriteLine($"Day 1 Part 2 Result is : {day1_part2_res}");
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 2
        {
            Day2 day2 = new Day2();

            var day2_res1 = day2.SafeReports_Part1();
            Console.WriteLine($"Day 2 Part 1 Result is : {day2_res1}");

            var day2_res2 = day2.TolerateOneBadLevel_Part2();
            Console.WriteLine($"Day 2 Part 2 Result is : {day2_res2}");
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 3
        {
            Day3 day3 = new Day3();

            var day3_res1 = day3.Multiplication(day3.i_input);
            Console.WriteLine($"Day 3 Part 1 Result is : {day3_res1}");

            var day3_res2 = day3.EnabledMultiplication(day3.i_input);
            Console.WriteLine($"Day 3 Part 1 Result is : {day3_res2}");
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 4
        {            
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 5
        {
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 6
        {
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 7
        {
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 8
        {
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 9
        {
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");
    }
}