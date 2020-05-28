using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace hotel_management
{
    class roommanage
    {
        connect conn = new connect();
        //
        public DataTable roomTypeList()
        {
            MySqlCommand command = new MySqlCommand(" SELECT * FROM `room_category` ", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public DataTable roomByType(int type)
        {
            MySqlCommand command = new MySqlCommand(" SELECT * FROM `room` WHERE `type`=@typ and `free`= 'ว่าง'", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //return รับค่า room id
        public int getRoomType(int number)
        {
            MySqlCommand command = new MySqlCommand(" SELECT `type` FROM `room` WHERE  `number`=@num", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

            adapter.SelectCommand = command;
            adapter.Fill(table);

           return Convert.ToInt32(table.Rows[0][0].ToString());
        }
        public bool setRoomFree(int number,String free)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `room` SET `free`='ไม่ว่าง' WHERE `number`=@num", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
  
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@fre", MySqlDbType.VarChar).Value = free;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

            
        }
        //เพิ่มข้อมูลห้อง
        public bool addRoom(int number, int type,String free)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = " INSERT INTO `room`(`number`, `type`,`free`) VALUES (@num,@typ,@fre)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@no,@type,@price
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@fre", MySqlDbType.VarChar).Value = free;


            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        //แสดงตาราง
        public DataTable getRooms()
        {
            MySqlCommand command = new MySqlCommand(" SELECT * FROM `room", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //แก้ไขข้อมูลห้อง
        public bool editRoom(int number, int type, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `room` SET `type`=@typ,`free`=@fre WHERE  `number`=@num";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@fre", MySqlDbType.VarChar).Value = free;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        // ลบข้อมูลห้อง
        public bool deleteRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String deleteQuery = "DELETE FROM `room` WHERE `number`=@num";
            command.CommandText = deleteQuery;
            command.Connection = conn.GetConnection();


            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}
