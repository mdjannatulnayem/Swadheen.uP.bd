//Minimalistic ALU
//revision - 2

//outGoing
#define A0_PIN 12
#define A1_PIN 11
#define B0_PIN 10
#define B1_PIN 9
#define Cin_PIN 8
#define R0_PIN 7
#define R1_PIN 6
#define Co_PIN 5

//inComing
#define R0_NOT_PIN 14
#define R1_NOT_PIN 15
#define R0_OR_PIN 16
#define R1_OR_PIN 17
#define R0_AND_PIN 18
#define R1_AND_PIN 19
#define R0_ADD_PIN 20
#define R1_ADD_PIN 21

String In,Out;
char Cmd;
int a0,a1,b0,b1,cin,r0,r1,co;
int r0_not,r1_not,r0_or,r1_or;
int r0_and,r1_and,r0_add,r1_add;

void multiplex(int s1,int s0){
  //DUAL 4:1 MUX
  if(s1 == 0 && s0 == 0){
    r0 = r0_not;
    r1 = r1_not;
  }
  else if(s1 == 0 && s0 == 1){
    r0 = r0_or;
    r1 = r1_or;
  }
  else if(s1 == 1 && s0 == 0){
    r0 = r0_and;
    r1 = r1_and;
  }
  else if(s1 == 1 && s0 == 1){
    r0 = r0_add;
    r1 = r1_add;
  }
  else{
    //DO NOTHING!
  }

  digitalWrite(R0_PIN,r0);
  digitalWrite(R1_PIN,r1);
}

void takeOutput(){
  co = digitalRead(Co_PIN);
  r0_not = digitalRead(R0_NOT_PIN);
  r1_not = digitalRead(R1_NOT_PIN);
  r0_or = digitalRead(R0_OR_PIN);
  r1_or = digitalRead(R1_OR_PIN);
  r0_and = digitalRead(R0_AND_PIN);
  r1_and = digitalRead(R1_AND_PIN);
  r0_add = digitalRead(R0_ADD_PIN);
  r1_add = digitalRead(R1_ADD_PIN);
  
}

void giveFeedback(){
  Out = (String)co + " " +(String)r1 + " " +(String)r0;
  delay(50);
  Serial.println(Out);  
}

void setup() {
  Serial.begin(9600);
  pinMode(A0_PIN,OUTPUT); //a0
  pinMode(A1_PIN,OUTPUT); //a1
  pinMode(B0_PIN,OUTPUT); //b0
  pinMode(B1_PIN,OUTPUT); //b1
  pinMode(Cin_PIN,OUTPUT); //cin
  pinMode(R0_PIN,OUTPUT); //r0
  pinMode(R1_PIN,OUTPUT); //r1
  pinMode(Co_PIN,INPUT); //co
  pinMode(R0_NOT_PIN,INPUT); //r0_not
  pinMode(R1_NOT_PIN,INPUT); //r1_not
  pinMode(R0_OR_PIN,INPUT); //r0_or
  pinMode(R1_OR_PIN,INPUT); //r1_or
  pinMode(R0_AND_PIN,INPUT); //r0_and
  pinMode(R1_AND_PIN,INPUT); //r1_and
  pinMode(R0_ADD_PIN,INPUT); //r0_add
  pinMode(R1_ADD_PIN,INPUT); //r1_add
  
}


void loop() {
  //Check if connected!
  if(Serial.available()>0){
    //Operation??
    Cmd = Serial.read();
    //Choose!
    if(Cmd == '0'){
      In = Serial.readString();
      b1 = (int)In[2] - '0';
      b0 = (int)In[3] - '0';
      digitalWrite(B1_PIN,b1);
      digitalWrite(B0_PIN,b0);
      delay(150);
      takeOutput();
      multiplex(0,0);
    }
    
    else if(Cmd == '1'){
      In = Serial.readString();
      a1 = (int)In[0] - '0';
      a0 = (int)In[1] - '0';
      b1 = (int)In[2] - '0';
      b0 = (int)In[3] - '0';
      digitalWrite(A1_PIN,a1);
      digitalWrite(A0_PIN,a0);
      digitalWrite(B1_PIN,b1);
      digitalWrite(B0_PIN,b0);
      delay(150);
      takeOutput();
      multiplex(0,1);
    }
    
    else if(Cmd == '2'){
      In = Serial.readString();
      a1 = (int)In[0] - '0';
      a0 = (int)In[1] - '0';
      b1 = (int)In[2] - '0';
      b0 = (int)In[3] - '0';
      digitalWrite(A1_PIN,a1);
      digitalWrite(A0_PIN,a0);
      digitalWrite(B1_PIN,b1);
      digitalWrite(B0_PIN,b0);
      delay(150);
      takeOutput();
      multiplex(1,0);    
    }
    
    else if(Cmd == '3'){
      In = Serial.readString();
      a1 = (int)In[0] - '0';
      a0 = (int)In[1] - '0';
      b1 = (int)In[2] - '0';
      b0 = (int)In[3] - '0';
      cin = 0;
      digitalWrite(A1_PIN,a1);
      digitalWrite(A0_PIN,a0);
      digitalWrite(B1_PIN,b1);
      digitalWrite(B0_PIN,b0);
      digitalWrite(Cin_PIN,cin);
      delay(150);
      takeOutput();
      multiplex(1,1);
    }
    
    else if(Cmd == '4'){
      In = Serial.readString();
      a1 = (int)In[0] - '0';
      a0 = (int)In[1] - '0';
      b1 = (int)In[2] - '0';
      b0 = (int)In[3] - '0';
      digitalWrite(B1_PIN,b1);
      digitalWrite(B0_PIN,b0);
      delay(150);
      takeOutput();
      multiplex(0,0);
      digitalWrite(A1_PIN,r1);
      digitalWrite(A0_PIN,r0);
      digitalWrite(B1_PIN,0);
      digitalWrite(B0_PIN,1);
      delay(150);
      takeOutput();
      multiplex(1,1);
      digitalWrite(A1_PIN,a1);
      digitalWrite(A0_PIN,a0);
      digitalWrite(B1_PIN,r1);
      digitalWrite(B0_PIN,r0);
      delay(150);
      takeOutput();
      multiplex(1,1);
      
    }

    //feedback to interface
    else if(Cmd == '&'){
      giveFeedback();
    }
    
  }
}
