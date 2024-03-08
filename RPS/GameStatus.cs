using System;

namespace GameStatus
{
    [Flags]
    enum Status
    {
        Draw = 0,
        Player1Win = 1,
        Player2Win = 2
    }
}