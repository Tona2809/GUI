﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class ScreenType
    {
        public string ID { get; set; }

        public string Name { get; set; }
        public ScreenType(string iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }
        public ScreenType(DataRow row)
        {
            this.ID = row["iD"].ToString();
            this.Name = row["TenMH"].ToString();
        }
    }
}
