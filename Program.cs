using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
   class Program
    {
        static void Main(string[] args)
        {
			Dimentions dim = new Dimentions(77, 53, 0);
			ArtPiece monaLisa = new ArtPiece("Mona Lisa", "Leonardo da Vinci", "Renaissance", "Oil on popular canvas", dim);
			for( int i = 0; i < 5; i++)
            {
				monaLisa.EnterRating();
            }
			monaLisa.DisplayArtExhibitInfo();
			HumanRemains ramesses_the_second = new HumanRemains("Ramesses II", "Ancient Egypt", "Deir el-Bahri", "poor", "male", 90);
			for (int i = 0; i < 5; i++)
			{
				ramesses_the_second.EnterRating();
			}

			Console.WriteLine("name: " + ramesses_the_second.Name + ", historic period: "+ramesses_the_second.HistoricPeriod);
			Console.WriteLine("place of excavation: " + ramesses_the_second.PlaceOfExcavation + ", condition: " + ramesses_the_second.Condition + ", sex: " + ramesses_the_second.Sex + ", age: " + ramesses_the_second.Age);
			Console.WriteLine("rating: " + ramesses_the_second.Rating);
		}
    }
}
