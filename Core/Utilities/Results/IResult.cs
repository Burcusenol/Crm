namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }//Sadece okunabilir
        string Message { get; } //Kullanıcı mesajı


    }
}
