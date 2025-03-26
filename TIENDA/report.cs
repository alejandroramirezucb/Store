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
        Console.WriteLine("-------------------------Reportes de Ventas-------------------------\n");
        if (listReports.Count == 0)
        {
            Console.WriteLine("ERROR: No hay reportes disponibles");
        }
        else
        {
            foreach (string report in listReports)
            {
                Console.WriteLine(report);
            }
        }
        Console.ReadKey();
    }
}
