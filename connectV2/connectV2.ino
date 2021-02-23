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
int sv1 = 0;
int sv2 = 0;
int sv3 = 0;
int sv4 = 0;
int sv5 = 0;
int sv6 = 0;
int times = 25;
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
           if (servodegree1 > 180) {
          servodegree1 = 180  ;
        }
          for (sv1 = 0; sv1 <= servodegree1; sv1=++i){
             Serial.println(sv1); 
            delay(times);
            }  
        }
      }
      else if (main_command == 2) {
        if (servodegree1 >= 0) {
          servodegree1 = servodegree1 - main_servodegree;
            if (servodegree1 < 0) {
          servodegree1 = 0  ;
        }
          for (sv1 >= 0; sv1 >= servodegree1; sv1= --i){
             Serial.println(sv1); 
            delay(times);}
             
        }
        }
        
      servo1.write(sv1);
  } 

  
  else if ( input == 202 ) {
      if (main_command == 1) {
        if (servodegree2 < 180) {
          servodegree2 = servodegree2 + main_servodegree;
           if (servodegree2 > 180) {
          servodegree2 = 180  ;
        }
          for (sv2 = 0; sv2 <= servodegree2; sv2=++i){
             Serial.println(sv2); 
            delay(times);
            }  
        }
      }
      else if (main_command == 2) {
        if (servodegree2 >= 0) {
          servodegree2 = servodegree2 - main_servodegree;
            if (servodegree2 < 0) {
          servodegree2 = 0  ;
        }
          for (sv2 >= 0; sv2 >= servodegree2; sv2= --i){
             Serial.println(sv2); 
            delay(times);}
             
        }
        }
        
  
      servo2.write(sv2);
  }
  else if ( input == 203 ) {
       if (main_command == 1) {
        if (servodegree3 < 180) {
          servodegree3 = servodegree3 + main_servodegree;
           if (servodegree3 > 180) {
          servodegree3 = 180  ;
        }
          for (sv3 = 0; sv3 <= servodegree3; sv3=++i){
             Serial.println(sv3); 
            delay(times);
            }  
        }
      }
      else if (main_command == 2) {
        if (servodegree3 >= 0) {
          servodegree3 = servodegree3 - main_servodegree;
            if (servodegree3 < 0) {
          servodegree3 = 0  ;
        }
          for (sv3 >= 0; sv3 >= servodegree3; sv3= --i){
             Serial.println(sv3); 
            delay(times);}
             
        }
        }   
      servo3.write(sv3);
  }
  else if ( input == 204 ) {
        if (main_command == 1) {
        if (servodegree4 < 180) {
          servodegree4 = servodegree4 + main_servodegree;
           if (servodegree4 > 180) {
          servodegree4 = 180  ;
        }
          for (sv4 = 0; sv4 <= servodegree4; sv4=++i){
             Serial.println(sv4); 
            delay(times);
            }  
        }
      }
      else if (main_command == 2) {
        if (servodegree4 >= 0) {
          servodegree4 = servodegree4 - main_servodegree;
            if (servodegree4 < 0) {
          servodegree4 = 0  ;
        }
          for (sv4 >= 0; sv4 >= servodegree4; sv4= --i){
             Serial.println(sv4); 
            delay(times);
        }    
        }
        }
      servo4.write(sv4);
  }
  else if ( input == 205 ) {
        if (main_command == 1) {
        if (servodegree5 < 180) {
          servodegree5 = servodegree5 + main_servodegree;
           if (servodegree5 > 180) {
          servodegree5 = 180  ;
        }
          for (sv5 = 0; sv5 <= servodegree5; sv5=++i){
             Serial.println(sv5); 
            delay(times);
            }  
        }
      }
      else if (main_command == 2) {
        if (servodegree5 >= 0) {
          servodegree5 = servodegree5 - main_servodegree;
            if (servodegree5 < 0) {
          servodegree5 = 0  ;
        }
          for (sv5 >= 0; sv5 >= servodegree5; sv5= --i){
             Serial.println(sv5); 
            delay(times);}
             
        }
        }
         
      servo5.write(sv5);
  }
  else if ( input == 206 ) {
        if (main_command == 1) {
        if (servodegree6 < 180) {
          servodegree6 = servodegree6 + main_servodegree;
           if (servodegree6 > 180) {
          servodegree6 = 180  ;
        }
          for (sv6 = 0; sv6 <= servodegree6; sv6=++i){
             Serial.println(sv6); 
            delay(times);
            }  
        }
      }
      else if (main_command == 2) {
        if (servodegree6 >= 0) {
          servodegree6 = servodegree6 - main_servodegree;
            if (servodegree6 < 0) {
          servodegree6 = 0  ;
        }
          for (sv6 >= 0; sv6 >= servodegree6; sv6= --i){
             Serial.println(sv6); 
            delay(times);}
             
        }
        }
        
      servo6.write(sv6);
  } 
  else {Serial.println("ERROR");}

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
