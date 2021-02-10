using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDoBlazor.Common.Enums;

namespace ToDoBlazor.Models
{
    public sealed class MissionModels
    {
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }
        public MissionPriority Priority { get; set; } = MissionPriority.Neutral;

        [Required(ErrorMessage = "Time is required!")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "Date is required!")]
        public DateTime EndDate { get; set; }
    }
}
