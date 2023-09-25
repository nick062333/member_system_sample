namespace MemberSystem.Infrastructure
{
    public class MemberSystemException : Exception
    {
        public MemberSystemException()
        { }

        public MemberSystemException(string message)
            : base(message)
        { }

        public MemberSystemException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
