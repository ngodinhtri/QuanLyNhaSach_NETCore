using ModelDatabase;
using ModelDatabase.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelHandle
{
    public class BillItemHandler : ApplicationDbContext
    {
        //Create
        public async Task<bool> Create(BillItem billItem)
        {
            try
            {
                await BillItem.AddAsync(billItem);
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
                BillItem.Remove(BillItem.Find(ID));
                await SaveChangesAsync();
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
            return true;
        }
        //Update
        public async Task<bool> Update(BillItem billItem)
        {
            try
            {
                BillItem bI = BillItem.Find(billItem.ID);
                bI.Quanity = billItem.Quanity;
                BillItem.Update(bI);
                SaveChangesAsync();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
            return true;

        }
        //Get list
        public List<BillItem> GetList(string BillID)
        {
            try
            {
                List<BillItem> list = BillItem.Where(x => x.BillID.Equals(BillID)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<BillItem>();
            }
        }
        //Get list
        public List<BillItem> GetList()
        {
            try
            {
                List<BillItem> list = BillItem.ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<BillItem>();
            }
        }
    }
}
