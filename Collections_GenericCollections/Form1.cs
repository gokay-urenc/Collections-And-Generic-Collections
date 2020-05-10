using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Collections_GenericCollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[3];
            sayilar[0] = 4;
            // int okunanSayi = sayilar[0]; // 0'ıncı index teki değeri okuduk.

            ArrayList sayilar1 = new ArrayList(); // Uzunluk 0'dır.
            // sayilar1[0] = 3; koleksiyonun eleman sayısı 0 olduğu için bu şekilde bir ekleme işlemi yapılamaz.

            // Arrayliste eleman ekleme 
            sayilar1.Add(4);
            sayilar1.Add(5); // Dizi uzunluğu 2'dir ve en büyük index 1'dir.
            sayilar1[1] = 10; // Atama.

            // ArrayList'in dizi uzunluğunu Count ile öğrenebilirsiniz.
            MessageBox.Show(sayilar1.Count.ToString());
            sayilar1.Reverse(); // Diziyi ters çevir.
            sayilar1.Sort(); // Diziyi sırala.

            // ArrayList yani Collections içerisindeki her elemanı object tipine çevirir.
            int okunanSayi = (int)sayilar1[0]; // Unboxing.

            ArrayList yeniDizi = new ArrayList();
            yeniDizi.Add(2);
            yeniDizi.Add("Onur");
            yeniDizi.Add('C');
            yeniDizi.Add(true);
            yeniDizi.Add(0.98);
            yeniDizi.Add(2.34f);
            bool gelenDeger = (bool)yeniDizi[4];

            // İlkel dizilerde tip güvenliği var iken Collections'larda tip güvenliği yoktur.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Generic Collection: ArrayList(Collections) , tip güvenliğinin olmaması ve okuma sırasında cast işleminin zorunlu olup hata payının yüksek olmasından dolayı yapılmış yeni bir dizi mantığıdır.
            List<int> numbers = new List<int>(); // tip güvenliği olan bir olaydır.
            numbers.Add(4);
            numbers.Add(14);
            numbers.Add(12);
            numbers.Add(87);
            int okunacakDeger = numbers[numbers.Count - 1]; // En son indexi okuma.
            // numbers.Add("AAA"); // Tip int olduğu için bu ekleme işlemi hatalıdır.
            // ArrayList(Collection) hataları çalışma zamanında oluşur.
            // GenericCollection(List<>) hataları derleme anında oluşur.
            int a = numbers.Count; // numbers dizisinin elaman sayısını verir.

            List<string> isimler = new List<string>();
            isimler.Add("Negan");

            List<double> ondaliklilar = new List<double>();
            ondaliklilar.Add(4.54);
        }
    }
}
/* Collections => Arraylar'ın(ilkel diziler[]) daha gelişmiş versiyonlarıdır. Örneğin; Arrayler'da en büyük problem eleman sayısı belirlemedir.
   Array kullanımında dizi uzunluğu zorunluluğu vardır.
   Collection kullanımında yoktur.
   Arraylerde diziye eleman eklerken index operatörü [] ile eklenirken, Collection'da Add metoduyla eklenir.
   Collection içerisindeki elemanlara yine index operatörü erişilir. 
   Bir array karşılığı collection olarak ArrayList sınıftır.
   Collection kullanımı: System.Collections kütüphanesi dahil edilmelidir.
*/
