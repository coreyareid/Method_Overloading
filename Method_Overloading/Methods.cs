using System;
namespace Method_Overloading
{
    public class Methods
    {
        // Exercise Method Overloading
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool choice)
        {
            int answer = x + y;


            if (choice == true && answer > 1)
            {
                return $"You have {answer} dollars.";
            }
            else if (choice == true && answer == 1)
            {
                return $"You have {answer} dollar.";
            }
            else if (choice == true && answer < 1)
            {
                return $"You have {answer} dollars.";
            }
            else
            {
                return answer.ToString();
            }
        }
    }
}

