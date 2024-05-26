using Library.Library.Business.Abstract;
using Library.Library.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Library.Business.DependencyResolvers.Ninject;
using Library.Library.Entities.Concrete;

namespace Library.Library.WinFormUI.Forms
{
    public partial class Dergiler : Form
    {
        public Dergiler()
        {
            InitializeComponent();
            _magazineService = InstanceFactory.GetInstance<IMagazineService>();
        }
        private IMagazineService _magazineService;

        private void loadMagazine()
        {
            dataGridView1.DataSource = _magazineService.GetAll();
        }
        private void Temizle()
        {
            txedID.Text = "";
            txedDergiAdi.Text = "";
            txedTur.Text = "";
            txedSayi.Text = "";
            txedSayfa.Text = "";
            rtbNotlar.Text = "";
        }
        private void Dergiler_Load(object sender, EventArgs e)
        {
            loadMagazine();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _magazineService.Add(new Magazine
                {
                    MagazineName = txedDergiAdi.Text,
                    MagazineCategory = txedTur.Text,
                    Issue = txedSayi.Text,
                    NumberOfPages = Convert.ToInt32(txedSayfa.Text),
                    Notes = rtbNotlar.Text
                });
                MessageBox.Show("Dergi sisteme eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMagazine();
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
                _magazineService.Update(new Magazine
                {
                    MagazineID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    MagazineName = txedDergiAdi.Text,
                    MagazineCategory = txedTur.Text,
                    Issue = txedSayi.Text,
                    NumberOfPages = Convert.ToInt32(txedSayfa.Text),
                    Notes = rtbNotlar.Text
                });
                MessageBox.Show("Dergi Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMagazine();
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
                _magazineService.Delete(new Magazine
                {
                    MagazineID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                });
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
            txedDergiAdi.Text = row.Cells[1].Value.ToString();
            txedTur.Text = row.Cells[2].Value.ToString();
            txedSayi.Text = row.Cells[3].Value.ToString();
            txedSayfa.Text = row.Cells[4].Value.ToString();
            rtbNotlar.Text = row.Cells[5].Value.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
