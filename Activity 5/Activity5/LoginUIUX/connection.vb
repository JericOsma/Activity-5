Imports MySql.Data.MySqlClient
Module connection
    Public con As New MySqlConnection
    Public coms As New MySqlCommand
    Public reader As MySqlDataReader

    Sub openCon()
        Try
            With con
                .ConnectionString = "server=localhost;port=3307;username=root;password=1225;database=activity5"
                .Open()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub closeCon()
        con.Close()
    End Sub
End Module
