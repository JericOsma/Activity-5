Imports System.IO
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Sub loadTable()
        Try
            openCon()
            With coms
                .Connection = con
                .CommandText = "select * from uploaded_data"
            End With
            reader = coms.ExecuteReader
            Dim tbl As New DataTable
            tbl.Load(reader)

            DataGridView1.DataSource = tbl
            closeCon()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            OpenFileDialog1.Filter = "CSV|*.csv"
            Dim filename As String = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            Try
                openCon()
                With coms
                    .Connection = con
                    .CommandText = "insert into uploaded_data(filename,Date)values('" & filename & "',curdate())"
                    .ExecuteNonQuery()
                End With
                MsgBox("File has been uploaded")
                closeCon()
                loadTable()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        backupDatabase()
    End Sub

    Sub backupDatabase()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "SQL Files (*.sql)|*.sql"
        saveFileDialog.FileName = "backup.sql"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then

            Dim server As String = "localhost"
            Dim port As Integer = 3307
            Dim database As String = "activity5"
            Dim username As String = "root"
            Dim password As String = "1225"


            Dim backupFilePath As String = saveFileDialog.FileName


            Dim command As String = $"mysqldump --host={server} --port={port} --user={username} --password={password} --databases {database} > ""{backupFilePath}"""


            Dim processInfo As New ProcessStartInfo("cmd.exe", "/c " & command)
            processInfo.CreateNoWindow = True
            processInfo.UseShellExecute = False
            processInfo.RedirectStandardError = True
            processInfo.RedirectStandardOutput = True

            Dim process As Process = Process.Start(processInfo)
            process.WaitForExit()


            If process.ExitCode = 0 Then
                MessageBox.Show("Database backup successfully.")
            Else
                MessageBox.Show("Error occurred during database backup.")
            End If
        End If
    End Sub
End Class