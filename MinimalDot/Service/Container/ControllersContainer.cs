using System;
using System.Collections.Generic;

namespace ConsoleApp1.Service
{
    public class ControllersContainer 
    {
        protected static Dictionary<Type, object> _itemMap = new Dictionary<Type, object>();

        public static void AddItem(Type t, object instance)
        {
            _itemMap.Add(t, instance);
        }
        
        public static T GetItem<T>()
        {
            Type t = typeof(T);
            return (T)_itemMap[t];
        }
    }
}