using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using Library.Library.Business.Abstract;
using Library.Library.Business.DependencyResolvers.Ninject;
using Library.Library.WinFormUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Library.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _statusService = InstanceFactory.GetInstance<IStatusService>();
        }
        private IBookService _bookService;
        private IStatusService _statusService;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        TumKitaplar tumKitaplar;
        private void btn_Click(object sender, EventArgs e)
        {
            if(tumKitaplar==null)
            {
                tumKitaplar = new TumKitaplar();
                tumKitaplar.MdiParent = this;
                tumKitaplar.Show();
            }
        }
        OkunacakKitaplar okunacakKitaplar;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(okunacakKitaplar == null)
            {
                okunacakKitaplar = new OkunacakKitaplar();
                okunacakKitaplar.MdiParent = this;
                okunacakKitaplar.Show();
            }
        }
        OkunmusKitaplar okunmusKitaplar;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(okunmusKitaplar == null)
            {
                okunmusKitaplar = new OkunmusKitaplar();
                okunmusKitaplar.MdiParent = this;
                okunmusKitaplar.Show();
            }
        }
        ALinacakKitaplar alinacakKitaplar;
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if(alinacakKitaplar == null)
            {
                alinacakKitaplar = new ALinacakKitaplar();
                alinacakKitaplar.MdiParent = this;
                alinacakKitaplar.Show();
            }
        }
        Dergiler dergiler;
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if(dergiler == null)
            {
                dergiler = new Dergiler();
                dergiler.MdiParent = this;
                dergiler.Show();
            }
        }
    }
}