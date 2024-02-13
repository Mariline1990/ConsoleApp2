using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Menu
    {
        // --  Il sistema dovrà consentire la selezione di un numero
        //  indefinito di cibi.L'ultima opzione invece dovrà riportare l'intero
        //    menu scelto dall'utente, con i relativi prezzi, ed il costo finale,
        //      comprensivo di servizio al tavolo di € 3.00.


        public static Piatto[] listaPietanze()
        {

            Piatto[] piatti = new Piatto[9]; 


            piatti[0] = new Piatto("Coca Cola 150 ml", 2.50);
            piatti[1] = new Piatto("Insalata di pollo", 5.20);
            piatti[2] = new Piatto("Pizza Margherita", 10.00);
            piatti[3] = new Piatto("Pz patatine fritte", 12.50);
            piatti[4] = new Piatto("Insalata di riso", 3.50);
            piatti[5] = new Piatto("Frutta di stagione", 8.00);
            piatti[6] = new Piatto("Pizza fritta ", 5.00);
            piatti[7] = new Piatto("Piadina vegetariana", 6.00);
            piatti[8] = new Piatto("Panino Hamburger", 7.90);

            return piatti;

        }

        


        static public void menuPiatti()
        {
          
          Piatto[] elenco = listaPietanze(); // Piatto è il tipo

                for (int i = 0; i < elenco.Length; i++) 
            {
                Console.WriteLine($" {i + 1} {elenco[i]._name } {elenco[i]._prezzo } Euro");


            }
        }



        



        






    }
    
}
