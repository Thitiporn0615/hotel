using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

       
        //Method ออกจากโปรแกรม
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Method นำหน้า guest มาไว้หน้าสุด
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            guest1.BringToFront();
        }
        //Method นำหน้า roomform มาไว้หน้าสุด
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            roomform1.BringToFront();
        }

        //Method นำหน้า user มาไว้หน้าสุด
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            user1.BringToFront();
        }
        //Method   กลับสู่หน้า Login
        private void bunifuFlatButton6_Click(object sender, EventArgs e)//เมื่อกดปุ้มกดออกจากระบบ
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
        //Method นำหน้า reservations มาไว้หน้าสุด
        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            reservations1.BringToFront();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void reservations1_Load(object sender, EventArgs e)
        {

        }
    }
}