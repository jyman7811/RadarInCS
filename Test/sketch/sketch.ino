#include <Servo.h>

Servo servo;

int trigPin = 7;
int echoPin = 6;
int motor = 12;
int range = 100;
int now = 90;
bool reverse = false;

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
    Serial.println((String)distance + "," + (String)now);
    
    if (!reverse) {
      if (now == 90 -range / 2) {
        now += 2;
        reverse = true;
      } 
      else {
        now-=2;
      }
    }
    else {
        if (now == 90 +range / 2) {
          now -= 2;
          reverse = false;
        } 
        else {
          now+=2;
        }
    }

    delay(300);
}

float measure() {
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  long duration = pulseIn(echoPin, HIGH);
  return duration * 340 / 2 / 10000;
}