using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _04ViewModel.Models;

namespace _04ViewModel.ViewModels
{
    public class VMEmp
    {
        public List<tDepartment> department { get; set; }
        public List<tEmployee> employee { get; set; }
    }
}