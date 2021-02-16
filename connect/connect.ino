#define BaudRate 9600
int servodegree = 0;
int input_data = 0;
int i = 0;
#include <Servo.h>
Servo servo1, servo2, servo3, servo4, servo5, servo6;

int main_command = 0; // error
void setup()
{
  servo1.attach(3);
  servo2.attach(5);
  servo3.attach(6);
  servo4.attach(9);
  servo5.attach(10);
  servo6.attach(11);
  Serial.begin(BaudRate);
}
void loop()
{
  dataup( );
  Servo1();
}
int dataup() {
  if (Serial.available()) {
    input_data = Serial.read();
    //check operation add or sub
    if (input_data == 255 || input_data == 254 ) {
      main_command = check_command(input_data);
    }
    // check value 
    else if (input_data <= 180 ) {
      if (main_command == 1) {
        if (servodegree < 180) {
          servodegree = servodegree + input_data;
        }
        else if (servodegree > 180) {
          servodegree = 180  ;
        }
      }
      else if (main_command == 2) {
        if (servodegree >= 15) {
          servodegree = servodegree - input_data;
        }
        else if (servodegree < 0) {
          servodegree = 0  ;
        }
      }
      else {
	run(input_data, servodegree);
      }
      Serial.println(servodegree);
      main_command = 0;

    }
  }
}


int check_servo_id (int input, int servodegree) {
  int servo_id = 0 ;

  if (input == 251) {
      servo1.write(servodegree);
  } 
  else if ( input == 252 ) {
      servo2.write(servodegree);
  }
  else if ( input == 253 ) {
      servo3.write(servodegree);
  }
  else if ( input == 254 ) {
      servo4.write(servodegree);
  }
  else if ( input == 255 ) {
      servo5.write(servodegree);
  }
  else if ( input == 256 ) {
      servo6.write(servodegree);
  } else {Serial.println("ERROR");}

}

int check_command(int input) {
  int command = 0;  // error
  if (input == 255) {
    command = 1; // add
  } else if (input == 254 ) {
    command = 2; //sub
  }
  return command;
}
