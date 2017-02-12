using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;
using System.IO;

namespace AndroidSwitchActivities
{
    [Activity(Label = "Przelicznik donacji")]
    public class PrzelicznikActivity : Activity
    {
        public string standardwynik, nstandardwynik;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.Przelicznik);
            //---------------------------------------------------------------------------
            var btnDonZapis = FindViewById<Button>(Resource.Id.btnStandard);
            btnDonZapis.Click += (s, e) => {
                Intent StandActivity = new Intent(this, typeof(DonacjeStandard));
                StartActivity(StandActivity);
            };
            var btnDonNieZapis = FindViewById<Button>(Resource.Id.btnNiestandard);
            btnDonNieZapis.Click += (s, e) => {
                Intent nStandActivity = new Intent(this, typeof(DonacjeNiestandard));
                StartActivity(nStandActivity);
            };
            var btnBack = FindViewById<Button>(Resource.Id.btnBack);
            btnBack.Click += (s, e) => {
                Intent nextActivity = new Intent(this, typeof(Menu));
                StartActivity(nextActivity);
            };
            var fVisitBtn = FindViewById<Button>(Resource.Id.futureVisitButton);
            fVisitBtn.Click += (s, e) => {
                Intent fVisitActivity = new Intent(this, typeof(WizytaActivity));
                StartActivity(fVisitActivity);
            };
            var ObliczButton = FindViewById<Button>(Resource.Id.ObliczButton);
            ObliczButton.Click += ObliczButton_Click;
        }

        private void ObliczButton_Click(object sender, EventArgs e)
        {
            obliczenia();
        }

        public static string loadFile(string plik)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string filename = System.IO.Path.Combine(path, plik);

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);
                return content;
            }
        }
        public void obliczenia()
        {
            standardwynik = loadFile("standard.txt");
            nstandardwynik = loadFile("niestandard.txt");
            int wynik;
            wynik = System.Int32.Parse(standardwynik);
            wynik += System.Int32.Parse(nstandardwynik);
            var txtobliczenWynik = FindViewById<TextView>(Resource.Id.txtobliczen);
            wynik /= 1000;
            if (wynik < 5000)
            {
                txtobliczenWynik.Text = "Do odznaki brakuje Ci " + (5000 - wynik) + " ml oddanej krwi pe³nej.";
            }
            else
            {
                txtobliczenWynik.Text = "GRATULUJÊ, ju¿ mo¿esz siê staraæ o Odznakê Zas³u¿onego Honorowego Dawcy Krwi III stopnia!";
            }
            if (wynik < 10000)
            {
                txtobliczenWynik.Text = "Do odznaki brakuje Ci " + (10000 - wynik) + " ml oddanej krwi pe³nej.";
            }
            else
            {
                txtobliczenWynik.Text = "GRATULUJÊ, ju¿ mo¿esz siê staraæ o Odznakê Zas³u¿onego Honorowego Dawcy Krwi II stopnia!";
            }
            if (wynik < 15000)
            {
                txtobliczenWynik.Text = "Do odznaki brakuje Ci " + (15000 - wynik) + " ml oddanej krwi pe³nej.";
            }
            else
            {
                txtobliczenWynik.Text = "GRATULUJÊ, ju¿ mo¿esz siê staraæ o Odznakê Zas³u¿onego Honorowego Dawcy Krwi I stopnia!";
            }
            if (wynik < 20000)
            {
                txtobliczenWynik.Text = "Do odznaki brakuje Ci " + (20000 - wynik) + " ml oddanej krwi pe³nej.";
            }
            else
            {
                txtobliczenWynik.Text = "GRATULUJÊ, ju¿ mo¿esz siê staraæ o Odznakê Zas³u¿onego Honorowego Dawcy Krwi - Zas³u¿onego dla Zdrowia Narodu!";
            }
        }
    }
}