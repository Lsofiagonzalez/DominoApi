using Domino.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domino.Core.DTOs
{
    public class DominoPieceDto : Entity
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public bool isValid { get; set; }
        public int UserId { get; set; }
     
    }
}
