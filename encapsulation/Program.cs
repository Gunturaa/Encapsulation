using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class Program
    {
        public static void Main()
        {
            Mahasiswa mahasiswa1 = new Mahasiswa();
            mahasiswa1.Nama = "Guntur";
            mahasiswa1.Nim = "22.11.4820";
            mahasiswa1.Matakuliah = "Pemrograman";
            mahasiswa1.Prodi = "S1 Informatika";
            mahasiswa1.Kampus = "Universitas Amikom Yogyakarta";

            Mahasiswa mahasiswa2 = new Mahasiswa();
            mahasiswa2.Nama = "Atmaja";
            mahasiswa2.Nim = "22.11.4820";
            mahasiswa2.Matakuliah = "Pemrograman";
            mahasiswa2.Prodi = "S1 Informatika";
            mahasiswa2.Kampus = "Universitas Amikom Yogyakarta";

            mahasiswa1.info();
            mahasiswa2.info();

            Console.ReadKey();
        }
        
    }
}
