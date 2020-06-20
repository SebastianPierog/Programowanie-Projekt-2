using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pizzeria
{
    class Baza
    {
        static readonly string connection = "Data Source=DESKTOP-J4VCE1U;Initial Catalog =BazaZamowienia; Integrated Security = SSPI";

        SqlConnection polaczenie = new SqlConnection(connection);

       public void select(int id)
        {
            polaczenie.Open();
            string komenda = "SELECT * FROM ";
            SqlCommand polecenie = new SqlCommand(komenda, polaczenie);
            polecenie.ExecuteNonQuery(); // robi ale nie pokazuje
            polecenie.ExecuteScalar(); // robi i oddaje jako cyferke 1 wartosc
            polecenie.ExecuteReader(); // robi i oddaje wszystko

            SqlDataReader czytnik = polecenie.ExecuteReader();

            czytnik.Read();
             //czytnik[0].ToString;
            czytnik.Read();

            polaczenie.Close();
        }

        public void dodaj(string NazwaPizzy, int Cena)
        {
            polaczenie.Open();
            string komendaDodaj = "INSERT INTO Zamowienia VALUES ('" + NazwaPizzy + "','" + Cena + "')";
            SqlCommand polecenie = new SqlCommand(komendaDodaj, polaczenie);
            polecenie.ExecuteNonQuery(); // robi ale nie pokazuje

            polaczenie.Close();
        }

        public string[] pobierz(string NazwaPizzy)
        {
            polaczenie.Open();
            string komendaDodaj= "SELECT * FROM ZAMOWIENIA WHERE Nazwa_Pizzy = '" + NazwaPizzy + "';";
            SqlCommand polecenie = new SqlCommand(komendaDodaj, polaczenie);

            SqlDataReader czytnik = polecenie.ExecuteReader();

            string nazwa = "";
            int cena = 0;
            int ilosc = 0;


            while (czytnik.Read())
            {
                ilosc++;
                if (nazwa.Equals(""))
                {
                    nazwa = czytnik[0].ToString();
                }

                cena += czytnik.GetInt32(1);
            }

            string[] wynik = new string[2];

            wynik[0] = "Nazwa: " + nazwa + " Ilość: "  + ilosc.ToString()+ " Suma zamówienia: " ;
            wynik[1] = cena.ToString() + "zł";




            polaczenie.Close();
            return wynik;
        }
        public void usun()
        {
            polaczenie.Open();
            string usun = "DELETE FROM Zamowienia";
            SqlCommand polecenie = new SqlCommand(usun, polaczenie);
            polecenie.ExecuteNonQuery(); // robi ale nie pokazuje

            polaczenie.Close();
        }
    }


}
