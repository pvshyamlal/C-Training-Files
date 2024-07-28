using System;
using StudentGradesCalculator;
namespace StdTest.nUnitTests
{
    public class GradeCal
    {
        private Std st { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            st = new Std();
        }

        [Test]
        public void GetGradesByPercentage_Test1()
        {
            var percentage = 91;
            var grade = st.GetGradesByPercentage(percentage);
            Assert.AreEqual("A+",grade);
        }
        [Test]
        public void GetGradesByPercentage_Test2()
        {
            var percentage = 89;
            var grade = st.GetGradesByPercentage(percentage);
            Assert.AreEqual("A", grade);
        }
        [Test]
        public void GetGradesByPercentage_Test3()
        {
            var percentage = 79;
            var grade = st.GetGradesByPercentage(percentage);
            Assert.AreEqual("B", grade);
        }
        [Test]
        public void GetGradesByPercentage_Test4()
        {
            var percentage = 69;
            var grade = st.GetGradesByPercentage(percentage);
            Assert.AreEqual("C", grade);
        }
        [Test]
        public void GetGradesByPercentage_Test5()
        {
            var percentage = 59;
            var grade = st.GetGradesByPercentage(percentage);
            Assert.AreEqual("D", grade);
        }
        [Test]
        public void GetGradesByPercentage_Test6()
        {
            var percentage = 49;
            var grade = st.GetGradesByPercentage(percentage);
            Assert.AreEqual("E", grade);
        }
        [Test]
        public void GetGradesByPercentage_Test7()
        {
            var percentage = 38;
            var grade = st.GetGradesByPercentage(percentage);
            Assert.AreEqual("Fail", grade);
        }
    }

}