namespace LucasFA.CAI.EjerciciosPrototipado.Ej1OfiCentral.RegistroEntrega
{
    partial class RegistroEntregaForm
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
            label2 = new Label();
            SolicitudesParaEntrega = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
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
            label1.Size = new Size(234, 20);
            label1.TabIndex = 0;
            label1.Text = "Registro de Entrega de Materiales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(276, 20);
            label2.TabIndex = 1;
            label2.Text = "Solicitudes con materiales para entregar";
            label2.Click += label2_Click;
            // 
            // SolicitudesParaEntrega
            // 
            SolicitudesParaEntrega.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            SolicitudesParaEntrega.Location = new Point(12, 89);
            SolicitudesParaEntrega.Name = "SolicitudesParaEntrega";
            SolicitudesParaEntrega.Size = new Size(776, 121);
            SolicitudesParaEntrega.TabIndex = 2;
            SolicitudesParaEntrega.UseCompatibleStateImageBehavior = false;
            SolicitudesParaEntrega.View = View.Details;
            SolicitudesParaEntrega.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Solicitud";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Empleado";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Area";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha de Orden";
            columnHeader4.Width = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 247);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Entrega:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 288);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 5;
            label4.Text = "Entregado por transportista:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(513, 392);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 7;
            button1.Text = "Registrar Entrega";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(660, 392);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // RegistroEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(SolicitudesParaEntrega);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroEntregaForm";
            Text = "RegistroEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView SolicitudesParaEntrega;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}