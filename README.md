1. ความเป็นมาของโปรแกรม
```
 อยากสร้างโปรแกรมเกี่ยวกับร้านอาหาร เพราะมีปัญหาเกี่ยวการ ไปร้านอาหารแล้วที่นั่งไม่พอ
```
2.วัตถุประสงค์ของโปรแกรม
 ```
 1.เพื่อให้ผู้คนที่จะเข้ามารับประทานอาหาร ได้เลือกจองโต๊ะที่นั่งได้สะดวกเเละง่ายยิ่งขึ้น
 2.เพื่อสามารถมีอีเมลส่งไปบอกว่าได้โต๊ะที่จุดอะไร
 3.สามารถคำนวณตังค์ เเละมีส่วนลดให้ใช้งาน เผื่อขี้เกียจคำนวณตัวเลข
 ```
3.โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown
 Class Diagram
 ```mermaid
classDiagram
  direction RT
  class Restaurant{
  -login():void
}
class Restaurant1{
  -cheakin():void
  -cheaout():void
  -Save():void
  -Clear():void
  -fooditems():void
  -exitProgram():void
}
  class Restaurant2{
  -discountcode():void
  -pay():void
  -back():void
  }
  class Checkpay{
  -discountCode:string
  -minimumPice:double
  +creat(double min):void
  +getDiscount():void
  }
  class Buy{
  -totalPice:double
  +Bill(double pay, double getmoney):void
  +restaurantBill():double
   }
   class Information{
   -name, customerNumber, mail, day, seat:string
   -time:int
   +Class(string name, string cutomerNumber, string mail, string day, int time, string seat)
   }
   Pay -- Checkpay
   Pay -- Buy
   Pay -- Information
   
  ```
 4.ชื่อของผู้พัฒนาโปรแกรม
  ```
 นาย นันทวัฒน์ แซ่ฮวม 653450510-0
  ```
