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
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;
using Android.Graphics;
using System.IO;

namespace AndroidSwitchActivities
{
    [Activity]
    public class AccountActivity : Activity
    {
        EditText txtFirstName, txtLastName, txtEmail, txtPassword, txtphone, txtPesel, txtAdres;
        RadioButton rb;
        public string rh,man,grupakrwi;
        RecvActivity recv = new RecvActivity();
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Account);
            Button btnSubmit = FindViewById<Button>(Resource.Id.btnSubmit);
            RadioButton aRadioBtn = FindViewById<RadioButton>(Resource.Id.AradioButton);
            RadioButton bRadioBtn = FindViewById<RadioButton>(Resource.Id.BradioButton);
            RadioButton abRadioBtn = FindViewById<RadioButton>(Resource.Id.ABradioButton);
            RadioButton zRadioBtn = FindViewById<RadioButton>(Resource.Id.ZeroradioButton);
            EditText email = FindViewById<EditText>(Resource.Id.txtEmail);
            EditText txtFirstName = FindViewById<EditText>(Resource.Id.txtFirstName);
            EditText txtLastName = FindViewById<EditText>(Resource.Id.txtLastName);
            EditText txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            EditText txtphone = FindViewById<EditText>(Resource.Id.txtphone);
            EditText txtAdres = FindViewById<EditText>(Resource.Id.txtAdres);
            string em = email.Text.ToString();
            string phone = txtphone.Text.ToString();
            string imie = txtFirstName.Text.ToString();
            string nazwisko = txtLastName.Text.ToString();
            string haslo = txtPassword.Text.ToString();
            string adres = txtAdres.Text.ToString();

            email.TextChanged += Email_TextChanged;
            txtFirstName.TextChanged += TxtFirstName_TextChanged;
            txtLastName.TextChanged += TxtLastName_TextChanged;
            txtPassword.TextChanged += TxtPassword_TextChanged;
            txtAdres.TextChanged += TxtAdres_TextChanged;
            txtphone.TextChanged += Txtphone_TextChanged;

            aRadioBtn.Click += RadioButtonClick;
            bRadioBtn.Click += RadioButtonClick;
            abRadioBtn.Click += RadioButtonClick;
            zRadioBtn.Click += RadioButtonClick;

