namespace TestyTest
{
    class TestyTest
    {
        public static void Main()
        {
            int loopCount1 = 0;
            TestArea1.TestSpace1();
        }
    }
    public static class TestArea1
    {
        public static void TestSpace1()
        {
            Console.WriteLine("Hello. This is TestSpace1");
            Console.ReadLine();
            TestyTest2.TestArea3.TestSpace3();
        }
    }
    public static class TestArea2
    {
        public static void TestSpace2()
        {
            Console.WriteLine("This is TestSpace2");
            TestyTest.Main(loopCount1++);
            Console.ReadLine();
            if (loopCount1 < 3)
            {
                TestArea1.TestSpace1();
            }
            else
            {
                TestArea4.TestSpace4();
            }
        }
    }
    public static class TestArea4
    {
        public static void TestSpace4()
        {
            Console.WriteLine("You have finished!");
        }
    }
}