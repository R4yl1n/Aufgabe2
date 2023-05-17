using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2 {
    public class Aufgabe4 {
        Random random = new Random();
        bool gamerunning = true;

        public void startAufgabe4() {
            Console.WriteLine("hallu zu dim schwule dice game lets go");
            while (gamerunning) {
                var diceNumber = getDice();
                isdice3(diceNumber);
                var dice4orabove = isdice4OrAbove(diceNumber);
                if ( !dice4orabove) {
                    Console.WriteLine($"du hesch verlore du lusche du hesch {diceNumber}");
                    break;
                 }

            }
        }
        private int getDice() {
            int dice = random.Next(1, 6);
            return dice;
        }

        private bool isdice3(int dice) {
            if (dice == 3) {
                Console.WriteLine($"du hast {dice} gewürfelt du hast gewonnen!");
                gamerunning=false;
                return true;
            } else { return false; }

        }

        private bool isdice4OrAbove(int dice) {
            if ((dice <= 4)) {
                Console.WriteLine($"du hast {dice} geürfelt du darfs nochmals würfeln");
                return true;
            } else { return false; }

        
        }
    }
}

