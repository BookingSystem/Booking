using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingTickets {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        String[] theaterAddresses = {"ул. Шереметьевская, д. 20, ТЦ \"Капитолий Марьина Роща\", 3-й этаж",
                                  "ул. Земляной вал, 33 (ТРК \"АТРИУМ\"",
                                    "Алтуфьевское ш., д. 70, корп. 1, ТЦ \"Маркос-Молл»\"",
                                    "пр-т Вернадского, д. 14"};

        private void Form1_Load(object sender, EventArgs e) {
            comboBox1.DataSource = new String[] {"Фильмы", "Кинотеатры"};
            listBox1.DataSource = theaterAddresses;
            updateImageListOfMovies();
        }

        private void listView1_Click(object sender, EventArgs e) {
            MessageBox.Show("index: " + listView1.SelectedIndices[0].ToString() + "\nTitle:" +
                listView1.Items[listView1.SelectedIndices[0]].Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
//            MessageBox.Show("combo index: " + comboBox1.SelectedIndex);
            if (comboBox1.SelectedIndex == 0) {
                listView1.Visible = true;
                listBox1.Visible = false;
            } else {
                listView1.Visible = false;
                listBox1.Visible = true;
            }
        }

        private void clearImageListOfMovies() {
            imageList1.Images.Clear();
            listView1.Clear();
        }

        private void updateImageListOfMovies() {

            imageList1.Images.Add("Zveropolis", Properties.Resources.Zveropolis);
            imageList1.Images.Add("Holo", Properties.Resources.Holo);
            imageList1.Images.Add("Batman", Properties.Resources.Batman);
            imageList1.Images.Add("Angry birds", Properties.Resources.Birds);
            imageList1.Images.Add("People X", Properties.Resources.X);
            imageList1.Images.Add("Warcraft", Properties.Resources.Warcraft);
            imageList1.ImageSize = new Size(150, 217);

            listView1.View = View.LargeIcon;
            listView1.LargeImageList = this.imageList1;

            int j = 0;
            foreach (var el in imageList1.Images.Keys) {
                listView1.Items.Add(new ListViewItem { ImageIndex = j++, Text = el });
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
