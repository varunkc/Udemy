using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Udemy.Models;

namespace Udemy.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie movie { set; get; }
        public List<Customer> Customers { set; get; }
    }
}