using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для WpfMailSender.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
        }

        private void BtnSendMail_Click( object sender, RoutedEventArgs e )
        {
            EmailSendServiceClass.GetMailProperties( tbMailTopic.Text, tbMailText.Text, tbGetter.Text, tbLogin.Text,
                    pbPassword.SecurePassword );
            try
            {
                EmailSendServiceClass.SendMail();
                SendEndWindow endWindow = new SendEndWindow( "Письмо отправлено" );
                endWindow.ShowDialog();
            }
            catch ( Exception exc )
            {
                SendEndWindow endWindow = new SendEndWindow("Письмо не отправлено");
                endWindow.ShowDialog();
            }
        }
    }
}