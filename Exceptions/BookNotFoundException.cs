namespace CoreTrainingDayTwo08122024.Exceptions
{
    public class BookNotFoundException: ApplicationException
    {
        public BookNotFoundException() { }

        public BookNotFoundException (string message) : base (message) { }
    }
}
