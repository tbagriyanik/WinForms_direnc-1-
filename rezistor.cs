using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace direnc
{
    class rezistor
    {
        public float renk1 { get; set; }
        public float renk2 { get; set; }
        public float renk3 { get; set; }
        public float renk4 { get; set; }
        public float direncOhm { get; set; }
        public string tolerans { get; set; }

        public Color renkColor1 { get; set; }
        public Color renkColor2 { get; set; }
        public Color renkColor3 { get; set; }

        //açılır kutulardan direnç değeri yapma
        public void DirencDegeri()
        {
            direncOhm = 0; //Değerleri hesaplamaya başlamadan SIFIRLAyalım

            //renk1
            if (renk1 == 0) //siyah
            {
                direncOhm += 0;
            }
            if (renk1 == 1) //kahverengi
            {
                direncOhm += 10;
            }
            if (renk1 == 2) //kırmızı
            {
                direncOhm += 20;
            }
            if (renk1 == 3) //turuncu
            {
                direncOhm += 30;
            }
            if (renk1 == 4) //sarı
            {
                direncOhm += 40;
            }
            if (renk1 == 5) //yeşil
            {
                direncOhm += 50;
            }
            if (renk1 == 6) //mavi
            {
                direncOhm += 60;
            }
            if (renk1 == 7) //mor
            {
                direncOhm += 70;
            }
            if (renk1 == 8) //gri
            {
                direncOhm += 80;
            }
            if (renk1 == 9) //beyaz
            {
                direncOhm += 90;
            }

            //ikinci renk
            if (renk2 == 1) //kahverengi
            {
                direncOhm += 1;
            }
            if (renk2 == 2) //kırmızı
            {
                direncOhm += 2;
            }
            if (renk2 == 3) //turuncu
            {
                direncOhm += 3;
            }
            if (renk2 == 4) //sarı
            {
                direncOhm += 4;
            }
            if (renk2 == 5) //yeşil
            {
                direncOhm += 5;
            }
            if (renk2 == 6) //mavi
            {
                direncOhm += 6;
            }
            if (renk2 == 7) //mor
            {
                direncOhm += 7;
            }
            if (renk2 == 8) //gri
            {
                direncOhm += 8;
            }
            if (renk2 == 9) //beyaz
            {
                direncOhm += 9;
            }

            //üçüncü renk
            if (renk3 == 1) //kahverengi
            {
                direncOhm *= 10;
            }
            if (renk3 == 2) //kırmızı
            {
                direncOhm *= 100;
            }
            if (renk3 == 3) //turuncu
            {
                direncOhm *= 1000;
            }
            if (renk3 == 4) //sarı
            {
                direncOhm *= 10000;
            }
            if (renk3 == 5) //yeşil
            {
                direncOhm *= 100000;
            }
            if (renk3 == 6) //mavi
            {
                direncOhm *= 1000000;
            }
            if (renk3 == 7) //mor
            {
                direncOhm *= 10000000;
            }
            if (renk3 == 8) //gri
            {
                direncOhm *= 100000000;
            }
            if (renk3 == 9) //beyaz
            {
                direncOhm *= 1000000000;
            }
            if (renk3 == 10) //altın
            {
                direncOhm *= 0.1f;
            }
            if (renk3 == 11) //gümüş
            {
                direncOhm *= 0.01f;
            }

            //dördüncü renk
            if (renk4 == 0) //altın
            {
                tolerans = "%5 altın";
            }
            if (renk4 == 1) //gümüş
            {
                tolerans = "%10 gümüş";
            }
            if (renk4 == 2) //yok
            {
                tolerans = "%20 boş";
            }
        }

        //metin kutusundan geleni de renge çevir
        public void metindenRengeCevir(string gelen)
        {
            if (gelen.Length >= 2)
            {
                char ilkHarf = gelen[0];        //renk1
                char ikinciHarf = gelen[1];     //renk2

                switch (ilkHarf)
                {
                    case '0':
                        renkColor1 = Color.Black;
                        break;
                    case '1':
                        renkColor1 = Color.SaddleBrown;
                        break;
                    case '2':
                        renkColor1 = Color.Red;
                        break;
                    case '3':
                        renkColor1 = Color.Orange;
                        break;
                    case '4':
                        renkColor1 = Color.Yellow;
                        break;
                    case '5':
                        renkColor1 = Color.Green;
                        break;
                    case '6':
                        renkColor1 = Color.Blue;
                        break;
                    case '7':
                        renkColor1 = Color.Purple;
                        break;
                    case '8':
                        renkColor1 = Color.Gray;
                        break;
                    case '9':
                        renkColor1 = Color.White;
                        break;
                    default:
                        break;
                }

                switch (ikinciHarf)
                {
                    case '0':
                        renkColor2 = Color.Black;
                        break;
                    case '1':
                        renkColor2 = Color.SaddleBrown;
                        break;
                    case '2':
                        renkColor2 = Color.Red;
                        break;
                    case '3':
                        renkColor2 = Color.Orange;
                        break;
                    case '4':
                        renkColor2 = Color.Yellow;
                        break;
                    case '5':
                        renkColor2 = Color.Green;
                        break;
                    case '6':
                        renkColor2 = Color.Blue;
                        break;
                    case '7':
                        renkColor2 = Color.Purple;
                        break;
                    case '8':
                        renkColor2 = Color.Gray;
                        break;
                    case '9':
                        renkColor2 = Color.White;
                        break;
                    default:
                        break;
                }

                int carpan = gelen.Substring(2).Length; //kalan harflerde kaç 0 varsa
                switch (carpan)
                {
                    case 0:
                        renkColor3 = Color.Black;
                        break;
                    case 1:
                        renkColor3 = Color.SaddleBrown;
                        break;
                    case 2:
                        renkColor3 = Color.Red;
                        break;
                    case 3:
                        renkColor3 = Color.Orange;
                        break;
                    case 4:
                        renkColor3 = Color.Yellow;
                        break;
                    case 5:
                        renkColor3 = Color.Green;
                        break;
                    case 6:
                        renkColor3 = Color.Blue;
                        break;
                    case 7:
                        renkColor3 = Color.Purple;
                        break;
                    case 8:
                        renkColor3 = Color.Gray;
                        break;
                    case 9:
                        renkColor3 = Color.White;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
