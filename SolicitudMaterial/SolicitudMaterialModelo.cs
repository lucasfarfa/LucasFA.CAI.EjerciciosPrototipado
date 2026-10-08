namespace LucasFA.CAI.EjerciciosPrototipado.Ej1OfiCentral.SolicitudMaterial
{
    internal class SolicitudMaterialModelo
    {
        private List<DetalleSolicitud> detalle = new();

        public string NombreEmpleado { get; } = "Juan Pérez";
        public string NombreArea { get; } = "Administración y finanzas";

        public List<Material> Materiales { get; } = new List<Material>
        {
            new Material { Id = 1, Nombre = "Lápiz", Unidad = "unidad" },
            new Material { Id = 2, Nombre = "Cuaderno", Unidad = "unidad" },
            new Material { Id = 3, Nombre = "Resma de papel", Unidad = "resma" }
        };

        internal bool AgregarMaterial(Material material, int cantidad)
        {
            //material no necesita validarse pq el usuario no interviene ni lo modifica.


            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //aca pueden ir otras validaciones de negocio.
            //....

            detalle.Add(new DetalleSolicitud { IdMaterial = material.Id, Cantidad = cantidad });
        }
    }
}
