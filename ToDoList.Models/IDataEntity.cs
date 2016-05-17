﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public interface IDataEntity
    {
        int Id { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
    }
}