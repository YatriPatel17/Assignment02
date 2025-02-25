using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
	public class Rectangle
	{
		public int length;
		public int width;
		public int max_value = 1200;

		public Rectangle()
		{
			this.length = 1;
			this.width = 1;
		}

		public Rectangle(int length, int width)
		{
			this.length = length;
			this.width = width;
		}

		public int GetLength()
		{
			return this.length;
		}
		public int SetLength(int length)
		{
			if (length < max_value)
			{
				this.length = length;
				return this.length;
			}
			else
			{
				Console.WriteLine("Invalid input. Length must be less than 1200");
			}
			return this.length;
		}

		public int GetWidth()
		{
			return this.width;
		}

		public int SetWidth(int width)
		{
			if (width < max_value)
			{
				this.width = width;
				return this.width;
			}
			else
			{
				Console.WriteLine("Invalid input. Width must be less than 1200.");
			}
			return this.width;
		}
		public int GetPerimeter()
		{
			return 2 * (this.length + this.width);
		}
		public int GetArea()
		{
			return (this.length * this.width);
		}
	}
}
