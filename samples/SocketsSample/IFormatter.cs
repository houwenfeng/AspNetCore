﻿using System.IO;
using System.Threading.Tasks;

namespace SocketsSample
{
    // TODO: Is this name too generic?
    public interface IFormatter<T>
    {
        Task<T> ReadAsync(Stream stream);
        Task WriteAsync(T value, Stream stream);
    }
}
