public class console
{
    private int option;

    public console()
    {

    }
    public void login()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------Bienvenido-----------------------------------\n");
        Console.WriteLine("1. Iniciar Sesion como Administrador " +
                          "| 2. Iniciar Sesion como Cliente " +
                          "| 3. Salir\n");
        Console.Write("Opcion: ");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                adminMenu();
                break;
            case 2:
                break;
            default:
                break;
        }
    }
    public void adminMenu()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------------Menu-------------------------------------------------------\n");
        Console.WriteLine("1. Gestion de Inventario " +
                          "| 2. Ver Inventario " +
                          "| 3. Gestion de Usuarios " +
                          "| 4. Ver Usuarios | 5. Reportes " +
                          "| 6. Regresar\n");
        Console.Write("Opcion: ");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                inventoryManagement();
                break;
            case 2:
                viewInventory();
                break;
            case 3:
                userManagement();
                break;
            case 4:
                viewUsers();
                break;
            case 5:
                login();
                break;
            default:
                break;
        }
    }
    public void inventoryManagement()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------Gestion de Inventario----------------------------------\n");
        Console.WriteLine("1. Agregar Producto | 2. Eliminar Producto " +
                          "| 3. Crear Categoria | 4. Eliminar Categoria\n" +
                          "5. Asociar Producto con Categoria | 6. Aumentar Stock " +
                          "| 7. Reducir Stock | 8. Regresar\n");
        Console.Write("Opcion: ");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Write("Nombre del Producto : ");
                string productName = Console.ReadLine();
                Console.Write("Marca del Producto : ");
                string productBrand = Console.ReadLine();
                Console.Write("ID del Producto : ");
                int productID = int.Parse(Console.ReadLine());
                Console.Write("Codigo de Barras del Producto : ");
                int productBarcode = int.Parse(Console.ReadLine());
                productType auxProductType = new productType(productName, productBrand, productBarcode);
                auxProductType.addProduct(productID);
                break;
            case 2:
                //delProductType();
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                adminMenu();
                break;
            default:
                break;
        }
    }
    public void viewInventory()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------Ver Inventario-------------------------------------------\n");
        Console.WriteLine("1. Tabla de Productos | 2. Tabla de Categorias " +
                          "| 3. Tabla de productos de una Categoria " +
                          "| 4. Regresar\n");
        Console.Write("Opcion: ");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                adminMenu();
                break;
            default:
                break;
        }
    }
    public void userManagement()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------Gestion de Usuarios--------------------------------\n");
        Console.WriteLine("1. Agregar Usuario | 2. Eliminar Usuario " +
                          "| 3. Cambiar Rango de Usuario " +
                          "| 4. Regresar\n");
        Console.Write("Opcion: ");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                adminMenu();
                break;
            default:
                break;
        }
    }
    public void viewUsers()
    {
        Console.Clear();
        Console.WriteLine("-------------------------Ver Usuarios-------------------------\n");
        Console.WriteLine("1. Tabla de Administradores| 2. Tabla de Clientes " +
                          "| 3 Regresar\n");
        Console.Write("Opcion: ");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                adminMenu();
                break;
            default:
                break;
        }
    }
}
