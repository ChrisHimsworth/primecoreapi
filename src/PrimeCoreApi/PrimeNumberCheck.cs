namespace PrimeCoreApi
{
    public class PrimeNumberCheck
    {
        public bool IsPrime(int numberToCheck)
        {
            if((numberToCheck & 1) == 0)
            {
                if(numberToCheck ==2)
                {
                    return true;
                }
                
                return false;
            }
            
            for(int i = 3; (i*i) <= numberToCheck; i+=2)
            {
                if((numberToCheck % i) == 0)
                {
                    return false;
                }                
            }
            return numberToCheck != 1;
        }        
    }
}