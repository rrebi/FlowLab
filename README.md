# FlowLab
Sensor Testing &amp; Diagnostics -C#, TCP, Modbus

A C# project that tests and diagnoses a simulated flow sensor over Modbus TCP.


Purpose: to better understand industrial communication protocols and automated testing.

## What it does
- Simulates a flow sensor (Modbus TCP server) with injectable faults:
  timeout, dropped connection, Modbus exception, out-of-range values.
- A client reads the sensor's registers and converts two 16-bit registers
  into a 32-bit float.
- Runs test scenarios and writes a PASS/FAIL report to CSV.

## Project structure
- `FlowLab.Core` - the Modbus TCP client, conversions, tests scenarios and reports
- `FlowLab.SensorSim` - simulated sensor
- `FlowLab.Tests` - automated tests

## Run
```
dotnet run --project FlowLab.SensorSim
dotnet test
```

Development notes:
I used Claude for a better flow of thoughts 
