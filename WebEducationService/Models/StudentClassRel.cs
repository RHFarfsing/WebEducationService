using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class StudentClassRel {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        [StringLength(10)]
        public string CLassGradeValue { get; set; }
        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }
        public virtual ClassGrade ClassGrade { get; set; }
        public StudentClassRel() { }
    }
}
