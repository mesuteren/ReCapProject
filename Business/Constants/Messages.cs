using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string RentalAdded = "Kiralama kaydı başarı ile oluşturuldu";
        public static string RentalInvalid = "Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalUpdatedReturnDate = "Araç Teslim Alındı.";
        public static string RentalUpdatedReturnDateError = "Araç Zaten Teslim Alınmış.";
        public static string DailyPriceInvalid = "Günlük fiyat 0 olamaz";
    }
}
