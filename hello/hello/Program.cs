using System;

/**
 * @file Program.cs
 * @author wided
 * @date 25 mars 2025
 * @version 1.0
 * @brief Programme simple affichant des messages de bienvenue et d'au revoir.
 */
class Program
{
    /**  
     * @brief Affiche "Hello, World!" dans la console.
     */
    static void Bonjour()
    {
        Console.WriteLine("Hello, World!");
    }

    /**
     * @brief Affiche "Au revoir!" dans la console.
     */
    static void AuRevoir()
    {
        Console.WriteLine("Au revoir!");
    }

    /**
     * @brief Attend une entrée de l'utilisateur avant de continuer.
     */
    static void AttendreUtilisateur()
    {
        Console.WriteLine("Appuyez sur Entrée pour continuer...");
        Console.ReadLine();
    }

    /**
     * @brief Fonction principale du programme.
     * 
     * Cette fonction appelle successivement Bonjour(), AttendreUtilisateur(), 
     * AuRevoir() et AttendreUtilisateur() pour gérer l'affichage des messages.
     */
    static void Main()
    {
        Bonjour();
        AttendreUtilisateur();
        AuRevoir();
        AttendreUtilisateur();
    }
}


