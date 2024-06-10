namespace Enigpus;

public class Magazine : Book
{
    public override string ToString()
    {
        return $"Code: {Code} \n" +
               $"Title: {Title} \n" +
               $"Publisher: {Publisher}\n" +
               $"Year: {Year}";
    }
}