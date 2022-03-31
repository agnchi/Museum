using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class ArtPiece:Exhibit
    {
		protected string _artist, _medium;
		protected Dimentions _dimentions;
		public ArtPiece(string name, string artist, string historic_period, string medium, Dimentions dimentions) : base(name, historic_period)
		{
			_artist = artist;
			_medium = medium;
			_dimentions = dimentions;

		}
		public string Artist
		{ get { return _artist; } }
		public string Medium
		{ get { return _medium; } }
		public Dimentions Dimentions
		{ get { return _dimentions; } }
		public void DisplayArtExhibitInfo()
		{
			Console.WriteLine("Art Piece: ");
			Console.WriteLine("title: " + _name + ", artist: " + _artist);
			Console.WriteLine("historic period: " + _historic_period + ", medium : " + _medium);
			Console.WriteLine("height: " + _dimentions.Height + " cm, width : " + _dimentions.Width + " cm, depth : " + _dimentions.Depth + " cm");
			Console.WriteLine("rating: " + _rating);

		}
	}
}
