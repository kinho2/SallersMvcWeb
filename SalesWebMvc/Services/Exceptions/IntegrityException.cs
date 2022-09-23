using System;
namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationExeption
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
