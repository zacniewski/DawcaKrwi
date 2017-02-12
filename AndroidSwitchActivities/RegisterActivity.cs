using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace AndroidSwitchActivities
{
    [Activity(Label = "RegisterActivity")]
    class RegisterActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetTheme(Resource.Style.MyTheme);
            SetContentView(Resource.Layout.RegisterActivity);
            Button btnDialogEmail = FindViewById<Button>(Resource.Id.btnDialogEmail);
            btnDialogEmail.Click += btnDialogEmail_Click;
        }
        public static bool isValidPesel(string inputPesel)
        {
            Regex regex = new Regex(@"^[0-9]{11}$");
            return regex.IsMatch(inputPesel);
        }
        public static void writeFile(string word)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "myfile.txt");

            using (var streamWriter = new StreamWriter(filename, false))
            {
                streamWriter.WriteLine(word);
                System.Diagnostics.Debug.WriteLine(word);
            }

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);
            }
        } 
        private void btnDialogEmail_Click(object sender, EventArgs e)
        {
            var email = FindViewById<EditText>(Resource.Id.txtRegEmail);
            var pesel = FindViewById<EditText>(Resource.Id.txtRegPesel);
            string peselek = pesel.Text.ToString();
            string em = email.Text.ToString();
            if (isValidPesel(peselek))
            {
                if (em.Length == 0)
                {
                    Toast.MakeText(this, "Wprowadü adres email", ToastLength.Short).Show();
                }
                else
                {
                    if (isValidEmail(em))
                    {
                        Intent nextActivity = new Intent(this, typeof(Menu));
                        StartActivity(nextActivity);
                        GetAccountCountFromMySQL();
                        writeFile(peselek);
                    }
                    else
                    {
                        Toast.MakeText(this, "Popraw adres email", ToastLength.Short).Show();
                    }
                }
            }
            else {
                Toast.MakeText(this, "Popraw pesel", ToastLength.Short).Show();
            }  
        }
        public static bool isValidEmail(string inputEmail)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(inputEmail);
        }
        public void GetAccountCountFromMySQL()
        {
            string connstring = "Server=sql.bdl.pl;database=sait_dawca;User Id=sait_dawca;Password=dawcakrwi;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstring);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    var edtPesel = FindViewById<EditText>(Resource.Id.txtRegPesel);
                    string psl = edtPesel.Text.ToString();
                    var edtEmail = FindViewById<EditText>(Resource.Id.txtRegEmail);
                    string mail = edtEmail.Text.ToString();
                    var edtPass = FindViewById<EditText>(Resource.Id.txtRegPassword);
                    string pass = edtPass.Text.ToString();
                    string command = "INSERT INTO pacjenci(email,has≥o,Pesel) VALUES (@email,@haslo,@pesel)";
                    MySqlCommand cmd = new MySqlCommand(command, conn);
                    cmd.Parameters.AddWithValue("@email", mail);
                    cmd.Parameters.AddWithValue("@haslo", pass);
                    cmd.Parameters.AddWithValue("@pesel", psl);
                    cmd.ExecuteNonQuery();
                    Toast.MakeText(this, "Udalo utworzyc konto", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toast.MakeText(this, "Nie mozna polaczyc sie z baza", ToastLength.Short).Show();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}