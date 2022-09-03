using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPinjamBuku
{
    internal class Person
    {
        public string Name { get; set; }
        public string NIK { get; set; }

        public class Member
        {
            public void pinjamBuku()
            {
                Book book = new Book();
                Console.WriteLine("\nIsi keterangan berikut ini: ");
                Console.WriteLine("\nNama anda: ");
                string name = Console.ReadLine();
                Console.WriteLine("Judul buku: ");
                book.Title = Console.ReadLine();
                Console.WriteLine("Penulis buku: ");
                book.Author = Console.ReadLine();
                Console.WriteLine("Tahun rilis buku: ");
                book.ReleaseYear = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("-----Keterangan peminjaman anda-----");
                Console.WriteLine($"\nNama peminjam                 : {name}");
                Console.WriteLine($"Judul buku yang dipinjam      : {book.Title}");
                Console.WriteLine($"Penulis buku yang dipinjam    : {book.Author}");
                Console.WriteLine($"Tahun rilis buku yang dipinjam: {book.ReleaseYear}");
                Console.WriteLine("\nTerima kasih! Selamat datang kembali :)");
            }
            public void beliBuku()
            {
                Book book = new Book();
                Console.WriteLine("\nIsi keterangan berikut ini: ");
                Console.WriteLine("\nNama anda: ");
                string name = Console.ReadLine();
                Console.WriteLine("Judul buku: ");
                book.Title = Console.ReadLine();
                Console.WriteLine("Penulis buku: ");
                book.Author = Console.ReadLine();
                Console.WriteLine("Tahun rilis buku: ");
                book.ReleaseYear = Console.ReadLine();
                Console.WriteLine("Harga buku: ");
                book.Price = Single.Parse(Console.ReadLine()); //Single.Parse() biar bisa nerima input berupa double/float
                Console.Clear();

                Console.WriteLine("-----Keterangan pembelian anda-----");
                Console.WriteLine($"\nNama pembeli                : {name}");
                Console.WriteLine($"Judul buku yang dibeli      : {book.Title}");
                Console.WriteLine($"Penulis buku yang dibeli    : {book.Author}");
                Console.WriteLine($"Tahun rilis buku yang dibeli: {book.ReleaseYear}");
                Console.WriteLine($"Harga buku yang dibeli      : {book.Price}");
                Console.WriteLine("\nTerima kasih! Selamat datang kembali :)");
            }
        }

        public class NonMember
        {
            public void pinjamBuku()
            {
                Book book = new Book();
                Console.WriteLine("\nIsi keterangan berikut ini: ");
                Console.WriteLine("\nNama anda: ");
                string name = Console.ReadLine();
                Console.WriteLine("Judul buku: ");
                book.Title = Console.ReadLine();
                Console.WriteLine("Penulis buku: ");
                book.Author = Console.ReadLine();
                Console.WriteLine("Tahun rilis buku: ");
                book.ReleaseYear = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("-----Keterangan peminjaman anda-----");
                Console.WriteLine($"\nNama peminjam                 : {name}");
                Console.WriteLine($"Judul buku yang dipinjam      : {book.Title}");
                Console.WriteLine($"Penulis buku yang dipinjam    : {book.Author}");
                Console.WriteLine($"Tahun rilis buku yang dipinjam: {book.ReleaseYear}");
                Console.WriteLine("\nTerima kasih! Selamat datang kembali :)");
            }
        }
    }
}
