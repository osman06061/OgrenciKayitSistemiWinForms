# Öğrenci Kayıt Sistemi

C# Windows Forms ve MySQL kullanılarak geliştirilmiş masaüstü öğrenci kayıt uygulamasıdır.

## Özellikler

- Öğrenci ekleme
- Öğrenci listeleme
- Öğrenci güncelleme
- Öğrenci silme
- Ad, soyad, numara ve bölüme göre arama
- DataGridView üzerinde kayıt görüntüleme
- MySQL veritabanı bağlantısı

## Kullanılan Teknolojiler

- C#
- Windows Forms
- MySQL
- MySqlConnector
- Visual Studio 2022

## Veritabanı Tablosu

```sql
CREATE TABLE ogrenciler(
    id INT AUTO_INCREMENT PRIMARY KEY,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    numara VARCHAR(20) NOT NULL UNIQUE,
    bolum VARCHAR(100),
    sinif INT
);
```

## Proje Görünümü

![Öğrenci Kayıt Sistemi](ogrenci-kayit-sistemi.png)


Uygulama üzerinden öğrenci bilgileri eklenebilir, güncellenebilir, silinebilir ve aranabilir.

## Geliştirici

Osman Ülger
