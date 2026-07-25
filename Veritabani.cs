using MySqlConnector;

namespace OgrenciKayitSistemi
{
    public static class Veritabani
    {
        private static string baglantiMetni =
            "Server=127.0.0.1;Port=3306;Database=ogrenci_sistemi;User ID=root;Password=1910;";

        public static MySqlConnection BaglantiOlustur()
        {
            return new MySqlConnection(baglantiMetni);
        }
    }
}