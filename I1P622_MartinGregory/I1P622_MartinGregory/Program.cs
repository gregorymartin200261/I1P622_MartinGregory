using System;

namespace I1P622_MartinGregory
{
    class Program
    {
        static void Main(string[] args)
        {
            int ColorBase = 3;
            int feuxId = 01;

            //new int[] = utils(feux.feuxRouge)
            Console.WriteLine("Etat des feux:");
            EtatFeuBase(ColorBase, feuxId);
            Console.WriteLine("Chéangement d'etat:");
            EtatFeu(ColorBase, feuxId);
            Console.WriteLine("Feu clignotant:");
            ClignoFeu(ColorBase, feuxId);
            Console.ReadLine();
            
        }

        static void EtatFeuBase(int ColorBase, int feuxId)
        {

            string Color;
            if (ColorBase==1)
            {
                 Color = "vert";
            }
            else if (ColorBase == 2)
            {
                 Color = "orange";
            }
            else
            {
                 Color = "rouge";
            }

            Console.WriteLine("Le feu de signalisation "+feuxId+" est "+ Color);
        }
        static void EtatFeu(int ColorBase, int feuxId)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int J = 0; J < 5; J++)
                {
                   
                }
                if(ColorBase<3)
                {
                    ColorBase++;
                }
                else
                { 
                    ColorBase = 1;
                        
                }
                string Color;
                if (ColorBase == 1)
                {
                    Color = "vert";
                }
                else if (ColorBase == 2)
                {
                    Color = "orange";
                }
                else
                {
                    Color = "rouge";
                }
                Console.WriteLine("Le feu de signalisation " + feuxId + " est " + Color);
            }
        }
        static void ClignoFeu(int ColorBase, int feuxId)
        {
            for (int i = 0; i < 15; i++)
            {
                
                
                if (ColorBase < 3)
                {
                    ColorBase++;
                }
                else
                {
                    ColorBase = 1;

                }
                
                string Color;
                if (ColorBase == 1)
                {
                    Color = "vert";
                }
                else if (ColorBase == 2)
                {
                    Color = "orange";
                }
                else
                {
                    Color = "rouge";
                }
                Console.WriteLine("Le feu de signalisation " + feuxId + " est " + Color);
            }
        }


    }
}
