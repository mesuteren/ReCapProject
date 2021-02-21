using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        //constructer overloading :this(success) i aşağıdakini kullanıyor
        //kendini tekrar ederek yazarsak; overloading;
        //public Result(bool success, string message)
        //{
        //    Message = message;
        //    Sucess = success;
        //}
        public Result(bool success, string message):this(success)
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
