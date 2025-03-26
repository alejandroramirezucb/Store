public class product
{
    private string productName;
    private string productBrand;
    private string productCategory;
    private int productBarcode;
    private int productID;
    private bool sold;
    private bool inCart;
    private product nextProduct; 

    public product(string productName, string productBrand, int productBarcode, int productID)
    {
        this.productName = productName;
        this.productBrand = productBrand;
        this.productCategory = "Sin categoria";
        this.productBarcode = productBarcode;
        this.productID = productID;
        this.sold = false;
        this.inCart = false;
        this.nextProduct = null;
    }
    public string getProductName()
    {
        return productName;
    }
    public void setProductName(string productName)
    {
        this.productName = productName;
    }
    public string getProductBrand()
    {
        return productBrand;
    }
    public void setProductBrand(string productBrand)
    {
        this.productBrand = productBrand;
    }
    public string getProductCategory()
    {
        return productCategory;
    }
    public void setProductCategory(string productCategory)
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
    public int getProductID()
    {
        return productID;
    }
    public void setProductID(int productID)
    {
        this.productID = productID;
    }
    public bool getSold()
    {
        return sold;
    }
    public void setSold(bool sold)
    {
        this.sold = sold;
    }
    public bool getInCart()
    {
        return inCart;
    }
    public void setInCart(bool inCart)
    {
        this.inCart = inCart;
    }
    public product getNextProduct()
    {
        return nextProduct;
    }
    public void setNextProduct(product nextProduct)
    {
        this.nextProduct = nextProduct;
    }
}