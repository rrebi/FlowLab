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
}