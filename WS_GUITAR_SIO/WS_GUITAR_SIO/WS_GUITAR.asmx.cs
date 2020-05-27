using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WS_GUITAR_SIO
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WS_GUITAR : System.Web.Services.WebService
    {
        //Declaration de classes et listes pour chacune
        public class C_GUITAR
        {
            public string Nomguitar;
            public string Micro1;
            public string Micro2;
            public string Micro3;
            public string BoisManche;
            public string BoisTouche;
            public string BoisCorps;
            public string NomVibrato;
        }
        List<C_GUITAR> les_Guitars = new List<C_GUITAR>();
        public class C_MICRO
        {
            public string Contructeur;
        }
        List<C_MICRO> Les_Types_De_Micros = new List<C_MICRO>();
        public class C_TYPEBOIS
        {
            public string NomTypeBois;
        }
        List<C_TYPEBOIS> les_Types_De_Bois = new List<C_TYPEBOIS>();
        public class C_VIBRATO
        {
            public string NomVibrato;
        }
        List<C_VIBRATO> les_Types_de_Vibrato = new List<C_VIBRATO>();
        public class C_COMMANDE
        {
            public string idCommande;
            public string NomClient;
            public string DateCommande;
            public string Montant;
            public string TelephoneClient;
        }
        List<C_COMMANDE> les_Commandes = new List<C_COMMANDE>();


        public class C_BON_COMMANDE
        {
            public int NroCommande;
            public string Client;
            public string Telephone;
            public string Nomguitar;
            public string M_Pos_1;
            public string M_Pos_2;
            public string M_Pos_3;
            public string Bois_Corps;
            public string Bois_Touche;
            public string Bois_Manche;
            public string DateCommande;
            public string Montant;
        }
        List<C_BON_COMMANDE> les_Bons_de_Commandes = new List<C_BON_COMMANDE>();

        //requette sql
        static string Chemin_BDD = @"Data Source=DESKTOP-1FELIK6\SQLEXPRESS;Initial Catalog=TP_Guitar;User ID=joseG;Password=1234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection cnx = new SqlConnection();
        [WebMethod]
        public string NouvelleCommande(string NomClient, string DateCommande, string Montant, string TelephoneClient)
        {
            cnx.ConnectionString = Chemin_BDD;
            string idCommande;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "NouvelleCommande";
                query2.Parameters.Add("@NomClient", System.Data.SqlDbType.Char, 32);
                query2.Parameters.Add("@Montant", System.Data.SqlDbType.Char, 32);
                query2.Parameters.Add("@DateCommande", System.Data.SqlDbType.Char, 32);
                query2.Parameters.Add("@telClient", System.Data.SqlDbType.VarChar, 128);
                query2.Parameters["@NomClient"].Value = NomClient;
                query2.Parameters["@Montant"].Value = Montant;
                query2.Parameters["@DateCommande"].Value = DateCommande;
                query2.Parameters["@telClient"].Value = TelephoneClient;
                idCommande = query2.ExecuteScalar().ToString();
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
            return idCommande;

        }

        [WebMethod]
        public void CommandeGuitar(String Nomguitar, String Micro1, String Micro2, String Micro3, String BoisManche, String BoisTouche, String BoisCorps, String NomVibrato, int idCommande)
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query = new SqlCommand();
                query.Connection = cnx;
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "CreateGuitarClient";

                query.Parameters.Add("@Micro1", System.Data.SqlDbType.Char, 32);
                query.Parameters.Add("@Micro2", System.Data.SqlDbType.Char, 32);
                query.Parameters.Add("@Micro3", System.Data.SqlDbType.Char, 32);
                query.Parameters.Add("@NomGuitar", System.Data.SqlDbType.VarChar, 128);
                query.Parameters.Add("@BoisCorps", System.Data.SqlDbType.Char, 32);
                query.Parameters.Add("@BoisTouche", System.Data.SqlDbType.Char, 32);
                query.Parameters.Add("@BoisManche", System.Data.SqlDbType.Char, 32);
                query.Parameters.Add("@NomVibrato", System.Data.SqlDbType.Char, 32);
                query.Parameters.Add("@idCommande", System.Data.SqlDbType.Int);



                query.Parameters["@Micro1"].Value = Micro1;
                query.Parameters["@Micro2"].Value = Micro2;
                query.Parameters["@Micro3"].Value = Micro3;
                query.Parameters["@Nomguitar"].Value = Nomguitar;
                query.Parameters["@BoisManche"].Value = BoisManche;
                query.Parameters["@BoisTouche"].Value = BoisTouche;
                query.Parameters["@BoisCorps"].Value = BoisCorps;
                query.Parameters["@NomVibrato"].Value = NomVibrato;
                query.Parameters["@idCommande"].Value = idCommande;


                query.ExecuteNonQuery();


            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
        }
        [WebMethod]
        public List<C_GUITAR> GetAllGuitars()
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query = new SqlCommand();
                query.Connection = cnx;
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "GetAllGuitars";

                var response = query.ExecuteReader();

                while (response.Read())
                {
                    C_GUITAR Une_Guitar = new C_GUITAR();
                    Une_Guitar.Nomguitar = response["NomGuitar"].ToString();
                    Une_Guitar.Micro1 = response["M_Pos_1"].ToString();
                    Une_Guitar.Micro2 = response["M_Pos_2"].ToString();
                    Une_Guitar.Micro3 = response["M_Pos_3"].ToString();
                    Une_Guitar.BoisManche = response["Bois_Manche"].ToString();
                    Une_Guitar.BoisTouche = response["Bois_Touche"].ToString();
                    Une_Guitar.BoisCorps = response["Bois_Corps"].ToString();
                    Une_Guitar.NomVibrato = response["NomVibrato"].ToString();

                    les_Guitars.Add(Une_Guitar);
                }
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
            return les_Guitars;
        }
        [WebMethod]
        public List<C_TYPEBOIS> GetAllTypeBois()
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query = new SqlCommand();
                query.Connection = cnx;
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "GetAllTypesBois";

                var response = query.ExecuteReader();

                while (response.Read())
                {
                    C_TYPEBOIS Un_Type_Bois = new C_TYPEBOIS();
                    Un_Type_Bois.NomTypeBois = response["NomTypeBois"].ToString();

                    les_Types_De_Bois.Add(Un_Type_Bois);
                }
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
            return les_Types_De_Bois;
        }
        [WebMethod]
        public List<C_MICRO> GetAllTypesMicro()
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query = new SqlCommand();
                query.Connection = cnx;
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "GetAllTypesMicro";

                var response = query.ExecuteReader();

                while (response.Read())
                {
                    C_MICRO Un_Type_Micro = new C_MICRO();
                    Un_Type_Micro.Contructeur = response["CONSTRUCTEUR"].ToString();

                    Les_Types_De_Micros.Add(Un_Type_Micro);
                }
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
            return Les_Types_De_Micros;
        }
        [WebMethod]
        public List<C_VIBRATO> GetAllTypesVibrato()
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query = new SqlCommand();
                query.Connection = cnx;
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "GetAllTypesVibrato";

                var response = query.ExecuteReader();

                while (response.Read())
                {
                    C_VIBRATO Un_Type_Vibrato = new C_VIBRATO();
                    Un_Type_Vibrato.NomVibrato = response["NomVibrato"].ToString();

                    les_Types_de_Vibrato.Add(Un_Type_Vibrato);
                }
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            return les_Types_de_Vibrato;
        }
        [WebMethod]
        public List<C_COMMANDE> GetAllCommandesExistant()
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query = new SqlCommand();
                query.Connection = cnx;
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "GetAllCommandes";

                var response = query.ExecuteReader();

                while (response.Read())
                {
                    C_COMMANDE Une_Commande = new C_COMMANDE();
                    Une_Commande.idCommande = response["id"].ToString();
                    Une_Commande.NomClient = response["NomClient"].ToString();
                    Une_Commande.DateCommande = response["DateCommande"].ToString();
                    Une_Commande.Montant = response["Montant"].ToString();
                    Une_Commande.TelephoneClient = response["TelephoneClient"].ToString();

                    les_Commandes.Add(Une_Commande);
                }
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            return les_Commandes;
        }
        [WebMethod]
        public List<C_BON_COMMANDE> GetAllCommandesFaites()
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query = new SqlCommand();
                query.Connection = cnx;
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "GetAllBons";

                var response = query.ExecuteReader();

                while (response.Read())
                {
                    C_BON_COMMANDE UnBon = new C_BON_COMMANDE();
                    UnBon.NroCommande = (int)response["NroCommande"];
                    UnBon.Client = response["Client"].ToString();
                    UnBon.Telephone = response["Telephone"].ToString();
                    UnBon.Nomguitar = response["Nomguitar"].ToString();
                    UnBon.M_Pos_1 = response["M_Pos_1"].ToString();
                    UnBon.M_Pos_2 = response["M_Pos_2"].ToString();
                    UnBon.M_Pos_3 = response["M_Pos_3"].ToString();
                    UnBon.Bois_Corps = response["Bois_Corps"].ToString();
                    UnBon.Bois_Touche = response["Bois_Touche"].ToString();
                    UnBon.Bois_Manche = response["Bois_Manche"].ToString();
                    UnBon.DateCommande = response["DateCommande"].ToString();
                    UnBon.Montant = response["MontantCommande"].ToString();


                    les_Bons_de_Commandes.Add(UnBon);
                }
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            return les_Bons_de_Commandes;
        }
        [WebMethod]
        public C_BON_COMMANDE GetCommandeByID(int idCommande)
        {
            cnx.ConnectionString = Chemin_BDD;
            C_BON_COMMANDE UnBon = new C_BON_COMMANDE();
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "GetCommandeByID";

                query2.Parameters.Add("@CommandeID", System.Data.SqlDbType.Int);
                query2.Parameters["@CommandeID"].Value = idCommande;

                var response = query2.ExecuteReader();
                while (response.Read())
                {
                    UnBon.NroCommande = (int) response["NroCommande"];
                    UnBon.Client = response["Client"].ToString(); 
                    UnBon.Telephone = response["Telephone"].ToString(); 
                    UnBon.Nomguitar = response["Nomguitar"].ToString(); 
                    UnBon.M_Pos_1 = response["M_Pos_1"].ToString();
                    UnBon.M_Pos_2 = response["M_Pos_2"].ToString();
                    UnBon.M_Pos_3 = response["M_Pos_3"].ToString();
                    UnBon.Bois_Corps = response["Bois_Corps"].ToString();
                    UnBon.Bois_Touche = response["Bois_Touche"].ToString();
                    UnBon.Bois_Manche = response["Bois_Manche"].ToString();
                    UnBon.DateCommande = response["DateCommande"].ToString();
                    UnBon.Montant = response["MontantCommande"].ToString();
                }
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
            return UnBon;
        }

        [WebMethod]
        public string GetLastCommandeID()
        {
            cnx.ConnectionString = Chemin_BDD;
            string myid;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "GetLastCommandeID";
                var response = query2.ExecuteReader();
                myid = response["id"].ToString();


            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
            return myid;
        }
        [WebMethod]
        public void EraseMicroByConstructeur(string Constructeur)
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "EraseConstructeur";
                query2.Parameters.Add("@Construc", System.Data.SqlDbType.Char, 32);
                query2.Parameters["@Construc"].Value = Constructeur;
                var response = query2.ExecuteNonQuery();
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
        }
        [WebMethod]
        public void EraseCommandeById(int idCommande)
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "EraseCommande";
                query2.Parameters.Add("@IdCommande", System.Data.SqlDbType.Int);
                query2.Parameters["@IdCommande"].Value = idCommande;
                var response = query2.ExecuteNonQuery();
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
        }
        [WebMethod]
        public void EraseTypeBoisByName(string NomTypeBois)
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "EraseTypeBois";
                query2.Parameters.Add("@TypeBois", System.Data.SqlDbType.Char, 32);
                query2.Parameters["@TypeBois"].Value = NomTypeBois;
                var response = query2.ExecuteNonQuery();
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
        }
        [WebMethod]
        public void EraseVibratoByName(string NomVibrato)
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "EraseVibrato";
                query2.Parameters.Add("@Vibrato", System.Data.SqlDbType.Char, 32);
                query2.Parameters["@Vibrato"].Value = NomVibrato;
                var response = query2.ExecuteNonQuery();
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
        }
        [WebMethod]
        public void AjoutVibratoByName(string NomVibrato)
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "AjoutVibrato";
                query2.Parameters.Add("@Vibrato", System.Data.SqlDbType.Char, 32);
                query2.Parameters["@Vibrato"].Value = NomVibrato;
                var response = query2.ExecuteNonQuery();
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
        }

        [WebMethod]
        public void AjoutTypeBoisByName(string NomTypeBois)
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "AjoutTypeBois";
                query2.Parameters.Add("@TypeBois", System.Data.SqlDbType.Char, 32);
                query2.Parameters["@TypeBois"].Value = NomTypeBois;
                var response = query2.ExecuteNonQuery();
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
        }
        [WebMethod]
        public void AjoutConstructeurMicroByName(string NomConstructeur)
        {
            cnx.ConnectionString = Chemin_BDD;
            try
            {
                cnx.Open();
                SqlCommand query2 = new SqlCommand();
                query2.Connection = cnx;
                query2.CommandType = System.Data.CommandType.StoredProcedure;
                query2.CommandText = "AjoutConstrucMicro";
                query2.Parameters.Add("@Constructeur", System.Data.SqlDbType.Char, 32);
                query2.Parameters["@Constructeur"].Value = NomConstructeur;
                var response = query2.ExecuteNonQuery();
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            cnx.Close();
        }
    }
}
