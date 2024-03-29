﻿using System;
using System.Collections.Generic;

namespace LMS.Models.LMSModels
{
    public partial class AssignmentCategories
    {
        public AssignmentCategories()
        {
            Assignments = new HashSet<Assignments>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int? Weight { get; set; }
        public int ClassId { get; set; }

        public virtual Classes Class { get; set; }
        public virtual ICollection<Assignments> Assignments { get; set; }
    }
}
