Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Module Connect
    Public strNoPicture As String = ""
    Public strDefaultPath As String = ""
    Public ConnStr As String = ""
    Public conn As New SqlConnection
    Public mGroup As String = ""
    Public mHoten As String = ""
    Public mManv As String = ""
    Public mlogin As String = ""
    Public mPass As String = ""
    Public servername As String = ""

    Public Function KetNoi() As Int32
        If conn.State = ConnectionState.Open Then conn.Close()
        Try

            ConnStr = "Data Source=" & servername &
                ";Initial Catalog=TKBUUDIEN;User ID=" & mlogin & ";Password=" & mPass
            conn.ConnectionString = ConnStr
            conn.Open()
            KetNoi = 1
        Catch ex As Exception
            MsgBox("Lỗi kết nối cơ sở dữ liệu . " & vbCrLf & "Bạn xem lại user name và password ")
            KetNoi = 0
        End Try

    End Function
    Public Function ExecSELECTSQL(ByVal strLenh As String) As SqlDataReader
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strLenh
        If conn.State = ConnectionState.Closed Then
            Connect.KetNoi()
        End If
        Try
            ExecSELECTSQL = cmd.ExecuteReader

            'conn.Close()
        Catch ex As SqlException
            MsgBox("Loi thuc thi cau lenh : " & vbCrLf &
                    strLenh & vbCrLf & ex.Message, MsgBoxStyle.OkOnly)

        End Try

    End Function
    Public Function ExecSELECTSQLTable(ByVal strLenh As String) As DataTable
        Dim da As New SqlDataAdapter(strLenh, conn)
        Dim dt As New DataTable
        If conn.State = ConnectionState.Closed Then
            Connect.KetNoi()
        End If
        Try
            da.Fill(dt)
            ExecSELECTSQLTable = dt
        Catch ex As SqlException
            MsgBox("Loi thuc thi cau lenh : " & vbCrLf &
                    strLenh & vbCrLf & ex.Message, MsgBoxStyle.OkOnly)

        End Try

    End Function
    Public Sub ExecNonQuery(ByVal strLenh As String)
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strLenh
        If conn.State = ConnectionState.Closed Then
            Connect.KetNoi()
        End If
        cmd.ExecuteNonQuery()
    End Sub
End Module
