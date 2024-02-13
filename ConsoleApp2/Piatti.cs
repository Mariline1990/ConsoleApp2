using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Piatto
    {

        public string _name { get; set; }
        public double _prezzo {  get; set; }



        public Piatto(string nome, double prezzo) {

            this._name = nome;
            this._prezzo = prezzo;
        
        } 

    }
}
