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
			var values = A.OrderBy(x => x).ToList();
			var result = 0;

			result = values.Count == 0 ? 1 : values.Count == 1 ? values[0] == 1 ? 2 : 1 : values.Count > 1 ? values[0] == 2 ? 1 : 0 : 0;

			if (result == 0) {
				for (int i=0; i< values.Count - 1; i++) {
					if (values[i + 1] != values[i] + 1) {
						result = values[i] + 1;
						break;
					} else if (values[i + 1] == values[values.Count - 1]) {
						result = values[i + 1] + 1;
						break;
					}
				}
			}

			return result;
		}
	}
}
