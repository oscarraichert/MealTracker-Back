using System.Runtime.InteropServices;

namespace Commands.Infra.Entities.Result
{
    public class Result
    {
        internal bool Failed { get; set; }

        public object? Data { get; private set; }

        public string? ErrorMessage { get; private set; }

        public bool HasFailed() => Failed;

        private Result() { }

        private Result(object? data)
        {
            Data = data;
        }

        public static Result Success<T>(T obj)
        {
            var result = new Result(obj);
            result.Failed = false;

            return result;
        }

        public static Result Success()
        {
            var result = new Result();
            result.Failed = false;

            return result;
        }

        public static Result Error(string errorMessage)
        {
            var result = new Result();
            result.ErrorMessage = errorMessage;
            result.Failed = true;

            return result;
        }
    }
}
