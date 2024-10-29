﻿using StoreManagementRazor.Models;

namespace StoreManagementRazor.Repositories
{
    public interface IProductsRepository
    {
        List<Product> GetAllProducts();

        Product? GetProductById(int id);

        Product AddProduct(Product product);

        Product EditProduct(Product product);

        Product DeleteProduct(int id);
    }
}
