namespace Enigpus;

public class Novel : Book
{
    public string? Author { get; set; }

    public override string ToString()
    {
        return $"Code: {Code} \n" +
               $"Title: {Title} \n" +
               $"Publisher: {Publisher}\n" +
               $"Year: {Year} \n" +
               $"Author: {Author}";
    }
}