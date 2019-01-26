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
            Maeland = new Village();
            Maeland.isAstrildeHere = true;
            schenig = new Village();

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = schenig;
            schenig.NextVillage = Alst;
        }
         public void WalkAround()
        {
         Village IntialVillage = this.Maeland;

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
