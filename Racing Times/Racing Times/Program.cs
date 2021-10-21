using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Times
{
    //YL
    class Program
    {
        static void Main(string[] args)
        {
            //loops the same question of asking how many people are in the race until it resolves
            while (true)
            {
                try
                {
                    //asks question and converts input into an integer
                    Console.WriteLine("How many people in the race?");
                    int NumberOfPeople = Convert.ToInt32(Console.ReadLine());

                    //only runs code if the input is under/equal to 8 or above/equal to 4
                    if (NumberOfPeople <= 8 && NumberOfPeople >= 4)
                    {
                        //loops this until resolved.
                        while (true)
                        {
                            //asks user for the athlete genders
                            Console.WriteLine("male or female?");
                            string gender = Console.ReadLine();


                            //runs only if the user answered "male"
                            if (gender == "male")
                            {    
                                //creates an array with the same length as the user input for amount of people in race
                                double[] AthleteByTimes = new double[NumberOfPeople];

                                //loops for as long as the input is
                                for (int i = 0; i < NumberOfPeople; i++)
                                {

                                    // try and catch so non-numerical inputs won't crash the program and instead runs catch.
                                    try
                                    { 
                                        // adds 1 to i, since i starts at 0 and the lanes start at 1.
                                        Console.WriteLine("Input lane " + (i + 1) + " Athlete's time");
                                        
                                        //converts the input into a double.
                                        double AthleteTime = Convert.ToDouble(Console.ReadLine());

                                        //rounds the input to 2 decimal places.
                                        AthleteTime = Math.Round(AthleteTime, 2);

                                        //creates an empty array that is the size of "AthleteTime", so if the input is 3, the array will be 3 large.
                                        AthleteByTimes[i] = AthleteTime;

                                        

                                        // code that runs to tell them they broke a record if the user inputted a number smaller than the times shown.
                                        if (AthleteTime < 9.58)
                                        {
                                            Console.WriteLine("Lane " + (i + 1) + " Athlete has broken the World Record");                                       
                                        }

                                        else if (AthleteTime < 9.86)
                                        {
                                            Console.WriteLine("Lane " + (i + 1) + " Athlete has broken the European Record");                                           
                                        }

                                        else if (AthleteTime < 9.87)
                                        {
                                            Console.WriteLine("Lane " + (i + 1) + " Athlete has broken the British Record");                                                                                 
                                        }

                                        else
                                        {
                                            Console.WriteLine("number inputted");                                          
                                        }



                                        //only happens if it reaches the end of the for iteration
                                        if (i == (NumberOfPeople-1))
                                        {

                                            // sorts the array from smallest to largest numbers.
                                            Array.Sort(AthleteByTimes);
                                            Console.WriteLine("The times from smallest to largest are:");

                                            //prints out each value in the array.
                                            foreach (var thing in AthleteByTimes)
                                            {
                                                Console.WriteLine(thing.ToString());
                                            }

                                            
                                        }

                                    }
                                    //catch to prevent invalid inputs from breaking the program.
                                    catch
                                    {
                                        Console.WriteLine("Invalid input.");
                                        i = (i - 1);
                                    }
                                }
                            }
                            
                            //repeat of the male section, but runs if "female" is inputted.
                            else if(gender == "female")
                            {

                                double[] AthleteByTimes = new double[NumberOfPeople];

                                for (int i = 0; i < NumberOfPeople; i++)
                                {
                                    try
                                    {
                                        Console.WriteLine("Input lane " + (i + 1) + " Athlete's time");
                                        double AthleteTime = Convert.ToDouble(Console.ReadLine());
                                        AthleteTime = Math.Round(AthleteTime, 2);
                                        AthleteByTimes[i] = AthleteTime;

                                        

                                        if (AthleteTime < 10.59)
                                        {
                                            Console.WriteLine("Lane " + (i + 1) + " Athlete has broken the World Record");
                                        }

                                        else if (AthleteTime < 10.73)
                                        {
                                            Console.WriteLine("Lane " + (i + 1) + " Athlete has broken the European Record");
                                        }

                                        else if (AthleteTime < 10.99)
                                        {
                                            Console.WriteLine("Lane " + (i + 1) + " Athlete has broken the British Record");
                                        }

                                        else
                                        {
                                            Console.WriteLine("number inputted");
                                        }





                                        if (i == (NumberOfPeople - 1))
                                        {
                                            Array.Sort(AthleteByTimes);

                                            foreach (var thing in AthleteByTimes)
                                            {
                                               
                                                Console.WriteLine(thing.ToString());
                                            }
                                            Console.ReadKey();
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Invalid input.");
                                        i = (i - 1);
                                    }
                                }
                         
                            }
                            // breaks out of loop
                            break;                        
                        }
                    }
                   //prints this message if the number inputted isn't within the boundaries (  >= 4 or <= 8 )
                    else 
                    {
                        Console.WriteLine("The inputted number is either too high or too low.");
                    }
                }
                catch 
                { 
                    Console.WriteLine("invalid input"); 
                }
            }
        }
    }
}
