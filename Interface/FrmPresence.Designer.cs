﻿namespace Interface
{
    partial class FrmPresence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresence));
            this.dgvListPresence = new System.Windows.Forms.DataGridView();
            this.presence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAttendance_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmPresence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDatePresence = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPresence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListPresence
            // 
            this.dgvListPresence.AllowUserToAddRows = false;
            this.dgvListPresence.AllowUserToDeleteRows = false;
            this.dgvListPresence.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPresence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListPresence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPresence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.presence,
            this.id,
            this.name,
            this.classStudent,
            this.gender,
            this.listAttendance_id});
            this.dgvListPresence.Location = new System.Drawing.Point(12, 81);
            this.dgvListPresence.Name = "dgvListPresence";
            this.dgvListPresence.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvListPresence.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListPresence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPresence.Size = new System.Drawing.Size(950, 404);
            this.dgvListPresence.TabIndex = 4;
            // 
            // presence
            // 
            this.presence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.presence.HeaderText = "";
            this.presence.MinimumWidth = 6;
            this.presence.Name = "presence";
            this.presence.Width = 6;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 55;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nome";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 82;
            // 
            // classStudent
            // 
            this.classStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classStudent.DataPropertyName = "class";
            this.classStudent.HeaderText = "Turma";
            this.classStudent.MinimumWidth = 6;
            this.classStudent.Name = "classStudent";
            this.classStudent.ReadOnly = true;
            this.classStudent.Width = 86;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.HeaderText = "Gênero";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 93;
            // 
            // listAttendance_id
            // 
            this.listAttendance_id.HeaderText = "listAttendance_id";
            this.listAttendance_id.MinimumWidth = 6;
            this.listAttendance_id.Name = "listAttendance_id";
            this.listAttendance_id.Visible = false;
            this.listAttendance_id.Width = 125;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "A1 - Manhã",
            "A2 -Tarde",
            "A3 - Noite",
            "B1- Manhã",
            "B2 -Tarde",
            "B3 - Noite"});
            this.cbClass.Location = new System.Drawing.Point(12, 33);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(350, 28);
            this.cbClass.TabIndex = 5;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turma";
            // 
            // btnConfirmPresence
            // 
            this.btnConfirmPresence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPresence.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPresence.Location = new System.Drawing.Point(756, 491);
            this.btnConfirmPresence.Name = "btnConfirmPresence";
            this.btnConfirmPresence.Size = new System.Drawing.Size(206, 44);
            this.btnConfirmPresence.TabIndex = 7;
            this.btnConfirmPresence.Text = "Confirmar Presença";
            this.btnConfirmPresence.UseVisualStyleBackColor = true;
            this.btnConfirmPresence.Click += new System.EventHandler(this.btnConfirmPresence_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data";
            // 
            // dtDatePresence
            // 
            this.dtDatePresence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatePresence.Location = new System.Drawing.Point(372, 34);
            this.dtDatePresence.Name = "dtDatePresence";
            this.dtDatePresence.Size = new System.Drawing.Size(113, 26);
            this.dtDatePresence.TabIndex = 10;
            this.dtDatePresence.ValueChanged += new System.EventHandler(this.dtDatePresence_ValueChanged);
            // 
            // FrmPresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(976, 547);
            this.Controls.Add(this.dtDatePresence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmPresence);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListPresence);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPresence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presença";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPresence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListPresence;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmPresence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDatePresence;
        private System.Windows.Forms.DataGridViewCheckBoxColumn presence;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn listAttendance_id;
    }
}