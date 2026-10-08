using LucasFA.CAI.EjerciciosPrototipado.Ej1OfiCentral.SolicitudMaterial;

namespace LucasFA.CAI.EjerciciosPrototipado
{
    public partial class SolicitudMaterialForm : Form
    {
        private SolicitudMaterialModelo _modelo = new();

        public SolicitudMaterialForm()
        {
            InitializeComponent();
        }

        private void SolicitudMaterialForm_Load(object sender, EventArgs e)
        {
            this.NombreEmpleadoLabel.Text = _modelo.NombreEmpleado;
            this.NombreAreaLabel.Text = _modelo.NombreArea;

            this.MaterialCombo.DisplayMember = "Nombre";
            this.MaterialCombo.ValueMember = "Id";
            foreach (var material in _modelo.Materiales)
            {
                this.MaterialCombo.Items.Add(material);
            }
        }
    }
}
