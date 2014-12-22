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

        void GetFruitType(PHPRPC_Callback<Hashtable> callback);
        void GetFruit(int fruitTypeId, PHPRPC_Callback<Hashtable> callback);
        void GetFruitPrice(int fruitId, PHPRPC_Callback<Hashtable> callback);
        void GetOrder(string cdate, PHPRPC_Callback<Hashtable> callback);
        void GetOrderItem(int orderId, PHPRPC_Callback<Hashtable> callback);

        void AddFruitType(string name, PHPRPC_Callback<int> callback);
        void AddFruit(int fruitTypeId, string name, int level, string area, string unit, string description, float loss, PHPRPC_Callback<int> callback);
        void AddFruitPrice(int fruitId, float mixPrice, float maxPrice, string cdate, PHPRPC_Callback<int> callback);
        void AddOrder(string customer, string cdate, string earliest, string latest, string comment, PHPRPC_Callback<int> callback);
        void AddOrderItem(int orderId, string product, int quantity, float money, string comment, PHPRPC_Callback<int> callback);

        void UpdateFruitType(int fruitTypeId, string name, PHPRPC_Callback<int> callback);
        void UpdateFruit(int fruitId, string name, int level, string area, string unit, string description, float loss, PHPRPC_Callback<int> callback);
        void UpdateFruitPrice(int fruitPriceId, float mixPrice, float maxPrice, string cdate, PHPRPC_Callback<int> callback);
        void UpdateOrder(int orderId, string customer, string cdate, string earliest, string latest, string comment, PHPRPC_Callback<int> callback);
        void UpdateOrderItem(int orderItemId, string product, int quantity, float money, string comment, PHPRPC_Callback<int> callback);

        void DeleteOrder(int orderId, PHPRPC_Callback<int> callback);
        void DeleteOrderItem(int orderItemId, PHPRPC_Callback<int> callback);

        void GetPrizer(int page, PHPRPC_Callback<Hashtable> callback);
        void UpdateReceived(int id, int received, PHPRPC_Callback<int> callback);
    }
}
