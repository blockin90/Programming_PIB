using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Sample.Model
{
    public class Group 
    {
        public int GroupId { get; set; }
        [Required]
        [RegularExpression(@"^[А-ЯЁ][а-яё]{1,}\-\d{2}$", ErrorMessage = "Строка не соответствует формату!")]
        public string Name { get; set; }
        /// <summary> Год набора </summary>
        [Range(0,9999, ErrorMessage = "Недопустимое значение года")]
        public int Year { get; set; }

        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
