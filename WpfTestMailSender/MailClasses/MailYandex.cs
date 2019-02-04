using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender
{
    public static class MailYandex
    {
        public static string SMTP
        {
            get => "smtp.yandex.ru";
        }

        public static int PORT
        {
            get => 25;
        }
    }
}
