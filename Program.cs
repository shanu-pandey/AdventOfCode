using AdventOfCode._2025;

internal class Program
{
    private static void Main(string[] args)
    {
        Day1 day1 = new Day1();
         
        var day1_part1_res = day1.TotalDistance_Part1();
        Console.WriteLine($"Day 1 Part 1 Result is : {day1_part1_res}");

        var day1_part2_res = day1.SimilarityScore_Part2();
        Console.WriteLine($"Day 1 Part 2 Result is : {day1_part2_res}");
    }
}