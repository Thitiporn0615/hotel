namespace hotel_management
{
    partial class Reservations
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboRoomNumber = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbguestId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DatetimeOut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DatetimeIn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addReserv = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboRoomType = new System.Windows.Forms.ComboBox();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReservId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRoomNumber
            // 
            this.comboRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomNumber.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoomNumber.FormattingEnabled = true;
            this.comboRoomNumber.Location = new System.Drawing.Point(617, 160);
            this.comboRoomNumber.Name = "comboRoomNumber";
            this.comboRoomNumber.Size = new System.Drawing.Size(193, 35);
            this.comboRoomNumber.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(985, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 59);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "ประเภทห้อง :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "หมายเลขห้อง :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID ลูกค้า  :";
            // 
            // tbguestId
            // 
            this.tbguestId.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbguestId.Location = new System.Drawing.Point(282, 109);
            this.tbguestId.Name = "tbguestId";
            this.tbguestId.Size = new System.Drawing.Size(192, 34);
            this.tbguestId.TabIndex = 29;
            this.tbguestId.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("CHULALONGKORN", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(843, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "จองห้องพัก";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 59);
            this.panel1.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(520, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 27);
            this.label11.TabIndex = 59;
            this.label11.Text = "วันที่ออก :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 27);
            this.label7.TabIndex = 58;
            this.label7.Text = "วันที่เข้าพัก :";
            // 
            // DatetimeOut
            // 
            this.DatetimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DatetimeOut.BorderRadius = 0;
            this.DatetimeOut.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatetimeOut.ForeColor = System.Drawing.Color.White;
            this.DatetimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatetimeOut.FormatCustom = "dd/MM/yyyyy";
            this.DatetimeOut.Location = new System.Drawing.Point(617, 211);
            this.DatetimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.DatetimeOut.Name = "DatetimeOut";
            this.DatetimeOut.Size = new System.Drawing.Size(213, 37);
            this.DatetimeOut.TabIndex = 62;
            this.DatetimeOut.Value = new System.DateTime(2020, 5, 20, 0, 0, 0, 0);
            // 
            // DatetimeIn
            // 
            this.DatetimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DatetimeIn.BorderRadius = 0;
            this.DatetimeIn.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatetimeIn.ForeColor = System.Drawing.Color.White;
            this.DatetimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatetimeIn.FormatCustom = "dd/MM/yyyy";
            this.DatetimeIn.Location = new System.Drawing.Point(281, 211);
            this.DatetimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.DatetimeIn.Name = "DatetimeIn";
            this.DatetimeIn.Size = new System.Drawing.Size(212, 37);
            this.DatetimeIn.TabIndex = 63;
            this.DatetimeIn.Value = new System.DateTime(2020, 5, 20, 0, 0, 0, 0);
            // 
            // clear
            // 
            this.clear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear.BorderRadius = 0;
            this.clear.ButtonText = "clear";
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.DisabledColor = System.Drawing.Color.Gray;
            this.clear.Iconcolor = System.Drawing.Color.Transparent;
            this.clear.Iconimage = ((System.Drawing.Image)(resources.GetObject("clear.Iconimage")));
            this.clear.Iconimage_right = null;
            this.clear.Iconimage_right_Selected = null;
            this.clear.Iconimage_Selected = null;
            this.clear.IconMarginLeft = 0;
            this.clear.IconMarginRight = 0;
            this.clear.IconRightVisible = true;
            this.clear.IconRightZoom = 0D;
            this.clear.IconVisible = true;
            this.clear.IconZoom = 50D;
            this.clear.IsTab = false;
            this.clear.Location = new System.Drawing.Point(456, 273);
            this.clear.Margin = new System.Windows.Forms.Padding(5);
            this.clear.Name = "clear";
            this.clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clear.OnHoverTextColor = System.Drawing.Color.White;
            this.clear.selected = false;
            this.clear.Size = new System.Drawing.Size(128, 41);
            this.clear.TabIndex = 81;
            this.clear.Text = "clear";
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear.Textcolor = System.Drawing.Color.White;
            this.clear.TextFont = new System.Drawing.Font("CHULALONGKORN", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // addReserv
            // 
            this.addReserv.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addReserv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addReserv.BorderRadius = 0;
            this.addReserv.ButtonText = "Save";
            this.addReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReserv.DisabledColor = System.Drawing.Color.Gray;
            this.addReserv.Iconcolor = System.Drawing.Color.Transparent;
            this.addReserv.Iconimage = ((System.Drawing.Image)(resources.GetObject("addReserv.Iconimage")));
            this.addReserv.Iconimage_right = null;
            this.addReserv.Iconimage_right_Selected = null;
            this.addReserv.Iconimage_Selected = null;
            this.addReserv.IconMarginLeft = 0;
            this.addReserv.IconMarginRight = 0;
            this.addReserv.IconRightVisible = true;
            this.addReserv.IconRightZoom = 0D;
            this.addReserv.IconVisible = true;
            this.addReserv.IconZoom = 50D;
            this.addReserv.IsTab = false;
            this.addReserv.Location = new System.Drawing.Point(262, 273);
            this.addReserv.Margin = new System.Windows.Forms.Padding(5);
            this.addReserv.Name = "addReserv";
            this.addReserv.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addReserv.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addReserv.OnHoverTextColor = System.Drawing.Color.White;
            this.addReserv.selected = false;
            this.addReserv.Size = new System.Drawing.Size(148, 41);
            this.addReserv.TabIndex = 80;
            this.addReserv.Text = "Save";
            this.addReserv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addReserv.Textcolor = System.Drawing.Color.White;
            this.addReserv.TextFont = new System.Drawing.Font("CHULALONGKORN", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReserv.Click += new System.EventHandler(this.addReserv_Click);
            // 
            // comboRoomType
            // 
            this.comboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomType.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoomType.FormattingEnabled = true;
            this.comboRoomType.Location = new System.Drawing.Point(282, 163);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(193, 35);
            this.comboRoomType.TabIndex = 82;
            this.comboRoomType.SelectedIndexChanged += new System.EventHandler(this.comboRoomType_SelectedIndexChanged);
            // 
            // delete
            // 
            this.delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.BorderRadius = 0;
            this.delete.ButtonText = "Delete";
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.DisabledColor = System.Drawing.Color.Gray;
            this.delete.Iconcolor = System.Drawing.Color.Transparent;
            this.delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("delete.Iconimage")));
            this.delete.Iconimage_right = null;
            this.delete.Iconimage_right_Selected = null;
            this.delete.Iconimage_Selected = null;
            this.delete.IconMarginLeft = 0;
            this.delete.IconMarginRight = 0;
            this.delete.IconRightVisible = true;
            this.delete.IconRightZoom = 0D;
            this.delete.IconVisible = true;
            this.delete.IconZoom = 50D;
            this.delete.IsTab = false;
            this.delete.Location = new System.Drawing.Point(737, 273);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delete.OnHoverTextColor = System.Drawing.Color.White;
            this.delete.selected = false;
            this.delete.Size = new System.Drawing.Size(133, 41);
            this.delete.TabIndex = 86;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Textcolor = System.Drawing.Color.White;
            this.delete.TextFont = new System.Drawing.Font("CHULALONGKORN", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.BorderRadius = 0;
            this.edit.ButtonText = "Edit";
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.DisabledColor = System.Drawing.Color.Gray;
            this.edit.Iconcolor = System.Drawing.Color.Transparent;
            this.edit.Iconimage = ((System.Drawing.Image)(resources.GetObject("edit.Iconimage")));
            this.edit.Iconimage_right = null;
            this.edit.Iconimage_right_Selected = null;
            this.edit.Iconimage_Selected = null;
            this.edit.IconMarginLeft = 0;
            this.edit.IconMarginRight = 0;
            this.edit.IconRightVisible = true;
            this.edit.IconRightZoom = 0D;
            this.edit.IconVisible = true;
            this.edit.IconZoom = 50D;
            this.edit.IsTab = false;
            this.edit.Location = new System.Drawing.Point(594, 273);
            this.edit.Margin = new System.Windows.Forms.Padding(5);
            this.edit.Name = "edit";
            this.edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.edit.OnHoverTextColor = System.Drawing.Color.White;
            this.edit.selected = false;
            this.edit.Size = new System.Drawing.Size(128, 41);
            this.edit.TabIndex = 85;
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.Textcolor = System.Drawing.Color.White;
            this.edit.TextFont = new System.Drawing.Font("CHULALONGKORN", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.DoubleBuffered = true;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(131, 336);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(739, 322);
            this.DataGridView1.TabIndex = 87;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 89;
            this.label5.Text = "ID การจอง  :";
            // 
            // tbReservId
            // 
            this.tbReservId.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReservId.Location = new System.Drawing.Point(281, 65);
            this.tbReservId.Name = "tbReservId";
            this.tbReservId.ReadOnly = true;
            this.tbReservId.Size = new System.Drawing.Size(192, 34);
            this.tbReservId.TabIndex = 88;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbReservId);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.comboRoomType);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addReserv);
            this.Controls.Add(this.DatetimeIn);
            this.Controls.Add(this.DatetimeOut);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboRoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbguestId);
            this.Controls.Add(this.panel1);
            this.Name = "Reservations";
            this.Size = new System.Drawing.Size(1002, 716);
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboRoomNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbguestId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker DatetimeOut;
        private Bunifu.Framework.UI.BunifuDatepicker DatetimeIn;
        private Bunifu.Framework.UI.BunifuFlatButton clear;
        private Bunifu.Framework.UI.BunifuFlatButton addReserv;
        private System.Windows.Forms.ComboBox comboRoomType;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
        private Bunifu.Framework.UI.BunifuFlatButton edit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReservId;
    }
}
