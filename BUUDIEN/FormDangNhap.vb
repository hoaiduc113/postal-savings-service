Imports System.Data.SqlClient
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Public Class FormDangNhap

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click

        If txtdangnhap.Text.Trim = "" Or txtmatkhau.Text.Trim = "" Or txtserver.Text.Trim = "" Then
            MsgBox("Tên đăng nhập hoặc mật khẩu không được rỗng", MsgBoxStyle.Information)
            Return
        End If
        Connect.mlogin = txtdangnhap.Text
        Connect.mPass = txtmatkhau.Text
        Connect.servername = txtserver.Text
        '  If txtdangnhap.Text.Trim <> "" And txtmatkhau.Text.Trim <> "" Then

        'End If

        If Connect.KetNoi = 0 Then
                Return
            End If
            MsgBox("Đăng nhập thành công", MsgBoxStyle.Information)
            Dim sqlReader As SqlDataReader
            Dim sql As String
            sql = "SP_DANGNHAP'" + Connect.mlogin + "'"
            sqlReader = Connect.ExecSELECTSQL(sql)
        If sqlReader Is Nothing Then
            MsgBox("Tài khoản của bạn không có quyền truy cập đến cơ sở dữ liệu")
        End If
        sqlReader.Read()

            Connect.mManv = sqlReader.GetString(0)
            Connect.mHoten = sqlReader.GetString(1)
            Connect.mGroup = sqlReader.GetString(2)

            sqlReader.Close()
            Connect.conn.Close()
            Dim formchinh As Form1

            formchinh = New Form1

            formchinh.MANV.Text = "Mã nhân viên:" + Connect.mManv
            formchinh.TEN.Text = "Tên:" + Connect.mHoten
            formchinh.NHOM.Text = "Nhóm:" + Connect.mGroup




    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()

    End Sub


End Class