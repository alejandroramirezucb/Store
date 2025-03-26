public class sale
{
    private int userActualID;
    private string userActualName;
    private DateTime date;
    private cart cart;

    public sale (int userActual, string userActualName, cart cart)
    {
        this.userActualID = userActual;
        this.userActualName = userActualName;
        this.date = DateTime.Now;
        this.cart = cart;
    }
    public int getUserActualID()
    {
        return userActualID;
    }
    public void setUserActualID(int userActual)
    {
        this.userActualID = userActual;
    }
    public string getUserActualName()
    {
        return userActualName;
    }
    public void setUserActualName(string userActualName)
    {
        this.userActualName = userActualName;
    }
    public DateTime getDate()
    {
        return date;
    }
    public bool buy()
    {
        pay pay = new pay();
        Console.WriteLine("Metodos de Pago: 1. Credito | 2. Debito | 3. Efectivo\n");
        Console.Write("Opcion: ");
        if (int.TryParse(Console.ReadLine(), out int paymentMethod))
        {
            string productIDs = cart.getProductsIDsString();
            switch (paymentMethod)
            {
                case 1:
                    pay.setCredit(true);
                    bill newBill = new bill(userActualID, userActualName, date, "Credito", cart);
                    cart.cartSold();
                    report.addReport($"{userActualID} | {date} | Credito | {cart.getStockCart()} | {productIDs}");
                    newBill.printBill();
                    Console.ReadKey();
                    return true;
                case 2:
                    pay.setDebit(true);
                    newBill = new bill(userActualID, userActualName, date, "Debito", cart);
                    cart.cartSold();
                    report.addReport($"{userActualID} | {date} | Debito | {cart.getStockCart()} | {productIDs}");
                    newBill.printBill();
                    Console.ReadKey();
                    return true;
                case 3:
                    pay.setCash(true);
                    newBill = new bill(userActualID, userActualName, date, "Efectivo", cart);
                    cart.cartSold();
                    report.addReport($"{userActualID} | {date} | Efectivo | {cart.getStockCart()} | {productIDs}");
                    newBill.printBill();
                    Console.ReadKey();
                    return true;
                default:
                    Console.WriteLine("ERROR: Opcion no valida");
                    Console.ReadKey();
                    return false;
            }
        }
        else
        {
            Console.WriteLine("ERROR: Entrada invalida");
            Console.ReadKey();
            return false;
        }
    }
}