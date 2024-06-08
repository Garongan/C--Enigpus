namespace Enigpus;

public abstract class Books
{
    public string? Code { get; set; }
    public string? Title { get; set; }
    public string? Publisher { get; set; }
    public DateTime PublishDate { get; set; }

    public string getTitle()
    {
        return Title ?? "";
    }
}