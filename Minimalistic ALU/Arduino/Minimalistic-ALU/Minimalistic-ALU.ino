#define S0_PIN 12
#define S1_PIN 11
#define A0_PIN 9
#define A1_PIN 8
#define B0_PIN 7
#define B1_PIN 6
#define Cin_PIN 5
#define R0_PIN 4
#define R1_PIN 3
#define Co_PIN 2

String In,Out;
char Cmd;
int a0,a1,b0,b1,cin,r0,r1,co;

void setOpcode(int s1,int s0){
  digitalWrite(S0_PIN,s0);
  digitalWrite(S1_PIN,s1);
}

void takeOutput(){
  r0 = digitalRead(R0_PIN);
  r1 = digitalRead(R1_PIN);
  co = digitalRead(Co_PIN);
}

void giveFeedback(){
  Out = (String)co + " " +(String)r1 + " " +(String)r0;
  delay(50);
  Serial.println(Out);  
}

void setup() {
  Serial.begin(9600);
  pinMode(S0_PIN,OUTPUT); //s0
  pinMode(S1_PIN,OUTPUT); //s1
  pinMode(A0_PIN,OUTPUT); //a0
  pinMode(A1_PIN,OUTPUT); //a1
  pinMode(B0_PIN,OUTPUT); //b0
  pinMode(B1_PIN,OUTPUT); //b1
  pinMode(Cin_PIN,OUTPUT); //cin
  pinMode(R0_PIN,INPUT); //r0
  pinMode(R1_PIN,INPUT); //r1
  pinMode(Co_PIN,INPUT); //co
  digitalWrite(S0_PIN,LOW);
  digitalWrite(S1_PIN,LOW);
  digitalWrite(A0_PIN,LOW);
  digitalWrite(A1_PIN,LOW);
  digitalWrite(B0_PIN,LOW);
  digitalWrite(B1_PIN,LOW);
  digitalWrite(Co_PIN,LOW);
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
      setOpcode(0,0);
      delay(150);
      takeOutput();
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
      setOpcode(0,1);
      delay(150);
      takeOutput();
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
      setOpcode(1,0);
      delay(150);
      takeOutput();      
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
      setOpcode(1,1);
      delay(150);
      takeOutput();
    }
    
    else if(Cmd == '4'){
      In = Serial.readString();
      a1 = (int)In[0] - '0';
      a0 = (int)In[1] - '0';
      b1 = (int)In[2] - '0';
      b0 = (int)In[3] - '0';
      digitalWrite(B1_PIN,b1);
      digitalWrite(B0_PIN,b0);
      setOpcode(0,0);
      delay(150);
      takeOutput();
      digitalWrite(A1_PIN,r1);
      digitalWrite(A0_PIN,r0);
      digitalWrite(B1_PIN,0);
      digitalWrite(B0_PIN,1);
      setOpcode(1,1);
      delay(150);
      takeOutput();
      digitalWrite(A1_PIN,a1);
      digitalWrite(A0_PIN,a0);
      digitalWrite(B1_PIN,r1);
      digitalWrite(B0_PIN,r0);
      setOpcode(1,1);
      delay(150);
      takeOutput();
      if(co==0){
        digitalWrite(B1_PIN,r1);
        digitalWrite(B0_PIN,r0);
        setOpcode(0,0);
        delay(150);
        takeOutput();
        digitalWrite(A1_PIN,r1);
        digitalWrite(A0_PIN,r0);
        digitalWrite(B1_PIN,0);
        digitalWrite(B0_PIN,1);
        setOpcode(1,1);
        delay(150);
        takeOutput();
      }
    }
    
    else if(Cmd == '&'){
      giveFeedback();
    }
  }
}
