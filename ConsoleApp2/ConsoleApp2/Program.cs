namespace ConsoleApp2
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            //Getting the file
            string filePath = @"C:\Users\tshilidzi.mudzusi\Downloads\calibration.txt";
            //integer for the lines in the file
            int lineNum = 0;    
            try
            {
                //reading all the lines from the file and placing them into an array called lines
                string[] lines = File.ReadAllLines(filePath);
                //for the sum of all the calibration value.
                int sum = 0;
                //Iterate each line in the file 
                foreach (string line in lines)
                {
                    //defining characters found in each fine from first to last 
                    char firstDigit = '\0';
                    char lastDigit = '\0';
                    // Iterate over each character in the current 'line' string
                    foreach (char Number in line)
                    {
                        if (char.IsDigit(Number))
                        {
                            if (firstDigit == '\0')
                            {
                                firstDigit = Number;
                            }
                            lastDigit = Number;
                        }
                    } 
                    lineNum++;
                    // Checking if both firstDigit and lastDigit have been assigned a value
                    if (firstDigit != '\0' && lastDigit != '\0')
                    { 
                       
                        // combinding the first and last digits to form a two-digit string
                        int calibrationValue = int.Parse(firstDigit.ToString() + lastDigit.ToString());

                        //to print each line and the combined value
                        Console.WriteLine("the values retried from line " + lineNum + " is " + calibrationValue);
                        //adding the combined values together
                        sum += calibrationValue;
                    }
                }
                //printing the total
                Console.WriteLine("The total sum is " + sum);
            }

            //error handling 
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. please check file path");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        // Console.WriteLine(sum);
    }
    }


