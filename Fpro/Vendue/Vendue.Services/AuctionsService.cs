using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendue.Data;
using Vendue.Entities;
using System.Data.Entity;
using System.Data;

namespace Vendue.Services
{
   public  class AuctionsService
    {
        public Auction GetAuctionByID(int ID)
        {
            VendueContext context = new VendueContext();
            return context.Auctions.Find(ID);
        }
        public List<Auction> GetAllOptions()
        {
            VendueContext context = new VendueContext();
            return context.Auctions.ToList();
        }
        public void UpdateAuction(Auction auction)
        {
            VendueContext context = new VendueContext();
            context.Entry(auction).State = EntityState.Modified;
        }
        public void SaveAuction(Auction auction)
        {
            VendueContext context = new VendueContext();
            context.Auctions.Add(auction);
            context.SaveChanges();
        }
    }
}
