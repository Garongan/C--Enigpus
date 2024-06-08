namespace Enigpus.service;

public interface InventoryService
{
    public void addBook();
    public Books searchBook();
    public List<Books> getAllBook();
}