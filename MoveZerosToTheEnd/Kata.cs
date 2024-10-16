using System.Linq;

namespace MoveZerosToTheEnd;

public class Kata
{
	public static int[] MoveZeroes(int[] arr)
	{
		return arr.OrderBy(i => i == 0 ? 2 : 1).ToArray();
	}
}