using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WepApi_Day1.Core.Entities
{
    public class Course
    {
        [Key] 
        public int Id { get; set; }

        [MaxLength(50)]
        [RegularExpression(@"^[A-Za-z\s#+]+$")]
        public String? Crs_Name { get; set; }
        [MaxLength(100)]
        public String? Crs_Description { get; set; }

        public int? Duration { get; set; }   


    }
}
