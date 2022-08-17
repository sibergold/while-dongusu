using System;
namespace while_dongusu{
    class Program{
        static void Main(string[] args){
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //int sayac=1;
            //int toplam=0;
            //while(sayac<=sayi){
              //toplam+=sayac;
              //sayac++;
            //}
            //Console.WriteLine(toplam/sayi);
            //char character='a';
            //while(character<'z'){
            //character ++;}
            Console.WriteLine("**** Foreach ****");
            string[] arabalar= {"BMW","Ford","Toyota","Nissan"};
            foreach(var araba in arabalar){
                Console.WriteLine(araba);
            }
            
            
            }
    }
}