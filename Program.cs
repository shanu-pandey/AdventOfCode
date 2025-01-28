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

            Console.WriteLine($"-------------------------------------------------------------------------------------------------");
        }        

        //Day 2 - Red-Nosed Reports
        {
            Day02 day2 = new Day02();

            var day2_res1 = day2.SafeReports_Part1();
            Console.WriteLine($"Day 2 Part 1 Result is : {day2_res1}");

            var day2_res2 = day2.TolerateOneBadLevel_Part2();
            Console.WriteLine($"Day 2 Part 2 Result is : {day2_res2}");

            Console.WriteLine($"-------------------------------------------------------------------------------------------------");
        }        

        //Day 3 - Mull It Over
        {
            Day03 day3 = new Day03();

            var day3_res1 = day3.Multiplication(day3.i_input);
            Console.WriteLine($"Day 3 Part 1 Result is : {day3_res1}");

            var day3_res2 = day3.EnabledMultiplication(day3.i_input);
            Console.WriteLine($"Day 3 Part 1 Result is : {day3_res2}");

            Console.WriteLine($"-------------------------------------------------------------------------------------------------");
        }        

        //Day 4 - Ceres Search
        {
            Day04 day04 = new Day04();
            
            var res_part1 = day04.CountXmas();
            Console.WriteLine($"Day 4 part 1 Result is : {res_part1}");

            var res_part2 = day04.CountXmas_Part2();
            Console.WriteLine($"Day 4 part 2 Result is : {res_part2}");

            Console.WriteLine($"-------------------------------------------------------------------------------------------------");
        }

        //Day 5 - Print Queue
        {
            Day05 day05 = new Day05();

            var res_part1 = day05.SumCorrectlyOrderedMiddlPage();
            Console.WriteLine($"Day 5 part 1 Result is : {res_part1}");

            var res_part2 = day05.SumAfterCorrectlyOrderingIncorrectUpdates();
            Console.WriteLine($"Day 5 part 2 Result is : {res_part2}");

            Console.WriteLine($"-------------------------------------------------------------------------------------------------");
        }
        
        //Day 6
        {
        }
        

        //Day 7
        {
        }
        

        //Day 8
        {
        }
        

        //Day 9
        {
        }
        
    }
}