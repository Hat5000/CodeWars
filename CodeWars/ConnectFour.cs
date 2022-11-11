using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ConnectFour
    {
        public bool Win(bool?[,] bord, int row , int colum, bool waarde)
        {
            if(3 <= row)
            {

            }
            return true;
        }
        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            bool?[,] bord = new bool?[6,7];
            foreach (string piece in piecesPositionList)
            {
                var split = piece.Split('_');
                var Colum = (int)char.Parse(split[0])-65;
                int Row;
                var Waarde = "Red" == split[1];
                for(Row = 0; Row< 6; Row++)
                {
                    if(bord[Row,Colum] == null)
                    {
                        bord[Row,Colum] = Waarde;
                        break;
                    }
                }
            }

            int i = 0;
            foreach(var Row in bord)
            {
                
                if(i == 7)
                {
                    Console.WriteLine();
                    i = 0;
                }
                i++;
                string waarde;
                if (Row == null)
                {
                    waarde = " ";
                }
                else if ((bool)Row)
                {
                    waarde = "x";
                }
                else
                {
                    waarde = "o";
                }
                Console.Write(waarde);
            }
            return "";
        }
    }
}
