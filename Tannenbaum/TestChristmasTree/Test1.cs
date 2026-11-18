namespace TestChristmasTree
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestLayer1WithoutStar()
        {
            Tannenbaum tannenbaum = new Tannenbaum();

            tannenbaum._height = 5;

            int count = 0;

            List<string> result = tannenbaum.GetCurrentChristmasTreeLayer(1, false);

            List<string> expectation = new List<string> { " ", " ", " ", " ", "X" };

            for (int i = 0; i < expectation.Count; i++)
            {
                if (expectation[i] == result[i])
                {
                    count++;
                }
            }

            Assert.HasCount(count, expectation);
        }

        [TestMethod]
        public void TestLayer3WithoutStar()
        {
            Tannenbaum tannenbaum = new Tannenbaum();

            tannenbaum._height = 5;

            int count = 0;

            List<string> result = tannenbaum.GetCurrentChristmasTreeLayer(3, false);

            List<string> expectation = new List<string> { " ", " ", "X", "X", "X", "X", "X" };

            for (int i = 0; i < expectation.Count; i++)
            {
                if (expectation[i] == result[i])
                {
                    count++;
                }
            }

            Assert.HasCount(count, expectation);
        }

        [TestMethod]
        public void TestLayer0WithStar()
        {
            Tannenbaum tannenbaum = new Tannenbaum();

            tannenbaum._height = 5;

            int count = 0;

            List<string> result = tannenbaum.GetCurrentChristmasTreeLayer(0, true);

            List<string> expectation = new List<string> { " ", " ", " ", " ", "*" };

            for (int i = 0; i < expectation.Count; i++)
            {
                if (expectation[i] == result[i])
                {
                    count++;
                }
            }

            Assert.HasCount(count, expectation);
        }

        [TestMethod]
        public void TestLayer3WithStar()
        {
            Tannenbaum tannenbaum = new Tannenbaum();

            tannenbaum._height = 5;

            int count = 0;

            List<string> result = tannenbaum.GetCurrentChristmasTreeLayer(3, true);

            List<string> expectation = new List<string> { " ", " ", "X", "X", "X", "X", "X" };

            for (int i = 0; i < expectation.Count; i++)
            {
                if (expectation[i] == result[i])
                {
                    count++;
                }
            }

            Assert.HasCount(count, expectation);
        }
    }
}
