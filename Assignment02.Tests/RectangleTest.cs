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

        /// <summary>
        /// This test verifies the behavior of the GetWidth after setting the width to 22.
        /// This test ensure that the updated width correctly returns in the method.
        /// I chose this test to verify that the SetWidth method will properly update and retrieves the updated width.
        /// This is an important test because it confirms that updated value can be set and retrieves properly.
        /// </summary>
        [Test]
        public void SetWidth_AfterSettingWidth_Returns22()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.SetWidth(22);
            int expected = 22;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test verifies the behavior of the SetWidth method by setting the width to 1199.
        /// This test ensure that the method correctly updates and returns the new width.
        /// I chose this test to verify that the SetWidth method can handle and correctly store large valid value.
        /// This is an important test because it confirms that the Rectangle class support a large range of valid inputs.
        /// </summary>
        [Test]
        public void SetWidth_AfterSettingWidth_Returns1199()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.SetWidth(1199);
            int expected = 1199;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test verifies the behavior of the SetWidth method by setting the invalid length to 1208.
        /// This test ensure that the method correctly returns -1 when we provide out of range width.
        /// I chose this test to verify that the SetWidth method properly reject the invalid input value.
        /// This is an important test because it confirms that the Rectangle class enforces its width constraints.
        /// </summary>
        [Test]
        public void SetWidth_AfterSettingWidth_Returns1208()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int actual = rect.SetWidth(1208);

            // Act
            int expected = -1;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test verifies the behavior of the GetPerimeter after setting the length and width values (4, 7).
        /// This test ensure that the updated values correctly returns in the method.
        /// I chose this test to verify that the GetPerimeter method properly computes the perimeter using valid input values.
        /// This is an important test because it confirms that the calculation of perimeter is correct.
        /// </summary>
        [Test]
        public void GetPerimeter_ValidValues_ReturnsCorrectPerimeter()
        {
            // Arrange
            Rectangle rect = new Rectangle(4, 7);

            // Act
            int actual = rect.GetPerimeter();
            int expected = 22;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test verifies the behavior of the GetPerimeter method.
        /// It ensure that default values length is 1 and width is 1.
        /// I chose this test to confirm that the Rectangle class initializes with correct default values.
        /// </summary>
        [Test]
        public void GetPerimeter_DefaultValues_ReturnsCorrectPerimeter()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.GetPerimeter();
            int expected = 4;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test verifies the behavior of the GetPerimeter after setting the maximum valid length and width values (1200, 1200).
        /// This test ensure that the updated large values correctly returns in the method.
        /// I chose this test to verify that the GetPerimeter method properly computes the perimeter using valid large input values.
        /// This is an important test because it confirms that the calculation of perimeter is correct.
        /// </summary>
        [Test]
        public void GetPerimeter_MaxValues_ReturnsCorrectPerimeter()
        {
            // Arrange
            Rectangle rect = new Rectangle(1200, 1200);
            int actual = rect.GetPerimeter();

            // Act
            int expected = 4800;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test verifies the behavior of the GetArea after setting the length and width values (2, 2).
        /// This test ensure that the updated values correctly returns in the method.
        /// I chose this test to verify that the GetArea method properly computes the perimeter using valid input values.
        /// This is an important test because it confirms that the calculation of area is correct.
        /// </summary>
        [Test]
        public void GetArea_ValidValues_ReturnsCorrectArea()
        {
            // Arrange
            Rectangle rect = new Rectangle(2, 2);

            // Act
            int actual = rect.GetArea();
            int expected = 4;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test verifies the behavior of the GetArea method.
        /// It ensure that default values length is 1 and width is 1.
        /// I chose this test to confirm that the Rectangle class initializes with correct default values.
        /// </summary>
        [Test]
        public void GetArea_DefaultValues_ReturnsCorrectArea()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.GetArea();
            int expected = 1;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test verifies the behavior of the GetArea after setting the maximum valid length and width values (1200, 1200).
        /// This test ensure that the updated large values correctly returns in the method.
        /// I chose this test to verify that the GetArea method properly computes the perimeter using valid large input values.
        /// This is an important test because it confirms that the calculation of perimeter is correct.
        /// </summary>
        [Test]
        public void GetArea_MaxValues_ReturnsCorrectArea()
        {
            // Arrange
            Rectangle rect = new Rectangle(1200, 1200);
            int actual = rect.GetArea();

            // Act
            int expected = 1440000;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
