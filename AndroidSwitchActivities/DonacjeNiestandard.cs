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
    public class DonacjeNiestandard : Activity
    {
        public int wynik = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DonacjeNiestandard);
            var btnnDonZapis = FindViewById<Button>(Resource.Id.btnNiestandardZapisz);
            btnnDonZapis.Click += (s, e) => {
                writeFile(wynik.ToString());
                Intent nnActivity = new Intent(this, typeof(PrzelicznikActivity));
                StartActivity(nnActivity);
            };
        }
        public static void writeFile(string word)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "niestandard.txt");

            using (var streamWriter = new StreamWriter(filename, false))
            {
                streamWriter.WriteLine(word);
                System.Diagnostics.Debug.WriteLine(word);
            }
        }
        public void obliczenia()
        {
            EditText txtniekrewpelna1 = FindViewById<EditText>(Resource.Id.txtniekrewpelna1);
            EditText txtniekrewpelna2 = FindViewById<EditText>(Resource.Id.txtniekrewpelna2);
            EditText txtniekrewpelna3 = FindViewById<EditText>(Resource.Id.txtniekrewpelna3);
            txtniekrewpelna1.TextChanged += Txtniekrewpelna1_TextChanged;
            txtniekrewpelna2.TextChanged += Txtniekrewpelna2_TextChanged;
            txtniekrewpelna3.TextChanged += Txtniekrewpelna3_TextChanged;
            EditText txtnieosocze1 = FindViewById<EditText>(Resource.Id.txtnieosocze1);
            EditText txtnieosocze2 = FindViewById<EditText>(Resource.Id.txtnieosocze2);
            EditText txtnieosocze3 = FindViewById<EditText>(Resource.Id.txtnieosocze3);
            txtnieosocze1.TextChanged += Txtnieosocze1_TextChanged;
            txtnieosocze2.TextChanged += Txtnieosocze2_TextChanged;
            txtnieosocze3.TextChanged += Txtnieosocze3_TextChanged;
        }
        private void Txtnieosocze3_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtnieosocze = FindViewById<EditText>(Resource.Id.txtnieosocze3);
            string text = txtnieosocze.Text.ToString();
            int osocze;
            osocze = Int32.Parse(text);
            if (text == String.Empty)
            {
                osocze = 0;
            }
            wynik += osocze * 650;
        }

        private void Txtnieosocze2_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtnieosocze = FindViewById<EditText>(Resource.Id.txtnieosocze2);
            string text = txtnieosocze.Text.ToString();
            int osocze;
            osocze = Int32.Parse(text);
            if (text == String.Empty)
            {
                osocze = 0;
            }
            wynik += ((osocze * 650) / 3);
        }

        private void Txtnieosocze1_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtnieosocze = FindViewById<EditText>(Resource.Id.txtnieosocze1);
            string text = txtnieosocze.Text.ToString();
            int osocze;
            osocze = Int32.Parse(text);
            if (text == String.Empty)
            {
                osocze = 0;
            }
            wynik += ((osocze * 650)/3);
        }

        private void Txtniekrewpelna3_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtniekrewpelna = FindViewById<EditText>(Resource.Id.txtniekrewpelna3);
            string text = txtniekrewpelna.Text.ToString();
            int krew;
            krew = Int32.Parse(text);
            if (text == String.Empty)
            {
                krew = 0;
            }
            wynik += krew * 450;
        }

        private void Txtniekrewpelna2_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtniekrewpelna = FindViewById<EditText>(Resource.Id.txtniekrewpelna2);
            string text = txtniekrewpelna.Text.ToString();
            int krew;
            krew = Int32.Parse(text);
            if (text == String.Empty)
            {
                krew = 0;
            }
            wynik += krew * 450;
        }

        private void Txtniekrewpelna1_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtniekrewpelna = FindViewById<EditText>(Resource.Id.txtniekrewpelna1);
            string text = txtniekrewpelna.Text.ToString();
            int krew;
            krew = Int32.Parse(text);
            if (text == String.Empty)
            {
                krew = 0;
            }
            wynik += krew * 450;
        }
    }
}