using AdventOfCode._2025;

internal class Program
{
    private static void Main(string[] args)
    {
        //Day 1 - Historian Hysteria
        {
            Day01 day1 = new Day01();

            var day1_part1_res = day1.TotalDistance_Part1();
            Console.WriteLine($"Day 1 Part 1 Result is : {day1_part1_res}");

            var day1_part2_res = day1.SimilarityScore_Part2();
            Console.WriteLine($"Day 1 Part 2 Result is : {day1_part2_res}");
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 2 - Red-Nosed Reports
        {
            Day02 day2 = new Day02();

            var day2_res1 = day2.SafeReports_Part1();
            Console.WriteLine($"Day 2 Part 1 Result is : {day2_res1}");

            var day2_res2 = day2.TolerateOneBadLevel_Part2();
            Console.WriteLine($"Day 2 Part 2 Result is : {day2_res2}");
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 3 - Mull It Over
        {
            Day03 day3 = new Day03();

            var day3_res1 = day3.Multiplication(day3.i_input);
            Console.WriteLine($"Day 3 Part 1 Result is : {day3_res1}");

            var day3_res2 = day3.EnabledMultiplication(day3.i_input);
            Console.WriteLine($"Day 3 Part 1 Result is : {day3_res2}");
        }
        Console.WriteLine($"-------------------------------------------------------------------------------------------------");

        //Day 4 - Ceres Search
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