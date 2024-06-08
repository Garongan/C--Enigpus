namespace Enigpus;

public abstract class Book
{
    public string? Code { get; set; }
    public string? Title { get; set; }
    public string? Publisher { get; set; }
    public int Year { get; set; }

    public string GetTitle()
    {
        return Title ?? "";
    }
}