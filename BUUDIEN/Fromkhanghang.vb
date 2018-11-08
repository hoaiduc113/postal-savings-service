Imports System.Data.SqlClient
Public Class Fromkhanghang
    Dim vitri As Int32 = 0
    Private Sub KHACHHANGBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.khachangbds.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub Fromkhanghang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KHACHHANGAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.KHACHHANGAdapter.Fill(Me.DS.KHACHHANG)
        PHIEUGUITableAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.PHIEUGUITableAdapter.Fill(Me.DS.PHIEUGUI)
    End Sub

    Private Sub btnthemkh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthemkh.ItemClick
        vitri = khachangbds.Position
        gropboxkh.Enabled = True
        gridviewkh.Enabled = False
        khachangbds.AddNew()
        'primakey với not null khi thêm phải cho nó bằng rỗng


        txthotenkh.Text = ""
        txtdiachikh.Text = ""
        txtcmnd.Text = ""
        NGAYCAPDateTimePicker.Text = ""
        btnthemkh.Enabled = False : btnhieuchinhkh.Enabled = False : btnxoakh.Enabled = False : btnthoat.Enabled = False
        btnnghikh.Enabled = True : btnphuchoikh.Enabled = True

    End Sub

    Private Sub btnnghikh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnnghikh.ItemClick


        If txthotenkh.Text.Trim = "" Then
            MsgBox("họ tên khách hàng không được rỗng", MsgBoxStyle.Information)
            txthotenkh.Focus()
            Exit Sub
        End If

        If txtdiachikh.Text.Trim = "" Then
            MsgBox("địa chỉ không được rỗng", MsgBoxStyle.Information)
            txtdiachikh.Focus()
            Exit Sub
        End If

        If NGAYCAPDateTimePicker.Text.Trim = "" Then
            MsgBox("ngày cấp không được rỗng", MsgBoxStyle.Information)

            Exit Sub
        End If
        If txtcmnd.Text.Trim = "" Then
            MsgBox("chứng minhh nhân dân không được rỗng", MsgBoxStyle.Information)
            txtcmnd.Focus()

            Exit Sub
        End If
        If txtcmnd.Text.Trim.Length > 12 Or txtcmnd.Text.Trim.Length < 9 Then
            MsgBox("chứng minh nhân dân từ 9 đến 12", MsgBoxStyle.Information)
            txtcmnd.Focus()
            Exit Sub
        End If

        Try

            khachangbds.EndEdit()
            khachangbds.ResetCurrentItem()
            If DS.HasChanges Then
                KHACHHANGAdapter.Update(DS.KHACHHANG)
            End If
        Catch ex As Exception

            Dim sp As String = "ktmakhachhang"
            Dim cmd As SqlCommand = New SqlCommand(sp, Connect.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@cmnd", txtcmnd.Text.Trim))
            Dim returnvalue As SqlParameter = New SqlParameter()
            returnvalue.Direction = ParameterDirection.ReturnValue
            cmd.Parameters.Add(returnvalue)
            If Connect.conn.State = ConnectionState.Closed Then
                Connect.KetNoi()
            End If

            cmd.ExecuteNonQuery()


            If returnvalue.Value = 1 Then

                MessageBox.Show("Mã nhân viên đã tồn tại", "", MessageBoxButtons.OK)
                txtcmnd.Focus()
                khachangbds.RemoveCurrent()

                KHACHHANGAdapter.Update(DS.KHACHHANG)
                Exit Sub
            End If


            Exit Sub
        End Try
        btnphuchoikh.Enabled = False : btnnghikh.Enabled = False : gropboxkh.Enabled = False
        btnthemkh.Enabled = True : btnhieuchinhkh.Enabled = True : btnxoakh.Enabled = True
        gridviewkh.Enabled = True
    End Sub

    Private Sub btnxoakh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnxoakh.ItemClick
        If phieuguibds.Count > 0 Then
            MsgBox("bạn không thể xóa khách hàng đã lập phiếu gửi", MsgBoxStyle.Information)
            Exit Sub
        End If
        If (MsgBox("Bạn có thật sự muốn xóa nhân viên này ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Try
                khachangbds.RemoveCurrent()

                KHACHHANGAdapter.Update(DS.KHACHHANG)
            Catch ex As Exception
                MsgBox("Lỗi Xóa khách hàng " & vbCrLf & ex.Message)
                Exit Sub
            End Try
        End If
        If khachangbds.Count = 0 Then
            btnxoakh.Enabled = False
        End If
    End Sub

    Private Sub btnphuchoikh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnphuchoikh.ItemClick
        khachangbds.CancelEdit()
        khachangbds.Position = vitri
        gridviewkh.Enabled = True
        btnthemkh.Enabled = True : btnxoakh.Enabled = True : btnhieuchinhkh.Enabled = True : btnthoat.Enabled = True
        gropboxkh.Enabled = False : btnnghikh.Enabled = False
    End Sub

    Private Sub btnhieuchinhkh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnhieuchinhkh.ItemClick
        btnthemkh.Enabled = False : btnhieuchinhkh.Enabled = False : btnxoakh.Enabled = False : btnthoat.Enabled = False : gridviewkh.Enabled = False
        btnnghikh.Enabled = True : gropboxkh.Enabled = True : btnphuchoikh.Enabled = True
        vitri = khachangbds.Position
    End Sub
End Class