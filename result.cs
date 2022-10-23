using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthlypaymentd6
{
    internal class result
    {

		void test0()
		{
			int result = (int)Utility.monthlypayment(10000, 2, 2);
			assertEquals(425, result);
		}

        private void assertEquals(int v, int result)
        {
            throw new NotImplementedException();
        }

        void test1()
		{
			int result = (int)Utility.monthlypayment(20000, 4, 10);
			assertEquals(507, result);
		}

		void test2()
		{
			int result = (int)Utility.monthlypayment(2500000, 1, 9);
			assertEquals(218628, result);
		}

		void test4()
		{
			int result = (int)Utility.monthlypayment(10000, 2, 2);
			assertEquals(425, result);
		}

		void test5()
		{
			int result = (int)Utility.monthlypayment(10000, 2, 2);
			assertEquals(425, result);
		}


		void test6()
		{
			int result = (int)Utility.monthlypayment(10000, 2, 2);
			assertEquals(425, result);
		}
	}

	private static void assertEquals(int v, int result)
	{
		throw new NotImplementedException();
	}
}

internal class Utility
{
	internal static int monthlypayment(int v1, int v2, int v3)
	{
		throw new NotImplementedException();
	}

}
