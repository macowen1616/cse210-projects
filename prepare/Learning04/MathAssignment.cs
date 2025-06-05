using System;

namespace library_demo
{
    public class MathAssignment
    {
        private string _name = "";
        private string _textbookSection = "";
        private string _problems = "";

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetTextbookSection()
        {
            return _textbookSection;
        }

        public void SetTextbookSection(string textbookSection)
        {
            _textbookSection = textbookSection;
        }

        public string GetProblems()
        {
            return _problems;
        }

        public void SetProblems(string problems)
        {
            _problems = problems;
        }

        public string GetMathInfo()
        {
            return $"{_name} - Section: {_textbookSection}, Problems: {_problems}";
        }
    }
}
