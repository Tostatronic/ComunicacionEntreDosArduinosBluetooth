#define DELAY_ENCENDIDO 1000
#define DELAY_APAGADO 500
void setup()
{  
  Serial.begin(9600);
}
void loop()
{
  Serial.write('1');
  delay(DELAY_ENCENDIDO);
  Serial.write('a');
  delay(DELAY_APAGADO);
  Serial.write('2');
  delay(DELAY_ENCENDIDO);
  Serial.write('b');
  delay(DELAY_APAGADO);
  Serial.write('3');
  delay(DELAY_ENCENDIDO);
  Serial.write('c');
  delay(DELAY_APAGADO);
}
