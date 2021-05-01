using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab13.E2.DeveloperInfoAttribute
{

	[CustomAttribute.DeveloperInfo("GeorgiyIsaev", Date = "Today")]
	public class Rational
	{
		private int dividend = 0;
		private int divisor = 1;

		// Define constructors

		public Rational(int dividend)
		{
			this.dividend = dividend;
			this.divisor = 1;
		}

		public Rational(int dividend, int divisor)
		{
			if (divisor == 0)
			{
				throw new ArgumentOutOfRangeException("Divisor cannot be zero");
			}
			else
			{
				this.dividend = dividend;
				this.divisor = divisor;
			}
		}

		public Rational(Rational r1)
		{
			this.dividend = r1.dividend;
			this.divisor = r1.divisor;
		}

		// Define operators

		public static bool operator ==(Rational r1, Rational r2)
		{
			return (r1.dividend * r2.divisor) == (r2.dividend * r1.divisor);
		}

		public static bool operator !=(Rational r1, Rational r2)
		{
			return !(r1 == r2);
		}

		public static bool operator <(Rational r1, Rational r2)
		{
			return (r1.dividend * r2.divisor) < (r2.dividend * r1.divisor);
		}

		public static bool operator >(Rational r1, Rational r2)
		{
			return !((r1 < r2) || (r1 == r2));
		}

		public static bool operator <=(Rational r1, Rational r2)
		{
			return !(r1 > r2);
		}

		public static bool operator >=(Rational r1, Rational r2)
		{
			return !(r1 < r2);
		}

		public static Rational operator +(Rational r1, Rational r2)
		{
			// Make working copies of r1 and r2
			Rational tempR1 = new Rational(r1);
			Rational tempR2 = new Rational(r2);

			// Work out a common divisor
			// E.g. to add 1/4 and 2/3, convert to 3/12 and 8/12
			int commonDivisor;
			if (tempR1.divisor != tempR2.divisor)
			{
				commonDivisor = tempR1.divisor * tempR2.divisor;

				// Multiply out the dividends of each rational
				tempR1.dividend *= tempR2.divisor;
				tempR2.dividend *= tempR1.divisor;
			}
			else
			{
				commonDivisor = tempR1.divisor;
			}

			// Create a new Rational with the dividends summed and the common divisor
			// E.g. 1/4 + 2/3 = 3/12 + 8/12 = 11/12

			Rational result = new Rational(tempR1.dividend + tempR2.dividend, commonDivisor);
			return result;
		}

		public static Rational operator +(Rational r1, int i1)
		{
			// Convert i1 into a Rational
			Rational r2 = new Rational(i1 * r1.divisor, r1.divisor);

			// Perform Rational addition
			return r1 + r2;
		}

		public static Rational operator -(Rational r1, Rational r2)
		{
			// Make working copies of r1 and r2
			Rational tempR1 = new Rational(r1);
			Rational tempR2 = new Rational(r2);

			// Work out a common divisor
			// E.g. to subtract 2/3 from 1/4, convert to 8/12 and 3/12
			int commonDivisor;
			if (tempR1.divisor != tempR2.divisor)
			{
				commonDivisor = tempR1.divisor * tempR2.divisor;

				// Multiply out the dividends of each rational
				tempR1.dividend *= tempR2.divisor;
				tempR2.dividend *= tempR1.divisor;
			}
			else
			{
				commonDivisor = tempR1.divisor;
			}

			// Create a new Rational with the dividends summed and the common divisor
			// E.g. 2/3 - 1/4 = 8/12 - 3/12 = 5/12

			Rational result = new Rational(tempR1.dividend - tempR2.dividend, commonDivisor);
			return result;
		}

		public static Rational operator -(Rational r1, int i1)
		{
			// Convert i1 into a Rational
			Rational r2 = new Rational(i1 * r1.divisor, r1.divisor);

			// Perform Rational addition
			return r1 - r2;
		}

		public static Rational operator ++(Rational r1)
		{
			return r1 + 1;
		}

		public static Rational operator --(Rational r1)
		{
			return r1 - 1;
		}

		public static explicit operator float(Rational r1)
		{
			float temp;
			temp = (float)r1.dividend / r1.divisor;
			return temp;
		}

		public static explicit operator int(Rational r1)
		{
			float temp;
			temp = (float)r1.dividend / r1.divisor;
			return (int)temp;
		}

		public static implicit operator Rational(int i1)
		{
			Rational temp = new Rational(i1, 1);
			return temp;
		}

		public static Rational operator *(Rational r1, Rational r2)
		{
			int dividend = r1.dividend * r2.dividend;
			int divisor = r1.divisor * r2.divisor;
			Rational temp = new Rational(dividend, divisor);
			return temp;
		}

		public static Rational operator /(Rational r1, Rational r2)
		{
			// Create the reciprocal of r2 and then multiply
			Rational temp = new Rational(r2.divisor, r2.dividend);
			return r1 * temp;
		}

		public static Rational operator %(Rational r1, int i1)
		{
			// Convert r1 to an int
			int temp = (int)r1;

			// Work out the rounding difference between temp and r1
			Rational diff = r1 - temp;

			// Perform % on temp and i1
			int remainder = temp % i1;

			// Add remainder and diff together to get the complete result
			diff = diff + remainder;
			return diff;
		}

		// Override methods

		public override string ToString()
		{
			return String.Format("{0}/{1}", dividend, divisor);
		}

		public override bool Equals(Object r1)
		{
			return (this == (Rational)r1);
		}
	}
}
