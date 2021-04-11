﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB_practices.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Position> Positions { get; set; }

        [NotMapped]
        public List<Position> DepartmentPositions
        {
            get
            {
                return DataWorker.GetAllPositionsByDepartmentId(Id);
            }
        }
    }
}