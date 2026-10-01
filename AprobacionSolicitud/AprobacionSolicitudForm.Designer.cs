namespace LucasFA.CAI.EjerciciosPrototipado.Ej1OfiCentral.AprobacionSolicitud
{
    partial class AprobacionSolicitudForm
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
            SolicitudesPendientes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label3 = new Label();
            SolicitudSeleccionada = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
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
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "Aprobación de Solicitudes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 1;
            label2.Text = "Solicitudes Pendientes";
            // 
            // SolicitudesPendientes
            // 
            SolicitudesPendientes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            SolicitudesPendientes.Location = new Point(12, 89);
            SolicitudesPendientes.Name = "SolicitudesPendientes";
            SolicitudesPendientes.Size = new Size(500, 90);
            SolicitudesPendientes.TabIndex = 2;
            SolicitudesPendientes.UseCompatibleStateImageBehavior = false;
            SolicitudesPendientes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° Solicitud";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Fecha";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Empleado";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cant. Items";
            columnHeader4.Width = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(211, 20);
            label3.TabIndex = 3;
            label3.Text = "Detalle Solicitud Seleccionada";
            // 
            // SolicitudSeleccionada
            // 
            SolicitudSeleccionada.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            SolicitudSeleccionada.Location = new Point(12, 226);
            SolicitudSeleccionada.Name = "SolicitudSeleccionada";
            SolicitudSeleccionada.Size = new Size(500, 90);
            SolicitudSeleccionada.TabIndex = 4;
            SolicitudSeleccionada.UseCompatibleStateImageBehavior = false;
            SolicitudSeleccionada.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Codigo";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Material";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Unidad";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Cantidad";
            columnHeader8.Width = 100;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ControlText;
            radioButton1.Location = new Point(552, 237);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Aprobar";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ControlText;
            radioButton2.Location = new Point(552, 277);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Rechazar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 342);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 7;
            label4.Text = "Motivo Rechazo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 27);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(499, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(613, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // AprobacionSolicitudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(SolicitudSeleccionada);
            Controls.Add(label3);
            Controls.Add(SolicitudesPendientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AprobacionSolicitudForm";
            Text = "AprobacionSolicitudForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView SolicitudesPendientes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label3;
        private ListView SolicitudSeleccionada;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}