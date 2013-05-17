﻿namespace NOpenCL
{
    using System;

    [Flags]
    public enum MigrationFlags : ulong
    {
        None = 0,
        Host = 1 << 0,
        ContentUndefined = 1 << 1,
    }
}
