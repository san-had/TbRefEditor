using System;

namespace ScriptGeneration.Dto
{
    public class InputDto
    {
        public DateTime PreachDate { get; set; }

        public string Lecture { get; set; }

        public string Textus { get; set; }

        public string Title { get; set; }

        public string Preacher { get; set; }

        public string FileName
        {
            get
            {
                return string.Format("{0}{1:00}{2:00}", PreachDate.Year, PreachDate.Month, PreachDate.Day);
            }
        }

        public string Youtube { get; set; }
    }
}