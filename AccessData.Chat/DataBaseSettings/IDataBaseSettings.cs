using System;
using System.Collections.Generic;
using System.Text;

namespace AccessData.Chat.Models
{
    public interface IDataBaseSettings
    {
        string VehicleCollectionName { get; set; }
        string ModelCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
