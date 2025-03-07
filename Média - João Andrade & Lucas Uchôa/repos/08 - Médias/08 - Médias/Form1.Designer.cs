namespace _08___Médias
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 9.75F);
            label1.Location = new Point(84, 59);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 0;
            label1.Text = "Digite os números:";
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 0;
            label2.Text = "Média";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 32);
            label3.Name = "label3";
            label3.Size = new Size(208, 23);
            label3.TabIndex = 1;
            label3.Text = "João Andrade e Lucas Uchôa";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Tahoma", 9.75F);
            button1.Location = new Point(84, 86);
            button1.Name = "button1";
            button1.Size = new Size(230, 28);
            button1.TabIndex = 3;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 117);
            label4.Name = "label4";
            label4.Size = new Size(230, 154);
            label4.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Tahoma", 9.75F);
            button2.Location = new Point(320, 178);
            button2.Name = "button2";
            button2.Size = new Size(103, 42);
            button2.TabIndex = 5;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(320, 142);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(320, 114);
            label6.Name = "label6";
            label6.Size = new Size(103, 18);
            label6.TabIndex = 7;
            label6.Text = "Média";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Tahoma", 9.75F);
            button3.Location = new Point(320, 226);
            button3.Name = "button3";
            button3.Size = new Size(103, 42);
            button3.TabIndex = 8;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(431, 280);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Button button3;
    }
}
