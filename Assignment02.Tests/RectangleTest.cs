using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Assignment02;
using System.Threading.Tasks;

namespace Assignment02.Tests
{
	
	public class RectangleTest
	{
		[Test]
		public void GetLength_InitialValue_Returns1()
		{
			// Arrange
			Rectangle rect = new Rectangle();

			// Act
			int actual = rect.GetLength();
			int expected = 1;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test]
		public void GetLength_AfterSettingLength_Returns20()
		{
			// Arrange
			Rectangle rect = new Rectangle();
			rect.SetLength(20);

			// Act
			int actual = rect.GetLength();
			int expected = 20;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test]
		public void GetLength_AfterSettingLength_Returns30()
		{
			// Arrange
			Rectangle rect = new Rectangle();
			rect.SetLength(30);

			// Act
			int actual = rect.GetLength();
			int expected = 30;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test]
		public void SetLength_AfterSettingLength_Returns15()
		{
			// Arrange
			Rectangle rect = new Rectangle();

			// Act
			int actual = rect.SetLength(15);
			int expected = 15;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test]
		public void SetLength_AfterSettingLength_Returns1199()
		{
			// Arrange
			Rectangle rect = new Rectangle();

			// Act
			int actual = rect.SetLength(1199);
			int expected = 1199;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test]
		public void SetLength_AfterSettingLength_Returns1201()
		{
			// Arrange
			Rectangle rect = new Rectangle();
			int actual = rect.SetLength(1201);

			// Act
			int expected = -1;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}
	}
}
