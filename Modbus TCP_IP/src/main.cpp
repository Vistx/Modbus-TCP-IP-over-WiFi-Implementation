#include <Arduino.h>
#include "DHT.h"
#ifdef ESP8266
 #include <ESP8266WiFi.h>
#else //ESP32
 #include <WiFi.h>
#endif
#include <ModbusIP_ESP8266.h>
#include "DHT.h"
#include <LiquidCrystal_I2C.h>

#define DHTTYPE DHT11
#define DHTPIN 5
#define Coil1 100
#define Coil2 101
#define Coil3 102
#define Coil4 103
#define temp_reg 50
#define D_pin_1 25
#define D_pin_2 26
#define D_pin_3 27
#define D_pin_4 14
#define d_in_pin 16
#define SWITCH_ISTS 100


//Modbus Registers Offsets
//Used Pins
unsigned long previousMillis = 0;
const long interval = 2000;
float temp=0;

//ModbusIP object
ModbusIP mb;
DHT dht(DHTPIN, DHTTYPE);
LiquidCrystal_I2C lcd(0x3F,16,2);
void setup() {
  Serial.begin(115200);
  lcd.init();            
  lcd.backlight();
  lcd.setCursor(0,0);
  lcd.print("Server IP:");
  lcd.setCursor(0,1);
  WiFi.begin("SSID", "Pass");
  
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
    lcd.print(". ");
  }
lcd.clear();
  
 
  Serial.println("");
  Serial.println("WiFi connected");  
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
   lcd.setCursor(0,0);
  lcd.print("Server IP:");
  lcd.setCursor(0,1);
  lcd.print(WiFi.localIP());
 dht.begin();
  mb.server();
  pinMode(d_in_pin, INPUT);
  pinMode(D_pin_1, OUTPUT);
  pinMode(D_pin_2, OUTPUT);
  pinMode(D_pin_3, OUTPUT);
  pinMode(D_pin_4, OUTPUT);
  mb.addCoil(Coil1);
  mb.addCoil(Coil2);
  mb.addCoil(Coil3);
  mb.addCoil(Coil4);
  mb.addHreg(temp_reg,temp);
  mb.addIsts(SWITCH_ISTS);
}
 
void loop() {
    unsigned long currentMillis = millis();

   //Call once inside loop() - all magic here
   mb.task();

   if (currentMillis - previousMillis >= interval) {
    // Save the last time something happened
    previousMillis = currentMillis;
    temp=dht.readTemperature();
   }
   
   mb.Hreg(temp_reg,temp);
   mb.Ists(SWITCH_ISTS, !digitalRead(d_in_pin));
   //Attach ledPin to Coil1 register
   digitalWrite(D_pin_1,!mb.Coil(Coil1));
   digitalWrite(D_pin_2,!mb.Coil(Coil2));
   digitalWrite(D_pin_3,!mb.Coil(Coil3));
   digitalWrite(D_pin_4,!mb.Coil(Coil4));
   delay(10);
}