﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class AboutMission : BaseEntity
    {
        public string Image { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

    }
}