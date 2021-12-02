using Newtonsoft.Json;
using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
    internal class IOService
    {
        private readonly string ADDRESS;
        public IOService(string address)
        {
            ADDRESS = address;
        }
        public BindingList<ToDoMod> LoadData()
        {
            var fileExists = File.Exists(ADDRESS);
            if(!fileExists)
            {
                File.CreateText(ADDRESS).Dispose();
                return new BindingList<ToDoMod>();
            }
            using (var reader = File.OpenText(ADDRESS))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<ToDoMod>>(fileText);
            }
        }
        public void SaveData(object todoData)
        {
            using(StreamWriter writer = File.CreateText(ADDRESS))
            {
                string output = JsonConvert.SerializeObject(todoData);
                writer.Write(output);
            }
        }
    }
}
