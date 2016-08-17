void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial1.begin(9600);
}

void loop() 
{
  // put your main code here, to run repeatedly:
  if(Serial.available())
  {
    Serial1.write(Serial.read());
  }
}
