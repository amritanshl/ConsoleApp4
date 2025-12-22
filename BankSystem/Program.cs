using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmMachine myAtm = new AtmMachine();

            // --- 1. Testing PUBLIC ---
            myAtm.BranchLocation = "Downtown Central"; // Works!
            Console.WriteLine($"Welcome to the ATM at: {myAtm.BranchLocation}");

            // --- 2. Testing PRIVATE ---
            // myAtm._vaultCash = 1000000; // COMPILER ERROR
            // Reason: You cannot reach into the vault from outside the class.

            // --- 3. Testing PROTECTED ---
            // Console.WriteLine(myAtm.MaintenanceCode); // COMPILER ERROR
            // Reason: Program.cs is not a 'child' of AtmMachine.

            // --- 4. Testing INTERNAL ---
            myAtm.SyncWithBankServer(); // Works!
            // Reason: Both files are in the 'BankSystem' project.

            // --- Correct way to interact ---
            myAtm.Withdraw(100); // Works!

            // Using the specialized class to see protected data
            TechnicianConsole tech = new TechnicianConsole();
            tech.PerformRepair(); // Works!
        }
    }
}