namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            Cod = new ColumnHeader();
            Marca = new ColumnHeader();
            Modelo = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            barra = new ToolStripButton();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBoxModelo = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            codigolabel = new Label();
            textBoxCodigo = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Cod, Marca, Modelo });
            listView1.Location = new Point(415, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(203, 205);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Cod
            // 
            Cod.Text = "Cod";
            Cod.Width = 50;
            // 
            // Marca
            // 
            Marca.Text = "Marca";
            // 
            // Modelo
            // 
            Modelo.Text = "Modelo";
            Modelo.Width = 90;
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 142);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 8;
            label1.Text = "Marca";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 185);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 9;
            label2.Text = "Modelo";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 229);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 10;
            label3.Text = "Operadora";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 277);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 11;
            label4.Text = "Sistema Operativo";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.DarkGray;
            toolStrip1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripSeparator1, toolStripButton1, barra });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 40);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "Barra de Ferramentas";
            // 
            // toolStripButton2
            // 
            toolStripButton2.BackColor = Color.Transparent;
            toolStripButton2.Image = Properties.Resources.images1;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(40, 37);
            toolStripButton2.Text = "Novo";
            toolStripButton2.TextAlign = ContentAlignment.BottomCenter;
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 40);
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = Color.Transparent;
            toolStripButton1.Image = Properties.Resources.save_icon_2048x2048_iovw4qr41;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(56, 37);
            toolStripButton1.Text = "Guardar";
            toolStripButton1.TextAlign = ContentAlignment.BottomCenter;
            toolStripButton1.TextDirection = ToolStripTextDirection.Horizontal;
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click_1;
            // 
            // barra
            // 
            barra.BackColor = Color.Transparent;
            barra.Image = Properties.Resources._777051;
            barra.ImageTransparentColor = Color.Magenta;
            barra.Name = "barra";
            barra.Size = new Size(48, 37);
            barra.Text = "Anular";
            barra.TextAlign = ContentAlignment.BottomCenter;
            barra.TextImageRelation = TextImageRelation.ImageAboveText;
            barra.Click += toolStripButton1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Iphone", "Samsung", "Alcatel", "Xiaomi", "BlackBerry", "BlackView", "Nokia", "Vivo", "Oppo", "Nothing Phone", "Huawei" });
            comboBox1.Location = new Point(144, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Meo", "Nos", "Nowo", "Vodafone", "WOO", "LigaT", "Lycamobile" });
            comboBox2.Location = new Point(144, 230);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Windows Mobile", "iOS", "Blackberry OS", "Bada", "Android", "Meego", "Windows Phone" });
            comboBox3.Location = new Point(144, 277);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 15;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(144, 185);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(121, 23);
            textBoxModelo.TabIndex = 16;
            textBoxModelo.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(415, 105);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 17;
            label5.Text = "Listagem";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(55, 357);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Câmera";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(55, 382);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Redes Sociais";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(160, 357);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 19);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "SMS/MMS";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(160, 382);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(66, 19);
            checkBox4.TabIndex = 21;
            checkBox4.Text = "Teclado";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(270, 357);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(49, 19);
            checkBox5.TabIndex = 22;
            checkBox5.Text = "WiFi";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(270, 382);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(78, 19);
            checkBox6.TabIndex = 23;
            checkBox6.Text = "Bluetooth";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // codigolabel
            // 
            codigolabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codigolabel.Location = new Point(65, 105);
            codigolabel.Name = "codigolabel";
            codigolabel.Size = new Size(73, 23);
            codigolabel.TabIndex = 7;
            codigolabel.Text = "Código";
            codigolabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(144, 106);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(121, 23);
            textBoxCodigo.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCodigo);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(textBoxModelo);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(toolStrip1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(codigolabel);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registos 1 || Autor: João Andrade";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStrip toolStrip1;
        private ToolStripButton barra;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBoxModelo;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private Label codigolabel;
        private ToolStripSeparator toolStripSeparator1;
        private TextBox textBoxCodigo;
        private ColumnHeader Cod;
        private ColumnHeader Marca;
        private ColumnHeader Modelo;
    }
}
