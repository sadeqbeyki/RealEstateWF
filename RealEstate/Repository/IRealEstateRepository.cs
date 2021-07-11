using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate//.Repository
{
    interface IRealEstateRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int itemId);
        DataTable Search(string parameter);
        bool insertItem(string itemName, int squareMeters, string itemOptions, string sellerName, string sellerMobile, int itemPrice);
        bool updateItem(int itemId, string itemName, int squareMeters, string itemOptions, string sellerName, string sellerMobile, int itemPrice);
        bool deleteItem(int itemId);
    }
}
