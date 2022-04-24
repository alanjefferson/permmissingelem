using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
{
	public class Solution
	{
		public int solution(int[] A) {
			int[] array = new int[A.Length+1];
			int maxValue = A.Max();
			int minValue = A.Min();

			for (int i = 0; i < array.Length; i++)  {
				if (i == 0) {
					array[i] = minValue;
				} else if(i == array.Length-1) {
					array[i] = maxValue;
				} else {
					array[i] = array[i - 1] + 1;
				}
			}

			List<int> lstValue = (from s in array where !A.Contains(s) select s).ToList<int>();

			return lstValue[0];
		}
	}
}
