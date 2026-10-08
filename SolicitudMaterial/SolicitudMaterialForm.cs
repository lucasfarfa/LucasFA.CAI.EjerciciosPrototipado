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

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            //if(algo esta mal)
            //{
            //  error
            //  salgo
            //}
            //

            if (this.MaterialCombo.SelectedItem is not Material material)
            {
                MessageBox.Show("Debe seleccionar un material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(this.CantidadText.Text, out int cantidad))
            {
                MessageBox.Show("Debe ingresar una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //NO VOY A VALIDAR NADA MÁS QUE LO NECESARIO. EJEMPLO: cantidad es positivo? Acá no importa.

            //le pido al modelo que "intente" agregar el material y devuelva ok si pudo hacerlo.
            bool estaOk = _modelo.AgregarMaterial(material, cantidad);
            if (!estaOk)
            {
                return;
            }

            //Agregar el material a la lista.

            var nuevoItem = new ListViewItem();
            nuevoItem.Text = material.Id.ToString();
            nuevoItem.SubItems.Add(material.Nombre);
            nuevoItem.SubItems.Add(material.Unidad);
            nuevoItem.SubItems.Add(cantidad.ToString());
            nuevoItem.Tag = material; // Guardar el objeto material en la propiedad Tag del ListViewItem
            this.MaterialesListView.Items.Add(nuevoItem);


        }
    }
}
