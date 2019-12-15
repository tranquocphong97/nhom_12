using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_KTTKPM.Models
{
    public class Brands
    {
        [Key]
        public int Brand_ID { get; set; }
        public string Name { get; set; }

        //thuộc tính Navigation để lấy dữ liệu liên quan
        public ICollection<Products> Products { get; set; }
    }
}