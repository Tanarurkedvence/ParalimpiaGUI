namespace ParalimpiaGUI
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Orszag = new DataGridViewTextBoxColumn();
            Varos = new DataGridViewTextBoxColumn();
            Ev = new DataGridViewTextBoxColumn();
            Arany = new DataGridViewTextBoxColumn();
            Ezust = new DataGridViewTextBoxColumn();
            Bronz = new DataGridViewTextBoxColumn();
            label2 = new Label();
            kijeloltev_lb = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            modositasijavaslat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(94, 41);
            label1.Name = "label1";
            label1.Size = new Size(264, 21);
            label1.TabIndex = 0;
            label1.Text = "Szűrés ország vagy város alapján:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Orszag, Varos, Ev, Arany, Ezust, Bronz });
            dataGridView1.Location = new Point(55, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(817, 253);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "#";
            Id.Name = "Id";
            // 
            // Orszag
            // 
            Orszag.HeaderText = "rendező ország";
            Orszag.Name = "Orszag";
            // 
            // Varos
            // 
            Varos.HeaderText = "helyszín";
            Varos.Name = "Varos";
            // 
            // Ev
            // 
            Ev.HeaderText = "év";
            Ev.Name = "Ev";
            // 
            // Arany
            // 
            Arany.HeaderText = "arany";
            Arany.Name = "Arany";
            // 
            // Ezust
            // 
            Ezust.HeaderText = "ezüst";
            Ezust.Name = "Ezust";
            // 
            // Bronz
            // 
            Bronz.HeaderText = "bronz";
            Bronz.Name = "Bronz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 425);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "kijelölt év:";
            // 
            // kijeloltev_lb
            // 
            kijeloltev_lb.AutoSize = true;
            kijeloltev_lb.Location = new Point(208, 425);
            kijeloltev_lb.Name = "kijeloltev_lb";
            kijeloltev_lb.Size = new Size(35, 15);
            kijeloltev_lb.TabIndex = 4;
            kijeloltev_lb.Text = "####";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 417);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(25, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(407, 417);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(25, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(476, 417);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(25, 23);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(323, 357);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "arany";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(398, 357);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "ezüst";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(476, 357);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "bronz";
            // 
            // modositasijavaslat
            // 
            modositasijavaslat.Location = new Point(615, 384);
            modositasijavaslat.Name = "modositasijavaslat";
            modositasijavaslat.Size = new Size(244, 56);
            modositasijavaslat.TabIndex = 11;
            modositasijavaslat.Text = "módosítási javaslat";
            modositasijavaslat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 495);
            Controls.Add(modositasijavaslat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(kijeloltev_lb);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Orszag;
        private DataGridViewTextBoxColumn Varos;
        private DataGridViewTextBoxColumn Ev;
        private DataGridViewTextBoxColumn Arany;
        private DataGridViewTextBoxColumn Ezust;
        private DataGridViewTextBoxColumn Bronz;
        private Label label2;
        private Label kijeloltev_lb;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button modositasijavaslat;
    }
}
