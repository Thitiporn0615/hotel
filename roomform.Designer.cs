namespace hotel_management
{
    partial class roomform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonYES = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TbRoomNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 59);
            this.panel1.TabIndex = 30;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("CHULALONGKORN", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(858, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "ข้อมูลห้อง";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(262, 188);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(148, 35);
            this.comboBoxRoomType.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "ประเภทห้อง :";
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
            this.DataGridView1.Location = new System.Drawing.Point(131, 369);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(739, 303);
            this.DataGridView1.TabIndex = 41;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
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
            this.clear.Location = new System.Drawing.Point(505, 295);
            this.clear.Margin = new System.Windows.Forms.Padding(5);
            this.clear.Name = "clear";
            this.clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clear.OnHoverTextColor = System.Drawing.Color.White;
            this.clear.selected = false;
            this.clear.Size = new System.Drawing.Size(128, 41);
            this.clear.TabIndex = 79;
            this.clear.Text = "clear";
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear.Textcolor = System.Drawing.Color.White;
            this.clear.TextFont = new System.Drawing.Font("CHULALONGKORN", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Click += new System.EventHandler(this.clear_Click);
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
            this.delete.Location = new System.Drawing.Point(786, 296);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delete.OnHoverTextColor = System.Drawing.Color.White;
            this.delete.selected = false;
            this.delete.Size = new System.Drawing.Size(133, 41);
            this.delete.TabIndex = 78;
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
            this.edit.Location = new System.Drawing.Point(643, 296);
            this.edit.Margin = new System.Windows.Forms.Padding(5);
            this.edit.Name = "edit";
            this.edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.edit.OnHoverTextColor = System.Drawing.Color.White;
            this.edit.selected = false;
            this.edit.Size = new System.Drawing.Size(128, 41);
            this.edit.TabIndex = 77;
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.Textcolor = System.Drawing.Color.White;
            this.edit.TextFont = new System.Drawing.Font("CHULALONGKORN", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // addRoom
            // 
            this.addRoom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRoom.BorderRadius = 0;
            this.addRoom.ButtonText = "Save";
            this.addRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRoom.DisabledColor = System.Drawing.Color.Gray;
            this.addRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.addRoom.Iconimage = ((System.Drawing.Image)(resources.GetObject("addRoom.Iconimage")));
            this.addRoom.Iconimage_right = null;
            this.addRoom.Iconimage_right_Selected = null;
            this.addRoom.Iconimage_Selected = null;
            this.addRoom.IconMarginLeft = 0;
            this.addRoom.IconMarginRight = 0;
            this.addRoom.IconRightVisible = true;
            this.addRoom.IconRightZoom = 0D;
            this.addRoom.IconVisible = true;
            this.addRoom.IconZoom = 50D;
            this.addRoom.IsTab = false;
            this.addRoom.Location = new System.Drawing.Point(262, 296);
            this.addRoom.Margin = new System.Windows.Forms.Padding(5);
            this.addRoom.Name = "addRoom";
            this.addRoom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addRoom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.addRoom.selected = false;
            this.addRoom.Size = new System.Drawing.Size(148, 41);
            this.addRoom.TabIndex = 76;
            this.addRoom.Text = "Save";
            this.addRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addRoom.Textcolor = System.Drawing.Color.White;
            this.addRoom.TextFont = new System.Drawing.Font("CHULALONGKORN", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 80;
            this.label2.Text = "สถานะ  :";
            // 
            // radioButtonYES
            // 
            this.radioButtonYES.AutoSize = true;
            this.radioButtonYES.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYES.Location = new System.Drawing.Point(262, 233);
            this.radioButtonYES.Name = "radioButtonYES";
            this.radioButtonYES.Size = new System.Drawing.Size(53, 31);
            this.radioButtonYES.TabIndex = 81;
            this.radioButtonYES.Text = "ว่าง";
            this.radioButtonYES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonYES.UseVisualStyleBackColor = true;
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Checked = true;
            this.radioButtonNO.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNO.Location = new System.Drawing.Point(342, 234);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(59, 33);
            this.radioButtonNO.TabIndex = 82;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "ไม่ว่าง";
            this.radioButtonNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonNO.UseCompatibleTextRendering = true;
            this.radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 83;
            this.label5.Text = "หมายเลขห้อง :";
            // 
            // TbRoomNumber
            // 
            this.TbRoomNumber.Font = new System.Drawing.Font("CHULALONGKORN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRoomNumber.Location = new System.Drawing.Point(262, 126);
            this.TbRoomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbRoomNumber.Name = "TbRoomNumber";
            this.TbRoomNumber.Size = new System.Drawing.Size(148, 34);
            this.TbRoomNumber.TabIndex = 85;
            // 
            // roomform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TbRoomNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonNO);
            this.Controls.Add(this.radioButtonYES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.addRoom);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "roomform";
            this.Size = new System.Drawing.Size(1002, 716);
            this.Load += new System.EventHandler(this.roomform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton clear;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
        private Bunifu.Framework.UI.BunifuFlatButton edit;
        private Bunifu.Framework.UI.BunifuFlatButton addRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonYES;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbRoomNumber;
    }
}