            btnSubmit.Click += SubmitClick;
        }
        private void Txtphone_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            string connstring = "Server=sql.bdl.pl;database=sait_dawca;User Id=sait_dawca;Password=dawcakrwi;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstring);
            EditText txtphone = FindViewById<EditText>(Resource.Id.txtphone);
            string tlfn = txtphone.Text.ToString();
            string pesel = loadFile();
            try
            {
                if (isValidPhone(tlfn))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string command = "UPDATE pacjenci SET has³o = @id1 WHERE pesel = @id2";
                        MySqlCommand cmd = new MySqlCommand(command, conn);
                        cmd.Parameters.AddWithValue("@id1", tlfn);
                        cmd.Parameters.AddWithValue("@id2", pesel);
                        MySqlDataReader myReader;
                        myReader = cmd.ExecuteReader();
                        Toast.MakeText(this, "Zmiana zapisana w bazie", ToastLength.Short).Show();
                        while (myReader.Read()) { }
                    }
                }
                else
                {
                    Toast.MakeText(this, "Z³y numer telefonu", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toast.MakeText(this, "Nie mo¿na zapisaæ zmiany", ToastLength.Short).Show();
            }
            finally
            {
                conn.Close();
            }
        }
        private void TxtAdres_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            string connstring = "Server=sql.bdl.pl;database=sait_dawca;User Id=sait_dawca;Password=dawcakrwi;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstring);
            EditText txtAdres = FindViewById<EditText>(Resource.Id.txtAdres);
            string adres = txtAdres.Text.ToString();
            string pesel = loadFile();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string command = "UPDATE pacjenci SET has³o = @id1 WHERE pesel = @id2";
                    MySqlCommand cmd = new MySqlCommand(command, conn);
                    cmd.Parameters.AddWithValue("@id1", adres);
                    cmd.Parameters.AddWithValue("@id2", pesel);
                    MySqlDataReader myReader;
                    myReader = cmd.ExecuteReader();
                    Toast.MakeText(this, "Zmiana zapisana w bazie", ToastLength.Short).Show();
                    while (myReader.Read()) { }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toast.MakeText(this, "Nie mo¿na zapisaæ zmiany", ToastLength.Short).Show();
            }
            finally
            {
                conn.Close();
            }
        }
        private void TxtPassword_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            string connstring = "Server=sql.bdl.pl;database=sait_dawca;User Id=sait_dawca;Password=dawcakrwi;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstring);
            EditText txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            string pswd = txtPassword.Text.ToString();
            string pesel = loadFile();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string command = "UPDATE pacjenci SET has³o = @id1 WHERE pesel = @id2";
                    MySqlCommand cmd = new MySqlCommand(command, conn);
                    cmd.Parameters.AddWithValue("@id1", pswd);
                    cmd.Parameters.AddWithValue("@id2", pesel);
                    MySqlDataReader myReader;
                    myReader = cmd.ExecuteReader();
                    Toast.MakeText(this, "Zmiana zapisana w bazie", ToastLength.Short).Show();
                    while (myReader.Read()) { }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toast.MakeText(this, "Nie mo¿na zapisaæ zmiany", ToastLength.Short).Show();
            }
            finally
            {
                conn.Close();
            }
        }
        private void TxtLastName_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            string connstring = "Server=sql.bdl.pl;database=sait_dawca;User Id=sait_dawca;Password=dawcakrwi;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstring);
            EditText txtLastName = FindViewById<EditText>(Resource.Id.txtLastName);
            string naz = txtLastName.Text.ToString();
            string pesel = loadFile();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string command = "UPDATE pacjenci SET Nazwisko = @id1 WHERE pesel = @id2";
                    MySqlCommand cmd = new MySqlCommand(command, conn);
                    cmd.Parameters.AddWithValue("@id1", naz);
                    cmd.Parameters.AddWithValue("@id2", pesel);
                    MySqlDataReader myReader;
                    myReader = cmd.ExecuteReader();
                    Toast.MakeText(this, "Zmiana zapisana w bazie", ToastLength.Short).Show();
                    while (myReader.Read()) { }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toast.MakeText(this, "Nie mo¿na zapisaæ zmiany", ToastLength.Short).Show();
            }
            finally
            {
                conn.Close();
            }
        }
        private void TxtFirstName_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            string connstring = "Server=sql.bdl.pl;database=sait_dawca;User Id=sait_dawca;Password=dawcakrwi;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstring);
            EditText txtFirstName = FindViewById<EditText>(Resource.Id.txtFirstName);
            string imie = txtFirstName.Text.ToString();
            string pesel = loadFile();
            try
            {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string command = "UPDATE pacjenci SET Imie = @id1 WHERE pesel = @id2";
                        MySqlCommand cmd = new MySqlCommand(command, conn);
                        cmd.Parameters.AddWithValue("@id1", imie);
                        cmd.Parameters.AddWithValue("@id2", pesel);
                        MySqlDataReader myReader;
                        myReader = cmd.ExecuteReader();
                        Toast.MakeText(this, "Zmiana zapisana w bazie", ToastLength.Short).Show();
                        while (myReader.Read()) { }
                    }       
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toast.MakeText(this, "Nie mo¿na zapisaæ zmiany", ToastLength.Short).Show();
            }
            finally
            {
                conn.Close();
            }
        }
        private void Email_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            string connstring = "Server=sql.bdl.pl;database=sait_dawca;User Id=sait_dawca;Password=dawcakrwi;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstring);
            EditText email = FindViewById<EditText>(Resource.Id.txtEmail);
            string em = email.Text.ToString();
            string pesel = loadFile();
            try
            {
                if (isValidEmail(em))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string command = "UPDATE pacjenci SET email = @id1 WHERE pesel = @id2";
                        MySqlCommand cmd = new MySqlCommand(command, conn);
                        cmd.Parameters.AddWithValue("@id1", em);
                        cmd.Parameters.AddWithValue("@id2", pesel);
                        MySqlDataReader myReader;
                        myReader = cmd.ExecuteReader();
                        Toast.MakeText(this, "Zmiana w bazie", ToastLength.Short).Show();
                        while (myReader.Read()) { }
                    }
                }
                else
                {
                    Toast.MakeText(this, "Z³y email", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toast.MakeText(this, "Nie mozna zapisac zmiany", ToastLength.Short).Show();
            }
            finally
            {
                conn.Close();
            }
        }
        private void SubmitClick(object sender, EventArgs e)
        {
            Intent menuActivity = new Intent(this, typeof(Menu));
            StartActivity(menuActivity);
        }
        public static string loadFile()
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string filename = System.IO.Path.Combine(path, "myfile.txt");

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);
                return content;
            }
        }
        private void RadioButtonClick(object sender, EventArgs e)
        {
            var pRadioBtn = FindViewById<RadioButton>(Resource.Id.rhPlusradioButton);
            var mRadioBtn = FindViewById<RadioButton>(Resource.Id.rhMinusradioButton);
            rb = (RadioButton)sender;
            grupakrwi = rb.Text.ToString();
            if (pRadioBtn.Checked)
            {
                rh = "Rh +";
            }
            else
            {
                rh = "Rh -";
            }
            Toast.MakeText(this, "Twoja grupa krwi to: " + grupakrwi + " " + rh, ToastLength.Short).Show();
        }
        public static bool isValidEmail(string inputEmail)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(inputEmail);
        }
        public static bool isValidPhone(string inputPhone)
        {
            Regex regex = new Regex(@"^([0-9]{9})|(([0-9]{3}-){2}[0-9]{3})$");
            return regex.IsMatch(inputPhone);
        }
    }
}