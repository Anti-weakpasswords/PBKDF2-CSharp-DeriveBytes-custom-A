﻿using System;

namespace Jither.PBKDF2
{
    public interface IPseudoRandomFunction : IDisposable
    {
        int HashSize { get; }
        byte[] Transform(byte[] input);
    }
}
