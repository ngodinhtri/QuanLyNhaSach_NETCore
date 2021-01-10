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
    public class BillHandler :ApplicationDbContext
    {
        //Create
        public async Task<bool> Create(Bill bill)
        {
            try
            {
                await Bill.AddAsync(bill);
                await SaveChangesAsync();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
            return true;
        }

        //Delete
        public async Task<bool> Delete(String ID)
        {
            try
            {
                Bill.Remove(Bill.Find(ID));
                await SaveChangesAsync();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
            return true;
        }
        //Update
        public async Task<bool> Update(Bill bill)
        {
            try
            {
                Bill b = Bill.Find(bill.ID);
                b.CustomerID = bill.CustomerID;
                Bill.Update(b);
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
        public List<Bill> GetList()
        {
            List<Bill> list = Bill.Include(x => x.Customer).OrderByDescending(date => date.dateTime).ToList();
            return list;
        }

        public Bill GetByID(string ID)
        {
            try
            {
                Bill result =  Bill.Find(ID);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
