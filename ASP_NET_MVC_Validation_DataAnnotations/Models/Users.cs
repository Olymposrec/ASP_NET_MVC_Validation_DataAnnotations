using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC_Validation_DataAnnotations.Models
{
    public class Users
    {
        [DisplayName("Adınız")]
        public string ad { get; set; }

        [DisplayName("Soyadınız")]
        public string soyad { get; set; }

        [DisplayName("Kullanıcı Adınız"), 
            Required(ErrorMessage ="Bu Alan Boş Geçilemez!"), 
            MinLength(8,ErrorMessage ="Minimum {1} Karakter olmalı."), 
            MaxLength(25, ErrorMessage = "Maksimum {1} karakter olmalı.")]
        public string kullaniciadi { get; set; }

        [DisplayName("Şifre"), 
            Required(ErrorMessage = "Bu Alan Boş Geçilemez!"), 
            MinLength(12, ErrorMessage = "Minimum {1} Karakter olmalı."), 
            MaxLength(25, ErrorMessage = "Maksimum {1} karakter olmalı."), 
            DataType(DataType.Password)]
        public string sifre { get; set; }

        [DisplayName("Şifre Onay"), 
            Required(ErrorMessage = "Bu Alan Boş Geçilemez!"), 
            MinLength(12, ErrorMessage = "Minimum {1} Karakter olmalı."), 
            MaxLength(25, ErrorMessage = "Maksimum {1} karakter olmalı."),
            DataType(DataType.Password), 
            Compare(nameof(sifre),ErrorMessage ="Şifreler Eşeleşmiyor!")]
        public string sifre2 { get; set; }

        [DisplayName("E-Posta Adresi"), 
            Required(ErrorMessage = "Bu Alan Boş Geçilemez!"), 
            MinLength(12, ErrorMessage = "Minimum {1} Karakter olmalı."), 
            MaxLength(35, ErrorMessage = "Maksimum {1} karakter olmalı."),
            EmailAddress()]
        public string Eposta { get; set; }

        [DisplayName("E-Posta Adresi Onay"), 
            Required(ErrorMessage = "Bu Alan Boş Geçilemez!"), 
            MinLength(12, ErrorMessage = "Minimum {1} Karakter olmalı."), 
            MaxLength(35,ErrorMessage = "Maksimum {1} karakter olmalı."), 
            DataType(DataType.EmailAddress), 
            Compare(nameof(Eposta), ErrorMessage = "Mailler Eşeleşmiyor!")]
        public string Eposta2 { get; set; }

        


    }
}