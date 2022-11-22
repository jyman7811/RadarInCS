#include <Servo.h>

Servo servo;

int trigPin = 7;
int echoPin = 6;
int motor = 12;
int range = 20;
int now = 90;

void setup() {
  servo.attach(motor);

  Serial.begin(9600);
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
}


/*
Serial Commands
Send:
"Status(Finding = f, Locked = l), Servo Angle, Distance 1, 2, 3...."
Receive:
a(Azimuth), Azimuth value
*/

void loop() {
  // put your main code here, to run repeatedly:
  // if (Serial.available()) {
    // String input = Serial.readString().;
    // if (input.startsWith("a"))

    servo.write(now);
    float distance = measure();
    Serial.println(distance + "," + now);
    

    delay(500);
  // }
}

float measure() {
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  long duration = pulseIn(echoPin, HIGH);
  return duration * 340 / 2 / 10000;
}