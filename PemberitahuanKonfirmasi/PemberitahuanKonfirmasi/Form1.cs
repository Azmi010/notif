using Npgsql;
using System.Data;
using System.Data.Common;
using System.Text;
using Timer = System.Threading.Timer;

namespace PemberitahuanKonfirmasi
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recpnl1;
        private Rectangle recpnl2;
        private Rectangle recpnlnt;
        private Rectangle reclbl1;
        private Rectangle reclbl2;
        private Rectangle reclbl3;
        private Rectangle reclbl4;
        private Rectangle reclbl5;
        private Rectangle recpnlout;
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recpnl1 = new Rectangle(panel1.Location, panel1.Size);
            recpnlnt = new Rectangle(PanelNotif.Location, PanelNotif.Size);
            recpnl2 = new Rectangle(panel2.Location, panel2.Size);
            reclbl1 = new Rectangle(label1.Location, label1.Size);
            reclbl2 = new Rectangle(label2.Location, label2.Size);
            reclbl3 = new Rectangle(label3.Location, label3.Size);
            reclbl4 = new Rectangle(label4.Location, label4.Size);
            reclbl5 = new Rectangle(label5.Location, label5.Size);
            recpnlout = new Rectangle(panelout.Location, panelout.Size);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BacaData();
        }
        private void BacaData()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=sbd";
            string sql = "SELECT * FROM notifikasi_admin ORDER BY id_notifikasi_admin DESC";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        NpgsqlDataReader dr = command.ExecuteReader();
                        int labelIndex = 0;
                        //StringBuilder sb = new StringBuilder();
                        while (dr.Read() && labelIndex < 100)
                        {
                            string rowdata = $"{dr.GetInt32(0)}\n{dr.GetInt32(1)}\n{dr.GetInt32(2)}\n{dr.GetInt32(3)}\n{dr.GetInt32(4)}";
                            if (labelIndex >= panelLabels.Controls.Count)
                            {
                                // Membuat label baru
                                Label newLabel = new Label();
                                newLabel.AutoSize = true;
                                newLabel.Location = new Point(0, (labelIndex * 150)); // Atur posisi label sesuai dengan kebutuhan
                                newLabel.Font = new Font("Montserrat", 12, FontStyle.Regular);
                                panelLabels.Controls.Add(newLabel);
                            }
                            // Mengambil nilai kolom dari dataReader
                            //sb.AppendLine(rowdata);

                            // Menetapkan nilai ke properti Text dari label yang sesuai
                            Label label = (Label)panelLabels.Controls[labelIndex];
                            label.Text = rowdata;

                            labelIndex++;
                        }

                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        //private Label GetLabelByIndex(int index)
        //{
        //    switch (index)
        //    {
        //        case 0:
        //            return label7;
        //        case 1:
        //            return label8;
        //        case 2:
        //            return label9;
        //        case 3:
        //            return label10;
        //        case 4:
        //            return label11;
        //        default:
        //            throw new ArgumentOutOfRangeException("index", "Invalid label index.");
        //    }
        //}
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpnl1);
            resize_Control(PanelNotif, recpnlnt);
            resize_Control(panel2, recpnl2);
            resize_Control(label1, reclbl1);
            resize_Control(label2, reclbl2);
            resize_Control(label3, reclbl3);
            resize_Control(label4, reclbl4);
            resize_Control(label5, reclbl5);
            resize_Control(panelout, recpnlout);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private bool notifikasi = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (notifikasi)
            {
                panelLabels.Hide();
                notifikasi = false;
            }
            else
            {
                panelLabels.Show();
                notifikasi = true;
            }


        }
        private void hidenotif()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
        }
        private void Form1_TextChanged(object sender, EventArgs e)
        {
            float fontSize = (float)(Width + Height) / 100; // Sesuaikan rumus ini sesuai kebutuhan Anda

            // Atur ukuran font pada kontrol yang diinginkan
            label1.Font = new Font(label1.Font.FontFamily, fontSize, label1.Font.Style);
            //button1.Font = new Font(button1.Font.FontFamily, fontSize, button1.Font.Style);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void PanelNotif_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool pictureprofil = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureprofil)
            {
                panelout.Hide();
                pictureprofil = false;
            }
            else
            {
                panelout.Show();
                Form2 profil = new Form2();
                profil.TopLevel = false;
                profil.FormBorderStyle = FormBorderStyle.None;
                this.panelout.Controls.Add(profil);
                profil.Show();
                pictureprofil = true;
            }
            hidenotif();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}