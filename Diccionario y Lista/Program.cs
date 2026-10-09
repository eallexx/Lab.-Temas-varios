namespace Diccionario_y_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> datosInventario = new Dictionary<string, object>{
    

        {"Nombre", "Laptop HP envy"},
        {"Precio", 850.99m},
        {"Cantidad", 15}
        };

            var setParts = new List<string>();
            foreach (var key in datosInventario.Keys)
            {
                setParts.Add($"{key} = @{key}");
            }
            string setClause = string.Join(", ", setParts);

            //imprimimos el retusltado en consola para verificar cómo se armó
            //Console.Writeline($"Tabla destino: {tbName}")
            Console.WriteLine($"Cláusula SET generada: {setClause}");




            var columns = string.Join(", ", datosInventario.Keys);
            var placeholders = "@" + string.Join(", @", datosInventario.Keys);

            string sql = $"INSERT INTO productos ({columns}) VALUES ({placeholders})";

            Console.WriteLine($"La cadena sql es: {sql} ");
        }
    }
}
