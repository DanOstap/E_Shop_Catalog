﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Shop_Catalog.Model
{

    public class LaptopModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Laptops_Id { get; }
        public string Category_Name { get; set; }
        public string Proccesor { get; set; }
        public string Graphic { get; set; }
        public int GPY { get; set; }
        public string Ram_Type { get; set; }
        public string Ram_Name { get; set; }
        public int Quantity_Ram { get; set; }
        public string Monitor { get; set; }
    }
}