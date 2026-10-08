namespace LucasFA.CAI.EjerciciosPrototipado
{
    partial class SolicitudMaterialForm
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
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            MaterialCombo = new ComboBox();
            CantidadText = new TextBox();
            AgregarBtn = new Button();
            label6 = new Label();
            MaterialesListView = new ListView();
            CodigoCol = new ColumnHeader();
            MaterialCol = new ColumnHeader();
            UnidadCol = new ColumnHeader();
            CantidadCol = new ColumnHeader();
            label7 = new Label();
            ObservacionesText = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label8 = new Label();
            label9 = new Label();
            QuitarBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 39);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleado: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 66);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Area: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 120);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Material";
            // 
            // MaterialCombo
            // 
            MaterialCombo.FormattingEnabled = true;
            MaterialCombo.Location = new Point(12, 141);
            MaterialCombo.Margin = new Padding(3, 2, 3, 2);
            MaterialCombo.Name = "MaterialCombo";
            MaterialCombo.Size = new Size(356, 23);
            MaterialCombo.TabIndex = 10;
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(374, 141);
            CantidadText.Margin = new Padding(3, 2, 3, 2);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(56, 23);
            CantidadText.TabIndex = 11;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(436, 134);
            AgregarBtn.Margin = new Padding(3, 2, 3, 2);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(82, 34);
            AgregarBtn.TabIndex = 12;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 120);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 13;
            label6.Text = "Cantidad:";
            // 
            // MaterialesListView
            // 
            MaterialesListView.Columns.AddRange(new ColumnHeader[] { CodigoCol, MaterialCol, UnidadCol, CantidadCol });
            MaterialesListView.FullRowSelect = true;
            MaterialesListView.GridLines = true;
            MaterialesListView.Location = new Point(11, 180);
            MaterialesListView.Margin = new Padding(3, 2, 3, 2);
            MaterialesListView.MultiSelect = false;
            MaterialesListView.Name = "MaterialesListView";
            MaterialesListView.Size = new Size(507, 107);
            MaterialesListView.TabIndex = 14;
            MaterialesListView.UseCompatibleStateImageBehavior = false;
            MaterialesListView.View = View.Details;
            // 
            // CodigoCol
            // 
            CodigoCol.Text = "Código";
            CodigoCol.Width = 100;
            // 
            // MaterialCol
            // 
            MaterialCol.Text = "Material";
            MaterialCol.Width = 100;
            // 
            // UnidadCol
            // 
            UnidadCol.Text = "Unidad";
            UnidadCol.Width = 100;
            // 
            // CantidadCol
            // 
            CantidadCol.Text = "Cantidad";
            CantidadCol.TextAlign = HorizontalAlignment.Right;
            CantidadCol.Width = 100;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 366);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 17;
            label7.Text = "Observaciones:";
            // 
            // ObservacionesText
            // 
            ObservacionesText.Location = new Point(10, 383);
            ObservacionesText.Margin = new Padding(3, 2, 3, 2);
            ObservacionesText.Name = "ObservacionesText";
            ObservacionesText.Size = new Size(507, 23);
            ObservacionesText.TabIndex = 18;
            // 
            // button4
            // 
            button4.Location = new Point(264, 484);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(153, 30);
            button4.TabIndex = 19;
            button4.Text = "Enviar Solicitud";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(435, 484);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 30);
            button5.TabIndex = 20;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 39);
            label8.Name = "label8";
            label8.Size = new Size(134, 15);
            label8.TabIndex = 21;
            label8.Text = "[Nombre del empleado]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 66);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 22;
            label9.Text = "[Nombre del area]";
            // 
            // QuitarBtn
            // 
            QuitarBtn.Location = new Point(10, 291);
            QuitarBtn.Margin = new Padding(3, 2, 3, 2);
            QuitarBtn.Name = "QuitarBtn";
            QuitarBtn.Size = new Size(507, 34);
            QuitarBtn.TabIndex = 23;
            QuitarBtn.Text = "Quitar";
            QuitarBtn.UseVisualStyleBackColor = true;
            // 
            // SolicitudMaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 532);
            Controls.Add(QuitarBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(ObservacionesText);
            Controls.Add(label7);
            Controls.Add(MaterialesListView);
            Controls.Add(label6);
            Controls.Add(AgregarBtn);
            Controls.Add(CantidadText);
            Controls.Add(MaterialCombo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SolicitudMaterialForm";
            Text = "SolicitudMaterial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox MaterialCombo;
        private TextBox CantidadText;
        private Button AgregarBtn;
        private Label label6;
        private ListView MaterialesListView;
        private ColumnHeader CodigoCol;
        private ColumnHeader MaterialCol;
        private ColumnHeader UnidadCol;
        private ColumnHeader CantidadCol;
        private Button button3;
        private Label label7;
        private TextBox ObservacionesText;
        private Button button4;
        private Button button5;
        private Label label8;
        private Label label9;
        private Button QuitarBtn;
    }
}
