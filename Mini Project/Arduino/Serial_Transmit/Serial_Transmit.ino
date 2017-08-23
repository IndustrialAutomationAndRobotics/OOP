int LED = 13;

void setup(){

  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
  
}

void loop(){
  Serial.println("Hello Madefake");

  Blink_LED();
}

void Blink_LED(){
  digitalWrite(LED, HIGH);
  delay(1000);
  digitalWrite(LED, LOW);
  delay(1000);
}

