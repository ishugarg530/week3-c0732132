using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732132
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Node
    {
        Node PreviousNode;
        Node NextNode;

    }

    class Countryside
    {
        Village Alst;
        Village Maeland;
        Village schenig;


        public void InitializeMap()
        {
           
            Alst = new Village();
            Alst.VillageName = "Alst";
            Maeland = new Village();
            Maeland.VillageName = "Maeland";
            Maeland.isAstrildeHere = true;
            schenig = new Village();
            schenig.VillageName = "schenig";

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = schenig;
            schenig.NextVillage = Alst;
        }
         public void FindAstrilde()
       
        {
         Village CurrentVillage = this.Maeland;
            if (CurrentVillage.isAstrildeHere)
            {
                Console.WriteLine("Hugi found Astrilde!!! Celebrations! XOXO");
                    
            }
            Village NextVillage;

            NextVillage = CurrentVillage.NextVillage;

        }
        
    }

    
    class Village
    {
        public Village PreviousVillage;
        public Village NextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
        public Village() { }
         
    }

    
}
