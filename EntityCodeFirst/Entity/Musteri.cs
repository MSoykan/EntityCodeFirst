﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity {
    public class Musteri {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriAD { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriUnvan { get; set; }
    }
}
