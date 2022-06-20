#!/usr/bin/env python
from socket import *
from time import ctime, sleep
import RPi.GPIO as GPIO

LedPin = 11

def setup():
    GPIO.setmode(GPIO.BOARD)
    GPIO.setup(LedPin, GPIO.OUT)   # Set pin mode as output
    GPIO.output(LedPin, GPIO.HIGH) # Set pin to high(+3.3V) to off the led

def loop():
    while True:
        sleep(1)
        GPIO.output(LedPin, GPIO.LOW)
        sleep(1)
        GPIO.output(LedPin, GPIO.HIGH)

if __name__ == '__main__':
    setup()
    loop()
