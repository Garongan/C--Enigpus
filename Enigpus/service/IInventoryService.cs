namespace Enigpus.service;

public interface IInventoryService
{
    public void AddBook(Book book);
    public Book? SearchBook(string title);
    public Book? GetBookById(string code);
    public List<Book> GetAllBook();
    public Book UpdateBook(Book book);
    public void DeleteBook(string code);
}