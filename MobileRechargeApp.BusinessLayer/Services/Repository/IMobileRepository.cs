using MobileRechargeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApp.BusinessLayer.Services.Repository
{
   public interface IMobileRepository
    {
        Task<IEnumerable<Postpaid>> PostPaidReadAsync();
        Task<Postpaid> PostpaidCreateAsync(Postpaid postpaid);
        Task<Postpaid> PostPaidUpdateAsync(Postpaid postpaid);
        Task<bool> PostPaidDeleteAsync(Postpaid postpaid);
        Task<IEnumerable<Prepaid>> PrePaidReadAsync();
        Task<Prepaid> PrepaidCreateAsync(Prepaid prepaid);
        Task<Prepaid> PrePaidUpdateAsync(Prepaid prepaid);
        Task<bool> PrePaidDeleteAsync(Prepaid prepaid);
    }
}
