using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_object.Text))
            {
                txt_object.BackColor = Color.White;
                Type T = Type.GetType(txt_object.Text);

                if (T != null)
                {
                    CTORS(T);
                    PROPS(T);
                    METHS(T);
                }

                else
                {
                    MessageBox.Show($"{txt_object.Text} sınıfı bulanmadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Lütfen bilgi almak istediğiniz sınıfın tam adını giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_object.BackColor = Color.Gray;
            }
        }

        private void CTORS(Type T)
        {
            lst_ctors.Items.Clear();

            ConstructorInfo[] RV = T.GetConstructors();

            foreach (var item in RV)
            {
                lst_ctors.Items.Add(item.ToString());
            }
        }

        private void PROPS(Type T)
        {
            lst_props.Items.Clear();

            PropertyInfo[] RV = T.GetProperties();

            foreach (var item in RV)
            {
                lst_props.Items.Add(item.Name);
            }
        }

        private void METHS(Type T)
        {
            lst_meths.Items.Clear();

            MethodInfo[] RV = T.GetMethods();

            foreach (var item in RV)
            {
                lst_meths.Items.Add($"{item.ReturnType.Name} {item.Name}");
            }
        }
    }
}
