Public Class FormLai
    Dim vitri As Int32 = 0
    Private Sub FormLai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.DICHVU' table. You can move, or remove it, as needed.

        LAISUATTableAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.LAISUATTableAdapter.Fill(Me.DS.LAISUAT)
        HienthimadvTableAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.HienthimadvTableAdapter.Fill(Me.DS.hienthimadv)





    End Sub

    Private Sub LAISUATBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.laisuatbds.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub btnthemlaisuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthemlaisuat.ItemClick
        vitri = laisuatbds.Position
        grouboxlaixuat.Enabled = True
        gridviewlaixuat.Enabled = False
        laisuatbds.AddNew()
        'primakey với not null khi thêm phải cho nó bằng rỗng
        btnthemlaisuat.Enabled = False : btnhieuchinhlaisuat.Enabled = False : btnxoalaixuat.Enabled = False : btnthoatlaisuat.Enabled = False
        btnghilaisuat.Enabled = True : btnphuchoilaisuat.Enabled = True
    End Sub

    Private Sub btnghilaisuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnghilaisuat.ItemClick
        If txtlaisuat.Text.Trim = "" Then
            MsgBox("họ tên khách hàng không được rỗng", MsgBoxStyle.Information)
            txtlaisuat.Focus()
            Exit Sub
        End If

        If txtlaisuat.Text.Trim <= 0 Then
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
    End Sub
End Class