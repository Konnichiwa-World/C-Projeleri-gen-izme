using System;
using System.Collections;
class Program{
public static void Main(string[] args){
System.Console.WriteLine("Lütfen oluşacak ikizkenar üçgenlerin kenarını giriniz:");
Int32 x =Int32.Parse(Console.ReadLine());
KuzeyBatı(x);
KuzeyDogu(x);
GüneyBatı(x);
GüneyDogu(x);
GoldenShot(x);}

static void KuzeyBatı(int x){System.Console.WriteLine("2. Bölge Üçgeni");
for(int a=x;a>=1;a--){
for(int b=a;b>=1;b--){System.Console.Write(" ");}
for(int c=a;c<=x;c++){System.Console.Write("#");}System.Console.WriteLine();}
System.Console.WriteLine(" \n ");}

static void KuzeyDogu(int x){System.Console.WriteLine("1. Bölge Üçgeni");
for(int a=1;a<=x;a++){for(int b=1;b<=a;b++){System.Console.Write("#");}
System.Console.WriteLine();}System.Console.WriteLine(" \n ");}

static void GüneyBatı(int x){System.Console.WriteLine("3. Bölge Üçgeni");
for(int a=1;a<=x;a++){
for(int b=1;b<=a;b++){System.Console.Write(" ");}
for(int c=x;c>=a;c--){System.Console.Write("#");}System.Console.WriteLine("");}
System.Console.WriteLine(" \n ");}

static void GüneyDogu(int x){System.Console.WriteLine("4. Bölge Üçgeni");
for(int a=x;a>=1;a--){
for(int b=a;b>=1;b--){System.Console.Write("#");}System.Console.WriteLine();}System.Console.WriteLine(" \n ");}

static void GoldenShot(int x){System.Console.WriteLine(" GOLDENSHOT!!!\n");
for(int a=x;a>=1;a--){
  for(int b=a;b>=1;b--){System.Console.Write(" ");}
  for(int c=a;c<=x;c++){System.Console.Write("#");}
  System.Console.Write(" | ");
  for(int d=a;d<=x;d++){System.Console.Write("#");}
  System.Console.WriteLine();}
  for(int g=1;g<=x;g++){System.Console.Write(" -- ");}System.Console.Write("  ");
  System.Console.WriteLine();

  for(int a=x;a>=1;a--){
    for(int e=a; e<=x;e++){System.Console.Write(" ");}
    for(int f=a;f>=1;f--){System.Console.Write("#");}
    System.Console.Write(" | ");for(int g=a;g>=1;g--){System.Console.Write("#");}System.Console.WriteLine();
  }
}
}

