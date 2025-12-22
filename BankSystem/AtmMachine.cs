using System;

namespace BankSystem
{
    // The class is public so it can be used anywhere
    public class AtmMachine
    {
        // 1. PUBLIC: Visible to everyone
        // Any user or program can see which street the ATM is on.
        public string BranchLocation;

        // 2. PRIVATE: Hidden from everyone except this class
        // This is the most secure data. We don't want any outside code 
        // to manually change the money inside the vault.
        private double _vaultCash = 50000.00;

        // 3. PROTECTED: Visible to this class and its children (Inheritance)
        // Only a specialized "Repair" version of this ATM should see the Diagnostic Code.
        protected string MaintenanceCode = "99-XRAY-01";

        // 4. INTERNAL: Visible to any class inside the SAME project
        // This simulates the bank's internal network connection logic.
        internal void SyncWithBankServer()
        {
            Console.WriteLine("Syncing transaction logs with central bank server...");
        }

        // --- PUBLIC INTERFACE ---
        // This is the "Button" the user presses. It safely interacts with private data.
        public void Withdraw(double amount)
        {
            if (amount <= _vaultCash)
            {
                _vaultCash -= amount; // Modifying private data safely
                Console.WriteLine($"Dispensing ${amount}. Please take your cash.");
                SyncWithBankServer(); // Calling internal method
            }
            else
            {
                Console.WriteLine("Error: Machine out of cash.");
            }
        }
    }

    // A Derived Class (Child) to demonstrate PROTECTED
    public class TechnicianConsole : AtmMachine
    {
        public void PerformRepair()
        {
            // We can access MaintenanceCode because this class 'is an' AtmMachine.
            Console.WriteLine($"Accessing system with Code: {MaintenanceCode}");
            Console.WriteLine("Repair complete.");
        }
    }
}