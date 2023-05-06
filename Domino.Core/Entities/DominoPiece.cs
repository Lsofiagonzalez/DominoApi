using System;
using System.Collections.Generic;
using System.Text;

namespace Domino.Core.Entities
{
    public class DominoPiece : Entity
    {
        //public int Id { get; set; }
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public bool isValid { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }

    }
}
