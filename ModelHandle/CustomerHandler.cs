using ModelDatabase;
using ModelDatabase.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelHandle
{
    public class CustomerHandler : ApplicationDbContext
    {
        public Customer FindPhone(string key)
        {
            Customer result = Customer.Where(ctm => ctm.Phone == key).FirstOrDefault();
            return result;
        }

        public async Task<bool> CreateCustomer(Customer customer)
        {
            try
            {
                await Customer.AddAsync(customer);
                await SaveChangesAsync();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
            return true;
        }

        public List<Customer> GetList()
        {
            List<Customer> customers = Customer.OrderByDescending(date => date.dateTime).ToList();
            return customers;
        }

        public List<Customer> GetSearchedList(string key)
        {
            try
            {
                List<Customer> customers = Customer.Where(search => search.Name.Contains(key)).OrderByDescending(date => date.dateTime).ToList();
                return customers;
            }
            catch (Exception)
            {
                return new List<Customer>();
            }
        }

        public async Task<bool> UpdateAsync(Customer ctm)
        {
            try
            {
                Customer customer = await Customer.FindAsync(ctm.ID);
                customer.Name = ctm.Name;
                customer.Phone = ctm.Phone;
                customer.Address = ctm.Address;
                customer.Gender = ctm.Gender;
                await SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Customer> GetByID(string ID)
        {
            try
            {
                Customer result = await Customer.FindAsync(ID);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> Remove(string Id)
        {
            try
            {
                Customer.Remove(Customer.Find(Id));
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Customer GetByPhone(string phone)
        {
            try
            {
                Customer result = Customer.Where(Customer => Customer.Phone == phone).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
