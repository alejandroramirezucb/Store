public class productType
{
    private String productName;
    private String productBrand;
    private String productCategory;
    private int productBarcode;
    private int stock;
    private productType nextProductType;
    private product top;

    public productType(String productName, String productBrand, int productBarcode)
    {
        this.productName = productName;
        this.productBrand = productBrand;
        this.productCategory = "Sin categoria";
        this.productBarcode = productBarcode;
        this.top = null;
        this.nextProductType = null;
        this.stock = 0;
    }
    public string getProductName()
    {
        return productName;
    }
    public void setProductName(String productName)
    {
        this.productName = productName;
    }
    public string getProductBrand()
    {
        return productBrand;
    }
    public void setProductBrand(String productBrand)
    {
        this.productBrand = productBrand;
    }
    public string getProductCategory()
    {
        return productCategory;
    }
    public void setProductCategory(String productCategory)
    {
        this.productCategory = productCategory;
    }
    public int getProductBarcode()
    {
        return productBarcode;
    }
    public void setProductBarcode(int productBarcode)
    {
        this.productBarcode = productBarcode;
    }
    public int getStock()
    {
        return stock;
    }
    public void setStock(int stock)
    {
        this.stock = stock;
    }
    public productType getNextProductType()
    {
        return nextProductType;
    }
    public void setNextProductType(productType nextProductType)
    {
        this.nextProductType = nextProductType;
    }
    public product getTop()
    {
        return top;
    }
    public void delProductType()
    {
        this.top = null;
    }
    public bool ifProductIDExists(string productID)
    {
        product auxProduct = top;
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
    public void addProduct(int productID)
    {
        product newProduct = new product($"{this.productName.ToUpper().Replace(" ", "")}-{productID}");
        if (ifProductIDExists($"{this.productName.ToUpper().Replace(" ", "")}-{productID}") == true)
        {
            Console.WriteLine("Error: El ID del Producto ya existe");
            return;
        }
        else
        {
            newProduct.setNextProduct(top);
            top = newProduct;
            setStock(getStock() + 1);
        }
    }
    public bool delProduct()
    {
        if (top == null)
        {
            Console.WriteLine("Error: El Producto no Existe o el Stock esta vacio");
            return false;
        }
        else
        {
            top = top.getNextProduct();
            setStock(getStock() - 1);
            return true;
        }
    }
}