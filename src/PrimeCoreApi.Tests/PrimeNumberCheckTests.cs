namespace PrimeCoreApi.Tests
{
    using Xunit;
    using PrimeCoreApi;
    
    public class PrimeNumberCheckTests
    {
        [Theory]
        [InlineData (1, false)]
        [InlineData (2, true)]
        [InlineData (3, true)]
        [InlineData (4, false)]
        [InlineData (5, true)]
        [InlineData (6, false)]
        [InlineData (7, true)]
        [InlineData (556680067, true)]
        [InlineData (556680068, false)]
        public void _Check_Number_x_Is_A_Prime_Number(int numberToCheck, bool shouldBePrimeNumber)        
        {
            PrimeNumberCheck primeNumberCheck = new PrimeNumberCheck();
            var isPrimeNumber = primeNumberCheck.IsPrime(numberToCheck);
            Assert.Equal(shouldBePrimeNumber, isPrimeNumber);
        }              
    }
}