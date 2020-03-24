namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.work = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.exam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.DoubleBuffered = true;
            this.DataGrid1.EnableHeadersVisualStyles = false;
            this.DataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DataGrid1.Location = new System.Drawing.Point(302, 55);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid1.Size = new System.Drawing.Size(321, 189);
            this.DataGrid1.TabIndex = 0;
            // 
            // name
            // 
            this.name.BorderColorFocused = System.Drawing.Color.Blue;
            this.name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.name.BorderThickness = 3;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.isPassword = false;
            this.name.Location = new System.Drawing.Point(13, 64);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(258, 41);
            this.name.TabIndex = 1;
            this.name.Text = "bunifuMetroTextbox1";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // work
            // 
            this.work.BorderColorFocused = System.Drawing.Color.Blue;
            this.work.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.work.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.work.BorderThickness = 3;
            this.work.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.work.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.work.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.work.isPassword = false;
            this.work.Location = new System.Drawing.Point(13, 125);
            this.work.Margin = new System.Windows.Forms.Padding(4);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(258, 41);
            this.work.TabIndex = 2;
            this.work.Text = "bunifuMetroTextbox2";
            this.work.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // exam
            // 
            this.exam.BorderColorFocused = System.Drawing.Color.Blue;
            this.exam.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exam.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.exam.BorderThickness = 3;
            this.exam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.exam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exam.isPassword = false;
            this.exam.Location = new System.Drawing.Point(13, 174);
            this.exam.Margin = new System.Windows.Forms.Padding(4);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(258, 41);
            this.exam.TabIndex = 3;
            this.exam.Text = "bunifuMetroTextbox3";
            this.exam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exam);
            this.Controls.Add(this.work);
            this.Controls.Add(this.name);
            this.Controls.Add(this.DataGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid1;
        private Bunifu.Framework.UI.BunifuMetroTextbox name;
        private Bunifu.Framework.UI.BunifuMetroTextbox work;
        private Bunifu.Framework.UI.BunifuMetroTextbox exam;
        private System.Windows.Forms.Button button1;
    }
}

