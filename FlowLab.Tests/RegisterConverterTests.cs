using System;
using System.Collections.Generic;
using System.Text;
using FlowLab.Core;
using Xunit;

namespace FlowLab.Tests;

public class RegisterConverterTests
{
    [Fact]
    public void ToFloat_TwoRegisters_Returns25Point5()
    {
        float result = RegisterConverter.ToFloat(0x41CC, 0x0000);

        Assert.Equal(25.5f, result);
    }
    [Fact]
    public void FromFloat_25Point5_ReturnsExpectedRegisters()
    {
        var (high, low) = RegisterConverter.FromFloat(25.5f);

        Assert.Equal(0x41CC, high);
        Assert.Equal(0x0000, low);
    }

    [Fact]
    public void FromFloat_ThenToFloat_ReturnsOriginalValue()
    {
        float original = 123.456f;

        var (high, low) = RegisterConverter.FromFloat(original);
        float result = RegisterConverter.ToFloat(high, low);

        Assert.Equal(original, result);
    }
}