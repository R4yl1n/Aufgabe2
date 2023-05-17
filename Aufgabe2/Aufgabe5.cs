using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2 {
    public class Aufgabe5 {
        Random random = new Random();
        int the6counter = 0;


        public void startAufgabe5() { 
        for (int i = 0; i <= 6000; i++) {
                if (getDice() == 6) {
                    the6counter++;
                }
            }
            Console.WriteLine($"die zahl 6 wurde{the6counter} mal gewürfelt");
        }

    private int getDice() {
             return random.Next(1,6);
        }
    }
}
