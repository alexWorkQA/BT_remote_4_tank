#include <SoftwareSerial.h>

void setup() {
SoftwareSerial BTSerial(0,1);
BTSerial.begin(9600);
Serial.begin(9600);
}

void loop() {
 

}
