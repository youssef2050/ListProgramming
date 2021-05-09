using System;

class MainClass {
  public static void Main (string[] args) {
    while(true){
    Console.WriteLine ("\n1. Reading flats area.\n2. Displaying. \n3. Flats area average.\n4. Maximum flat area.\n5. Flats count 140-120.\n6. Exite.\n \n         Enter chice ()");
    int chice = Convert.ToInt32(Console.ReadLine());
    if(chice==1){
      //يتم ادخال مساحة الشقق
      Console.WriteLine ("Reading flats area");
    }else if(chice==2){
      // يتم طباعة جميع مساحات الشقق
      Console.WriteLine ("Displaying");  
    }else if(chice==3){
      //معدل مساحات الشقق الموجودة
      Console.WriteLine ("Flats area average");  
    }else if(chice==4){
      // اكبر مساحة شقة موجودة
      Console.WriteLine ("Maximum flat area");
    }else if(chice==5){
      // عدد الشقق التي مساحتها من 120-140 م2
      Console.WriteLine ("Flats count 140-120");
    }else if(chice==6){
      // الخروج من البرنامج 
      Console.WriteLine ("Thank you for using our software !");
      break;
    }else{
      Console.WriteLine ("Enter number 1 to 6 \n");
    }
    }

  }

}


/*
 كتب قائمة مناسبة للبرنامج 
اكتب تعليقاتك باللغة العربية على جميع أجزاء البرنامج للأهمية 
Reading flats area
Displaying 
Flats area average 
Maximum flat area
Flats count 140-120
Exite
Enter chice ()
*/