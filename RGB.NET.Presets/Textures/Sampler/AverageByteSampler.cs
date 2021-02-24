﻿using System;
using RGB.NET.Core;

namespace RGB.NET.Presets.Textures.Sampler
{
    public class AverageByteSampler : ISampler<byte>
    {
        #region Methods

        public void SampleColor(in SamplerInfo<byte> info, Span<byte> pixelData)
        {
            int count = info.Width * info.Height;
            if (count == 0) return;

            ReadOnlySpan<byte> data = info.Data;

            int dataLength = pixelData.Length;
            Span<uint> sums = stackalloc uint[dataLength];
            for (int i = 0; i < data.Length; i += dataLength)
                for (int j = 0; j < sums.Length; j++)
                    sums[j] += data[i + j];

            for (int i = 0; i < pixelData.Length; i++)
                pixelData[i] = (byte)MathF.Round(sums[i] / (float)count);
        }

        #endregion
    }
}
