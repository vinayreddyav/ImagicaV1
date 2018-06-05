using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tralive.API.Application.Models
{
    public class ConfigSettings
    {
        public ConfigSettings() { }
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
