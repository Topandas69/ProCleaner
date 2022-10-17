using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProCleaner.Models
{
    public class MachineColorViewModel
    {
        public List<Machine> Machines { get; set; }
        public SelectList Colors { get; set; }
        public string MachineColor { get; set; }
        public string SearchString { get; set; }
    }
}