
using System;

// ============================================
// SWEET CORNER
// A beginner-friendly bakery management game
// ============================================

namespace SweetCorner
{
    internal class Program
    {
        // These variables store the player's starting information.

        // The amount of money the bakery starts with.
        static decimal bakeryMoney = 100.00m;

        // How many products the bakery has sold.
        static int productsSold = 0;

        // The current level of the bakery.
        static int bakeryLevel = 1;

        static void Main(string[] args)
        {
            // Set the title displayed in the console window.
            Console.Title = "Sweet Corner - Bakery Simulator";

            // Display the welcome screen.
            DisplayWelcomeMessage();

            // Display the player's starting statistics.
            DisplayBakeryStatistics();

            // Keep the console window open.
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Displays the game's welcome message.
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("     WELCOME TO SWEET CORNER     ");
            Console.WriteLine("=================================");

            Console.WriteLine();
            Console.WriteLine("Congratulations! You own a bakery.");
            Console.WriteLine("Your journey as a bakery owner starts today!");
        }

        // Displays the current bakery statistics.
        static void DisplayBakeryStatistics()
        {
            Console.WriteLine();
            Console.WriteLine("========= BAKERY STATUS =========");

            Console.WriteLine($"Money: €{bakeryMoney:F2}");
            Console.WriteLine($"Products Sold: {productsSold}");
            Console.WriteLine($"Bakery Level: {bakeryLevel}");

            Console.WriteLine("=================================");
        }
    }
}