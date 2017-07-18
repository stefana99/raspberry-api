using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace raspberry_api.Models
{
    public class TempraturesContext : DbContext
    {
        
    }

    public class Reading
    {
        public float Temprature { get; set; }
        public float Humidity { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}