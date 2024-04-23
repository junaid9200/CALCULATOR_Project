namespace CALCULATOR_Project
{
    partial class TableNameInputForm
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
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.labelSelectedTable = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.op_text1 = new System.Windows.Forms.TextBox();
            this.op_text2 = new System.Windows.Forms.TextBox();
            this.res_text1 = new System.Windows.Forms.TextBox();
            this.op1 = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.Label();
            this.res1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(190, 29);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTables.TabIndex = 0;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 279);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(409, 265);
            this.dataGridViewData.TabIndex = 1;
            // 
            // labelSelectedTable
            // 
            this.labelSelectedTable.AutoSize = true;
            this.labelSelectedTable.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSelectedTable.Location = new System.Drawing.Point(40, 32);
            this.labelSelectedTable.Name = "labelSelectedTable";
            this.labelSelectedTable.Size = new System.Drawing.Size(126, 16);
            this.labelSelectedTable.TabIndex = 2;
            this.labelSelectedTable.Text = "SELECT  TABLE -->";
            this.labelSelectedTable.Click += new System.EventHandler(this.labelSelectedTable_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(190, 67);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxID.TabIndex = 3;
            this.comboBoxID.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(75, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select ID\"s -->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // op_text1
            // 
            this.op_text1.Location = new System.Drawing.Point(190, 130);
            this.op_text1.Name = "op_text1";
            this.op_text1.Size = new System.Drawing.Size(100, 22);
            this.op_text1.TabIndex = 6;
            // 
            // op_text2
            // 
            this.op_text2.Location = new System.Drawing.Point(190, 167);
            this.op_text2.Name = "op_text2";
            this.op_text2.Size = new System.Drawing.Size(100, 22);
            this.op_text2.TabIndex = 7;
            // 
            // res_text1
            // 
            this.res_text1.Location = new System.Drawing.Point(190, 205);
            this.res_text1.Name = "res_text1";
            this.res_text1.Size = new System.Drawing.Size(100, 22);
            this.res_text1.TabIndex = 8;
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.op1.Location = new System.Drawing.Point(81, 130);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(85, 16);
            this.op1.TabIndex = 9;
            this.op1.Text = "Operand1 -->";
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.op2.Location = new System.Drawing.Point(81, 167);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(85, 16);
            this.op2.TabIndex = 10;
            this.op2.Text = "Operand2 -->";
            // 
            // res1
            // 
            this.res1.AutoSize = true;
            this.res1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.res1.Location = new System.Drawing.Point(121, 205);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(45, 16);
            this.res1.TabIndex = 11;
            this.res1.Text = "Result";
            // 
            // TableNameInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 679);
            this.Controls.Add(this.res1);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.res_text1);
            this.Controls.Add(this.op_text2);
            this.Controls.Add(this.op_text1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.labelSelectedTable);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.comboBoxTables);
            this.Name = "TableNameInputForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TableNameInputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label labelSelectedTable;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox op_text1;
        private System.Windows.Forms.TextBox op_text2;
        private System.Windows.Forms.TextBox res_text1;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.Label res1;
    }
}