public class inventory
{
    private int productStock;
    private int categoryStock;
    private product firstProduct;

    public inventory()
    {
        productStock = 0;
        categoryStock = 0;
        firstProduct = null;
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
}
