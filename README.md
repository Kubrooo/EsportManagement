# Esport Management

## 📌 Deskripsi
Esport Management adalah aplikasi berbasis Windows Forms yang digunakan untuk mengelola turnamen esports. Aplikasi ini menyediakan fitur untuk mengelola tim, pertandingan, serta menampilkan statistik turnamen dan tim secara real-time.

## ✨ Fitur Utama
- **Manajemen Turnamen**: Tambah, ubah, dan lihat daftar turnamen yang tersedia.
- **Manajemen Pertandingan**: Tambahkan hasil pertandingan hanya jika turnamen sudah dimulai.
- **Manajemen Tim**: Kelola data tim yang berpartisipasi dalam turnamen.
- **Statistik Turnamen**: Menampilkan data turnamen, tim peserta, pemenang, dan total hadiah.
- **Statistik Tim**: Menampilkan jumlah pertandingan, kemenangan, kekalahan, dan total poin tim.

## 🛠 Teknologi yang Digunakan
- **C# .NET Framework** - Backend dan UI menggunakan Windows Forms
- **Entity Framework** - ORM untuk mengelola database
- **SQL Server** - Database untuk menyimpan data turnamen dan tim

## 📂 Struktur Proyek
```
📂 EsportManagement
 ├── 📂 Forms
 │   ├── StatisticForm.cs   # Menampilkan statistik turnamen dan tim
 │   ├── MainForm.cs        # Halaman utama aplikasi
 │   ├── TournamentForm.cs  # Halaman untuk mengelola turnamen
 │   ├── MatchForm.cs       # Halaman untuk mengelola pertandingan
 │   ├── TeamForm.cs        # Halaman untuk mengelola tim
 │
 ├── 📂 Models
 │   ├── Tournament.cs      # Model untuk turnamen
 │   ├── Pertandingan.cs    # Model untuk pertandingan
 │   ├── Tim.cs             # Model untuk tim
 │
 ├── 📂 Data
 │   ├── DataContext.cs     # Koneksi ke database dan konfigurasi Entity Framework
 │
 ├── Program.cs             # Entry point aplikasi
 ├── README.md              # Dokumentasi proyek
```

## 🚀 Instalasi dan Penggunaan
### **1. Clone Repository**
```sh
git clone https://github.com/Kubrooo/EsportManagement.git
cd EsportManagement
```

### **2. Konfigurasi Database**
- Pastikan **SQL Server** sudah terinstall.
- Update koneksi database di `DataContext.cs`.
- Jalankan migrasi database jika menggunakan Entity Framework.

### **3. Jalankan Aplikasi**
Buka proyek di Visual Studio, lalu tekan **F5** atau klik **Start**.

## 🛡️ Validasi Penting
✅ **Pertandingan tidak bisa ditambahkan sebelum turnamen dimulai**
✅ **Total poin tim diperbarui berdasarkan hasil pertandingan**
✅ **Hanya pertandingan dari turnamen yang sedang berlangsung yang dapat ditambahkan**

---
Made with ❤️ by [Kubrooo]

