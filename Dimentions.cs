using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Dimentions
    {

		private float _height, _width, _depth;
		public Dimentions(float height, float width, float depth)
		{
			_height = height;
			_width = width;
			_depth = depth;
		}
		public float Height
		{
			get { return _height; }
		}
		public float Width
		{
			get { return _width; }
		}
		public float Depth
		{
			get { return _depth; }
		}
	}
}
