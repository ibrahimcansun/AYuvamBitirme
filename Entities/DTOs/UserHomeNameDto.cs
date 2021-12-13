﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserHomeNameDto:IDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int HomeId { get; set; }
        public string StructureName { get; set; }
    }
}