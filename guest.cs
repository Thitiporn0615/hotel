using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class guest : UserControl
    {
        guestmanage guests = new guestmanage(); //สร้างตัวแปรเก็บค่า ของฟังก์ชัน guestmanage
        public guest()
        {
            InitializeComponent();
        }
        //method บันทึกข้อมูลลูกค้า
        private void save_Click(object sender, EventArgs e)
        {
            //ประกาศตัวแปร รับค่าจาก textbox ต่าง ๆ
            String fname = TBfirstname.Text;
            String lname = TBlastname.Text;
            String gender = TBgender.Text;
            String address = TBaddress.Text;
            String tel = TBtel.Text;
            String mail = TBmail.Text;//ถ้าค่าที่รับมามีค่าว่าง
            if (fname.Trim().Equals("") || lname.Trim().Equals("") || gender.Trim().Equals("") || address.Trim().Equals(""))
            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertguest = guests.insertguest(fname, lname, gender, address, tel, mail);//เรียกฟังก์ชัน insertguest มาใช้

                if (insertguest)//ถ้า ฟังก์ชัน insertguest ถูกใช้
                {
                    DataGridView1.DataSource = guests.getGuets();
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error ไม่สามารถบันทึกข้อมูลได้", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        //method แสดง Datagridview
        private void guest_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = guests.getGuets();//ดึงข้อมูลมาจาก ตัวแปรเก็บค่า ของฟังก์ชัน guestmanage ไว้
        }
        //method แก้ไขข้อมูลลูกค้า
        private void edit_Click(object sender, EventArgs e)
        {
            //ประกาศตัวแปร รับค่าจาก textbox ต่าง ๆ
            int id;
            String fname = TBfirstname.Text;
            String lname = TBlastname.Text;
            String gender = TBgender.Text;
            String address = TBaddress.Text;
            String tel = TBtel.Text;
            String mail = TBmail.Text;

            try//ลองทำ
            {
                id = Convert.ToInt32(TBID.Text);//รับค่าจาก ID Textboox

                if (fname.Trim().Equals("") || lname.Trim().Equals("") || gender.Trim().Equals("") || address.Trim().Equals(""))//ถ้าตัวแปรที่เราสร้างไว้มีค่าว่าง
                {
                    MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertguest = guests.editGuets(id,fname, lname, gender, address, tel, mail);

                    if (insertguest)//ถ้ามีการเรียกใช้ฟังก์ชัน editduest
                    {
                        DataGridView1.DataSource = guests.getGuets();//ดึงข้อมูลมาแสดงใน datagridview
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error ไม่สามารถแก้ไขข้อมูลได้", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)//ดักจับและจัดการข้อผิดพลาดของโปรแกรมในรูปแบบต่าง ๆ
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //method ถ้ากดข้อมูลใน DataGridView
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textbox ต่าง ๆรับค่าจาก DataGridView ของตำแหน่ง cell นั้น ๆ
            TBID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            TBfirstname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            TBlastname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            TBgender.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            TBaddress.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            TBtel.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            TBmail.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //method ลบข้อมูลลูกค้า
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                //สร้างตัวแปรรับค่า Id 
                int id = Convert.ToInt32(TBID.Text);

                if (guests.deleteGuests(id))// ถ้า ฟังก์ชัน deleteGuests ถูกใช้
                {
                    DataGridView1.DataSource = guests.getGuets();
                    MessageBox.Show("ลบข้อมูลสำเร็จ", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error ไม่สามารถลบข้อมูลได้", "Guests Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //method ล้างข้อมูล
        private void clear_Click(object sender, EventArgs e)
        {

                    TBID.Text = "";
                    TBfirstname.Text = "";
                    TBlastname.Text = "";
                    TBgender.Text = "";
                    TBaddress.Text = "";
                    TBtel.Text = "";
                    TBmail.Text = "";
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
