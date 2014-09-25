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

        void addFruitType(string name, PHPRPC_Callback<int> callback);
        void addFruit(int fruitTypeId, string name, int level, string area, string unit, string description, float loss, PHPRPC_Callback<int> callback);
        void addFruitPrice(int fruitId, float mixPrice, float maxPrice, string cdate, PHPRPC_Callback<int> callback);

        void updateFruitType(int fruitTypeId, string name, PHPRPC_Callback<int> callback);
        void updateFruit(int fruitId, string name, int level, string area, string unit, string description, float loss, PHPRPC_Callback<Hashtable> callback);
        void updateFruitPrice(int fruitPriceId, float mixPrice, float maxPrice, string cdate, PHPRPC_Callback<Hashtable> callback);
    }
}
