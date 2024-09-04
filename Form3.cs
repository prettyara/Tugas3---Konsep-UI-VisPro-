using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3___Konsep_UI__VisPro_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            // Ambil data dari form
            string namaLengkap = labelNamaLengkap.Text;
            string namaPanggilan = labelNamaPanggilan.Text;
            string jenisKelamin = labelJenisKelamin.Text;
            string tempatLahir = labelTempatLahir.Text;
            string tanggalLahir = labelTanggalLahir.Text;
            string alamat = labelAlamat.Text;
            string kecamatan = labelKecamatan.Text;
            string kabupaten = labelKabupaten.Text;
            string provinsi = labelProvinsi.Text;
            string kodePos = labelKodePos.Text;
            string noTelp = labelNoTelp.Text;
            string email = labelEmail.Text;
            string universitas = labelUniversitas.Text;
            string fakultas = labelFakultas.Text;
            string jurusan = labelJurusan.Text;
            string status = labelStatus.Text;
            string agama = labelAgama.Text;
            string hobi = labelHobi.Text;
            string citaCita = labelCitaCita.Text;
            string kewarganegaraan = labelKewarganegaraan.Text;

            // Logika untuk menyimpan data (misalnya ke file, database, dll.)
            MessageBox.Show("Data berhasil disimpan!\n\n" +
                            $"Nama Lengkap: {namaLengkap}\n" +
                            $"Nama Panggilan: {namaPanggilan}\n" +
                            $"Jenis Kelamin: {jenisKelamin}\n" +
                            $"Tempat Lahir: {tempatLahir}\n" +
                            $"Tanggal Lahir: {tanggalLahir}\n" +
                            $"Alamat: {alamat}\n" +
                            $"Kecamatan: {kecamatan}\n" +
                            $"Kabupaten: {kabupaten}\n" +
                            $"Provinsi: {provinsi}\n" +
                            $"Kode Pos: {kodePos}\n" +
                            $"No Telp: {noTelp}\n" +
                            $"Email: {email}\n" +
                            $"Univesitas: {universitas}\n" +
                            $"Fakultas: {fakultas}\n" +
                            $"Jurusan: {jurusan}\n" +
                            $"Status: {status}\n" +
                            $"Agama: {agama}\n" +
                            $"Hobi: {hobi}\n" +
                            $"Cita-cita: {citaCita}\n" +
                            $"Kewarganegaraan: {kewarganegaraan}");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Ganti Form4 dengan form yang ingin Anda buka
            form4.Show();
            this.Hide(); // Menyembunyikan Form3
        }
    }
}
