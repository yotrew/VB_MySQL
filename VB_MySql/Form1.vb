Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btn_get_data_Click(sender As Object, e As EventArgs) Handles btn_get_data.Click
        'Ref:http://blog.davidou.org/archives/922
        Dim dbconn As New MySqlConnection 'Imports MySql.Data.MySqlClient
        Dim server As String = tb_server.Text
        Dim user As String = tb_user.Text
        Dim passwd As String = tb_pw.Text
        Dim conn_str = "Database=cmdev;Data Source=" & server & ";User Id=" & user & ";Password=" & passwd & ";CharSet=utf8"
        If dbconn.State = ConnectionState.Open Then '連線中...
            dbconn.Close() '斷線
        End If
        ToolStripStatusLabel1.Text = "連線中..."
        dbconn = New MySqlConnection(conn_str) '連線
        Try
            dbconn.Open()
        Catch ex As MySqlException
            ToolStripStatusLabel1.Text = "連線失敗..."
            MessageBox.Show("連線失敗")
            Exit Sub
        End Try

        ToolStripStatusLabel1.Text = "連線完成..."

        If dbconn Is Nothing Then '連線失敗
            MessageBox.Show("連線失敗")
            Exit Sub
        End If
        ToolStripStatusLabel1.Text = "取得資料中..."
        Dim sql_str As String = "select * from emp"
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql_str, dbconn)
        Dim ds As DataSet = New DataSet
        adapter.Fill(ds, "Employee") '將查詢結果丟到dataset中,並取名為Employee
        DataGridView1.DataSource = ds.Tables("Employee")
        ToolStripStatusLabel1.Text = "取得資料完成..."
        dbconn.Close()
    End Sub
End Class
