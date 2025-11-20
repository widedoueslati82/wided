/**
 * @file Calculatrice.cs
 * @brief Programme de calculatrice simple en C#
 * @version 1.0
 * @date 2025-04-07
 * @author Wided Oueslati
 */

using System;

namespace CalculatriceApp
{
    /**
     * @brief Représente une calculatrice avec des opérations de base.
     */
    public class Calculatrice
    {
        /**
         * @brief Additionne deux entiers.
         * @param a Premier entier
         * @param b Deuxième entier
         * @return La somme de a et b
         */
        public int Addition(int a, int b)
        {
            return a + b;
        }

        /**
         * @brief Multiplie deux entiers.
         * @param a Premier entier
         * @param b Deuxième entier
         * @return Le produit de a et b
         */
        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static void Main()
        {
            Calculatrice calc = new Calculatrice();
            int x = 5, y = 3;

            Console.WriteLine("Addition : " + calc.Addition(x, y));
            Console.WriteLine("Multiplication : " + calc.Multiplication(x, y));
        }
    }
}
