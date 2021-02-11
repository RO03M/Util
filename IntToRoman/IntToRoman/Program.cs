using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This application transforms integers to roman letters*/

namespace IntToRoman {
    class Roman {

        public enum NumberRoman { 
            I = 1,
            IV = 4,
            V = 5,
            IX = 9,
            X = 10,
            XL = 40,
            L = 50,
            LC = 90,
            C = 100,
            CD = 400,
            D = 500,
            DM = 900,
            M = 1000
        }

        public void SplitNumber(int number) {
            int tempNumber = number;
            Array array = Enum.GetValues(typeof(NumberRoman));
            Console.Write(number + ": ");
            for (int i = array.Length - 1; i >= 0; --i) {
                Console.Write(new StringBuilder().Insert(0, array.GetValue(i).ToString(), tempNumber / (int)array.GetValue(i)));
                tempNumber %= (int)array.GetValue(i);
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {
            Roman main = new Roman();
            for (int i = 0; i < 3000; i++) {
                main.SplitNumber(i);
            }
            Console.ReadLine();
        }
    }
}
