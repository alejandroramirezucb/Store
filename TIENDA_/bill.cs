using System.Security.Cryptography.X509Certificates;

public class bill
{
    private int userActualID;
    private string userActualName;
    private DateTime date;
    private string paymentMethod;
    private string productIDs;
    private cart cart;

    public bill(int userActualID, string userActualName, DateTime date, string paymentMethod, cart cart)
    {
        this.userActualID = userActualID;
        this.userActualName = userActualName;
        this.date = date;
        this.paymentMethod = paymentMethod;
        this.cart = cart;
        this.productIDs = cart.getProductsIDsString();
    }
    public void printBill()
    {
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" {0,-10} | {1,-20} | {2,-15} | {3,-15} | {4,-20} ",
                          "ID", "Nombre del Comprador", "Metodo de Pago", "Fecha", "Numero de Productos Comprados");
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" {0,-10} | {1,-20} | {2,-15} | {3,-15} | {4,-20} ",
                                      userActualID,
                                      userActualName,
                                      paymentMethod,
                                      date,
                                      cart.getStockCart());
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine("IDs de productos comprados: " + productIDs);
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
    }
}
