namespace PrimeCoreApi
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    
    [Route("/api/v1/prime/")]
    public class PrimeCoreController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("{ result:\"okay\" }");
        }
    }
}