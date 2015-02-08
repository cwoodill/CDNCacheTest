using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CacheTest.Models
{
    public class CacheTestModel
    {
        [DisplayName("Random Number")]
        public int RandomNumber { get; set; }

        [DisplayName("Page Construction Date Time")]
        public DateTime ConstructionTime { get; set; }

        public CacheTestModel()
        {
            Random rnd = new Random();
            RandomNumber = rnd.Next();
            ConstructionTime = DateTime.Now;
        }

        

    }
}