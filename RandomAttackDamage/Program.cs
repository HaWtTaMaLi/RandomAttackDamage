using System;

namespace RandomAttackDamage
{
    internal class Program
    {
        static int currEnemyHealth;

        static Random ranDamage;
        static int attackDamageAmount;

        static void Main()
        {
            ranDamage = new Random();
            currEnemyHealth = 100;

            //AttackRandomnessGenerator();
            ShowHUD();
            PlayerAttack();
            ShowHUD();
            PlayerAttack();
            ShowHUD();
            PlayerAttack();
            ShowHUD();
            PlayerAttack();
            ShowHUD();
            PlayerAttack();
            ShowHUD();
            PlayerAttack();
            ShowHUD();
            PlayerAttack();
        }

        static void SetAttackDamageAmount()
        {
            attackDamageAmount = ranDamage.Next(101); //set max random to 101, if set to 100 it will only go to 99
            Console.WriteLine("\nDamage number rolled:  " + attackDamageAmount);
        }

        static void PlayerAttack()
        {
            SetAttackDamageAmount();
            currEnemyHealth = currEnemyHealth - attackDamageAmount;
            Console.WriteLine("\nEnemy took " + attackDamageAmount + " damage.");

            if (currEnemyHealth <= 0)
            {
                //make a method
                currEnemyHealth = 0;
                YouWon();
            }
        }
        static void YouWon()
        {
            ShowHUD();
            Console.WriteLine("\nYou WON!");
            Console.WriteLine("Press any button to exit...");
            Console.ReadLine();
        }

        static void ShowHUD()
        {
            Console.WriteLine("\n---Enemy Stat's Bar---");
            Console.WriteLine("Enemy Health: " + currEnemyHealth);
            Console.WriteLine("Random Gen #: " + attackDamageAmount +"/100");
        }
    }
}
