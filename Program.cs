using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek List khusus untuk menampung tipe data string
            List<string> lstNamaMhs = new List<string>();

            //menambahkan elemen List
            //tidak ada proses boxing
            lstNamaMhs.Add("Kristian");
            lstNamaMhs.Add("Ugahari");
            lstNamaMhs.Add("Dwipa");

            //mengakses elemen List
            //tidak ada proses unboxing
            string namaMhs = lstNamaMhs[1];

            Console.WriteLine(namaMhs);
            Console.WriteLine();

            foreach (string nama in lstNamaMhs)
            {
                Console.WriteLine(nama);
            }

            Console.ReadKey();
        }
    }
}
