char c;
void setup()
{      

//inicializa la comunicacion serial  
   Serial.begin(9600);
   
//se configura los pines de entrada y salida   
   pinMode(13,OUTPUT);
   pinMode(12,OUTPUT);
   pinMode(11,OUTPUT);
   
// inicializa el estdo de los LEDs   
   digitalWrite(13,LOW);
   digitalWrite(12,LOW);
   digitalWrite(11,LOW);   
}

void loop() 
{
  if(Serial.available())
  {
    c=Serial.read();
    if(c=='1') digitalWrite(13,HIGH);
    else if(c=='2') digitalWrite(12,HIGH);
    else if(c=='3') digitalWrite(11,HIGH);   
    else if(c=='a') digitalWrite(13,LOW);
    else if(c=='b') digitalWrite(12,LOW);
    else if(c=='c') digitalWrite(11,LOW);  
  }
}
