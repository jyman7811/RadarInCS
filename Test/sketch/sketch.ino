#include <Servo.h>
#include <string.h>

Servo servo;

int trigPin = 7;
int echoPin = 6;
int motor = 12;
int range = 20;
int now = 90;
bool reverse = false;

void setup() {
    servo.attach(motor);

    Serial.begin(500000);
    pinMode(trigPin, OUTPUT);
    pinMode(echoPin, INPUT);

    servo.write(now);
}

String input;
/*
Serial Commands
Send:
"Status(Finding = f, Locked = l), Servo Angle, Distance 1, 2, 3...."
Receive:
a(Azimuth), Azimuth value
*/


void loop() {
    // put your main code here, to run repeatedly:
    if (Serial.available() > 0) {
        input = Serial.readStringUntil('\n');

        if (input.startsWith("a")) {
            now = 90;

            range = input.substring(2).toInt();
        }

        if (input == "WORK") {

            servo.write(now);
            float distance = measure();
            Serial.println((String)distance + "," + (String)now);

            if (!reverse) {
                if (now == 90 - range / 2) {
                    reverse = true;
                }
                else {
                    now -= 2;
                }
            }
            else {
                if (now == 90 + range / 2) {
                    reverse = false;
                }
                else {
                    now += 2;
                }
            }
        }
    }
}

float measure() {
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);
    long duration = pulseIn(echoPin, HIGH);
    return duration * 340 / 2 / 10000;
}