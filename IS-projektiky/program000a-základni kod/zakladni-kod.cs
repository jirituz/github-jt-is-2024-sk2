using System;
using System.Runtime.CompilerServices;

class Program {

    static void main () {

        // chci aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            Console.Clear();


        Console.WriteLine ("****************");
        Console.WriteLine ("****************");
        Console.WriteLine ("*****Název programu ***********");
        Console.WriteLine ("****************");
        Console.WriteLine ("******Jiří Tuž**********");
        Console.WriteLine ("****************");
        Console.WriteLine ("****************");
           


            // vstup uživatele lepší varianta 
            Console.Write("Vlož první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celéčíslo): ");
            }

           
            }

            // opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }


    }


}