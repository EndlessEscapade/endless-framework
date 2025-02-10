namespace EndlessEscapade.Framework.Core;

public class InvalidComponentException : Exception
{
    public InvalidComponentException() { }

    public InvalidComponentException(string? message) : base(message) { }

    public InvalidComponentException(string? message, Exception? innerException) : base(message, innerException) { }
}