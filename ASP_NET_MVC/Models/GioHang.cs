using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC.Models
{
    [Serializable]
    public class GioHang
    {
        public San_Pham San_Pham { get; set; }
        public int Quantity { get; set; }

    }
}