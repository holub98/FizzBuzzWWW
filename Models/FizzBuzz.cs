using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWWW.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Podaj liczbę od 1 do 1000 ")]
        [Range(1, 1000),Required (ErrorMessage ="Podałeś liczbę, która nie należy do przedziału")]
        public int Liczba { get; set; }
        public DateTime OstatnioSzukane { get; set; }

        public string GetResult()
        {
            string result = "Wynik szukania FizzBuzz to: ";
            OstatnioSzukane = DateTime.Now;
            if( Liczba%3==0 && Liczba % 5 == 0)
            {
                return result += "FizzBuzz";
            }
            else if (Liczba % 3 == 0 )
            {
                return result += "Fizz" ;
            }
            else if ( Liczba % 5 == 0)
            {
                return result += "Buzz";
            }
            else
            {
                return "Liczba: " + Liczba + " nie jest podzielna ani przez 3 ani przez 5";
            }






        }
    }
}
