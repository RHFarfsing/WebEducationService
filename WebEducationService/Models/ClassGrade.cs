using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class ClassGrade {
        [StringLength(10)]
        [Key]
        public String Grade { get; set; }
        public double GPA { get; set; }
    }
}
