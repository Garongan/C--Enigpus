/*
 * SOAL !
 * Sebuah perpustakaan bernama Enigpus memiliki beberapa jenis buku yang tersimpan didalamnya diantaranya adalah novel dan majalah.
 * Novel memiliki code, judul, penerbit, tahun terbit dan penulis. Sedangkan majalah memiliki code, judul, penerbit dan tahun terbit saja.
 * Setiap buku di Enigpus akan dicatat didalam sebuah catatan inventory. Dalam proses pencatatannya Enigpus membutuhkan sebuah program, untuk itu buatlah program dengan ketentuan sebagai berikut:
 * 1. Buatlah sebuah abstract class Buku yang memiliki method abstact getTitle()
 * 2. Buatlah sebuah Interface dengan nama inventoryService yang memiliki method addBook(), searchBook() berdasarkan title dan getAllBook();
 * 3. Implementasikan interface dari inventoryService kedalam class inventoryServiceImpl, supaya transaksi create, read, update, delete inventory bisa digunakan
 * 4. Buatlah tampilan menu yang dapat digunakan untuk memilih proses apa yang akan dilakukan oleh user dalam menjalankan program inventory Enigpus
 * 5. Semua class dan variable ditulis menggunakan Bahasa inggris dan sesuai dengan ketentuan penulisan nama variable dan kelas seperti yang telah diajarkan.
 */

using Enigpus.service;

namespace Enigpus;

public static class Program
{
    public static void Main(string[] args)
    {
        var run = new Menu();
        run.RunMenu();
    }
}