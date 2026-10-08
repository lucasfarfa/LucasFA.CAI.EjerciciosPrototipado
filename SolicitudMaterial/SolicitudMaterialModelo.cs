namespace LucasFA.CAI.EjerciciosPrototipado.Ej1OfiCentral.SolicitudMaterial
{
    internal class SolicitudMaterialModelo
    {
        public string NombreEmpleado { get; } = "Juan Pérez";
        public string NombreArea { get; } = "Administración y finanzas";

        public List<Material> Materiales { get; } = new List<Material>
        {
            new Material { Id = 1, Nombre = "Lápiz" },
            new Material { Id = 2, Nombre = "Cuaderno" },
            new Material { Id = 3, Nombre = "Resma de papel" }
        };
    }
}
