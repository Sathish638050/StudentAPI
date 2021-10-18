﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StudentApi.Model
{
    public partial class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string Answer1 { get; set; }
        public int UserId { get; set; }

        public virtual Question Question { get; set; }
        public virtual UserAccount User { get; set; }
    }
}
