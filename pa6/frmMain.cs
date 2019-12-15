using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa6
{
    public partial class frmMain : Form
    {        
        string cwid;
        List<Book> myBook;
        public frmMain(string tempCwid)
        {
            this.cwid = tempCwid;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadList();
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoadList()
        {
            myBook = BookFile.GetAllBooks(cwid);
            lstBooks.DataSource = myBook;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Author_Click(object sender, EventArgs e)
        {

        }

        private void LstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book myBook = (Book)lstBooks.SelectedItem;
            titleboxData.Text = myBook.title;
            authorboxData.Text = myBook.author;
            genreboxData.Text = myBook.genre;
            copiesboxData.Text = myBook.copies.ToString();
            lengthboxData.Text = myBook.length.ToString();

            try
            {
                picBox.Load(myBook.cover);
            }
            catch
            {

            }
        }
    }
}
