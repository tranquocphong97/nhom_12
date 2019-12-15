using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_KTTKPM.Models
{
    public class Products
    {
        [Key]
        public int P_ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        //thuộc tính khóa ngoại
        public int Brand_ID { get; set; }

        //thuộc tính Navigation để lấy dữ liệu liên quan
        [ForeignKey("Brand_ID")]
        public Brands Brand { get; set; }
    }
}