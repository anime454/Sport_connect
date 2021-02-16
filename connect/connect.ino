#define BaudRate 9600
int main_servodegree = 0; 
int servodegree1 = 0;
int servodegree2 = 0;
int servodegree3 = 0;
int servodegree4 = 0;
int servodegree5 = 0;
int servodegree6 = 0;
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
      main_servodegree = input_data;
    }
    else {
      run(input_data, main_servodegree);
    }
  }
}


int run (int input, int main_servodegree) {

  if (input == 201) {
      if (main_command == 1) {
        if (servodegree1 < 180) {
          servodegree1 = servodegree1 + main_servodegree;
        }
        else if (servodegree1 > 180) {
          servodegree1 = 180  ;
        }
      }
      else if (main_command == 2) {
        if (servodegree1 >= 15) {
          servodegree1 = servodegree1 - main_servodegree;
        }
        else if (servodegree1 < 0) {
          servodegree1 = 0  ;
        }
      }
      Serial.println(servodegree1); 
      servo1.write(servodegree1);
  } 
  else if ( input == 202 ) {
      if (main_command == 1) {
        if (servodegree2 < 180) {
          servodegree2 = servodegree2 + main_servodegree;
        }
        else if (servodegree2 > 180) {
          servodegree2 = 180  ;
        }
      }
      else if (main_command == 2) {
        if (servodegree2 >= 15) {
          servodegree2 = servodegree2 - main_servodegree;
        }
        else if (servodegree2 < 0) {
          servodegree2 = 0  ;
        }
      }
      Serial.println(servodegree2); 
      servo2.write(servodegree2);
  }
  else if ( input == 203 ) {
      if (main_command == 1) {
        if (servodegree3 < 180) {
          servodegree3 = servodegree3 + main_servodegree;
        }
        else if (servodegree3 > 180) {
          servodegree3 = 180  ;
        }
      }
      else if (main_command == 2) {
        if (servodegree3 >= 15) {
          servodegree3 = servodegree3 - main_servodegree;
        }
        else if (servodegree3 < 0) {
          servodegree3 = 0  ;
        }
      }
      Serial.println(servodegree3); 
      servo3.write(servodegree3);
  }
  else if ( input == 204 ) {
      if (main_command == 1) {
        if (servodegree4 < 180) {
          servodegree4 = servodegree4 + main_servodegree;
        }
        else if (servodegree4 > 180) {
          servodegree4 = 180  ;
        }
      }
      else if (main_command == 2) {
        if (servodegree4 >= 15) {
          servodegree4 = servodegree4 - main_servodegree;
        }
        else if (servodegree4 < 0) {
          servodegree4 = 0  ;
        }
      }
      Serial.println(servodegree4); 
      servo4.write(servodegree4);
  }
  else if ( input == 205 ) {
      if (main_command == 1) {
        if (servodegree5 < 180) {
          servodegree5 = servodegree5 + main_servodegree;
        }
        else if (servodegree5 > 180) {
          servodegree5 = 180  ;
        }
      }
      else if (main_command == 2) {
        if (servodegree5 >= 15) {
          servodegree5 = servodegree5 - main_servodegree;
        }
        else if (servodegree5 < 0) {
          servodegree5 = 0  ;
        }
      }
      Serial.println(servodegree5); 
      servo5.write(servodegree5);
  }
  else if ( input == 206 ) {
      if (main_command == 1) {
        if (servodegree6 < 180) {
          servodegree6 = servodegree6 + main_servodegree;
        }
        else if (servodegree6 > 180) {
          servodegree6 = 180  ;
        }
      }
      else if (main_command == 2) {
        if (servodegree6 >= 15) {
          servodegree6 = servodegree6 - main_servodegree;
        }
        else if (servodegree6 < 0) {
          servodegree6 = 0  ;
        }
      }
      Serial.println(servodegree6); 
      servo6.write(servodegree6);
  } else {Serial.println("ERROR");}

  main_command = 0;
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
