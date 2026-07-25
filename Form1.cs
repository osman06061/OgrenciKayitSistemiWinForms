using MySqlConnector;
using System.Data;

namespace OgrenciKayitSistemi
{
    public partial class frmAnaSayfa : Form
    {
        private int secilenOgrenciId = 0;
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrencileriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtNumara.Text))
            {
                MessageBox.Show("Ad, soyad ve numara alanları zorunludur.");
                return;
            }

            try
            {
                using MySqlConnection baglanti =
                    Veritabani.BaglantiOlustur();

                baglanti.Open();

                string sorgu = @"INSERT INTO ogrenciler
                                 (ad, soyad, numara, bolum, sinif)
                                 VALUES
                                 (@ad, @soyad, @numara, @bolum, @sinif)";

                using MySqlCommand komut =
                    new MySqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                komut.Parameters.AddWithValue("@numara", txtNumara.Text.Trim());
                komut.Parameters.AddWithValue("@bolum", txtBolum.Text.Trim());
                komut.Parameters.AddWithValue("@sinif", Convert.ToInt32(nudSinif.Value));

                komut.ExecuteNonQuery();

                MessageBox.Show("Öğrenci başarıyla eklendi.");
                OgrencileriListele();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Bu öğrenci numarası daha önce kaydedilmiş.");
                }
                else
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void OgrencileriListele()
        {
            try
            {
                using MySqlConnection baglanti =
                    Veritabani.BaglantiOlustur();

                baglanti.Open();

                string sorgu = @"SELECT
                                    id AS 'ID',
                                    ad AS 'Ad',
                                    soyad AS 'Soyad',
                                    numara AS 'Numara',
                                    bolum AS 'Bölüm',
                                    sinif AS 'Sınıf'
                                 FROM ogrenciler
                                 ORDER BY id DESC";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(sorgu, baglanti);

                DataTable tablo = new DataTable();
                adapter.Fill(tablo);

                dgvOgrenciler.DataSource = tablo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void dgvOgrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow satir = dgvOgrenciler.Rows[e.RowIndex];
                    secilenOgrenciId = Convert.ToInt32(satir.Cells["ID"].Value);

                    txtAd.Text = satir.Cells["Ad"].Value?.ToString();
                    txtSoyad.Text = satir.Cells["Soyad"].Value?.ToString();
                    txtNumara.Text = satir.Cells["Numara"].Value?.ToString();
                    txtBolum.Text = satir.Cells["Bölüm"].Value?.ToString();

                    if (satir.Cells["Sınıf"].Value != null)
                    {
                        nudSinif.Value = Convert.ToDecimal(satir.Cells["Sınıf"].Value);
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            {
                if (secilenOgrenciId == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek öğrenciyi tablodan seçin.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                    string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                    string.IsNullOrWhiteSpace(txtNumara.Text))
                {
                    MessageBox.Show("Ad, soyad ve numara alanları zorunludur.");
                    return;
                }

                try
                {
                    using MySqlConnection baglanti = Veritabani.BaglantiOlustur();
                    baglanti.Open();

                    string sorgu = @"UPDATE ogrenciler
                         SET ad = @ad,
                             soyad = @soyad,
                             numara = @numara,
                             bolum = @bolum,
                             sinif = @sinif
                         WHERE id = @id";

                    using MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                    komut.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                    komut.Parameters.AddWithValue("@numara", txtNumara.Text.Trim());
                    komut.Parameters.AddWithValue("@bolum", txtBolum.Text.Trim());
                    komut.Parameters.AddWithValue("@sinif", Convert.ToInt32(nudSinif.Value));
                    komut.Parameters.AddWithValue("@id", secilenOgrenciId);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Öğrenci başarıyla güncellendi.");
                    OgrencileriListele();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Bu öğrenci numarası başka bir kayıtta kullanılıyor.");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            {
                if (secilenOgrenciId == 0)
                {
                    MessageBox.Show("Lütfen silinecek öğrenciyi seçin.");
                    return;
                }

                DialogResult cevap = MessageBox.Show(
                    "Bu öğrenciyi silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (cevap == DialogResult.No)
                    return;

                try
                {
                    using MySqlConnection baglanti = Veritabani.BaglantiOlustur();
                    baglanti.Open();

                    string sorgu = "DELETE FROM ogrenciler WHERE id=@id";

                    using MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", secilenOgrenciId);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Öğrenci silindi.");

                    secilenOgrenciId = 0;

                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtNumara.Clear();
                    txtBolum.Clear();
                    nudSinif.Value = 1;

                    OgrencileriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
        {
                txtAd.Clear();
                txtSoyad.Clear();
                txtNumara.Clear();
                txtBolum.Clear();


            nudSinif.Value = nudSinif.Minimum;
            secilenOgrenciId = 0;

            dgvOgrenciler.ClearSelection();
            txtAd.Focus();
        }
    }
    }
}
