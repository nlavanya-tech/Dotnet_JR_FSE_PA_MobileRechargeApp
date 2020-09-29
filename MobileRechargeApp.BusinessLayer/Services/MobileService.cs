using MobileRechargeApp.BusinessLayer.Interface;
using MobileRechargeApp.BusinessLayer.Services.Repository;
using MobileRechargeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApp.BusinessLayer.Services
{
    public class MobileService : IMobileService
    {
        //create local instance 
        private readonly IMobileRepository _repositary;

        public MobileService(IMobileRepository repositary)
        {
            _repositary = repositary;
        }

        //Get pospaiddetails and retrun list of pospaiddetails
        public async Task<IEnumerable<Postpaid>> PostPaidReadAsync()
        {
            var teams = await _repositary.PostPaidReadAsync();
            return teams;
        }
        //Create pospaiddetails
        public async Task<Postpaid> PostpaidCreateAsync(Postpaid postpaid)
        {
            await _repositary.PostpaidCreateAsync(postpaid);
            return postpaid;
        }
        //Update pospaiddetails
        public async Task<Postpaid> PostPaidUpdateAsync(Postpaid postpaid)
        {
            var postpaid1 = await _repositary.PostPaidUpdateAsync(postpaid);

            return postpaid1;
        }
        //Delete pospaiddetails 
        public async Task<bool> PostPaidDeleteAsync(Postpaid postpaid)
        {
            var result = await _repositary.PostPaidDeleteAsync(postpaid);
            return result;
        }
        //Get pospaiddetails and retrun list of pospaiddetails
        public async Task<IEnumerable<Prepaid>> PrePaidReadAsync()
        {
            var result = await _repositary.PrePaidReadAsync();
            return result;
        }
        //Create pospaiddetails
        public async Task<Prepaid> PrepaidCreateAsync(Prepaid prepaid)
        {
            await _repositary.PrepaidCreateAsync(prepaid);
            return prepaid;
        }
        //Update pospaiddetails
        public async Task<Prepaid> PrePaidUpdateAsync(Prepaid prepaid)
        {
            var result = await _repositary.PrePaidUpdateAsync(prepaid);

            return result;
        }
        //Delete pospaiddetails 
        public async Task<bool> PrePaidDeleteAsync(Prepaid prepaid)
        {
            var result = await _repositary.PrePaidDeleteAsync(prepaid);
            return result;
        }
    }
}
