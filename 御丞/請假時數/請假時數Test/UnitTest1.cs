using 請假時數;
namespace 請假時數Test
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void 請假幾小時()
		{
			請假 timeOff = new 請假();
			Assert.AreEqual(0, timeOff.GetTimeOff(0, 5));
			Assert.AreEqual(8, timeOff.GetTimeOff(9, 18));
			Assert.AreEqual(7, timeOff.GetTimeOff(9, 17));
			Assert.AreEqual(3, timeOff.GetTimeOff(9, 12));
			Assert.AreEqual(3, timeOff.GetTimeOff(9, 13));
			Assert.AreEqual(1, timeOff.GetTimeOff(12, 14));
			Assert.AreEqual(8, timeOff.GetTimeOff(8, 18));
			Assert.AreEqual(8, timeOff.GetTimeOff(9, 23));
			Assert.AreEqual(0, timeOff.GetTimeOff(18, 23));

		}
	}
}