using System;
namespace SalesWebMvc.Services.Exceptions
{
    public class ApplicationExeption : ApplicationException
    {
        public ApplicationExeption(string message) : base(message)
        {
             
        }
    }
}
