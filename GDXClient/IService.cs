using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using org.phprpc;

namespace GDXClient
{
    public interface IService
    {
        void Login(string name, string password, PHPRPC_Callback<Boolean> callback);

        void GetOrder(string cdate, PHPRPC_Callback<Hashtable> callback);
        void GetOrderItem(int orderId, PHPRPC_Callback<Hashtable> callback);

        void GetFruitType(PHPRPC_Callback<Hashtable> callback);
        void GetFruit(int fruitTypeId, PHPRPC_Callback<Hashtable> callback);
        void GetFruitPrice(int fruitId, PHPRPC_Callback<Hashtable> callback);

        void AddFruitType(string name, PHPRPC_Callback<int> callback);
        void AddFruit(int fruitTypeId, string name, int level, string area, string unit, string description, float loss, PHPRPC_Callback<int> callback);
        void AddFruitPrice(int fruitId, float mixPrice, float maxPrice, string cdate, PHPRPC_Callback<int> callback);

        void UpdateFruitType(int fruitTypeId, string name, PHPRPC_Callback<int> callback);
        void UpdateFruit(int fruitId, string name, int level, string area, string unit, string description, float loss, PHPRPC_Callback<int> callback);
        void UpdateFruitPrice(int fruitPriceId, float mixPrice, float maxPrice, string cdate, PHPRPC_Callback<int> callback);

        void GetUserForPrize(int page, PHPRPC_Callback<Hashtable> callback);
        void UpdateReceived(int id, int received, PHPRPC_Callback<int> callback);
    }
}
