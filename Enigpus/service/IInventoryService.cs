namespace Enigpus.service;

public interface IInventoryService
{
    public void AddBook(Book book);
    public List<Book> SearchBook(string title);
    public Book? GetBookById(string code);
    public List<Book> GetAllBook();
    public void UpdateBook(Book book);
    public void DeleteBook(string code);
}