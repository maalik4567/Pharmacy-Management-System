namespace Grand_project
{
    partial class employee
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.empname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empsal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empcont = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.combobox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.empgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(205, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // empname
            // 
            this.empname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empname.ForeColor = System.Drawing.Color.Brown;
            this.empname.HintForeColor = System.Drawing.Color.Empty;
            this.empname.HintText = "";
            this.empname.isPassword = false;
            this.empname.LineFocusedColor = System.Drawing.Color.Brown;
            this.empname.LineIdleColor = System.Drawing.Color.Gray;
            this.empname.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empname.LineThickness = 3;
            this.empname.Location = new System.Drawing.Point(31, 217);
            this.empname.Margin = new System.Windows.Forms.Padding(5);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(240, 49);
            this.empname.TabIndex = 2;
            this.empname.Text = "Employ Name";
            this.empname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empsal
            // 
            this.empsal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empsal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empsal.ForeColor = System.Drawing.Color.Brown;
            this.empsal.HintForeColor = System.Drawing.Color.Empty;
            this.empsal.HintText = "";
            this.empsal.isPassword = false;
            this.empsal.LineFocusedColor = System.Drawing.Color.Brown;
            this.empsal.LineIdleColor = System.Drawing.Color.Gray;
            this.empsal.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empsal.LineThickness = 3;
            this.empsal.Location = new System.Drawing.Point(344, 122);
            this.empsal.Margin = new System.Windows.Forms.Padding(5);
            this.empsal.Name = "empsal";
            this.empsal.Size = new System.Drawing.Size(240, 49);
            this.empsal.TabIndex = 3;
            this.empsal.Text = "Salary";
            this.empsal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empid
            // 
            this.empid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empid.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.ForeColor = System.Drawing.Color.Brown;
            this.empid.HintForeColor = System.Drawing.Color.Empty;
            this.empid.HintText = "";
            this.empid.isPassword = false;
            this.empid.LineFocusedColor = System.Drawing.Color.Brown;
            this.empid.LineIdleColor = System.Drawing.Color.Gray;
            this.empid.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empid.LineThickness = 3;
            this.empid.Location = new System.Drawing.Point(31, 122);
            this.empid.Margin = new System.Windows.Forms.Padding(5);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(240, 49);
            this.empid.TabIndex = 4;
            this.empid.Text = "Employee ID";
            this.empid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empage
            // 
            this.empage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empage.ForeColor = System.Drawing.Color.Brown;
            this.empage.HintForeColor = System.Drawing.Color.Empty;
            this.empage.HintText = "";
            this.empage.isPassword = false;
            this.empage.LineFocusedColor = System.Drawing.Color.Brown;
            this.empage.LineIdleColor = System.Drawing.Color.Gray;
            this.empage.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empage.LineThickness = 3;
            this.empage.Location = new System.Drawing.Point(31, 336);
            this.empage.Margin = new System.Windows.Forms.Padding(5);
            this.empage.Name = "empage";
            this.empage.Size = new System.Drawing.Size(240, 49);
            this.empage.TabIndex = 5;
            this.empage.Text = "Employee Age";
            this.empage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empcont
            // 
            this.empcont.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empcont.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcont.ForeColor = System.Drawing.Color.Brown;
            this.empcont.HintForeColor = System.Drawing.Color.Empty;
            this.empcont.HintText = "";
            this.empcont.isPassword = false;
            this.empcont.LineFocusedColor = System.Drawing.Color.Brown;
            this.empcont.LineIdleColor = System.Drawing.Color.Gray;
            this.empcont.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empcont.LineThickness = 3;
            this.empcont.Location = new System.Drawing.Point(344, 336);
            this.empcont.Margin = new System.Windows.Forms.Padding(5);
            this.empcont.Name = "empcont";
            this.empcont.Size = new System.Drawing.Size(240, 49);
            this.empcont.TabIndex = 6;
            this.empcont.Text = "Phone Number";
            this.empcont.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // combobox2
            // 
            this.combobox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox2.ForeColor = System.Drawing.Color.Brown;
            this.combobox2.FormattingEnabled = true;
            this.combobox2.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.combobox2.Location = new System.Drawing.Point(344, 233);
            this.combobox2.Name = "combobox2";
            this.combobox2.Size = new System.Drawing.Size(240, 33);
            this.combobox2.TabIndex = 7;
            this.combobox2.Text = "Gender";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Brown;
            this.button5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(91, 440);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 43);
            this.button5.TabIndex = 9;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Brown;
            this.button6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(273, 440);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 43);
            this.button6.TabIndex = 10;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Brown;
            this.button7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(451, 441);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 43);
            this.button7.TabIndex = 11;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Brown;
            this.button8.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(273, 518);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 43);
            this.button8.TabIndex = 12;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // empgridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.empgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empgridview.BackgroundColor = System.Drawing.Color.White;
            this.empgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empgridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empgridview.ColumnHeadersHeight = 34;
            this.empgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.empgridview.EnableHeadersVisualStyles = false;
            this.empgridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empgridview.Location = new System.Drawing.Point(601, 12);
            this.empgridview.Name = "empgridview";
            this.empgridview.RowHeadersVisible = false;
            this.empgridview.RowHeadersWidth = 51;
            this.empgridview.RowTemplate.Height = 24;
            this.empgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empgridview.Size = new System.Drawing.Size(792, 554);
            this.empgridview.TabIndex = 14;
            this.empgridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.empgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.empgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empgridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.empgridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.empgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.empgridview.ThemeStyle.HeaderStyle.Height = 34;
            this.empgridview.ThemeStyle.ReadOnly = false;
            this.empgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empgridview.ThemeStyle.RowsStyle.Height = 24;
            this.empgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empgridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empgridview_CellClick);
            this.empgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 578);
            this.Controls.Add(this.empgridview);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.combobox2);
            this.Controls.Add(this.empcont);
            this.Controls.Add(this.empage);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.empsal);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empsal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empage;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empcont;
        private System.Windows.Forms.ComboBox combobox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private Guna.UI2.WinForms.Guna2DataGridView empgridview;
    }
}