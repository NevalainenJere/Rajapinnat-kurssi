using System;
using System.Collections.Generic;
using System.Text;

namespace Tietovisa
{ public class QuestionCountInfo
        {
            public int category_id { get; set; }
            public Category_Question_Count category_question_count { get; set; }
        }

        public class Category_Question_Count
        {
            public int total_question_count { get; set; }
            public int total_easy_question_count { get; set; }
            public int total_medium_question_count { get; set; }
            public int total_hard_question_count { get; set; }
        }
}
