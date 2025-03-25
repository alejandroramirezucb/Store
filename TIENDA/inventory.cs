﻿using System.Diagnostics.Metrics;

public class inventory
{
    private int stock;
    private product firstProduct;
    private List<string> listCategories;

    public inventory()
    {
        this.stock = 0;
        this.firstProduct = null;
        this.listCategories = new List<string>();
        listCategories.Add("Sin categoria");
    }
    public int getStock()
    {
        return stock;
    }
    public void setStock(int stock)
    {
        this.stock = stock;
    }
    public int getStockProduct(string productName)
    {
        int stockProduct = 0;
        if (firstProduct == null)
        {
            Console.WriteLine("ERROR: El Producto no existe o el stock esta vacío");
            return 0;
        }
        else
        {
            product auxProduct = firstProduct;
            while (auxProduct != null)
            {
                if (auxProduct.getProductName() == productName)
                {
                    ++stockProduct;
                }
                auxProduct = auxProduct.getNextProduct();
            }
            return stockProduct;
        }
    }
    public int getStockCategory(string productCategory)
    {
        int stockCategory = 0;
        if (firstProduct == null)
        {
            Console.WriteLine("ERROR: El inventario esta vacio");
            return 0;
        }
        else
        {
            product auxProduct = firstProduct;
            while (auxProduct != null)
            {
                if (auxProduct.getProductCategory() == productCategory)
                {
                    ++stockCategory;
                }
                auxProduct = auxProduct.getNextProduct();
            }
            return stockCategory;
        }
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
    public bool ifProductBarcodeExists(int productBarcode, string productName)
    {
        product auxProduct = firstProduct;
        while (auxProduct != null)
        {
            if (auxProduct.getProductBarcode() == productBarcode && auxProduct.getProductName() != productName)
            {
                return true;
            }
            auxProduct = auxProduct.getNextProduct();
        }
        return false;
    }
    public bool linkProduct_Category(string productName, string productCategory)
    {
        if (firstProduct == null)
        {
            Console.WriteLine("ERROR: El Producto no existe o el stock esta vacío");
            return false;
        }
        else if (ifCategoryExits(productCategory) == false)
        {
            Console.WriteLine("ERROR: La Categoria no existe");
            return false;
        }
        else
        {
            product auxProduct = firstProduct;
            while (auxProduct != null)
            {
                if (auxProduct.getProductName() == productName)
                {
                    auxProduct.setProductCategory(productCategory);
                }
                auxProduct = auxProduct.getNextProduct();
            }
            return true;
        }
    }
    public bool addProduct(string productName, string productBrand, int productBarcode, int productID)
    {
        product newProduct = new product(productName, productBrand, productBarcode, productID);
        if (ifProductIDExists(productID))
        {
            Console.WriteLine("ERROR: El ID del Producto ya existe");
            return false;
        }
        if (ifProductBarcodeExists(productBarcode, productName))
        {
            Console.WriteLine("ERROR: El codigo de barras le pertenece a otro producto");
            return false;
        }
        else if (firstProduct == null)
        {
            firstProduct = newProduct;
            return true;
        }
        else
        {
            product auxProduct = firstProduct;
            while (auxProduct.getNextProduct() != null)
            {
                auxProduct = auxProduct.getNextProduct();
            }
            auxProduct.setNextProduct(newProduct);
            setStock(getStock() + 1);
            return true;
        }
    }
    public bool delProduct(int productID)
    {
        product auxProduct = firstProduct;
        if (firstProduct == null)
        {
            return false;
        }
        else if (firstProduct.getProductID() == productID)
        {
            firstProduct = firstProduct.getNextProduct();
            setStock(getStock() - 1);
            return true;
        }
        else
        {
            while (auxProduct.getNextProduct() != null)
            {
                if (auxProduct.getProductID() == productID)
                {
                    auxProduct.setNextProduct(auxProduct.getNextProduct().getNextProduct());
                    setStock(getStock() - 1);
                    return true;
                }
                auxProduct = auxProduct.getNextProduct();
            }
            return false;
        }
    }
    public bool ifCategoryExits(string categoryName)
    {
        for (int i = 0; i<listCategories.Count; ++i)
        {
            if (listCategories[i] == categoryName)
            {
                return true;
            }
        }
        return false;
    }
    public bool addCategory (string categoryName)
    {
        if (ifCategoryExits(categoryName) == true)
        {         
            Console.WriteLine("ERROR: La Categoria ya existe");
            return false;
        }
        else
        {
            listCategories.Add(categoryName);
            return true;
        }
    }
    public bool delCategory (string categoryName)
    {
        if (ifCategoryExits(categoryName) == true)
        {
            listCategories.Remove(categoryName);
            if (firstProduct == null)
            {
                Console.WriteLine("ERROR: El inventario esta vacio");
                return false;
            }
            else
            {
                product auxProduct = firstProduct;
                while (auxProduct != null)
                {
                    if (auxProduct.getProductCategory() == categoryName)
                    {
                        linkProduct_Category(auxProduct.getProductName(), "Sin categoria");
                    }
                    auxProduct = auxProduct.getNextProduct();
                }
                return true;
            }
        }
        else
        {
            Console.WriteLine("ERROR: La categoria no existe");
            return false;
        }

    }
    public void printProducts()
    {
        product auxProduct = firstProduct;
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("| {0,-10} | {1,-20} | {2,-15} | {3,-15} | {4,-10} |",
                          "ID", "Nombre", "Marca", "Categoria", "Codigo de Barras");
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        while (auxProduct != null)
        {
            if (auxProduct.getSold() == false) {
                Console.WriteLine("| {0,-10} | {1,-20} | {2,-15} | {3,-15} | {4,-10} |",
                                  auxProduct.getProductID(),
                                  auxProduct.getProductName(),
                                  auxProduct.getProductBrand(),
                                  auxProduct.getProductCategory(),
                                  auxProduct.getProductBarcode());
            }
            auxProduct = auxProduct.getNextProduct();
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------");
    }
    public void printCategories()
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("| {0,-10} | {1,-30} |", "Stock", "Nombre");
        Console.WriteLine("-----------------------------------------------");
        for (int i = 0; i < listCategories.Count; ++i)
        {
            Console.WriteLine("| {0,-10} | {1,-30} |", getStockCategory(listCategories[i]), listCategories[i]);
        }
        Console.WriteLine("-----------------------------------------------");
    }
    public void printProductsInCategories(string categoryName)
    {
        product auxProduct = firstProduct;
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("| {0,-10} | {1,-20} | {2,-15} | {3,-15} | {4,-10} |",
                          "ID", "Nombre", "Marca", "Categoria", "Codigo de Barras");
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        while (auxProduct != null)
        {
            if (auxProduct.getSold() == false && auxProduct.getProductCategory() == categoryName)
            {
                Console.WriteLine("| {0,-10} | {1,-20} | {2,-15} | {3,-15} | {4,-10} |",
                                  auxProduct.getProductID(),
                                  auxProduct.getProductName(),
                                  auxProduct.getProductBrand(),
                                  auxProduct.getProductCategory(),
                                  auxProduct.getProductBarcode());
            }
            auxProduct = auxProduct.getNextProduct();
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------");
    }
}
