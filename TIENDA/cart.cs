using System.Data;

public class cart
{
    private int userID;
    private int stockCart;
    private List<int> productsInCart;
    private inventory listInventory;

    public cart(inventory listInventory)
    {
        this.stockCart = 0;
        this.productsInCart = new List<int>();
        this.listInventory = listInventory;
    }
    public int getUserID()
    {
        return userID;
    }
    public void setUserID(int userID)
    {
        this.userID = userID;
    }
    public int getStockCart() {
        return stockCart;
    }
    public void setStockCart(int stockCart)
    {
        this.stockCart = stockCart;
    }
    /*public void returnMyCart()
    {
        product auxProduct = listInventory.getFirstProduct();
        if (auxProduct != null)
        {
            Console.WriteLine("ERROR: No hay productos disponibles en el inventario");
        }
        else
        {
            for(int i = 0; i < productsInCart.Count; ++i)
            {
                auxProduct = listInventory.getFirstProduct();
                while (auxProduct != null)
                {
                    if (productsInCart[i] == auxProduct.getProductID() && auxProduct.getInCart() == true)
                    {
                       
                    }
                    auxProduct = auxProduct.getNextProduct();
                }
            }
        }
    }*/
    public bool ifProductExitsInCart(int productID)
    {
        for (int i = 0; i < productsInCart.Count; ++i)
        {
            if (productsInCart[i] == productID)
            {
                return true;
            }
        }
        return false;
    }
    public bool addProductInCart(int productID)
    {
        product auxProduct = listInventory.getFirstProduct();
        if (auxProduct == null)
        {
            Console.WriteLine("ERROR: No hay productos disponibles en el inventario");
            return false;
        }
        if (ifProductExitsInCart(productID) == true)
        {
            Console.WriteLine($"ERROR: El producto con el ID \"{productID}\" ya se encuentra en el carrito");
            return false;
        }
        else
        {
            while (auxProduct != null)
            {
                if (auxProduct.getProductID() == productID)
                {
                    productsInCart.Add(productID);
                    auxProduct.setInCart(true);
                    setStockCart(getStockCart() + 1);
                    return true;
                }

            }
            Console.WriteLine($"ERROR: El producto con el ID \"{productID}\" no existe");
            return false;
        }
    }
    public bool delProductInCart(int productID)
    {
        if (ifProductExitsInCart(productID) == false)
        {
            Console.WriteLine($"ERROR: El producto con el ID \"{productID}\" no se encuentra en el carrito");
            return false;
        }
        else
        {
            product auxProduct = listInventory.getFirstProduct();
            if (auxProduct == null)
            {
                Console.WriteLine("ERROR: No hay productos disponibles en el inventario");
                return false;
            }
            else
            {
                while (auxProduct != null)
                {
                    if (auxProduct.getProductID() == productID)
                    {
                        auxProduct.setInCart(false);
                        productsInCart.Remove(productID);
                        setStockCart(getStockCart() - 1);
                        return true;
                    }
                }
                Console.WriteLine($"ERROR: El producto con el ID \"{productID}\" no se encuentra en el carrito");
                return false;
            }
        }
    }
    public void printProductsbyCart()
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" {0,-10} | {1,-20} | {2,-15} | {3,-15} | {4,-20} | {5, -10} ",
                          "ID", "Nombre", "Marca", "Categoria", "Codigo de Barras", "Stock");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        for (int i = 0; i < productsInCart.Count; ++i)
        {
            product auxProduct = listInventory.getFirstProduct();
            while (auxProduct != null)
            {
                if (productsInCart[i] == auxProduct.getProductID() && auxProduct.getSold() == false && auxProduct.getInCart() == true)
                {
                    Console.WriteLine(" {0,-10} | {1,-20} | {2,-15} | {3,-15} | {4,-20} | {5, -10} ",
                                      listInventory.getProductIDs(auxProduct.getProductName()),
                                      auxProduct.getProductName(),
                                      auxProduct.getProductBrand(),
                                      auxProduct.getProductCategory(),
                                      auxProduct.getProductBarcode(),
                                      listInventory.getStockProduct(auxProduct.getProductName()));
                    break;
                }
                auxProduct = auxProduct.getNextProduct();
            }
        }
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
    }
}