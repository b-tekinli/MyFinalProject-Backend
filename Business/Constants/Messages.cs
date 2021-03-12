using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductDeleted = "Ürün silindi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "1 kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string MaintenanceTime = "Sistem bakımda...";
        public static string AuthorizationDenied = "Bu işlemi gerçekleştirmek için yetkiniz bulunmamaktadır.";

        public static string PasswordError = "Hatalı parola lütfen tekrar deneyiniz...";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";
    }
}