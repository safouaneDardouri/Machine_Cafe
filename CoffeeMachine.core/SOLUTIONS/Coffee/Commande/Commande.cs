using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetTN.Connector.SQL.Mapping;
using System.Runtime.Serialization;

namespace CoffeeMachine.core.SOLUTIONS.Coffee.Commande
{
    [Serializable()]
    [DataContract]
    [Table("commande")]
    
    public class Commande
    {
        [Column(IsPrimaryKey = true, ColumnName = "id")]
        public int id { get; set; }

        public int qtsucre { get; set; }

        public string type { get; set; }

        public string userId { get; set; }
        public string mug { get; set; }

     



    }
}