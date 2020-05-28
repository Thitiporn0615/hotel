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
    public partial class roomform : UserControl
    {
        public roomform()
        {
            InitializeComponent();
        }

        roommanage room = new roommanage(); //สร้าง room เรียก  roommanage มาใช้งาน

        //Method แสดงข้อมูลใน comboBoxRoomType
        private void roomform_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList(); //ดึงข้อมูลจาก ฟังก์ชัน roomTypeList
            comboBoxRoomType.DisplayMember = "label"; //DisplayMember ชื่อ label 
            comboBoxRoomType.ValueMember = "category_id";//ValueMember ชื่อ category_id

            DataGridView1.DataSource = room.getRooms();//แสดงข้อมูล DataGridView1 
        }

        //Method เพิ่มข้อมูลห้อง
        private void addRoom_Click(object sender, EventArgs e)
        {
            //สร้างตัวแปรรับค่า จาก comboBoxRoomType โดยนำ Value ที่เลือก
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            string free = ""; //Free คือ สถานะของห้อง ว่าว่างมั้ย
            try
            {
                int number = Convert.ToInt32(TbRoomNumber.Text);//สร้าง number รับค่าจาก TbRoomNumber
                if (radioButtonYES.Checked)//ถ้า ปุ่ม ว่าง ถูก checked
                {
                    free = "ว่าง"; 
                }
                else if (radioButtonNO.Checked)
                {
                    free = "ไม่ว่าง";
                }
                if(room.addRoom(number,type,free))//ถ้า ฟังก์ชัน addRoom ถูกใช้
                {
                    DataGridView1.DataSource = room.getRooms(); //แสดงข้อมูลในDataGridView1 
                    MessageBox.Show("เพิ่มห้องสำเร็จ", "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("เพิ่มห้องไม่สำเร็จ", "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
               catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Method  clear ข้อมูลห้อง
        private void clear_Click(object sender, EventArgs e)
        {
            TbRoomNumber.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            radioButtonYES.Checked = true;
        }

        //Method  ถ้า datagirdView ถูก Click
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //สร้างตัวแปรรับค่า จาก DatagridView
            TbRoomNumber.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomType.SelectedValue = DataGridView1.CurrentRow.Cells[1].Value;
            string free = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            //ถ้า free = ว่าง ก็ให้ radioButtonYES ถูก Checked
            if (free.Equals("ว่าง"))
            {
                radioButtonYES.Checked = true;
            }
            else if (free.Equals("ไม่ว่าง"))
            {
                radioButtonNO.Checked = true;
            }

        }
        //Method แก้ไขข้อมูลห้อง
        private void edit_Click(object sender, EventArgs e)
        {
            //สร้างตัวแปรรับค่า จาก comboBoxRoomType
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            String free = "";
            try
            {
                int number = Convert.ToInt32(TbRoomNumber.Text);
                if (radioButtonYES.Checked)
                {
                    free = "ว่าง";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "ไม่ว่าง";
                }
                if (room.editRoom(number,type,free))//ถ้า ฟังก์ชัน editRoom ถูกใช้
                {
                    DataGridView1.DataSource = room.getRooms();//แสดงข้อมูลในDataGridView1 
                    MessageBox.Show("แก้ไขข้อมูลห้องสำเร็จ", "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("เเก้ไขข้อมูลห้องไม่สำเร็จ", "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method ลบข้อมูลห้อง
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(TbRoomNumber.Text);
                if (room.deleteRoom(number))//ถ้า ฟังก์ชัน deleteRoom ถูกใช้
                {
                    DataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("ลบข้อมูลห้องสำเร็จ", "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ลบข้อมูลห้องไม่สำเร็จ", "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
