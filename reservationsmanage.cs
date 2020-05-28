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
    class reservationsmanage
    {
        connect conn = new connect();

        public DataTable getAllReserv()
        {
            MySqlCommand command = new MySqlCommand(" SELECT * FROM `reservation` ", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }
        //เพิ่มข้อมูลห้อง
        public bool addReservation(int number,int guestId ,DateTime dateIn , DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `reservation`( `roomNumber`, `guestId`, `dateIn`, `dateOut`) VALUES (@num,@gid,@in,@out)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@no,@type,@price
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@gid", MySqlDbType.Int32).Value = guestId;
            command.Parameters.Add("@in", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@out", MySqlDbType.Date).Value = dateOut;


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
        //สร้าง ฟังก์ชัน แก้ไขการจองห้อง
        public bool editReserv(int reservId,int number, int guestId, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `reservation` SET `roomNumber`=@num,`guestId`=@gid,`dateIn`=@in,`dateOut`=@out WHERE `reservId`=@rvid";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@gid", MySqlDbType.Int32).Value = guestId;
            command.Parameters.Add("@in", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@out", MySqlDbType.Date).Value = dateOut;

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

        //สร้าง ฟังก์ชัน ลบการจองห้อง
        public bool deleteReservation(int reservId)
        {
            MySqlCommand command = new MySqlCommand();
            String deleteQuery = "DELETE FROM `reservation` WHERE `reservId`=@rvid";
            command.CommandText = deleteQuery;
            command.Connection = conn.GetConnection();


            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId;

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
