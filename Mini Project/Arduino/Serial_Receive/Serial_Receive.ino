
int LED = 13;
int LED_Blink = 0;

void setup(){
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
}

void loop(){

  char Data_Received;

  if(Serial.available() > 0){

    Data_Received = Serial.read();

    LED_Blink = int(Data_Received);
    LED_Blink = LED_Blink - 48;
  }else{
    LED_Blink = 0;
  }

  Blink_LED(LED_Blink);
}

void Blink_LED(int times){

  Serial.println(times);
  
  while(times > 0){
    digitalWrite(LED, HIGH);
    delay(500);
    digitalWrite(LED, LOW);
    delay(500);
    times--;
  }
}

