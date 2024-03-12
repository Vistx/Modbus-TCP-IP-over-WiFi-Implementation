##  Modbus TCP/IP over WiFi Implementation

This repository contains code for implementing client-server communication using Modbus TCP/IP over WiFi protocol between a PC and an ESP32 controller. The purpose of this implementation is to facilitate reading and writing of Digital Inputs (DI), Digital Outputs (DO), Analog Inputs (AI), and Analog Outputs (AO).

![Connection](https://github.com/Vistx/Modbus-TCP-IP-over-WiFi-Implementation/assets/123487221/8f2795b0-1a7d-4b11-8f98-33c61bafc962)

## Programming languages used

 - C# with Winforms in Visual Studio 2019 for the PC application.
 - C++ with Visual Studio Code (with the PlatformIO extension) and Arduino Framework for the ESP32 controller.
 
## Libraries used
1.  **Nmodbus4 Nuget**: Used for Modbus communication in C#.
2.  **modbus-esp8266**: A library for Modbus communication on ESP8266 (compatible with ESP32).
3.  **adafruit/DHT sensor library@^1.4.6**: Library for interfacing with DHT11 sensor.
4.  **adafruit/Adafruit Unified Sensor@^1.1.14**: Required for the DHT sensor library.
5.  **marcoschwartz/LiquidCrystal_I2C@^1.1.4**: Library for interfacing with the LCD using I2C protocol.

## Wiring and Pin definition:

-   GPIO 25 to 14 on the ESP32 are connected to the respective input pins (IN1 to IN4) of the relay module.
-   GPIO 16 is connected to the output pin of the IR proximity sensor.
-   GPIO 5 is connected to the signal pin (S) of the DHT11 sensor.
-   GPIO 22 is connected to the SCL (I2C Clock) pin of the LCD.
-   GPIO 21 is connected to the SDA (I2C Data) pin of the LCD.
-   Ensure all modules are connected to a power supply for proper operation.

![Wiring1](https://github.com/Vistx/Modbus-TCP-IP-over-WiFi-Implementation/assets/123487221/b64cefba-36f4-44a4-ae0d-51f1e972b095)

## Usage
1.  Clone this repository.
2.  Set up the hardware components according to the provided wiring and pin definitions.
3.  Open the PC application solution in Visual Studio 2019 and build the project.
4.  Flash the ESP32 controller using the provided code in Visual Studio Code with the PlatformIO extension.
5.  Run the PC application and connect to the ESP32 controller over WiFi.

![Live](https://github.com/Vistx/Modbus-TCP-IP-over-WiFi-Implementation/assets/123487221/d4b1642d-fac1-4706-bf28-56c48d9792ab)
