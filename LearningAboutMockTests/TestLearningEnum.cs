using NUnit.Framework;

namespace LearningAboutMockTests
{
    enum DaysOfTheWeek {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday
    }

    enum DumbDaysOfTheWeek {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday
    }

    class TestLearningEnum
    {
        [Test]
        public void CanAccessEnum()
        {
            //Assert.AreEqual("Sunday", DaysOfTheWeek.Sunday);
            Assert.AreEqual(5, (int)DaysOfTheWeek.Thrusday);

            Assert.AreEqual(0, (int)DumbDaysOfTheWeek.Sunday);
        }
    }
}
