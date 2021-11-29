using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarNameAndPriceValid="Araba ve Günlük fiyat Bilgisi Eksik";
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdate = "Araba Güncellendi";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka Silindi.";
        public static string BrandUpdate = "Marka Güncellendi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk Silindi.";
        public static string ColorUpdated = "Renk Güncellendi.";

        public static string FirstNameLastNameInvalid = "İsim veya Soyisim Girilmemiş";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserNotDeleted = "HATA. Kullanıcı Silinemedi";
        public static string UsersListed = "Kullanıcılar Listelendi...";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string RentalAdded = "Kiralama Bilgisi Eklendi";
        public static string RentalAddedError = "Araç teslim edilmediği için tekrar kiraya verilemez";
        public static string RentalDeleted = "Kiralama Bilgisi Silindi";
        public static string RentalListed = "Kiralama Bilgileri Listelendi...";
        public static string RentalUpdated = "Kiralama Bilgisi Güncellendi";
        public static string RentalUpdateReturnDateError = "Araç Teslim Alınmamış";
        public static string RentalUpdateReturnDate = "Araç Teslim Alındı";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerNotAdded = "HATA. Müşteri Eklenemedi";
        public static string CustomerDeleted = "Müşteri Silindi" ;
        public static string CustomerNotDeleted = "HATA. Müşteri Silinemedi" ;
        public static string CustomersListed = "Müşteriler Listelendi...";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string Added = "Resim Eklendi.";
        public static string Imagefull = "5 resimden fazla yükleyemezsiniz.";
        public static string NotFound = "Resim bulunamadı.";
        public static string Update = "Resim başarıyla güncellendi";
        public static string Deleted = "Resim başarıyla silindi.";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string TokenCreate = "Token Oluşturuldu.";
        public static string UserExists = "Kullanıcı mevcut.";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordWrong = "Parola Yanlış";
        public static string SuccessLogin = "Giriş Başarılı";
        public static string UserCreated = "Kayıt Olundu.";
    }
}
