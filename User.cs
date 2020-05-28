using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hotel_management
{
    public partial class User : UserControl
    {
        usermanage user = new usermanage(); //สร้าง user เรียก usermanage มาใช้งาน

        public User()
        {
            InitializeComponent();
        }
        //method การบันทึกข้อมูล User
        private void save_Click(object sender, EventArgs e)
        {
            //สร้างตัวแปรรับค่าจาก textbox ตาง ๆ 
            string username = tbusername.Text;
            string password = tbpassword.Text;
            string name = tbname.Text;
            string tel = tbtel.Text;
            string mail = tbmail.Text;
            //สร้าง If else ตรวจสอบว่าข้อมูลในตัวแปรที่เราสร้างไว้มีค่าว่างมั้ย ถ้าว่างก็ให้แจ้ง เช่น ผู้ใช้ไม่ได้กรอกชื่อ ก็ให้ MessageBox แสดงว่า กรุณากรอกชื่อผู้ใช้ นะ
            if (username.Trim().Equals(""))
                {
                    MessageBox.Show("กรุณากรอกชื่อผู้ใช้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                    {
                    MessageBox.Show("กรุณากรอกรหัสผ่าน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (name.Trim().Equals(""))
                {
                    MessageBox.Show("กรุณากรอกชื่อ-สกุล", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tel.Trim().Equals(""))
                {
                    MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mail.Trim().Equals(""))
                {
                    MessageBox.Show("กรุณากรอก Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else //ถ้าไม่ใช่ ก็ เรียก ฟังก์ชัน insertUser มาใช้
            {
                    Boolean insertUser = user.insertUser(username,password,name,tel,mail);

                    if (insertUser)//ถ้ามีการใช้ ฟังก์ชัน insertUser
                {
                        DataGridView1.DataSource = user.getUser();
                        MessageBox.Show("บันทึกข้อมูลสำเร็จ", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error ไม่สามารถบันทึกข้อมูลได้", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
        //Method แสดงข้อมูลใน DatagridView
        private void User_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = user.getUser();//ดึงข้อมูลจาก ฟังก์ชัน getUser
        }
        //Method แก้ไขข้อมูล User หรือ พนักงาน
        private void edit_Click(object sender, EventArgs e)
        {
            //สร้างตัวแปรรับค่า จาก TextBox ต่าง ๆ
            int id;
            string username = tbusername.Text;
            string password = tbpassword.Text;
            string name = tbname.Text;
            string tel = tbtel.Text;
            string mail = tbmail.Text;
            try
            {
                id = Convert.ToInt32(TBID.Text);//รับค่าจาก ID Textboox

                if (username.Trim().Equals("") || password.Trim().Equals("") || name.Trim().Equals("") || tel.Trim().Equals(""))//ถ้าตัวแปรที่เราสร้างไว้มีค่าว่าง
                {
                    MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertUser = user.editUser(id,username, password, name, tel, mail);

                    if (insertUser)//ถ้ามีการเรียกใช้ฟังก์ชัน editUser
                    {
                        DataGridView1.DataSource = user.getUser();//ดึงข้อมูลมาแสดงใน datagridview
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error ไม่สามารถแก้ไขข้อมูลได้", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //method ถ้ากดข้อมูลใน DataGridView
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textbox ต่าง ๆรับค่าจาก DataGridView ของตำแหน่ง cell นั้น ๆ
            TBID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbusername.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbpassword.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbname.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbtel.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbmail.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        //method ล้างข้อมูล Clear
        private void clear_Click(object sender, EventArgs e)
        {
            TBID.Text = "";
            tbusername.Text = "";
            tbpassword.Text = "";
            tbtel.Text = "";
            tbname.Text = "";
            tbmail.Text = "";
        }
        //method ลบข้อมูล
        private void delete_Click(object sender, EventArgs e)
        {
            //ลองทำดูก่อน
            try
            {
                int id = Convert.ToInt32(TBID.Text);

                if (user.deleteUser(id))
                {
                    DataGridView1.DataSource = user.getUser();
                    MessageBox.Show("ลบข้อมูลสำเร็จ", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error ไม่สามารถลบข้อมูลได้", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            ///ดักจับ Error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
