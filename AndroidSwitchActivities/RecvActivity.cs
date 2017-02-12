using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System.Text.RegularExpressions;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace AndroidSwitchActivities
{
    [Activity(Label = "RecvActivity")]
    public class RecvActivity : Activity
    {
        public MySqlDataAdapter dataAdapter;
        public DataSet dataSet;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetTheme(Resource.Style.MyTheme);
            SetContentView(Resource.Layout.RecvActivity);
            var btnGoBack = FindViewById<Button>(Resource.Id.btnGoBack);
            btnGoBack.Click += btnDialogEmail_Click;
        }
        public static bool isValidEmail(string inputEmail)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(inputEmail);
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
        }
        public void GetAccountCountFromMySQL(string ml,string pswd)
        {
            string connstring = "Server=sql.bdl.pl;database=sait_dawca;User Id=sait_dawca;Password=dawcakrwi;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstring);
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    Toast.MakeText(this, "Uda≥o sie polaczyc z baza", ToastLength.Short).Show();
                    string query = "SELECT * FROM pacjenci";
                    var cmd = new MySqlCommand(query, conn);
                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        string emailValue = reader["email"].ToString();
                        string passValue = reader["has≥o"].ToString();
                        string peselValue = reader["Pesel"].ToString();
                        if (String.Compare(emailValue, ml, false) == 0)
                        {
                            if (String.Compare(passValue, pswd, false) == 0)
                            {
                                writeFile(peselValue);
                                Toast.MakeText(this, "Witaj", ToastLength.Short).Show();
                                Intent menuActivity = new Intent(this, typeof(Menu));
                                StartActivity(menuActivity);
                            }
                            else
                            {
                                Toast.MakeText(this, "Bledny login lub has≥o", ToastLength.Short).Show();
                            }
                        }
                        else {
                            //Toast.MakeText(this, "Bledny login lub has≥o", ToastLength.Short).Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toast.MakeText(this, "Nie mozna polaczyc sie z baza" ,ToastLength.Long).Show();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void btnDialogEmail_Click(object sender, EventArgs e)
        {
            var email = FindViewById<EditText>(Resource.Id.txtLogEmail);
            string em = email.Text.ToString();
            var pass = FindViewById<EditText>(Resource.Id.txtLogPassword);
            string pas = pass.Text.ToString();
            if (em.Length == 0)
            {
                Toast.MakeText(this, "Wprowadü adres email", ToastLength.Short).Show();
            }
            else
            {
                if (isValidEmail(em))
                {
                    if (pas.Length == 0)
                    {
                        Toast.MakeText(this, "Wprowadü has≥o", ToastLength.Short).Show();
                    }
                    else
                    {
                        GetAccountCountFromMySQL(em,pas);
                    }
                }
                else
                {
                    Toast.MakeText(this, "Popraw adres email", ToastLength.Short).Show();
                }
            }
        }
    }
}