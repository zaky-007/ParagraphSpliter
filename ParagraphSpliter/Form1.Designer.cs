namespace ParagraphSpliter
{
    partial class Form1
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
            inputTxt = new System.Windows.Forms.TextBox();
            outPutTxt = new System.Windows.Forms.TextBox();
            filterTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // inputTxt
            // 
            inputTxt.AllowDrop = true;
            inputTxt.Location = new System.Drawing.Point(12, 12);
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new System.Drawing.Size(239, 23);
            inputTxt.TabIndex = 0;
            inputTxt.DragDrop += inputTxt_DragDrop;
            inputTxt.DragEnter += inputTxt_DragEnter;
            // 
            // outPutTxt
            // 
            outPutTxt.AllowDrop = true;
            outPutTxt.Location = new System.Drawing.Point(12, 41);
            outPutTxt.Name = "outPutTxt";
            outPutTxt.Size = new System.Drawing.Size(239, 23);
            outPutTxt.TabIndex = 1;
            outPutTxt.DragDrop += outPutTxt_DragDrop;
            outPutTxt.DragEnter += outPutTxt_DragEnter;
            // 
            // filterTxt
            // 
            filterTxt.AllowDrop = true;
            filterTxt.Location = new System.Drawing.Point(12, 70);
            filterTxt.Name = "filterTxt";
            filterTxt.Size = new System.Drawing.Size(239, 23);
            filterTxt.TabIndex = 2;
            filterTxt.DragDrop += filterTxt_DragDrop;
            filterTxt.DragEnter += filterTxt_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(257, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(257, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(257, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Filter";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(257, 108);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(351, 142);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(filterTxt);
            Controls.Add(outPutTxt);
            Controls.Add(inputTxt);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.TextBox outPutTxt;
        private System.Windows.Forms.TextBox filterTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
