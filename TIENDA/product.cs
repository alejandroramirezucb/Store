public class product
{
    private String productID;
    private bool sold;
    private product nextProduct; 

    public product(String productID)
    {
        this.productID = productID;
        this.sold = false;
        this.nextProduct = null;
    }
    public String getProductID()
    {
        return productID;
    }
    public void setProductID(String productID)
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
    public product getNextProduct()
    {
        return nextProduct;
    }
    public void setNextProduct(product nextProduct)
    {
        this.nextProduct = nextProduct;
    }
}