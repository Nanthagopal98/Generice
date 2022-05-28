namespace findMaximum.test
{
    public class TestInt
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
    public class TestFloat
    {
        [Test]
        public void findMaxFloat_MaximumValueAtFirstPosition()
        {
            float A = 30.5F, B = 20.5F, C = 10.5F;
            findMaximumValue findMaximumValue = new findMaximumValue();
            float finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(A, finalResult);
        }
        [Test]
        public void findMaxFloat_MaximumValueAtSecondPosition()
        {
            float A = 10.5F, B = 30.5F, C = 20.5F;
            findMaximumValue findMaximumValue = new findMaximumValue();
            float finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(B, finalResult);
        }
        [Test]
        public void findMaxFloat_MaximumValueAtThirdPosition()
        {
            float A = 10.5F, B = 20.5F, C = 30.5F;
            findMaximumValue findMaximumValue = new findMaximumValue();
            float finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(C, finalResult);
        }
    }
    public class TestString
    {
        [Test]
        public void findMaxString_MaximumValueAtFirstPosition()
        {
            string A = "Orange", B = "Banana", C = "Apple";
            findMaximumValue findMaximumValue = new findMaximumValue();
            string finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(A, finalResult);
        }
        [Test]
        public void findMaxString_MaximumValueAtSecondPosition()
        {
            string A = "Banana", B = "Orange", C = "Apple";
            findMaximumValue findMaximumValue = new findMaximumValue();
            string finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(B, finalResult);
        }
        [Test]
        public void findMaxString_MaximumValueAtThirdPosition()
        {
            string A = "Banana", B = "Apple", C = "Orange";
            findMaximumValue findMaximumValue = new findMaximumValue();
            string finalResult = findMaximumValue.findMax(A, B, C);
            Assert.AreEqual(C, finalResult);
        }
    }

}