using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.Model
{
    public class Blog
    {
        [Key]
        public int idblog { get; set; }
        public string title { get; set; }
    }
}
