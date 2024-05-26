using Library.Library.Business.Abstract;
using Library.Library.Business.DependencyResolvers.Ninject;
using Library.Library.Entities.Concrete;
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
    public partial class OkunmusKitaplar : Form
    {
        public OkunmusKitaplar()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
        }
        private IBookService _bookService;

        private void LoadBook()
        {
            dataGridView1.DataSource = _bookService.GetBooksByStatus(1);
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
        }
        private void OkunmusKitaplar_Load(object sender, EventArgs e)
        {
            LoadBook();
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
            rtbNotlar.Text = row.Cells[7].Value.ToString();
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
                    StatusID = 1,
                    Notes = rtbNotlar.Text,
                });
                MessageBox.Show("Kitap Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBook();
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
                    StatusID = 1,
                    Notes = rtbNotlar.Text
                });
                MessageBox.Show("Kitap Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBook();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Delete(new Book
                {
                    BookID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Kitap Sİlindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
