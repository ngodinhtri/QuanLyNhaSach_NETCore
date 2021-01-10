using ModelDatabase;
using ModelDatabase.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelHandle
{
    public class CategoryHandler : ApplicationDbContext
    {
        public Category FindCategory(string CateName)
        {
            Category result = Category.Where(cate => cate.Name == CateName).FirstOrDefault();
            return result;
        }

        public async Task<bool> CreateCategory(Category cate)
        {
            try
            {
                await Category.AddAsync(cate);
                await SaveChangesAsync();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
            return true;
        }

        public List<Category> GetCategoryList()
        {
            List<Category> Categories = Category.OrderByDescending(date => date.dateTime).ToList();
            return Categories;
        }

        public List<Category> GetSearchedList(string key)
        {
            try
            {
                List<Category> Categories = Category.Where(search => search.Name.Contains(key)).OrderByDescending(date => date.dateTime).ToList();
                return Categories;
            }
            catch (Exception)
            {
                return new List<Category>();
            }
        }

        public async Task<bool> UpdateCategoryAsync(Category cate)
        {
            try
            {
                Category category = await Category.FindAsync(cate.CategoryId);
                category.Name = cate.Name;
                category.Image = cate.Image;
                await SaveChangesAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<Category> GetCategory(string ID)
        {
            try
            {
                Category result = await Category.FindAsync(ID);
                return result;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public async Task<bool> RemoveCategory(string Id)
        {
            try
            {
                Category.Remove(Category.Find(Id));
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public String getName(string id)
        {
            return Category.Find(id).Name;
        }
    }
}
