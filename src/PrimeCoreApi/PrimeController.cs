namespace PrimeCoreApi
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    
    [Route("/api/v1/prime/")]
    public class PrimeCoreController
    {
        [HttpGet("{numberToCheck}")]
        public IActionResult Get(int numberToCheck)
        {
            PrimeNumberCheck primeNumberCheck = new PrimeNumberCheck();
            return new OkObjectResult(primeNumberCheck.IsPrime(numberToCheck));
        }
    }
}