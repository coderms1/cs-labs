using System;
using static System.Console;

public class IntegerFacts
{
    public static void Main()
    {
        int[] nums = new int[10];
        int count = FillArray(nums);

        if (count > 0)
        {
            Statistics(nums, count, out int max, out int min, out int sum, out double avg);

            WriteLine($"The array has {count} values");
            WriteLine($"The highest value is {max}");
            WriteLine($"The lowest value is {min}");
            WriteLine($"The sum of the values is {sum}");
            WriteLine($"The average is {avg}");
            Write("The inputs were ");
            for (int i = 0; i < count; i++)
            {
                if (i < count - 1) Write(nums[i] + ", ");
                else WriteLine(nums[i]);
            }
        }
        else
        {
            WriteLine("No values were entered.");
        }
    }

    public static int FillArray(int[] array)
    {
        int count = 0;

        while (count < array.Length)
        {
            Write($"Enter integer #{count + 1} (999 to stop): ");
            string input = ReadLine();

            try
            {
                int value = Convert.ToInt32(input);
                if (value == 999) break;
                array[count] = value;
                count++;
            }
            catch (FormatException)
            {
                WriteLine("invalid");
            }
            catch (OverflowException)
            {
                WriteLine("invalid");
            }
        }

        return count;
    }

    public static void Statistics(int[] array, int value, out int max, out int min, out int sum, out double avg)
    {
        if (value <= 0)
        {
            max = 0;
            min = 0;
            sum = 0;
            avg = 0;
            return;
        }

        max = array[0];
        min = array[0];
        sum = 0;

        for (int i = 0; i < value; i++)
        {
            int val = array[i];
            if (val > max) max = val;
            if (val < min) min = val;
            sum += val;
        }
        avg = (double)sum / value;
    }
}