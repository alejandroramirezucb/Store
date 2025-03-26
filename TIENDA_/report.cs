public static class report
{
    private static List<string> listReports = new List<string>();

    public static void addReport(string report)
    {
        listReports.Add(report);
    }
    public static void printReports()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------------Reportes de Ventas--------------------------------------------------------------\n");
        Console.WriteLine("                                                 1. Regresar\n");
        if (listReports.Count == 0)
        {
            Console.WriteLine("ERROR: No hay reportes disponibles");
            Console.ReadKey();  
            return;
        }
        else
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" {0,-10} | {1,-20} | {2,-15} | {3,-20} | {4,-10} ",
                          "ID del Usuario", "Fecha", "Metodo de Pago", "Numero de Productos Comprados", "IDs de los productos comprados");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
            foreach (string report in listReports)
            {
                Console.WriteLine(report);
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
            }
            Console.ReadKey();
        }
    }

}
