using System;
using System.Collections.Generic;
using System.Text;
using ToDoBlazor.Common.Enums;

namespace ToDoBlazor.DAL.Models
{
    public sealed class Mission
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public MissionPriority Priority { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime EndDate { get; set; }
    }
}
