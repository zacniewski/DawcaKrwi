using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using static Android.App.DatePickerDialog;

namespace AndroidSwitchActivities
{
    [Activity]
    public class WizytaActivity : Activity, IOnDateSetListener
    {
        private const int DATE_DIALOG = 1;
        private int year=2017, month=02, day=01;

        public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
        {
            this.year = year;
            this.month = monthOfYear;
            this.day = dayOfMonth;
            Toast.MakeText(this,"Wybra³eœ datê: "+day+" "+(month+1)+" "+year,ToastLength.Short).Show();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.WizytaActivity);
            Button visitbutton = FindViewById<Button>(Resource.Id.visitdatebutton);
            Button visitBackButton = FindViewById<Button>(Resource.Id.visitBackButton);
            Button makedatebutton = FindViewById<Button>(Resource.Id.makedatebutton);
            
            visitBackButton.Click += delegate {
                Intent fVisitActivity = new Intent(this, typeof(PrzelicznikActivity));
                StartActivity(fVisitActivity);
            };
            visitbutton.Click += delegate {
                ShowDialog(DATE_DIALOG);
            };
            makedatebutton.Click += Makedatebutton_Click;
        }

        private void Makedatebutton_Click(object sender, System.EventArgs e)
        {
            VisitDate();
        }

        protected override Dialog OnCreateDialog(int id)
        {
            switch (id)
            {
                case DATE_DIALOG:
                    {
                        return new DatePickerDialog(this, this, year, month, day);
                    }
                    break;
                default:
                    break;
            }
            return null;
        }
        public void VisitDate()
        {
            RadioButton ostDonRadioBtn1 = FindViewById<RadioButton>(Resource.Id.ostDonRadioBtn1);
            RadioButton ostDonRadioBtn2 = FindViewById<RadioButton>(Resource.Id.ostDonRadioBtn2);
            RadioButton ostDonRadioBtn3 = FindViewById<RadioButton>(Resource.Id.ostDonRadioBtn3);
            RadioButton ostDonRadioBtn4 = FindViewById<RadioButton>(Resource.Id.ostDonRadioBtn4);
            //----------------------------------------------------------------------------------------
            RadioButton nastDonRadioBtn1 = FindViewById<RadioButton>(Resource.Id.nastDonRadioBtn1);
            RadioButton nastDonRadioBtn2 = FindViewById<RadioButton>(Resource.Id.nastDonRadioBtn2);
            RadioButton nastDonRadioBtn3 = FindViewById<RadioButton>(Resource.Id.nastDonRadioBtn3);
            RadioButton nastDonRadioBtn4 = FindViewById<RadioButton>(Resource.Id.nastDonRadioBtn4);

            if (ostDonRadioBtn1.Checked)
            {
                if (nastDonRadioBtn1.Checked || nastDonRadioBtn2.Checked || nastDonRadioBtn3.Checked || nastDonRadioBtn4.Checked)
                {
                    //OnDateSet(null, year, (month + 2), day);
                    Toast.MakeText(this, "Nabli¿szy termin to: " + day + " " + (month + 3) + " " + year, ToastLength.Short).Show();
                }
            }
            else
            {
                if (ostDonRadioBtn2.Checked)
                {
                    if (nastDonRadioBtn1.Checked || nastDonRadioBtn2.Checked || nastDonRadioBtn3.Checked || nastDonRadioBtn4.Checked)
                    {
                        //OnDateSet(null, year, (month + 2), day);
                        Toast.MakeText(this, "Nabli¿szy termin to: " + day + " " + (month + 3) + " " + year, ToastLength.Short).Show();
                    }
                }
                else
                {
                    if (ostDonRadioBtn3.Checked)
                    {
                        if (nastDonRadioBtn1.Checked || nastDonRadioBtn2.Checked || nastDonRadioBtn3.Checked || nastDonRadioBtn4.Checked)
                        {
                            //OnDateSet(null, year, (month + 2), day);
                            Toast.MakeText(this, "Nabli¿szy termin to: " + (day+15) + " " + (month + 2) + " " + year, ToastLength.Short).Show();
                        }
                    }
                    else
                    {
                        if (ostDonRadioBtn4.Checked)
                        {
                            //OnDateSet(null, year, (month + 2), day);
                            Toast.MakeText(this, "Nabli¿szy termin to: " + (day + 15) + " " + (month + 2) + " " + year, ToastLength.Short).Show();
                        }
                    }
                }
            }
        }
    }
}