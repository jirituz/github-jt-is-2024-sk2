// chci aby se program opakoval po stisku klávesy "a"
using System.Diagnostics.CodeAnalysis;

string again = "a";
        while(again == "a") {
            Console.Clear();


        Console.WriteLine ("****************");
        Console.WriteLine ("****************");
        Console.WriteLine ("*****součet a součin cifer ***********");
        Console.WriteLine ("****************");
        Console.WriteLine ("******Jiří Tuž**********");
        Console.WriteLine ("****************");
        Console.WriteLine ("****************");
           


            // vstup uživatele lepší varianta 
            Console.Write("Zadejte celé číslo): ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }

           //výpis vstupní hodnoty
           Console.WriteLine("=========================");
           Console.WriteLine("uživatel zadal: {0}", number);
           Console.WriteLine("=========================");

            int suma = 0;
            int numberbackup = number;
            int digit;

            //pokud je číslo záporné tak to odstraníme
            if(number < 0) {
                number = - number;
            }


            while(number >= 10) {
               digit = number % 10; // % operátor modulo- podělení zbytku čísel
              number = (number - digit) / 10;
              Console.WriteLine("digit = {0}", digit);
            suma = suma + digit;

            }
            Console.WriteLine("digit = {0}", number);
            suma = suma + number; 
        
        Console.WriteLine("součet cifer čísla {0} je {1}", numberbackup, suma);


            

            // opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }


        


    
