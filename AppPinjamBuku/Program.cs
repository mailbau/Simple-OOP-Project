using AppPinjamBuku;
using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            SelamatDatang();
        }

        static void SelamatDatang()
        {
            Console.WriteLine("-----Selamat datang di Perpustakaan Mail Ganteng!-----");
            Console.WriteLine("\n-----Keuntungan menjadi member di Perpustakaan Mail Ganteng: -----");
            Console.WriteLine("Bukan member: Hanya bisa meminjam buku. \nMember      : Bisa meminjam buku dan juga bisa membeli buku.");
            Console.WriteLine("\nApakah kamu sudah menjadi member di Perpustakaan Mail Ganteng? (y/n)");

            string member = Console.ReadLine();
            Console.Clear();
            Aksi(member);
        }

        static void Aksi(string member)
        {
            if (member == "y" | member == "Y")
            {
           
                Person.Member myMember = new Person.Member();
                Console.WriteLine("Apa yang ingin anda lakukan?");
                Console.WriteLine("1. Pinjam buku \n2. Beli buku \nTulis angka dari yang ingin anda pilih.");
                string pilih = Console.ReadLine();
                if (pilih == "1")
                {
                    myMember.pinjamBuku();
                }
                else if (pilih == "2")
                {
                    myMember.beliBuku();
                }
            }
            else if (member == "n" | member == "N")
            {
                Person.NonMember myMember = new Person.NonMember();
                Console.WriteLine("Apa yang ingin anda lakukan?");
                Console.WriteLine("1. Pinjam buku \nTulis angka dari yang ingin anda pilih.");
                string pilih = Console.ReadLine();
                if (pilih == "1")
                {
                    myMember.pinjamBuku();
                }
            }
        }
    }
}
