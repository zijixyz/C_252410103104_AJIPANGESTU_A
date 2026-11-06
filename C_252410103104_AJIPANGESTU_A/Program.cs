//namespace Soal1
//{
//    class Sekolah
//    {
//        public string idSekolah;
//        public string namaSekolah;
//        public int jumlahPaketDiterima;

//        public Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
//        {
//            this.idSekolah = idSekolah;
//            this.namaSekolah = namaSekolah;
//            this.jumlahPaketDiterima = jumlahPaketDiterima;
//        }

//        public void TampilInfo()
//        {
//            Console.WriteLine("=====Nama Sekolah=====");
//            Console.WriteLine($"ID Sekolah: {idSekolah}");
//            Console.WriteLine($"Nama Sekolah: {namaSekolah}");
//            Console.WriteLine($"Jumlah MBG Diterima: {jumlahPaketDiterima}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Sekolah sekolah1 = new Sekolah("001", "SMA Jaya 1", 250);
//            sekolah1.TampilInfo();
//            Sekolah sekolah2 = new Sekolah("002", "SMA Jaya 2", 275);
//            sekolah2.TampilInfo();
//        }
//    }
//}

//=============================================================================================

//namespace Soal2
//{
//    class PaketMBG
//    {
//        private string idPaket { get; set; }
//        private string namaPaket { get; set; }
//        private int stokDapur
//        {
//            get
//            {
//                return stokDapur;
//            }
//            set
//            {
//                if (stokDapur <= 0)
//                {
//                    Console.WriteLine("Nilai Stok Dapur tidak boleh bernilai negatif.");
//                }
//            }
//        }


//        public void KurangiStok(int jumlah)
//        {
//            if (jumlah >= stokDapur)
//            {
//                Console.WriteLine("Jumlah pengurangan stok melebihi stok");
//            }
//            else
//            {
//                stokDapur -= jumlah;
//            }
//        }

//        public PaketMBG(string idPaket, string namaPaket, int stokDapur)
//        {
//            this.idPaket = idPaket;
//            this.namaPaket = namaPaket;
//            this.stokDapur = stokDapur;
//        }

//        public void TampilInfo()
//        {
//            Console.WriteLine("=====Nama Paket MBG=====");
//            Console.WriteLine($"ID Paket MBG: {idPaket}");
//            Console.WriteLine($"Nama Sekolah: {namaPaket}");
//            Console.WriteLine($"Jumlah MBG Diterima: {stokDapur}");
//        }
//    }
//}

//=============================================================================================

//namespace Soal3
//{
//    class PaketMBG
//    {
//        public string idPaket;
//        public string namaPaket;
//        public int stokDapur;

//        public PaketMBG(string idPaket, string namaPaket, int stokDapur)
//        {
//            this.idPaket = idPaket;
//            this.namaPaket = namaPaket;
//            this.stokDapur = stokDapur;
//        }

//        public void TampilInfo()
//        {
//            Console.WriteLine("=====Nama Paket MBG=====");
//            Console.WriteLine($"ID Paket MBG: {idPaket}");
//            Console.WriteLine($"Nama Sekolah: {namaPaket}");
//            Console.WriteLine($"Jumlah MBG Diterima: {stokDapur}");
//        }
//    }

//    class PaketReguler : PaketMBG
//    {
//        string isiPaket = "Nasi, Ayam, Sayur, dan Buah.";
//        int harga = 15000;

//        public PaketReguler(string idPaket, string namaPaket, int stokDapur, string isiPaket, int harga) : base(idPaket, namaPaket, stokDapur)
//        {
//            this.isiPaket = isiPaket;
//            this.harga = harga;
//        }
//    }

//    class PaketKhusus : PaketMBG
//    {
//        string isiPaket;
//        int harga = 20000;
//        string jenisDiet;

//        public PaketKhusus(string idPaket, string namaPaket, int stokDapur, string isiPaket, int harga, string jenisDiet) : base(idPaket, namaPaket, stokDapur)
//        {
//            this.isiPaket = isiPaket;
//            this.harga = harga;
//            this.jenisDiet = jenisDiet;
//        }
//    }
//}

//=============================================================================================

//namespace Soal4
//{
//    class PaketMBG
//    {
//        public string idPaket;
//        public string namaPaket;
//        public int stokDapur;

//        public PaketMBG(string idPaket, string namaPaket, int stokDapur)
//        {
//            this.idPaket = idPaket;
//            this.namaPaket = namaPaket;
//            this.stokDapur = stokDapur;
//        }

//        public void TampilInfo()
//        {
//            Console.WriteLine("=====Nama Paket MBG=====");
//            Console.WriteLine($"ID Paket MBG: {idPaket}");
//            Console.WriteLine($"Nama Sekolah: {namaPaket}");
//            Console.WriteLine($"Jumlah MBG Diterima: {stokDapur}");
//        }

//        public virtual void HitungBiaya(int jumlah) { }
//    }

//    class PaketReguler : PaketMBG
//    {
//        string isiPaket = "Nasi, Ayam, Sayur, dan Buah.";
//        int harga = 15000;

//        public PaketReguler(string idPaket, string namaPaket, int stokDapur, string isiPaket, int harga) : base(idPaket, namaPaket, stokDapur)
//        {
//            this.isiPaket = isiPaket;
//            this.harga = harga;
//        }

//        public override void HitungBiaya(int jumlah)
//        {
//            jumlah *= harga;
//            Console.WriteLine($"Harga total PaketReguler adalah {jumlah}");
//        }
//    }

//    class PaketKhusus : PaketMBG
//    {
//        string isiPaket;
//        int harga = 20000;
//        string jenisDiet;

//        public PaketKhusus(string idPaket, string namaPaket, int stokDapur, string isiPaket, int harga, string jenisDiet) : base(idPaket, namaPaket, stokDapur)
//        {
//            this.isiPaket = isiPaket;
//            this.harga = harga;
//            this.jenisDiet = jenisDiet;
//        }

//        public override void HitungBiaya(int jumlah)
//        {
//            jumlah *= harga;
//            Console.WriteLine($"Harga total PaketKhusus adalah {jumlah}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            PaketMBG pktReguler1 = new PaketReguler("001", "Reguler", 255, "Nasi, Ayam, Sayur, dan Buah.", 15000);
//            pktReguler1.HitungBiaya(2);

//            PaketMBG pktKhusus1 = new PaketKhusus("002", "Khusus", 255, "", 20000, "RendahGula");
//            pktKhusus1.HitungBiaya(3);
//        }
//    }
//}

//=============================================================================================

//namespace Soal5
//{
//    class
//}

//=============================================================================================

//namespace Soal6
//{
//    class
//}

//=============================================================================================

//namespace SoalOpsional
//{
//    class PengelolaMBG
//    {
//        List 
//    }
//}

//Sebutkan dan jelaskan hubungan antara class PengelolaMBG dan class Sekolah, 
//apakah termasuk association, aggregation, atau composition. Berikan penjelasan 
//melalui komentar di dalam kode program.

//Jawaban: Termasuk association karena pengelolambg dan sekolah berdiri sendiri