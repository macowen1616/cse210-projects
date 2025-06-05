using System;

namespace library_demo
{
    public class Writing
    {
        private string _title = "";

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetWritingInfo()
        {
            return $"{_title}";
        }
    }


}