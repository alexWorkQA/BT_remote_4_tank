//first DC motor
int M1_1 = 5;
int M1_2 = 6;

//second DC motor
int M2_1 = 9;
int M2_2 = 10;

//command
char command;


void setup() {
Serial.begin(9600);
  

pinMode(M1_1, OUTPUT);
pinMode(M1_2, OUTPUT);

pinMode(M2_1, OUTPUT);
pinMode(M2_2, OUTPUT);

}

void backwardDC(){
  analogWrite(M1_1,220);
  analogWrite(M1_2,0);

  analogWrite(M2_1,220);
  analogWrite(M2_2,0);
}

void forwardDC(){
  analogWrite(M1_1,0);
  analogWrite(M1_2,220);

  analogWrite(M2_1,0);
  analogWrite(M2_2,220);
}

void leftDC(){
  analogWrite(M1_1,220);
  analogWrite(M1_2,0);

  analogWrite(M2_1,0);
  analogWrite(M2_2,220);
}

  void rightDC(){
  analogWrite(M1_1,0);
  analogWrite(M1_2,220);

  analogWrite(M2_1,220);
  analogWrite(M2_2,0);
}

void stopDC(){
  analogWrite(M1_1,0);
  analogWrite(M1_2,0);

  analogWrite(M2_1,0);
  analogWrite(M2_2,0); 
}

void loop() {

  if (Serial.available()>0){
  command = Serial.read();
  }
stopDC();

 switch (command){
 case 'F':
 forwardDC();
 break;
case 'B':
backwardDC();
break;
case 'R':
rightDC();
break;
case 'L':
leftDC();
break;
case 'S':
stopDC();
break;
 }


}
