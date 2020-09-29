using MobileRechargeApp.DataLayer;
using MobileRechargeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApp.BusinessLayer.Services.Repository
{
  public class MobileRepository : IMobileRepository
    {
        private InMemoryDb DbContext;
        public MobileRepository(InMemoryDb DbContext)
        {
            this.DbContext = DbContext;
        }
        public async Task<IEnumerable<Postpaid>> PostPaidReadAsync()
        {
            var postpaid = this.DbContext.postpaid.ToList();
            return postpaid;
        }
        //Add team into Inmemory Db and return teams
        public async Task<Postpaid> PostpaidCreateAsync(Postpaid postpaid)
        {
            this.DbContext.Add(postpaid);
            this.DbContext.SaveChanges();
            return postpaid;
        }
        //Update team into Inmemory Db and return teams 
        public async Task<Postpaid> PostPaidUpdateAsync(Postpaid postpaid)
        {
            var result = this.DbContext.postpaid.FirstOrDefault(e => e.MobilrNumber == postpaid.MobilrNumber);
            if (result != null)
            {
                postpaid.MobilrNumber = postpaid.MobilrNumber;
                postpaid.Amount = postpaid.Amount;
                postpaid.Operator = postpaid.Operator;
                this.DbContext.SaveChanges();
            }
            else
            {
                postpaid = null;
            }
            return postpaid;
        }
        //Delete team from INmemory Db and return teams
        public async Task<bool> PostPaidDeleteAsync(Postpaid postpaid)
        {
            var result = this.DbContext.postpaid.FirstOrDefault(e => e.MobilrNumber == postpaid.MobilrNumber);
            if (result != null)
            {
                this.DbContext.Remove(postpaid.MobilrNumber);
                this.DbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        public async Task<IEnumerable<Prepaid>> PrePaidReadAsync()
        {
            var prepaid = this.DbContext.prepaid.ToList();
            return prepaid;
        }
        //Add team into Inmemory Db and return teams
        public async Task<Prepaid> PrepaidCreateAsync(Prepaid prepaid)
        {
            this.DbContext.Add(prepaid);
            this.DbContext.SaveChanges();
            return prepaid;
        }
        //Update team into Inmemory Db and return teams 
        public async Task<Prepaid> PrePaidUpdateAsync(Prepaid prepaid)
        {
            var prepaids = this.DbContext.prepaid.FirstOrDefault(e => e.MobilrNumber == prepaid.MobilrNumber);
            if (prepaids != null)
            {
                prepaids.MobilrNumber = prepaid.MobilrNumber;
                prepaids.Amount = prepaid.Amount;
                prepaids.Operator = prepaid.Operator;
                this.DbContext.SaveChanges();
            }
            else
            {
                prepaid = null;
            }
            return prepaid;
        }
        //Delete team from INmemory Db and return teams
        public async Task<bool> PrePaidDeleteAsync(Prepaid prepaid)
        {
            var result = this.DbContext.prepaid.FirstOrDefault(e => e.MobilrNumber == prepaid.MobilrNumber);
            if (result != null)
            {
                this.DbContext.Remove(prepaid.MobilrNumber);
                this.DbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
