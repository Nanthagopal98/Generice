namespace findMaximum.test
{
    public class Tests
    {
        [Test]
        public void findMax_MaximumValueAtFirstPosition()
        {
            int A = 30, B = 20, C = 10;
            findMaximumValue findMaximumValue = new findMaximumValue();
            int finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(A, finalResult);
        }
        [Test]
        public void findMax_MaximumValueAtSecondPosition()
        {
            int A = 10, B = 30, C = 20;
            findMaximumValue findMaximumValue = new findMaximumValue();
            int finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(B, finalResult);
        }
        [Test]
        public void findMax_MaximumValueAtThirdPosition()
        {
            int A = 10, B = 20, C = 30;
            findMaximumValue findMaximumValue = new findMaximumValue();
            int finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(C, finalResult);
        }
    }
}