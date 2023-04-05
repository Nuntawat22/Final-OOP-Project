1. ความเป็นมาของโปรแกรม
```
 อยากสร้างโปรแกรมเกี่ยวกับร้านอาหาร เพราะมีปัญหาเกี่ยวการ ไปร้านอาหารแล้วที่นั่งไม่พอ
```
2.วัตถุประสงค์ของโปรแกรม
 ```
 1.เพื่อให้ผู้คนที่จะเข้ามารับประทานอาหาร ได้เลือกจองโต๊ะที่นั่งได้สะดวกเเละง่ายยิ่งขึ้น
 2.เพื่อสามารถมีอีเมลส่งไปบอกว่าได้โต๊ะที่จุดอะไร
 3.สามารถคำนวณตังค์ เเละมีส่วนลดให้ง่ายๆ เพื่อบ้างคนไม่ถนัด คณิต 
 ```
3.โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown
 Class Diagram
 ```mermaid
classDiagram
  direction LR
  class form1{
  -cheakin():void
  -cheaout():void
  -Save():void
  -Clear():void
}
  class Pay{
  -discountcode():void
  -pay():void
  -back():void
  }
  class codepay{
  -couponCode:string
  -minimumPice:double
  +creat(double min):void
  +getCoupon():void
  }
  class Buy{
  -totalPice:double
  +Bill(pay double,getmoney Double):void
  +payBill():double
   }
   Pay -- codepay
   Pay -- Buy
   
  ```
 4.ชื่อของผู้พัฒนาโปรแกรม
  ```
 นาย นันทวัฒน์ แซ่ฮวม 653450510-0
  ```
