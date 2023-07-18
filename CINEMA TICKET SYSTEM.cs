using System;

namespace deneme_2

{
    class Program
    {
    

        static void Main(string[] args)
        {
        
               Console.WriteLine("Welcome to CINEMA");
               
                    
                     Console.WriteLine("Please select a movie and type the number");

                     Console.WriteLine("0) HARRY POTTER");

                     Console.WriteLine("1) LORD OF THE RINGS");

                     Console.WriteLine("2) STAR WARS");
                     
                     string[] Movies = {"Harry_Potter", "Lord_Of_The_Rings", "Star_Wars"};
                      
                     Console.WriteLine("Please type the number: ");

                      int Movie_Number;

                      Movie_Number = Convert.ToInt32(Console.ReadLine());

                      if(Movie_Number == 0)
                      {
                        Console.WriteLine("Harry Potter. Nice choice. It's 12.99 for adults and 6.99 for students.");
                      }

                      else if (Movie_Number == 1)
                      {
                        Console.WriteLine("Lord Of The Rings. Nice choice. It's 8.99 for adults and 4.99 for students.");
                      }

                      else if (Movie_Number == 2)
                      {
                        Console.WriteLine("Star Wars. Nice choice. It's 6.99 for adults and 3.99 for students.");
                      }

                      else 
                      {
                        Console.WriteLine("Invalid number."); 

                      
                      }
                        
                        
                        
                        Console.WriteLine("Please scan your id to the machine and type your age");

                        Console.WriteLine("Your age: ");

                        
                        
                        int age;

                        age = Convert.ToInt32(Console.ReadLine());

                        
                        if(age > 19 && Movie_Number == 0)
                        {
                          Console.WriteLine("Thank you. It's 12.99");
                        }
                        
                        else if(age < 19 && Movie_Number == 0)
                        {
                          Console.WriteLine("Thank you. It's 6.99");
                        }

                        else if(age > 19 && Movie_Number == 1)
                        {
                          Console.WriteLine("Thank you. It's 8.99");
                        }

                        else if(age < 19 && Movie_Number == 1)
                        {
                          Console.WriteLine("Thank you. It's 4.99");
                        }

                        else if(age > 19 && Movie_Number == 2)
                        {
                          Console.WriteLine("Thank you. It's 6.99");
                        }

                        else if(age < 19 && Movie_Number == 2)
                        {
                          Console.WriteLine("Thank you. It's 3.99");
                        }
                        
                      

        }
    }
}