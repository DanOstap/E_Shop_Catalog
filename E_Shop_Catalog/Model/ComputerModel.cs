﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Shop_Catalog.Model
{

    public class ComputerModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Computers_Id { get;}
        public string Copmputer_Name { get; set; }
        public string Category_Name { get; set; }
        public string Proccesor { get; set; }
        public string Graphic { get; set; }
        public int GPY { get; set; }
        public string Ram_Type { get; set; }
        public string Ram_Name { get; set; }
        public int Quantity_Ram { get; set; }
    }
}
