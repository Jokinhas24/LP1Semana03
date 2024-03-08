using System;

namespace GameItem
{
    [Flags]
    enum Items
    {
        rock = 1 << 0,
        paper = 1 << 1,
        scissors = 1 << 2
    }
}