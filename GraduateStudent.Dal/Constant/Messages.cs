using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Dal.Constant
{
   public static class Messages
    {
        public static string NoRecord = "Sistemde böyle bir öğrenci numarası bulunmamaktadır. ";
        public static string NotYetGraduated = "Henüz mezun değilsiniz, Sisteme kayıt olamazsınız";
        public static string Graduated = "Mezunsunuz,Sisteme kayıt olabilirsiniz";
        public static string HasRecord = "Daha önce sisteme kayıt olmuşsunuz";
        public static string SuccessRecord = "Sisteme başarıyla kayıt oldunuz,Giriş yapabilirsiniz";
        public static string NotMatchInformation = "Bilgileriniz uyuşmuyor";
    }
}
