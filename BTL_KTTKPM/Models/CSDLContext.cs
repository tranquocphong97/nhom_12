using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BTL_KTTKPM.Models
{
    //lớp database context quản lý mọi thao tác với database
    public class CSDLContext:DbContext
    { 
        public CSDLContext():base("name=CSDLContext")
        {

        }

        //định nghĩa các thuộc tính Map với các bảng trong database
        public DbSet<Products> Products { get; set; }

        public DbSet<Brands> Brands { get; set; }
    }
}