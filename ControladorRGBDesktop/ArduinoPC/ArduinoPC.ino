String RGB;
int tira[]={2,3,4};
void setup() 
{
  // put your setup code here, to run once:
  Serial.begin(9600);
  for(int i=0;i<3;i++)
  {
    pinMode(tira[i],OUTPUT);
  }
}

void loop() 
{
  // put your main code here, to run repeatedly:
  if(Serial.available())
  {
    RGB=Serial.readString();
    SplitString(RGB);
  }
}

void SplitString(String aux)
{
  //255,0,0,
  String R,G,B;
  int cont=0,st;
  for (int i = 0; i < aux.length(); i++) {
      if (aux.substring(i, i+1) == ",") 
      {
        if(cont==0)
        {
          R=aux.substring(0, i);
          st=i+1;
          cont++;
        }
        else if(cont==1)
        {
          G=aux.substring(st, i);
          st=i+1;
          cont++;
        }
        else
        {
           B=aux.substring(st, i);
          st=i+1;
          cont++;
        }
      }
    }
    analogWrite(tira[0],R.toInt());
    analogWrite(tira[1],G.toInt());
    analogWrite(tira[2],B.toInt());
}
