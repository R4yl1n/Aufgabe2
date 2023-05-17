using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2 {
    public static class StartingPoint {

        public static void startGame() {


            Console.WriteLine("Hallo David da hesch volli uswahl für alles");
            Console.WriteLine("du deffsch uswehle mit welli ufgab zerst usprobiersch");
            Console.WriteLine("1:  Aufgabe3");
            Console.WriteLine("2:  Aufgabe4");
            Console.WriteLine("3:  Aufgabe5");

            string inputOfUser = Console.ReadLine();



            while (inputOfUserIsValid(inputOfUser)) {
                switch (inputOfUser) {
                    case "1":
                        Aufagbe3.startAufgabe3();
                        break;
                    case "2":
                        Aufgabe4 aufgabe4 = new Aufgabe4();
                        aufgabe4.startAufgabe4();
                        break;
                    case "3":
                        Aufgabe5 aufgabe5 = new Aufgabe5();
                        aufgabe5.startAufgabe5();
                        break;
                    default:
                        Console.WriteLine("mach en valid input 1-3 sust pflanz ich der en trojaner ihne");
                        break;
                }
            }
        }

        private static bool inputOfUserIsValid(string inputOfUser) {
            if (inputOfUser == "1" || inputOfUser == "2" || inputOfUser == "3") 
                return true; 
            return false;
        }
    }

}
