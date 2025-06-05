using System;

namespace library_demo
{
    public class Writing : Assignment
    {
        private string _title = "";

        public Writing(string name, string topic, string title)
            : base(name, topic) // Call the base Assignment constructor
        {
            _title = title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetWritingInfo()
        {
            return $"{_title} by {GetStudentName()}";
        }
    }
}
