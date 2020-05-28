using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace hotel_management
{
    class connect
    {
        /// <summary>
        /// เชื่อมต่อกับ Database กับ host ที่สร้างไว้
        /// </summary>
        private MySqlConnection connection = new MySqlConnection("datasource = localhost;port=3306;username=root;password=;database=felicityhotel");
        //รับค่าการเชื่อมต่อ
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        //เปิด 
        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //ปิด
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

}
