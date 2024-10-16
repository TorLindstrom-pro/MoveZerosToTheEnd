using MoveZerosToTheEnd;

namespace Test;

public class Tests
{
	[SetUp]
	public void Setup()
	{
	}

	[Theory]
	[TestCase(0)]
	[TestCase(1)]
	public void SingleDigit_IsReturnedAsIs(int digit)
	{
		var result = Kata.MoveZeroes([digit]);
		var expectedResult = new[] { digit };
		Assert.That(result, Is.EquivalentTo(expectedResult));
	}

	[Test]
	public void InputWithOnlyNonZeroDigits_IsReturnedAsIs()
	{
		var result = Kata.MoveZeroes([1, 2, 3]);
		var expectedResult = new[] { 1, 2, 3 };
		Assert.That(result, Is.EquivalentTo(expectedResult));
	}

	[Test]
	public void SingleZero_MovesToTheEnd()
	{
		var result = Kata.MoveZeroes([0, 1, 2, 3]);
		var expectedResult = new[] { 1, 2, 3, 0 };
		Assert.That(result, Is.EquivalentTo(expectedResult));
	}

	[Test]
	public void AllZeros_MovesToTheEnd()
	{
		var result = Kata.MoveZeroes([1, 2, 0, 1, 0, 1, 0, 3, 0, 1]);
		var expectedResult = new[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };
		Assert.That(result, Is.EquivalentTo(expectedResult));
	}
}