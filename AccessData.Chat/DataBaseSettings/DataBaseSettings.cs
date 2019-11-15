using System;
using System.Collections.Generic;
using System.Text;

namespace AccessData.Chat.Models
{
    public class DataBaseSettings : IDataBaseSettings
    {
        public string VehicleCollectionName { get; set; }
        public string ModelCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
