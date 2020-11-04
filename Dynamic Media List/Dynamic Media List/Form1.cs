using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Media_List
{
    public partial class formMediaList : Form
    {
        private List<Media> allMedia = new List<Media>();

        public formMediaList()
        {
            InitializeComponent();
        }

        //Method that hides Duration when TV Show is selected, and hides Episodes when Movie is selected.
        private void RestrictInput()
        {
            lblDuration.Visible = btnMovie.Checked;
            txtDuration.Visible = btnMovie.Checked;
            lblEpisodes.Visible = !btnMovie.Checked;
            txtEpisodes.Visible = !btnMovie.Checked;
        }
        private void btnMovie_CheckedChanged(object sender, EventArgs e)
        {
            RestrictInput();
        }

        //Method that fills the list using the object list allMedia as reference
        private void FillList()
        {
            lstTitles.Items.Clear();
            foreach (Media newMedia in allMedia)
            {
                lstTitles.Items.Add(newMedia.getInfo());
            }
        }

        //Method that empties the textboxes after an entry has been made
        private void LineClear()
        {
            txtDuration.Text = "";
            txtEpisodes.Text = "";
            txtTitle.Text = "";
            txtYear.Text = "";
        }

        private void btnShow_CheckedChanged(object sender, EventArgs e)
        {
            RestrictInput();
        }

        private void formMediaList_Load(object sender, EventArgs e)
        {
            RestrictInput();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Media newMedia;
            if (btnMovie.Checked)
            {
                newMedia = new Movie(txtTitle.Text, int.Parse(txtYear.Text), int.Parse(txtDuration.Text));
            }
            else
            {
                newMedia = new TV_Show(txtTitle.Text, int.Parse(txtYear.Text), int.Parse(txtEpisodes.Text));
            }
            allMedia.Add(newMedia);
            FillList();
            LineClear();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if(lstTitles.SelectedIndex != -1)
            {
                lstTitles.Items.RemoveAt(lstTitles.SelectedIndex);
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete all entries in the list, are you sure?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                lstTitles.Items.Clear();
            }
        }


    }
}
