using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;

namespace AndroidSwitchActivities
{
    [Activity]
    public class DonacjeStandard : Activity
    {
        public int wynik = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DonacjeStandard);
            obliczenia();
            var btnDonZapis = FindViewById<Button>(Resource.Id.btnStandardZapisz);
            btnDonZapis.Click += (s, e) => {
                writeFile(wynik.ToString());
                Intent nActivity = new Intent(this, typeof(PrzelicznikActivity));
                StartActivity(nActivity);
            };
        }

        public static void writeFile(string word)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "standard.txt");

            using (var streamWriter = new StreamWriter(filename, false))
            {
                streamWriter.WriteLine(word);
                System.Diagnostics.Debug.WriteLine(word);
            }
        }

        public void obliczenia()
        {
            EditText txtkrewpelna1 = FindViewById<EditText>(Resource.Id.txtkrewpelna1);
            EditText txtkrewpelna2 = FindViewById<EditText>(Resource.Id.txtkrewpelna2);
            EditText txtkrewpelna3 = FindViewById<EditText>(Resource.Id.txtkrewpelna3);
            txtkrewpelna1.TextChanged += Txtkrewpelna1_TextChanged;
            txtkrewpelna2.TextChanged += Txtkrewpelna2_TextChanged;
            txtkrewpelna3.TextChanged += Txtkrewpelna3_TextChanged;

            EditText txtosocze1 = FindViewById<EditText>(Resource.Id.txtosocze1);
            EditText txtosocze2 = FindViewById<EditText>(Resource.Id.txtosocze2);
            EditText txtosocze3 = FindViewById<EditText>(Resource.Id.txtosocze3);
            txtosocze1.TextChanged += Txtosocze1_TextChanged;
            txtosocze2.TextChanged += Txtosocze2_TextChanged;
            txtosocze3.TextChanged += Txtosocze3_TextChanged;

            EditText txtplytki1 = FindViewById<EditText>(Resource.Id.txtplytki1);
            EditText txtplytki2 = FindViewById<EditText>(Resource.Id.txtplytki2);
            EditText txtplytki3 = FindViewById<EditText>(Resource.Id.txtplytki3);
            txtplytki1.TextChanged += Txtplytki1_TextChanged;
            txtplytki2.TextChanged += Txtplytki2_TextChanged;
            txtplytki3.TextChanged += Txtplytki3_TextChanged;

            EditText txtkrwinki1 = FindViewById<EditText>(Resource.Id.txtkrwinki1);
            EditText txtkrwinki2 = FindViewById<EditText>(Resource.Id.txtkrwinki2);
            EditText txtkrwinki3 = FindViewById<EditText>(Resource.Id.txtkrwinki3);
            txtkrwinki1.TextChanged += Txtkrwinki1_TextChanged;
            txtkrwinki2.TextChanged += Txtkrwinki2_TextChanged;
            txtkrwinki3.TextChanged += Txtkrwinki3_TextChanged;

            EditText txtkrwinkibiale1 = FindViewById<EditText>(Resource.Id.txtkrwinkibiale1);
            EditText txtkrwinkibiale2 = FindViewById<EditText>(Resource.Id.txtkrwinkibiale2);
            EditText txtkrwinkibiale3 = FindViewById<EditText>(Resource.Id.txtkrwinkibiale3);
            txtkrwinkibiale1.TextChanged += Txtkrwinkibiale1_TextChanged;
            txtkrwinkibiale2.TextChanged += Txtkrwinkibiale2_TextChanged;
            txtkrwinkibiale3.TextChanged += Txtkrwinkibiale3_TextChanged;
        }

        private void Txtkrwinkibiale3_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrwinkibiale = FindViewById<EditText>(Resource.Id.txtkrwinkibiale3);
            string text = txtkrwinkibiale.Text.ToString();
            int krwinki;
            krwinki = Int32.Parse(text);
            if (text == String.Empty)
            {
                krwinki = 0;
            }
            wynik += krwinki * 200;
        }

        private void Txtkrwinkibiale2_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrwinkibiale = FindViewById<EditText>(Resource.Id.txtkrwinkibiale2);
            string text = txtkrwinkibiale.Text.ToString();
            int krwinki;
            krwinki = Int32.Parse(text);
            if (text == String.Empty)
            {
                krwinki = 0;
            }
            wynik += krwinki * 2000;
        }

        private void Txtkrwinkibiale1_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrwinkibiale = FindViewById<EditText>(Resource.Id.txtkrwinkibiale1);
            string text = txtkrwinkibiale.Text.ToString();
            int krwinki;
            krwinki = Int32.Parse(text);
            if (text == String.Empty)
            {
                krwinki = 0;
            }
            wynik += krwinki * 2000;
        }

        private void Txtkrwinki3_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrwinki = FindViewById<EditText>(Resource.Id.txtkrwinki3);
            string text = txtkrwinki.Text.ToString();
            int krwinki;
            krwinki = Int32.Parse(text);
            if (text == String.Empty)
            {
                krwinki = 0;
            }
            wynik += krwinki * 600;
        }

        private void Txtkrwinki2_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrwinki = FindViewById<EditText>(Resource.Id.txtkrwinki2);
            string text = txtkrwinki.Text.ToString();
            int krwinki;
            krwinki = Int32.Parse(text);
            if (text == String.Empty)
            {
                krwinki = 0;
            }
            wynik += krwinki * 1000;
        }

        private void Txtkrwinki1_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrwinki = FindViewById<EditText>(Resource.Id.txtkrwinki1);
            string text = txtkrwinki.Text.ToString();
            int krwinki;
            krwinki = Int32.Parse(text);
            if (text == String.Empty)
            {
                krwinki = 0;
            }
            wynik += krwinki * 1000;
        }

        private void Txtplytki3_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtplytki = FindViewById<EditText>(Resource.Id.txtplytki3);
            string text = txtplytki.Text.ToString();
            int plytki;
            plytki = Int32.Parse(text);
            if (text == String.Empty)
            {
                plytki = 0;
            }
            wynik += plytki * 250;
        }

        private void Txtplytki2_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtplytki = FindViewById<EditText>(Resource.Id.txtplytki2);
            string text = txtplytki.Text.ToString();
            int plytki;
            plytki = Int32.Parse(text);
            if (text == String.Empty)
            {
                plytki = 0;
            }
            wynik += plytki * 830;
        }

        private void Txtplytki1_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtplytki = FindViewById<EditText>(Resource.Id.txtplytki1);
            string text = txtplytki.Text.ToString();
            int plytki;
            plytki = Int32.Parse(text);
            if (text == String.Empty)
            {
                plytki = 0;
            }
            wynik += plytki * 500;
        }

        private void Txtosocze3_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtosocze = FindViewById<EditText>(Resource.Id.txtosocze3);
            string text = txtosocze.Text.ToString();
            int osocze;
            osocze = Int32.Parse(text);
            if (text == String.Empty)
            {
                osocze = 0;
            }
            wynik += osocze * 650;
        }

        private void Txtosocze2_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtosocze = FindViewById<EditText>(Resource.Id.txtosocze2);
            string text = txtosocze.Text.ToString();
            int osocze;
            osocze = Int32.Parse(text);
            if (text == String.Empty)
            {
                osocze = 0;
            }
            wynik += osocze * 200;
        }

        private void Txtosocze1_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtosocze = FindViewById<EditText>(Resource.Id.txtosocze1);
            string text = txtosocze.Text.ToString();
            int osocze;
            osocze = Int32.Parse(text);
            if (text == String.Empty)
            {
                osocze = 0;
            }
            wynik += osocze * 216;
        }

        private void Txtkrewpelna3_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrewpelna = FindViewById<EditText>(Resource.Id.txtkrewpelna3);
            string text = txtkrewpelna.Text.ToString();
            int krewpelna;
            krewpelna = Int32.Parse(text);
            if (text == String.Empty)
            {
                krewpelna = 0;
            }
            wynik += krewpelna * 450;
        }

        private void Txtkrewpelna2_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrewpelna = FindViewById<EditText>(Resource.Id.txtkrewpelna2);
            string text = txtkrewpelna.Text.ToString();
            int krewpelna;
            krewpelna = Int32.Parse(text);
            if (text == String.Empty)
            {
                krewpelna = 0;
            }
            wynik += krewpelna * 450;
        }

        private void Txtkrewpelna1_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtkrewpelna = FindViewById<EditText>(Resource.Id.txtkrewpelna1);
            string text = txtkrewpelna.Text.ToString();
            int krewpelna;
            krewpelna = Int32.Parse(text);
            if (text == String.Empty)
            {
                krewpelna = 0;
            }
            wynik += krewpelna * 450;
        }
    }
}