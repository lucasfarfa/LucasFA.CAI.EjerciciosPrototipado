namespace LucasFA.CAI.EjerciciosPrototipado.Ej1OfiCentral.GeneracionOrdenDeCompra
{
    partial class GeneracionOrdenCompraForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            SolcitudesAprobadasPendientesOC = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            listView1 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            label7 = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 0;
            label1.Text = "Generación de Orden de Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(297, 20);
            label2.TabIndex = 1;
            label2.Text = "Solicitudes aprobadas pendientes de orden";
            // 
            // SolcitudesAprobadasPendientesOC
            // 
            SolcitudesAprobadasPendientesOC.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            SolcitudesAprobadasPendientesOC.Location = new Point(12, 89);
            SolcitudesAprobadasPendientesOC.Name = "SolcitudesAprobadasPendientesOC";
            SolcitudesAprobadasPendientesOC.Size = new Size(404, 121);
            SolcitudesAprobadasPendientesOC.TabIndex = 2;
            SolcitudesAprobadasPendientesOC.UseCompatibleStateImageBehavior = false;
            SolcitudesAprobadasPendientesOC.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Solicitud";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Fecha";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Área";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Empleado";
            columnHeader4.Width = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 236);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 3;
            label3.Text = "Nro de Orden:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 239);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(376, 236);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 294);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 7;
            label5.Text = "Proveedor:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 294);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 356);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 9;
            label6.Text = "Items de la Orden";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.Location = new Point(12, 379);
            listView1.Name = "listView1";
            listView1.Size = new Size(404, 121);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Material";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Cantidad";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Precio unitario";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Subtotal";
            columnHeader8.Width = 100;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(450, 473);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 450);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 12;
            label7.Text = "Total:";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(397, 568);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Generar OC";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(507, 568);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // GeneracionOrdenCompraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(SolcitudesAprobadasPendientesOC);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GeneracionOrdenCompraForm";
            Text = "GeneracionOrdenCompraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView SolcitudesAprobadasPendientesOC;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private ListView listView1;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
        private Label label7;
        private ContextMenuStrip contextMenuStrip2;
        private Button button1;
        private Button button2;
    }
}