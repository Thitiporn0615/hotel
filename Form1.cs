using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hotel_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ออกจากโปรแกรม
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //เมื่อกดปุ่ม login
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            connect conn = new connect();//เชื่อมต่อกับ Database
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(); //SqlDataAdapter ใช้ในการดึงข้อมูลมาเก็บลง DataTable และทำการ Update ข้อมูล ที่อยู่ใน DataTable กลับสูDatabase
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `user` WHERE `username`=@usn AND `password`=@pass";//สอบถามค่าที่ Database

            command.CommandText = query;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username.text;//รับค่ามาเก็บไว้ใน Database
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // ถ้าชื่อผู้ใช้และรหัสผ่านมีอยู่
            if (table.Rows.Count > 0)
            {
                
                // หน้านี้ซ่อน แล้วให้ show หน้าหลัก
                this.Hide();
                home homeform = new home();
                homeform.Show();
                
            }
            else
            {
                if (username.text.Trim().Equals(""))//ถ้า username = ว่าง
                {
                    MessageBox.Show("กรุณากรอกชื่อผู้ใช้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Text.Trim().Equals(""))//ถ้า password = ว่าง
                {
                    MessageBox.Show("กรุณากรอกรหัสผ่าน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//นอกเหนือจากนั้น
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านนี้ไม่มีอยู่", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
