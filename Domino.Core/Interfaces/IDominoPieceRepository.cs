using Domino.Core.DTOs;
using Domino.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domino.Core.Interfaces
{
    public interface IDominoPieceRepository
    {
        Task<IEnumerable<DominoPiece>> GetDominoPieces();
        List<DominoPieceDto> CalculateChain(List<DominoPieceDto> dominoPiece);
    }
}
