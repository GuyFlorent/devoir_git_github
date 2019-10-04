  public bool VerifierLoginpass(string login, string pass)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connectionString;

            conn.Open();

            MySqlCommand cmd = new MySqlCommand();


            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            //cmd.CommandText = "SELECT * FROM couleur WHERE id = @id";
            cmd.CommandText = "SELECT * FROM User where login = @login AND pass = @pass";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@pass", pass);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            return dataReader.Read();
        }


