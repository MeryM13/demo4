using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.CLASSES
{
    public class Task
    {
        public int ID { get; set; }
        public int ExecutorID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime Deadline { get; set; }
        public int Difficulty { get; set; }
        public int Time { get; set; }
        public string Status { get; set; }
        public string WorkType { get; set; }
        public DateTime CompletedDateTime { get; set; }
        public bool IsDeleted { get; set; }

    }
}
