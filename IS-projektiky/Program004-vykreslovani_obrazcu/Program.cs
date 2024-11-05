using System;

class Program
{
    static void Main()
    {

         // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {

        Console.WriteLine("**********************");
        Console.WriteLine("*****Jiří Tuž ********");
        Console.WriteLine("**********************");
        Console.WriteLine("*****Vykreslování*****");
        Console.WriteLine("**********************");

//kosočtverec
             // Vstup od uživatele - lepší varianta
            // Console.Write("Zadejte velikost obrazce (celé číslo): ");
            // int n;
            // while(!int.TryParse(Console.ReadLine(), out n)) {
            //     Console.Write("Nezadali jste celé číslo. Zadejte znovu velikost obrazce (celé číslo): ");
            // }


        // // horní část kosočtverce
        // for (int i = 1; i <= n; i++)
        // {
        //     // vypsání mezer
        //     for (int j = i; j < n; j++)
        //     {
        //         Console.Write(" ");
        //     }

        //     // vypsání hvězd
        //     for (int j = 1; j <= (2 * i - 1); j++)
        //     {
        //         Console.Write("*");
        //     }

        //     Console.WriteLine();
        // }

        // // spodní část 
        // for (int i = n - 1; i >= 1; i--)
        // {
        //     // vypsání mezer
        //     for (int j = n; j > i; j--)
        //     {
        //         Console.Write(" ");
        //     }

        //     // vypsání hvězd
        //     for (int j = 1; j <= (2 * i - 1); j++)
        //     {
        //         Console.Write("*");
        //     }

        //     Console.WriteLine();
        
        //     }
            
        //     Console.WriteLine();

//PŘESÍPACÍ HODINY 

        //horní část hodin přesípacích hodin
        // for (int i = n ; i >= 1; i--)
        // {
        //     // vypsání mezer
        //     for (int j = n; j > i; j--)
        //     {
        //         Console.Write(" ");
        //     }

        //     // vypsání hvězd
        //     for (int j = 1; j <= (2 * i ); j++)
        //     {
        //         Console.Write("*");
        //     }
        //     Console.WriteLine();
        //     }



        // // spodní část přesípacích hodin
        // for (int i = 1; i <= n; i++)
        // {
        //     // vypsání mezer
        //     for (int j = i; j < n; j++)
        //     {
        //         Console.Write(" ");
        //     }

        //     // vypsání hvězd
        //     for (int j = 1; j <= (2 * i ); j++)
        //     {
        //         Console.Write("*");
        //     }

        //     Console.WriteLine();
        // }

 //vykreslení pímena N
            //vstup uživatele 
            Console.Write("Zadejte velikost obrazce minimální velikost 2 (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n) || n < 2) {
                Console.Write("nezadali jste celé číslo, Zadejte znovu velikost obrazce alespoň 2 (celé číslo)");
            }
           for (int i = 0; i <= n; i++)
        {
            // Llevá strana
            Console.Write("*");

            // uhlopříčka
            for (int j = 0; j <= n; j++)
            {
                if (j == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            // pravá strana
            Console.WriteLine("*");
        }

            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

    }       
}