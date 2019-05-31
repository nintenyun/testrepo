using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.Model
{
    public class Position
    {
        [Key]
        public int id { get; set; }
        public string publisher { get; set; }
        public string title { get; set; }
        public DateTime publish_date { get; set; }
        public string editor { get; set; }
        public DateTime editor_date { get; set; }
        public int status { get; set; }
        public string file_path { get; set; }
    }
}
