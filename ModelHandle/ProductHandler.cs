using Microsoft.EntityFrameworkCore;
using ModelDatabase;
using ModelDatabase.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelHandle
{
    public class ProductHandler : ApplicationDbContext
    {
        public Product FindProductByName(string ProductName)
        {
            Product result = Product.Where(product => product.Name == ProductName).FirstOrDefault();
            return result;
        }
        //Create
        public async Task<bool> CreateProduct(Product product)
        {
            try
            {
                await Product.AddAsync(product);
                await SaveChangesAsync();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
            return true;
        }
        //Get list
        public List<Product> GetProductList()
        {
            List<Product> products = Product.Include(x => x.category).OrderByDescending(date => date.dateTime).ToList();
            return products;
        }
        //Update
        public async Task<bool> UpdateProductAsync(Product pd)
        {
            try
            { 
                Product product = await Product.FindAsync(pd.ID);
                product.Name = pd.Name;
                product.Price = pd.Price;
                product.Image = pd.Image;
                product.Quantiy = pd.Quantiy;
                product.CategoryID = pd.CategoryID;
                Product.Update(product);
                await SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Delete
        public async Task<bool> RemoveProduct(string Id)
        {
            try
            {
                Product.Remove(Product.Find(Id));
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public  Product GetProduct(string name)
        {
            try
            {
                Product result =  Product.Where(product => product.Name == name).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Product> GetProductyByID(string ID)
        {
            try
            {
                Product result = await Product.FindAsync(ID);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //Tìm kiếm
        public List<Product> GetSearchedList(string key)
        {
            try
            {
                List<Product> products = Product.Where(search => search.Name.Contains(key)).OrderByDescending(date => date.dateTime).ToList();
                return products;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }
    }
}
