using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelModelLess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MusteriKayitFormu musteriKayit = new MusteriKayitFormu();
            musteriKayit.Show();
            // Yeni form oluşturmak için kullanılır birden fazla kez tıklanabilir veya kullanıcı form açık iken uygulamanın diğer menülerine erişebilir.
        }

        private void btnGosterPopUp_Click(object sender, EventArgs e)
        {
            MusteriKayitFormu musteriKayit = new MusteriKayitFormu();
            musteriKayit.ShowDialog();
            // Kullanıcı bu şekilde form açtığı zamqan ilgili form kapanmadan herhangi bir başka işlem yapamaz.. 
        }
    }
}
