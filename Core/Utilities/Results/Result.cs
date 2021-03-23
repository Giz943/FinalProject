using System;
namespace Core.Utilities.Results
{
    public class Result : IResult //çıplak class yok
    {
 

        public Result(bool success, string message):this(success)//this demek classın kendisi yani result
        {
            Message = message;
            
        }


        public Result(bool success)
        {
            
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
