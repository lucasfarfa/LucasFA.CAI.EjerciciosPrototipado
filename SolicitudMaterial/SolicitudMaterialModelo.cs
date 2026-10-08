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

            foreach (var det in detalle)
            {
                if (det.IdMaterial == material.Id)
                {
                    det.Cantidad += cantidad;
                    return true;
                }
            }


            detalle.Add(new DetalleSolicitud { IdMaterial = material.Id, Cantidad = cantidad });

            return true; //para indicar que está todo bien
        }

        internal bool EnviarSolicitud(string observaciones)
        {
            //hacer las validaciones, simular los cambios (ej.: baja de stock) etc.

            //si está todo ok...
            detalle.Clear();
            return true;
        }

        //ESTO ESTA MAL: al modelo se le pasan DATOS NO ELEMENTOS DE PANTALLA.
        /*
        internal bool QuitarMaterial(ListViewItem linea)
        {

        }
        */

        internal bool QuitarMaterial(Material material)
        {
            //pueden haber validaciones de negocio X.

            var detalleAEliminar = detalle.FirstOrDefault(d => d.IdMaterial == material.Id);
            detalle.Remove(detalleAEliminar);

            return true;
        }
    }
}
