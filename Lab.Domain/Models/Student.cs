using Lab.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Domain.Models
{
    public class Student : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
