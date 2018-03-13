namespace CW5_Bonus
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
            this.gbxPropertyPinBoard = new System.Windows.Forms.GroupBox();
            this.btnCreatPinBoard = new System.Windows.Forms.Button();
            this.txtYInterval = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.txtXInterval = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCoord = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxPinBoard = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.txtTriMessage = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxPropertyPinBoard.SuspendLayout();
            this.gbxCoord.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPropertyPinBoard
            // 
            this.gbxPropertyPinBoard.Controls.Add(this.btnCreatPinBoard);
            this.gbxPropertyPinBoard.Controls.Add(this.txtYInterval);
            this.gbxPropertyPinBoard.Controls.Add(this.txtCols);
            this.gbxPropertyPinBoard.Controls.Add(this.txtXInterval);
            this.gbxPropertyPinBoard.Controls.Add(this.txtRows);
            this.gbxPropertyPinBoard.Controls.Add(this.label4);
            this.gbxPropertyPinBoard.Controls.Add(this.label3);
            this.gbxPropertyPinBoard.Controls.Add(this.label2);
            this.gbxPropertyPinBoard.Controls.Add(this.label1);
            this.gbxPropertyPinBoard.Location = new System.Drawing.Point(13, 13);
            this.gbxPropertyPinBoard.Name = "gbxPropertyPinBoard";
            this.gbxPropertyPinBoard.Size = new System.Drawing.Size(390, 159);
            this.gbxPropertyPinBoard.TabIndex = 2;
            this.gbxPropertyPinBoard.TabStop = false;
            this.gbxPropertyPinBoard.Text = "Properties of PinBoard";
            // 
            // btnCreatPinBoard
            // 
            this.btnCreatPinBoard.Location = new System.Drawing.Point(278, 124);
            this.btnCreatPinBoard.Name = "btnCreatPinBoard";
            this.btnCreatPinBoard.Size = new System.Drawing.Size(105, 26);
            this.btnCreatPinBoard.TabIndex = 23;
            this.btnCreatPinBoard.Text = "Creat PinBoard";
            this.btnCreatPinBoard.UseVisualStyleBackColor = true;
            this.btnCreatPinBoard.Click += new System.EventHandler(this.btnCreatPinBoard_Click);
            // 
            // txtYInterval
            // 
            this.txtYInterval.Location = new System.Drawing.Point(250, 91);
            this.txtYInterval.Name = "txtYInterval";
            this.txtYInterval.Size = new System.Drawing.Size(100, 22);
            this.txtYInterval.TabIndex = 7;
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(250, 41);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(100, 22);
            this.txtCols.TabIndex = 6;
            // 
            // txtXInterval
            // 
            this.txtXInterval.Location = new System.Drawing.Point(76, 91);
            this.txtXInterval.Name = "txtXInterval";
            this.txtXInterval.Size = new System.Drawing.Size(100, 22);
            this.txtXInterval.TabIndex = 5;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(76, 41);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 22);
            this.txtRows.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cols";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "YInterval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "XInterval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // gbxCoord
            // 
            this.gbxCoord.Controls.Add(this.btnCalculate);
            this.gbxCoord.Controls.Add(this.label7);
            this.gbxCoord.Controls.Add(this.label8);
            this.gbxCoord.Controls.Add(this.label6);
            this.gbxCoord.Controls.Add(this.label5);
            this.gbxCoord.Location = new System.Drawing.Point(13, 187);
            this.gbxCoord.Name = "gbxCoord";
            this.gbxCoord.Size = new System.Drawing.Size(390, 281);
            this.gbxCoord.TabIndex = 3;
            this.gbxCoord.TabStop = false;
            this.gbxCoord.Text = "Coordinates of Points";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(240, 232);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 26);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cols";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rows";
            // 
            // gbxPinBoard
            // 
            this.gbxPinBoard.Location = new System.Drawing.Point(427, 13);
            this.gbxPinBoard.Name = "gbxPinBoard";
            this.gbxPinBoard.Size = new System.Drawing.Size(480, 232);
            this.gbxPinBoard.TabIndex = 4;
            this.gbxPinBoard.TabStop = false;
            this.gbxPinBoard.Text = "Visualization of PinBoard";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(427, 252);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtTriMessage
            // 
            this.txtTriMessage.Location = new System.Drawing.Point(427, 308);
            this.txtTriMessage.Multiline = true;
            this.txtTriMessage.Name = "txtTriMessage";
            this.txtTriMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTriMessage.Size = new System.Drawing.Size(371, 135);
            this.txtTriMessage.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(814, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 493);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTriMessage);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.gbxPinBoard);
            this.Controls.Add(this.gbxCoord);
            this.Controls.Add(this.gbxPropertyPinBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxPropertyPinBoard.ResumeLayout(false);
            this.gbxPropertyPinBoard.PerformLayout();
            this.gbxCoord.ResumeLayout(false);
            this.gbxCoord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxPropertyPinBoard;
        private System.Windows.Forms.TextBox txtYInterval;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.TextBox txtXInterval;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCoord;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxPinBoard;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox txtTriMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreatPinBoard;
    }
}

