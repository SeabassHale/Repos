using BankyStuffLibrary;

namespace BankTests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Potato", 1000);

            Assert.Throws<InvalidOperationException>(

                () => account.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw")

            );
        }

        [Fact]
        public void Test3()
        {
            //This test doesn't actually work as a test because you've created accounts that can open with negative balances.
            Assert.Throws<ArgumentOutOfRangeException>(

                () => new BankAccount("invalid", 55)

                );
        }
    }
}