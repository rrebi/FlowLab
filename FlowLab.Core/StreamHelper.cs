using System;
using System.Collections.Generic;
using System.Text;

namespace FlowLab.Core;

public static class StreamHelper
{
    public static async Task<byte[]> ReadExactAsync(Stream stream, int length, CancellationToken ct = default)
    //loop until we have the full message (all bytes needed, not in separate chunks)
    {
        byte[] buffer = new byte[length];
        int read = 0;

        while (read < length)
        {
            int n = await stream.ReadAsync(buffer.AsMemory(read, length - read), ct); //remaining empty part
            if (n == 0)
                throw new EndOfStreamException("Connection closed before all bytes were received.");
            read += n;
        }

        return buffer;
    }
}
