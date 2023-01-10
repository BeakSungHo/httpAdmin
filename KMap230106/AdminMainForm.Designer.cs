namespace KMap230106
{
    partial class AdminMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapPage_update = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_imgname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_longtitude = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_latitude = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.LV_MarkData = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.tb_tureFalse = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tapPage_update.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapPage_update);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 343);
            this.tabControl1.TabIndex = 23;
            // 
            // tapPage_update
            // 
            this.tapPage_update.BackColor = System.Drawing.Color.White;
            this.tapPage_update.Controls.Add(this.groupBox3);
            this.tapPage_update.Controls.Add(this.groupBox2);
            this.tapPage_update.Controls.Add(this.groupBox1);
            this.tapPage_update.Controls.Add(this.tb_result);
            this.tapPage_update.Controls.Add(this.btn_create);
            this.tapPage_update.Controls.Add(this.btn_delete);
            this.tapPage_update.Controls.Add(this.btn_update);
            this.tapPage_update.Location = new System.Drawing.Point(4, 29);
            this.tapPage_update.Margin = new System.Windows.Forms.Padding(4);
            this.tapPage_update.Name = "tapPage_update";
            this.tapPage_update.Padding = new System.Windows.Forms.Padding(4);
            this.tapPage_update.Size = new System.Drawing.Size(1083, 310);
            this.tapPage_update.TabIndex = 0;
            this.tapPage_update.Text = "Admin";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.tb_imgname);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tb_description);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(343, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 238);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // tb_imgname
            // 
            this.tb_imgname.Location = new System.Drawing.Point(135, 165);
            this.tb_imgname.Multiline = true;
            this.tb_imgname.Name = "tb_imgname";
            this.tb_imgname.Size = new System.Drawing.Size(421, 50);
            this.tb_imgname.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "IMGNAME";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(135, 30);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(421, 117);
            this.tb_description.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "DESCRIPTION";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.tb_longtitude);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_latitude);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(9, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 86);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // tb_longtitude
            // 
            this.tb_longtitude.Location = new System.Drawing.Point(110, 46);
            this.tb_longtitude.Name = "tb_longtitude";
            this.tb_longtitude.Size = new System.Drawing.Size(179, 27);
            this.tb_longtitude.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "LONGTITUDE";
            // 
            // tb_latitude
            // 
            this.tb_latitude.Location = new System.Drawing.Point(110, 13);
            this.tb_latitude.Name = "tb_latitude";
            this.tb_latitude.Size = new System.Drawing.Size(179, 27);
            this.tb_latitude.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "LATITUDE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tb_tag);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 167);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // tb_tag
            // 
            this.tb_tag.Location = new System.Drawing.Point(86, 115);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.Size = new System.Drawing.Size(205, 27);
            this.tb_tag.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "TAG";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(86, 82);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(205, 27);
            this.tb_address.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "ADDRESS";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(86, 49);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(205, 27);
            this.tb_name.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "NAME";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(86, 16);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(205, 27);
            this.tb_id.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID";
            // 
            // tb_result
            // 
            this.tb_result.Enabled = false;
            this.tb_result.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_result.Location = new System.Drawing.Point(194, 268);
            this.tb_result.Margin = new System.Windows.Forms.Padding(4);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(726, 27);
            this.tb_result.TabIndex = 43;
            this.tb_result.Text = "반환 값";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(963, 11);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(96, 86);
            this.btn_create.TabIndex = 42;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(963, 209);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 86);
            this.btn_delete.TabIndex = 42;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(963, 111);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 86);
            this.btn_update.TabIndex = 42;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // LV_MarkData
            // 
            this.LV_MarkData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.LV_MarkData.FullRowSelect = true;
            this.LV_MarkData.Location = new System.Drawing.Point(15, 389);
            this.LV_MarkData.Margin = new System.Windows.Forms.Padding(4);
            this.LV_MarkData.Name = "LV_MarkData";
            this.LV_MarkData.Size = new System.Drawing.Size(967, 193);
            this.LV_MarkData.TabIndex = 25;
            this.LV_MarkData.UseCompatibleStateImageBehavior = false;
            this.LV_MarkData.View = System.Windows.Forms.View.Details;
            this.LV_MarkData.SelectedIndexChanged += new System.EventHandler(this.LV_MarkData_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "name";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "imgName";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "address";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "description";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "tag";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "latitude";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "longtitude";
            this.columnHeader8.Width = 100;
            // 
            // tb_tureFalse
            // 
            this.tb_tureFalse.Enabled = false;
            this.tb_tureFalse.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_tureFalse.Location = new System.Drawing.Point(120, 351);
            this.tb_tureFalse.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tureFalse.Name = "tb_tureFalse";
            this.tb_tureFalse.Size = new System.Drawing.Size(127, 27);
            this.tb_tureFalse.TabIndex = 24;
            this.tb_tureFalse.Text = "성공 실패";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(15, 351);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(97, 31);
            this.btn_load.TabIndex = 23;
            this.btn_load.Text = "불러오기";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_tureFalse);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.LV_MarkData);
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMainForm";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tapPage_update.ResumeLayout(false);
            this.tapPage_update.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private ListView LV_MarkData;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TextBox tb_tureFalse;
        private Button btn_load;
        private TabPage tapPage_update;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox tb_result;
        private Button btn_create;
        private Button btn_delete;
        private Button btn_update;

        private TextBox tb_imgname;
        private Label label16;
        private TextBox tb_description;
        private Label label15;
        private TextBox tb_longtitude;
        private Label label14;
        private TextBox tb_latitude;
        private Label label13;
        private TextBox tb_tag;
        private Label label12;
        private TextBox tb_address;
        private Label label11;
        private TextBox tb_name;
        private Label label10;
        private TextBox tb_id;
        private Label label9;
    }
}