#define BaudRate 9600
int servodegree = 0;
int input_data = 0;
int i = 0;
int main_command = 0; // error
void setup()
{
  Serial.begin(BaudRate);
}
void loop()
{
  if (Serial.available()) {
    input_data = Serial.read();
    if (input_data > 180 ) {
      main_command = check_command(input_data);
    } else if (input_data <= 180 ) {
      if (main_command == 1) {
        servodegree = servodegree + input_data;
      } else if (main_command == 2) {
        servodegree = servodegree - input_data;
      } else {
        Serial.println(input_data);
      }
      Serial.println(servodegree);
      main_command = 0;
      
    }
  }
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