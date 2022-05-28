namespace findMaximum.test
{
    public class TestInt
    {
        [Test]
        public void findMax_MaximumValueAtFirstPosition()
        {
            int A = 30, B = 20, C = 10;
            findMaximumValue<int> findMaximumValue = new findMaximumValue<int>(A, B, C);
            int finalResult = findMaximumValue.findMax();
            Assert.AreEqual(A, finalResult);
        }
        [Test]
        public void findMax_MaximumValueAtSecondPosition()
        {
            int A = 10, B = 30, C = 20;
            findMaximumValue<int> findMaximumValue = new findMaximumValue<int>(A, B, C);
            int finalResult = findMaximumValue.findMax();
            Assert.AreEqual(B, finalResult);
        }
        [Test]
        public void findMax_MaximumValueAtThirdPosition()
        {
            int A = 10, B = 20, C = 30;
            findMaximumValue<int> findMaximumValue = new findMaximumValue<int>(A, B, C);
            int finalResult = findMaximumValue.findMax();
            Assert.AreEqual(C, finalResult);
        }
    }
    public class TestFloat
    {
        [Test]
        public void findMaxFloat_MaximumValueAtFirstPosition()
        {
            float A = 30.5F, B = 20.5F, C = 10.5F;
            findMaximumValue<float> findMaximumValue = new findMaximumValue<float>(A, B, C);
            float finalResult = findMaximumValue.findMax();
            Assert.AreEqual(A, finalResult);
        }
        [Test]
        public void findMaxFloat_MaximumValueAtSecondPosition()
        {
            float A = 10.5F, B = 30.5F, C = 20.5F;
            findMaximumValue<float> findMaximumValue = new findMaximumValue<float>(A, B, C);
            float finalResult = findMaximumValue.findMax();
            Assert.AreEqual(B, finalResult);
        }
        [Test]
        public void findMaxFloat_MaximumValueAtThirdPosition()
        {
            float A = 10.5F, B = 20.5F, C = 30.5F;
            findMaximumValue<float> findMaximumValue = new findMaximumValue<float>(A, B, C);
            float finalResult = findMaximumValue.findMax();
            Assert.AreEqual(C, finalResult);
        }
    }
    public class TestString
    {
        [Test]
        public void findMaxString_MaximumValueAtFirstPosition()
        {
            string A = "Orange", B = "Banana", C = "Apple";
            findMaximumValue<string> findMaximumValue = new findMaximumValue<string>(A, B, C);
            string finalResult = findMaximumValue.findMax();
            Assert.AreEqual(A, finalResult);
        }
        [Test]
        public void findMaxString_MaximumValueAtSecondPosition()
        {
            string A = "Banana", B = "Orange", C = "Apple";
            findMaximumValue<string> findMaximumValue = new findMaximumValue<string>(A, B, C);
            string finalResult = findMaximumValue.findMax();
            Assert.AreEqual(B, finalResult);
        }
        [Test]
        public void findMaxString_MaximumValueAtThirdPosition()
        {
            string A = "Banana", B = "Apple", C = "Orange";
            findMaximumValue<string> findMaximumValue = new findMaximumValue<string>(A, B, C);
            string finalResult = findMaximumValue.findMax();
            Assert.AreEqual(C, finalResult);
        }
    }

}