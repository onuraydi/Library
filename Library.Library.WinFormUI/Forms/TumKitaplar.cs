using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;
using Library.Library.Business.Abstract;
using Library.Library.Business.DependencyResolvers.Ninject;
using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Library.WinFormUI
{
    public partial class TumKitaplar : Form
    {
        public TumKitaplar()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _statusService = InstanceFactory.GetInstance<IStatusService>();
        }
        private IBookService _bookService;
        private IStatusService _statusService;

        private void LoadBooks()
        {
                    
            dataGridView1.DataSource = _bookService.GetAll();
        }
        private void LoadStatus()
        {
            cbxDurum.DataSource = _statusService.GetAll();
            cbxDurum.DisplayMember = "StatusName";
            cbxDurum.ValueMember = "StatusID";

        }

        private void Temizle()
        {
            txedID.Text = "";
            txedKitapAdi.Text = "";
            txedYazar.Text = "";
            txedSayfa.Text = "";
            txedTur.Text = "";
            txedYayinEvi.Text = "";
            rtbNotlar.Text = "";
            cbxDurum.Text = null;
        }
        private void TumKitaplar_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadStatus();
            Temizle();      
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Add(new Book
                {
                    BookTitle = txedKitapAdi.Text,
                    Author = txedYazar.Text,
                    Category = txedTur.Text,
                    Publisher = txedYayinEvi.Text,
                    NumberOfPages = Convert.ToInt32(txedSayfa.Text),
                    StatusID = Convert.ToInt32(cbxDurum.SelectedValue),
                    Notes = rtbNotlar.Text,
                });
                MessageBox.Show("Kitap Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks();
            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message);
            }
        }
    
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Update(new Book
                {
                    BookID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    BookTitle = txedKitapAdi.Text,
                    Author = txedYazar.Text,
                    Category = txedTur.Text,
                    Publisher = txedYayinEvi.Text,
                    NumberOfPages = Convert.ToInt32(txedSayfa.Text),
                    StatusID = Convert.ToInt32(cbxDurum.SelectedValue),
                    Notes= rtbNotlar.Text
                });
                MessageBox.Show("Kitap Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            txedID.Text = row.Cells[0].Value.ToString();
            txedKitapAdi.Text = row.Cells[1].Value.ToString();
            txedYazar.Text = row.Cells[2].Value.ToString();
            txedTur.Text = row.Cells[3].Value.ToString();
            txedYayinEvi.Text = row.Cells[4].Value.ToString();
            txedSayfa.Text = row.Cells[5].Value.ToString();
            cbxDurum.SelectedValue = row.Cells[7].Value;
            rtbNotlar.Text = row.Cells[6].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Delete(new Book
                {
                    BookID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                });
                MessageBox.Show("Kitap Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle(); 
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
