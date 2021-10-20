
namespace WindowsFormsApp2
{
    partial class l
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurNameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.DtTable = new System.Windows.Forms.DataGridView();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateBox = new System.Windows.Forms.Button();
            this.EmptyBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SurName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(124, 20);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(152, 30);
            this.NameBox.TabIndex = 4;
            // 
            // SurNameBox
            // 
            this.SurNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurNameBox.Location = new System.Drawing.Point(124, 56);
            this.SurNameBox.Name = "SurNameBox";
            this.SurNameBox.Size = new System.Drawing.Size(152, 30);
            this.SurNameBox.TabIndex = 5;
            // 
            // IDBox
            // 
            this.IDBox.Enabled = false;
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(124, 127);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(152, 30);
            this.IDBox.TabIndex = 6;
            // 
            // AgeBox
            // 
            this.AgeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeBox.Location = new System.Drawing.Point(124, 91);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(152, 30);
            this.AgeBox.TabIndex = 7;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(32, 163);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(131, 42);
            this.Create.TabIndex = 8;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(189, 163);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(131, 42);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DtTable
            // 
            this.DtTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DtTable.EnableHeadersVisualStyles = false;
            this.DtTable.Location = new System.Drawing.Point(347, 25);
            this.DtTable.Name = "DtTable";
            this.DtTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtTable.Size = new System.Drawing.Size(402, 401);
            this.DtTable.TabIndex = 10;
            this.DtTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtTable_CellClick);
            // 
            // NameSearch
            // 
            this.NameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSearch.Location = new System.Drawing.Point(168, 270);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(152, 30);
            this.NameSearch.TabIndex = 11;
            this.NameSearch.TextChanged += new System.EventHandler(this.NameSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "SearchByName";
            // 
            // UpdateBox
            // 
            this.UpdateBox.Location = new System.Drawing.Point(32, 211);
            this.UpdateBox.Name = "UpdateBox";
            this.UpdateBox.Size = new System.Drawing.Size(131, 42);
            this.UpdateBox.TabIndex = 13;
            this.UpdateBox.Text = "UpdateBox";
            this.UpdateBox.UseVisualStyleBackColor = true;
            this.UpdateBox.Click += new System.EventHandler(this.UpdateBox_Click);
            // 
            // EmptyBox
            // 
            this.EmptyBox.Location = new System.Drawing.Point(189, 211);
            this.EmptyBox.Name = "EmptyBox";
            this.EmptyBox.Size = new System.Drawing.Size(131, 42);
            this.EmptyBox.TabIndex = 14;
            this.EmptyBox.Text = "Empty";
            this.EmptyBox.UseVisualStyleBackColor = true;
            this.EmptyBox.Click += new System.EventHandler(this.EmptyBox_Click);
            // 
            // l
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmptyBox);
            this.Controls.Add(this.UpdateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.DtTable);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.SurNameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "l";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DtTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurNameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView DtTable;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateBox;
        private System.Windows.Forms.Button EmptyBox;
    }
}

