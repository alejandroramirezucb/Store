public class inventory
{
    private int stock;
    private product firstProduct;

    public inventory()
    {
        this.firstProduct = null;
        this.stock = 0;
    }
    public int getStock()
    {
        return stock;
    }
    public void setStock(int stock)
    {
        this.stock = stock;
    }
    public bool ifProductIDExists(int productID)
    {
        product auxProduct = firstProduct;
        while (auxProduct != null)
        {
            if (auxProduct.getProductID() == productID)
            {
                return true;
            }
            auxProduct = auxProduct.getNextProduct();
        }
        return false;
    }
    public bool addProduct(string productName, string productBrand, int productBarcode, int productID)
    {
        if (ifProductIDExists(productID))
        {
            Console.WriteLine("ERROR: El ID del Producto ya existe");
            return false;
        }
        else
        {
            product newProduct = new product(productName, productBrand, productBarcode, productID);
            product auxProduct = firstProduct;
            while (auxProduct.getNextProduct() != null)
            {
                auxProduct = auxProduct.getNextProduct();
            }
            newProduct.setNextProduct(firstProduct);
            setStock(getStock() + 1);
            return true;
        }
    }
    public bool delProduct(int productID)
    {
        product auxProduct = firstProduct;
        if (firstProduct == null)
        {
            Console.WriteLine("ERROR: El Producto no existe o el stock esta vacío");
            return false;
        }
        else if (firstProduct.getProductID() == productID)
        {
            firstProduct = firstProduct.getNextProduct();
            return true;
        }
        else
        {
            while (auxProduct.getNextProduct() != null)
            {
                if (auxProduct.getProductID() == productID)
                {
                    auxProduct.setNextProduct(auxProduct.getNextProduct().getNextProduct());
                    return true;
                }
                auxProduct = auxProduct.getNextProduct();
            }
            return false;
        }
    }
}
