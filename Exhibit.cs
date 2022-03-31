using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Exhibit
    {
		protected string _name, _historic_period;
		protected double _rating;
		private int _num_of_ratings, _rating_sum;

		public Exhibit(string name, string historic_period)
		{
			_name = name;
			_historic_period = historic_period;
			_rating = 0;
			_num_of_ratings = 0;
			_rating_sum = 0;
		}

		public string Name
		{
			get { return _name; }
		}

		public string HistoricPeriod
		{
			get { return _historic_period; }
		}
		public double Rating
		{
			get { return _rating; }
		}
		public void EnterRating()
		{
			int new_rating_entry;
			Console.WriteLine("Enter your rating (1-5) of " + _name);
			int.TryParse(Console.ReadLine(), out new_rating_entry);
			_num_of_ratings++;
			_rating_sum = _rating_sum + new_rating_entry;
			_rating = (double)_rating_sum / (double)_num_of_ratings;
		}

	}
}
