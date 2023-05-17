using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2 {
    public static class Aufagbe3 {


        public static void startAufgabe3() {
            checkIfBiggerThan20(generatenumber());
        }

        private static int generatenumber() {
            Random random = new Random();
            int randomNumber = random.Next(10, 30);
            return randomNumber;
        }

        private static void checkIfBiggerThan20(int number) {
            var isbigger = String.Empty;

            if (number > 20) {
                isbigger = "grösser";
            } else if (number < 20) {
                isbigger = "kleiner";
            }
            if (number == 20) { Console.WriteLine("die Gewürfelte zahl ist 20"); } 
            else Console.WriteLine($"die Gewürfelte zahl: {number} ist {isbigger} als 20");

        }
    }

}

