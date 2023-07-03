using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Sistem bakımda";
        public static string MaintenanceTime = "Ürünler listelendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string UserAdded = "Kişi eklendi";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "kayıt olundu";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "hatalı şifre";
        public static string SuccessfulLogin = "giriş başarılı";
        public static string UserAlreadyExists = "kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "token oluşturuldu";
    }
}
