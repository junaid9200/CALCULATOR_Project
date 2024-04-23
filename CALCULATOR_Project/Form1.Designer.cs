namespace CALCULATOR_Project
{
    partial class calculator
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
            this.tbdisplay = new System.Windows.Forms.TextBox();
            this.lbcurrentop = new System.Windows.Forms.Label();
            this.history_btn = new System.Windows.Forms.Button();
            this.CE_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.c_btn = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.equal_btn = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbdisplay
            // 
            this.tbdisplay.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbdisplay.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdisplay.Location = new System.Drawing.Point(12, 26);
            this.tbdisplay.Multiline = true;
            this.tbdisplay.Name = "tbdisplay";
            this.tbdisplay.Size = new System.Drawing.Size(376, 59);
            this.tbdisplay.TabIndex = 0;
            this.tbdisplay.Text = "0";
            this.tbdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbdisplay.TextChanged += new System.EventHandler(this.tbdisplay_TextChanged);
            // 
            // lbcurrentop
            // 
            this.lbcurrentop.AutoSize = true;
            this.lbcurrentop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbcurrentop.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcurrentop.Location = new System.Drawing.Point(12, 26);
            this.lbcurrentop.Name = "lbcurrentop";
            this.lbcurrentop.Size = new System.Drawing.Size(0, 19);
            this.lbcurrentop.TabIndex = 1;
            // 
            // history_btn
            // 
            this.history_btn.BackColor = System.Drawing.Color.DarkGray;
            this.history_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_btn.Location = new System.Drawing.Point(12, 116);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(75, 54);
            this.history_btn.TabIndex = 2;
            this.history_btn.Text = "History⏰";
            this.history_btn.UseVisualStyleBackColor = false;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // CE_btn
            // 
            this.CE_btn.BackColor = System.Drawing.Color.DarkGray;
            this.CE_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE_btn.Location = new System.Drawing.Point(109, 116);
            this.CE_btn.Name = "CE_btn";
            this.CE_btn.Size = new System.Drawing.Size(75, 54);
            this.CE_btn.TabIndex = 3;
            this.CE_btn.Text = "CE";
            this.CE_btn.UseVisualStyleBackColor = false;
            this.CE_btn.Click += new System.EventHandler(this.CE_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(174, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "6";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(174, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 54);
            this.button4.TabIndex = 5;
            this.button4.Text = "9";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(174, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 54);
            this.button5.TabIndex = 6;
            this.button5.Text = ".";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(93, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 54);
            this.button6.TabIndex = 7;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(93, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 54);
            this.button7.TabIndex = 8;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(93, 268);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 54);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DimGray;
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(12, 448);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(156, 54);
            this.button9.TabIndex = 10;
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DimGray;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(12, 388);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 54);
            this.button10.TabIndex = 11;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DimGray;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(12, 328);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 54);
            this.button11.TabIndex = 12;
            this.button11.Text = "4";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DimGray;
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(12, 268);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 54);
            this.button12.TabIndex = 13;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Red;
            this.del_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(313, 116);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 54);
            this.del_btn.TabIndex = 14;
            this.del_btn.Text = "DELL";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // c_btn
            // 
            this.c_btn.BackColor = System.Drawing.Color.DarkGray;
            this.c_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_btn.Location = new System.Drawing.Point(211, 116);
            this.c_btn.Name = "c_btn";
            this.c_btn.Size = new System.Drawing.Size(75, 54);
            this.c_btn.TabIndex = 15;
            this.c_btn.Text = "C";
            this.c_btn.UseVisualStyleBackColor = false;
            this.c_btn.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DarkGray;
            this.button15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(267, 197);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(121, 50);
            this.button15.TabIndex = 16;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.operation_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DarkGray;
            this.button16.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(145, 197);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(104, 50);
            this.button16.TabIndex = 17;
            this.button16.Text = "√2";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.operation_click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DarkGray;
            this.button17.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(12, 197);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(115, 50);
            this.button17.TabIndex = 18;
            this.button17.Text = "x²";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.operation_click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.DimGray;
            this.button18.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(174, 388);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 54);
            this.button18.TabIndex = 19;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button_click);
            // 
            // equal_btn
            // 
            this.equal_btn.BackColor = System.Drawing.Color.Orange;
            this.equal_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal_btn.Location = new System.Drawing.Point(12, 583);
            this.equal_btn.Name = "equal_btn";
            this.equal_btn.Size = new System.Drawing.Size(372, 54);
            this.equal_btn.TabIndex = 20;
            this.equal_btn.Text = "=";
            this.equal_btn.UseVisualStyleBackColor = false;
            this.equal_btn.Click += new System.EventHandler(this.equal_btn_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.DarkGray;
            this.button20.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(267, 282);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(121, 54);
            this.button20.TabIndex = 21;
            this.button20.Text = "x";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.operation_click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DarkGray;
            this.button21.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(267, 369);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(121, 54);
            this.button21.TabIndex = 22;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.operation_click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DarkGray;
            this.button22.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(267, 448);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(121, 54);
            this.button22.TabIndex = 23;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.operation_click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Green;
            this.update_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_btn.Location = new System.Drawing.Point(12, 523);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(372, 54);
            this.update_btn.TabIndex = 24;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(400, 649);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.equal_btn);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.c_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CE_btn);
            this.Controls.Add(this.history_btn);
            this.Controls.Add(this.lbcurrentop);
            this.Controls.Add(this.tbdisplay);
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbdisplay;
        private System.Windows.Forms.Label lbcurrentop;
        private System.Windows.Forms.Button history_btn;
        private System.Windows.Forms.Button CE_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button c_btn;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button equal_btn;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button update_btn;
    }
}

