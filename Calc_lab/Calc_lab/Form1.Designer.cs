namespace Calc_lab
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
            this.inputField = new System.Windows.Forms.TextBox();
            this.buttonSub = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.prevNumber = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputField.Location = new System.Drawing.Point(56, 84);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(258, 38);
            this.inputField.TabIndex = 0;
            this.inputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSub.Location = new System.Drawing.Point(279, 324);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(60, 53);
            this.buttonSub.TabIndex = 12;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.operator_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button9.Location = new System.Drawing.Point(198, 206);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 53);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button8.Location = new System.Drawing.Point(117, 206);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 53);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button7.Location = new System.Drawing.Point(36, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 53);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonAdd.Location = new System.Drawing.Point(279, 379);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 54);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonDiv.Location = new System.Drawing.Point(279, 206);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(60, 53);
            this.buttonDiv.TabIndex = 20;
            this.buttonDiv.Text = "%";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.operator_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(198, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 53);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(117, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 53);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(36, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonMult.Location = new System.Drawing.Point(279, 265);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(60, 53);
            this.buttonMult.TabIndex = 24;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.operator_click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button6.Location = new System.Drawing.Point(198, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 53);
            this.button6.TabIndex = 23;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.Location = new System.Drawing.Point(117, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 53);
            this.button5.TabIndex = 22;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.Location = new System.Drawing.Point(36, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 53);
            this.button4.TabIndex = 21;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonCalc.Location = new System.Drawing.Point(198, 147);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(141, 54);
            this.buttonCalc.TabIndex = 25;
            this.buttonCalc.Text = "=";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonBackSpace.Location = new System.Drawing.Point(117, 147);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(60, 53);
            this.buttonBackSpace.TabIndex = 27;
            this.buttonBackSpace.Text = "C";
            this.buttonBackSpace.UseVisualStyleBackColor = true;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonClearAll.Location = new System.Drawing.Point(36, 146);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(60, 53);
            this.buttonClearAll.TabIndex = 26;
            this.buttonClearAll.Text = "CE";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonDec.Location = new System.Drawing.Point(198, 379);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(60, 54);
            this.buttonDec.TabIndex = 28;
            this.buttonDec.Text = ",";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.button_Click);
            // 
            // prevNumber
            // 
            this.prevNumber.AutoSize = true;
            this.prevNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prevNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.prevNumber.ForeColor = System.Drawing.Color.DimGray;
            this.prevNumber.Location = new System.Drawing.Point(58, 46);
            this.prevNumber.Name = "prevNumber";
            this.prevNumber.Size = new System.Drawing.Size(0, 25);
            this.prevNumber.TabIndex = 29;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button0.Location = new System.Drawing.Point(36, 379);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(141, 54);
            this.button0.TabIndex = 30;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "C:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.prevNumber);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonBackSpace);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.inputField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Label prevNumber;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label label1;
    }
}

