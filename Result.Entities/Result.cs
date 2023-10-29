using Result.Entities;
using System.Runtime.InteropServices;

namespace Result.Entities.Result
{
    public class Result<T>
    {
        internal bool Failed { get; set; }

        public T? Data { get; private set; }

        public Error? ErrorData { get; private set; }

        public bool HasFailed() => Failed;

        private Result() { }

        private Result(T data)
        {
            Data = data;
        }

        public static Result<T> Success(T obj)
        {
            var result = new Result<T>(obj);
            result.Failed = false;

            return result;
        }

        public static Result<T> Error(Error error)
        {
            var result = new Result<T>();
            result.ErrorData = error;
            result.Failed = true;

            return result;
        }
    }
}
