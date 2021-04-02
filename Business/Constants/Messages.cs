using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Başarıyla Eklendi";
        public static string CarDeleted = "Araba Başarıyla Silindi";
        public static string CarUpdated = "Araba Başarıyla Güncellendi";
        public static string CarListed = "Arabalar Listelendi";
        public static string CarMustReturn = "Araba kiralayabilmek için arabayı teslim ediniz!";

        public static string BrandAdded = "Marka Başarıyla Eklendi";
        public static string BrandDeleted = "Marka Başarıyla Silindi";
        public static string BrandUpdated = "Marka Başarıyla Güncellendi";
        public static string BrandListed = "Markalar Listelendi";

        public static string ColorAdded = "Renk Başarıyla Eklendi";
        public static string ColorDeleted = "Renk Başarıyla Silindi";
        public static string ColorUpdated = "Renk Başarıyla Güncellendi";
        public static string ColorListed = "Renkler Listelendi";

        public static string UserAdded = "Kullanıcı Başarıyla Eklendi";
        public static string UserDeleted = "Kullanıcı Başarıyla Silindi";
        public static string UserUpdated = "Kullanıcı Başarıyla Güncellendi";
        public static string UserRegistered = "Başarıyla Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı!";
        public static string PasswordError = "Şifre Hatalı!";
        public static string SuccessfulLogin = "Başarıyla Giriş Yapıldı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";

        public static string CustomerAdded = "Müşteri Başarıyla Eklendi";
        public static string CustomerDeleted = "Müşteri Başarıyla Silindi";
        public static string CustomerUpdated = "Müşteri Başarıyla Güncellendi";

        public static string RentalAdded = "Kiralama Başarıyla Yapıldı";
        public static string RentalDeleted = "Kiralama Başarıyla İptal Edildi";
        public static string RentalUpdated = "Araba Başarıyla Güncellendi";

        public static string CarImageAdded = "Araba Resmi Başarıyla Eklendi";
        public static string CarImageDeleted = "Araba Resmi Başarıyla Silindi";
        public static string CarImageUpdated = "Araba Resmi Başarıyla Güncellendi";
        public static string CarImageListed = "Araba Resimleri Listelendi";
        public static string LimitOfCarImages = "Araba için en fazla 5 resim eklenebilir";

        public static string AuthorizationDenied = "Yetkiniz Yok!";
        public static string CarNameAndDailyPrice = "Araba ismi en az 2 harfli ve günlük değeri 0 dan büyük olmalı";
    }
}
