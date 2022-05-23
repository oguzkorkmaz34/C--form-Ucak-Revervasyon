using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        DialogResult sigara_mesaj,soru_mesaj;
        int listedeki_eleman_sayisi;
        bool sigara;
        int[,] rezervasyon = new int[8,10];
        int i, j;
        string bolum;
        string ad;
        public Form1()
        {
            InitializeComponent();
            listedeki_eleman_sayisi = 0;
            sigara_mesaj = MessageBox.Show("Uçakta sigara içmek istiyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sigara_mesaj==DialogResult.Yes)
            {
                sigara = true;
                radioButton1.Checked = true;
            }
            if (sigara_mesaj == DialogResult.No)
            {
                sigara = false;
                radioButton2.Checked = true;
            }
            for(i=0;i<8;i++)
            {
                for(j=0;j<10;j++)
                {
                    rezervasyon[i,j] = 0;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            ad = textBox1.Text;
            if (sigara == true)
            {
                if (comboBox1.Text == "00:00")
                {
                    if (rezervasyon[0, 4] != 1)
                    {

                        for (i = 0; i < 5; i++)
                        {
                            if (rezervasyon[0, i] == 0)
                            {
                                bolum = "Sigara icilebilir";
                                rezervasyon[0, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[0, 9] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilen bölümde boş yer yok,sigara içilmeyen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 5; i < 10; i++)
                                {
                                    if (rezervasyon[0, i] == 0)
                                    {
                                        bolum = "Sigara icilemez";
                                        rezervasyon[0, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "03:00")
                {
                    if (rezervasyon[1, 4] != 1)
                    {

                        for (i = 0; i < 5; i++)
                        {
                            if (rezervasyon[1, i] == 0)
                            {
                                bolum = "Sigara icilebilir";
                                rezervasyon[1, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[1, 9] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilen bölümde boş yer yok,sigara içilmeyen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 5; i < 10; i++)
                                {
                                    if (rezervasyon[1, i] == 0)
                                    {
                                        bolum = "Sigara icilemez";
                                        rezervasyon[1, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "06:00")
                {
                    if (rezervasyon[2, 4] != 1)
                    {

                        for (i = 0; i < 5; i++)
                        {
                            if (rezervasyon[2, i] == 0)
                            {
                                bolum = "Sigara icilebilir";
                                rezervasyon[2, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[2, 9] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilen bölümde boş yer yok,sigara içilmeyen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 5; i < 10; i++)
                                {
                                    if (rezervasyon[2, i] == 0)
                                    {
                                        bolum = "Sigara icilemez";
                                        rezervasyon[2, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "09:00")
                {
                    if (rezervasyon[3, 4] != 1)
                    {

                        for (i = 0; i < 5; i++)
                        {
                            if (rezervasyon[3, i] == 0)
                            {
                                bolum = "Sigara icilebilir";
                                rezervasyon[3, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                              
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[3, 9] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilen bölümde boş yer yok,sigara içilmeyen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 5; i < 10; i++)
                                {
                                    if (rezervasyon[3, i] == 0)
                                    {
                                        bolum = "Sigara icilemez";
                                        rezervasyon[3, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "12:00")
                {
                    if (rezervasyon[4, 4] != 1)
                    {

                        for (i = 0; i < 5; i++)
                        {
                            if (rezervasyon[4, i] == 0)
                            {
                                bolum = "Sigara icilebilir";
                                rezervasyon[4, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[4, 9] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilen bölümde boş yer yok,sigara içilmeyen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 5; i < 10; i++)
                                {
                                    if (rezervasyon[4, i] == 0)
                                    {
                                        bolum = "Sigara icilemez";
                                        rezervasyon[4, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "15:00")
                {
                    if (rezervasyon[5, 4] != 1)
                    {

                        for (i = 0; i < 5; i++)
                        {
                            if (rezervasyon[5, i] == 0)
                            {
                                bolum = "Sigara icilebilir";
                                rezervasyon[5, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[5, 9] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilen bölümde boş yer yok,sigara içilmeyen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 5; i < 10; i++)
                                {
                                    if (rezervasyon[5, i] == 0)
                                    {
                                        bolum = "Sigara icilemez";
                                        rezervasyon[5, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "18:00")
                {
                    if (rezervasyon[6, 4] != 1)
                    {

                        for (i = 0; i < 5; i++)
                        {
                            if (rezervasyon[6, i] == 0)
                            {
                                bolum = "Sigara icilebilir";
                                rezervasyon[6, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[6, 9] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilen bölümde boş yer yok,sigara içilmeyen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 5; i < 10; i++)
                                {
                                    if (rezervasyon[6, i] == 0)
                                    {
                                        bolum = "Sigara icilemez";
                                        rezervasyon[6, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "21:00")
                {
                    if (rezervasyon[7, 4] != 1)
                    {

                        for (i = 0; i < 5; i++)
                        {
                            if (rezervasyon[7, i] == 0)
                            {
                                bolum = "Sigara icilebilir";
                                rezervasyon[7, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[7, 9] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilen bölümde boş yer yok,sigara içilmeyen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 5; i < 10; i++)
                                {
                                    if (rezervasyon[7, i] == 0)
                                    {
                                        bolum = "Sigara icilemez";
                                        rezervasyon[7, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (comboBox1.Text == "00:00")
                {
                    if (rezervasyon[0, 9] != 1)
                    {

                        for (i = 5; i < 10; i++)
                        {
                            if (rezervasyon[0, i] == 0)
                            {
                                bolum = "Sigara icilemez";
                                rezervasyon[0, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[0, 4] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilmeyen bölümde boş yer yok,sigara içilen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 0; i < 5; i++)
                                {
                                    if (rezervasyon[0, i] == 0)
                                    {
                                        bolum = "Sigara icilebilir";
                                        rezervasyon[0, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "03:00")
                {
                    if (rezervasyon[1, 9] != 1)
                    {
                        
                        for (i = 5; i < 10; i++)
                        {
                            if (rezervasyon[1, i] == 0)
                            {
                                bolum = "Sigara icilemez";
                                rezervasyon[1, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[1, 4] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilmeyen bölümde boş yer yok,sigara içilen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 0; i < 5; i++)
                                {
                                    if (rezervasyon[1, i] == 0)
                                    {
                                        bolum = "Sigara icilebilir";
                                        rezervasyon[1, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (comboBox1.Text == "06:00")
                {
                    if (rezervasyon[2, 9] != 1)
                    {

                        for (i = 5; i < 10; i++)
                        {
                            if (rezervasyon[2, i] == 0)
                            {
                                bolum = "Sigara icilemez";
                                rezervasyon[2, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[2, 4] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilmeyen bölümde boş yer yok,sigara içilen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 0; i < 5; i++)
                                {
                                    if (rezervasyon[2, i] == 0)
                                    {
                                        bolum = "Sigara icilebilir";
                                        rezervasyon[2, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (comboBox1.Text == "09:00")
                {
                    if (rezervasyon[3, 9] != 1)
                    {

                        for (i = 5; i < 10; i++)
                        {
                            if (rezervasyon[3, i] == 0)
                            {
                                bolum = "Sigara icilemez";
                                rezervasyon[3, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[3, 4] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilmeyen bölümde boş yer yok,sigara içilen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 0; i < 5; i++)
                                {
                                    if (rezervasyon[3, i] == 0)
                                    {
                                        bolum = "Sigara icilebilir";
                                        rezervasyon[3, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (comboBox1.Text == "12:00")
                {
                    if (rezervasyon[4, 9] != 1)
                    {

                        for (i = 5; i < 10; i++)
                        {
                            if (rezervasyon[4, i] == 0)
                            {
                                bolum = "Sigara icilemez";
                                rezervasyon[4, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[4, 4] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilmeyen bölümde boş yer yok,sigara içilen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 0; i < 5; i++)
                                {
                                    if (rezervasyon[4, i] == 0)
                                    {
                                        bolum = "Sigara icilebilir";
                                        rezervasyon[4, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (comboBox1.Text == "15:00")
                {
                    if (rezervasyon[5, 9] != 1)
                    {

                        for (i = 5; i < 10; i++)
                        {
                            if (rezervasyon[5, i] == 0)
                            {
                                bolum = "Sigara icilemez";
                                rezervasyon[5, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[5, 4] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilmeyen bölümde boş yer yok,sigara içilen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 0; i < 5; i++)
                                {
                                    if (rezervasyon[5, i] == 0)
                                    {
                                        bolum = "Sigara icilebilir";
                                        rezervasyon[5, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (comboBox1.Text == "18:00")
                {
                    if (rezervasyon[6, 9] != 1)
                    {

                        for (i = 5; i < 10; i++)
                        {
                            if (rezervasyon[6, i] == 0)
                            {
                                bolum = "Sigara icilemez";
                                rezervasyon[6, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[6, 4] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilmeyen bölümde boş yer yok,sigara içilen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 0; i < 5; i++)
                                {
                                    if (rezervasyon[6, i] == 0)
                                    {
                                        bolum = "Sigara icilebilir";
                                        rezervasyon[6, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (comboBox1.Text == "21:00")
                {
                    if (rezervasyon[7, 9] != 1)
                    {

                        for (i = 5; i < 10; i++)
                        {
                            if (rezervasyon[7, i] == 0)
                            {
                                bolum = "Sigara icilemez";
                                rezervasyon[7, i] = 1;
                                kontrol = true;
                                listedeki_eleman_sayisi++;
                                listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                break;
                            }
                        }
                    }
                    else if (kontrol == false)
                    {
                        if (rezervasyon[7, 4] != 1)
                        {
                            soru_mesaj = MessageBox.Show("Sigara içilmeyen bölümde boş yer yok,sigara içilen bölümde yolculuk yapmak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (soru_mesaj == DialogResult.Yes)
                            {

                                for (i = 0; i < 5; i++)
                                {
                                    if (rezervasyon[7, i] == 0)
                                    {
                                        bolum = "Sigara icilebilir";
                                        rezervasyon[7, i] = 1;
                                        kontrol = true;
                                        listedeki_eleman_sayisi++;
                                        listBox1.Items.Add(listedeki_eleman_sayisi.ToString() + "--->" + "Bölüm: " + bolum + "---" + " Ad-Soyad: " + ad + "---" + " Koltuk Numarası:" + (i + 1).ToString() + " Uçuş saati: " + comboBox1.Text);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz saatte maalesef yer yok, 3 saat sonraki uçuşumuza rezervasyon yapmayı deneyebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }






            }
        }
           
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sigara = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listedeki_eleman_sayisi = 0;
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    rezervasyon[i, j] = 0;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sigara = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
