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
		/// <summary>
		/// This test verifies the behavior of the GetLength.
		/// It ensure that default length is 1.
		/// I chose this test to confirm that the Rectangle class initializes ite length correctly.
		/// </summary>
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

		/// <summary>
		/// This test verifies the behavior of the GetLength after setting the length to 20.
		/// This test ensure that the updated length correctly returns in the method.
		/// I chose this test to verify that the SetLength method will properly update and retrieves the updated length.
		/// This is an important test because it confirms that updated value can be set and retrieves properly.
		/// </summary>
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

		/// <summary>
		/// This test verifies the behavior of the GetLength after setting the length to 30.
		/// This test ensure that the updated length correctly returns in the method.
		/// I chose this test to verify that the SetLength method will properly update and retrieves the updated length.
		/// This is an important test because it confirms that updated value can be set and retrieves properly.
		/// </summary>
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

		/// <summary>
		/// This test verifies the behavior of the GetLength after setting the length to 15.
		/// This test ensure that the updated length correctly returns in the method.
		/// I chose this test to verify that the SetLength method will properly update and retrieves the updated length.
		/// This is an important test because it confirms that updated value can be set and retrieves properly.
		/// </summary>
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

		/// <summary>
		/// This test verifies the behavior of the SetLength method by setting the length to 1199.
		/// This test ensure that the method correctly updates and returns the new length.
		/// I chose this test to verify that the SetLength method can handle and correctly store large valid value.
		/// This is an important test because it confirms that the Rectangle class support a large range of valid inputs.
		/// </summary>

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

		/// <summary>
		/// This test verifies the behavior of the SetLength method by setting the invalid length to 1201.
		/// This test ensure that the method correctly returns -1 when we provide out of range length.
		/// I chose this test to verify that the SetLength method properly reject the invalid input value.
		/// This is an important test because it confirms that the Rectangle class enforces its length constraints.
		/// </summary>
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

		/// <summary>
		/// This test verifies the behavior of the GetWidth.
		/// It ensure that default width is 1.
		/// I chose this test to confirm that the Rectangle class initializes ite width correctly.
		/// </summary>
		[Test]
		public void GetWidth_InitialValue_Returns1()
		{
			// Arrange
			Rectangle rect = new Rectangle();

			// Act
			int actual = rect.GetWidth();
			int expected = 1;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		/// <summary>
		/// This test verifies the behavior of the GetWidth after setting the width to 12.
		/// This test ensure that the updated width correctly returns in the method.
		/// I chose this test to verify that the SetWidth method will properly update and retrieves the updated width.
		/// This is an important test because it confirms that updated value can be set and retrieves properly.
		/// </summary>
		[Test]
		public void GetWidth_AfterSettingWidth_Returns12()
		{
			// Arrange
			Rectangle rect = new Rectangle();
			rect.SetWidth(12);

			// Act
			int actual = rect.GetWidth();
			int expected = 12;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		/// <summary>
		/// This test verifies the behavior of the GetWidth after setting the width to 34.
		/// This test ensure that the updated width correctly returns in the method.
		/// I chose this test to verify that the SetWidth method will properly update and retrieves the updated width.
		/// This is an important test because it confirms that updated value can be set and retrieves properly.
		/// </summary>
		[Test]
		public void GetWidth_AfterSettingWidth_Returns34()
		{
			// Arrange
			Rectangle rect = new Rectangle();
			rect.SetWidth(34);

			// Act
			int actual = rect.GetWidth();
			int expected = 34;

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

	}
}
