public class inventory
{
    private productType firstProductType;
    private int productStock;
    private int categoryStock;

    public inventory()
    {
        firstProductType = null;
        productStock = 0;
        categoryStock = 0;
    }
    public int getProductStock()
    {
        return productStock;
    }
    public void setProductStock(int productStock)
    {
        this.productStock = productStock;
    }
    public int getCategoryStock()
    {
        return categoryStock;
    }
    public void setCategoryStock(int categoryStock)
    {
        this.categoryStock = categoryStock;
    }
    public productType getFirstProductType()
    {
        return firstProductType;
    }
    public void addProductType(productType newProductType)
    {
        if (firstProductType == null)
        {
            firstProductType = newProductType;
        }
        else
        {
            productType current = firstProductType;
            while (current.getNextProductType() != null)
            {
                current = current.getNextProductType();
            }
            current.setNextProductType(newProductType);
        }
        ++categoryStock; 
    }
}
