﻿using Checkpoint.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint.Models
{
    public class CheckpointAdditionalAccessWithTitleID : CheckpointAdditionalAccess
    {
        public int CheckpointID { get; set; }
        public string CheckpointTitle { get; set; }
    }
}
