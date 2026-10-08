namespace LucasFA.CAI.EjerciciosPrototipado.Ej1OfiCentral.ConfirmacionRecepcion
{
    partial class ConfirmacionRecepcionForm
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
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 0;
            label1.Text = "Entregas pendientes de confirmación";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(12, 50);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 121);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° Solicitud";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Fecha de Solicitud";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha de Entrega";
            columnHeader3.Width = 160;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            listView2.Location = new Point(12, 207);
            listView2.Name = "listView2";
            listView2.Size = new Size(776, 121);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Material";
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Cantidad entregada";
            columnHeader5.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 184);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Detalle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 348);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha Recepcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 381);
            label4.Name = "label4";
            label4.Size = new Size(180, 20);
            label4.TabIndex = 5;
            label4.Text = "Conforme / No conforme:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 443);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 6;
            label5.Text = "Detalle de faltantes";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(208, 381);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Conforme";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(331, 381);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(118, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "No conforme";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(199, 348);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 443);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(504, 486);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 11;
            button1.Text = "Confirmar recepcion";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(679, 486);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ConfirmacionRecepcionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "ConfirmacionRecepcionForm";
            Text = "ConfirmacionRecepcionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}