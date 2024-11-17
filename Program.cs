namespace BonusEligibilityChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bonus Eligibility Checker!");

            // Input Section
            #region Input Section
            Console.WriteLine("Enter the employee's salary:");
            if (!double.TryParse(Console.ReadLine(), out double salary))
            {
                Console.WriteLine("Invalid salary input. Please enter a valid number.");
                return;
            }

            Console.WriteLine("Enter the employee's years of experience:");
            if (!int.TryParse(Console.ReadLine(), out int experience))
            {
                Console.WriteLine("Invalid experience input. Please enter a valid number.");
                return;
            }

            Console.WriteLine("Is the employee full-time (true/false)?");
            if (!bool.TryParse(Console.ReadLine(), out bool isFullTime))
            {
                Console.WriteLine("Invalid full-time status input. Please enter true or false.");
                return;
            }
            #endregion

            // Bonus Eligibility Check
            #region Basic Bonus Eligibility
            if ((salary < 50000 || experience > 5) && isFullTime)
            {
                Console.WriteLine("Eligible for a bonus.");
            }
            else
            {
                Console.WriteLine("Not eligible for a bonus.");
            }
            #endregion

            // Special Bonus Eligibility
            #region Special Bonus Eligibility
            if (salary < 40000 || experience > 7)
            {
                if (isFullTime)
                {
                    Console.WriteLine("Eligible for a special bonus as a full-time employee.");
                }
                else if (experience > 10)
                {
                    Console.WriteLine("Eligible for a special bonus as a part-time employee with over 10 years of experience.");
                }
                else
                {
                    Console.WriteLine("Not eligible for a special bonus.");
                }
            }
            else
            {
                Console.WriteLine("Not eligible for any additional bonuses.");
            }
            #endregion

            // Bonus Categories
            #region Bonus Categories
            if (salary < 50000)
            {
                Console.WriteLine("Category: Low Salary - Eligible for additional benefits.");
            }
            else if (salary > 100000)
            {
                Console.WriteLine("Category: High Salary - Eligible for senior bonus.");
            }
            else
            {
                Console.WriteLine("Category: Standard Salary - No additional benefits.");
            }
            #endregion

            Console.WriteLine("Thank you for using the Bonus Eligibility Checker!");
        }
    }
}
