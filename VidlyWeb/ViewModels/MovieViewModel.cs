using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyWeb.Models;

namespace VidlyWeb.ViewModels
{
    public class MovieViewModel
    {
        public Customers Customer { get; set; }
        public List<Movies> Movies { get; set; }
    }
}