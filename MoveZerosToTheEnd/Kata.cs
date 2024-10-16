using System.Linq;

namespace MoveZerosToTheEnd;

public class Kata
{
	public static int[] MoveZeroes(int[] arr) => arr.OrderBy(i => i == 0).ToArray();
}