using Result.Entities.Result;

namespace Result.Entities
{
    public class Empty
    {
        private Empty()
        {
            
        }

        public static Empty Value { get; } = new Empty();

        public static implicit operator Result<Empty>(Empty empty)
        {
            return Result<Empty>.Success(empty);
        }
    }
}
