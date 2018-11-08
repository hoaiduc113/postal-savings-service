Imports System.Data.SqlClient
Public Class Fromdichvu
    Dim vitri As Int32 = 0
    Private Sub DICHVUBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DICHVUbds.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub Fromdichvu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DICHVUAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.DICHVUAdapter.Fill(Me.DS.DICHVU)
        LAISUATTableAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.LAISUATTableAdapter.Fill(Me.DS.LAISUAT)
        PHIEUGUITableAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.PHIEUGUITableAdapter.Fill(Me.DS.PHIEUGUI)


    End Sub

    Private Sub btnthemdv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthemdv.ItemClick
        vitri = DICHVUbds.Position
        griviewdichvu.Enabled = False
        gropboxdichvu.Enabled = True
        DICHVUbds.AddNew()
        txtkyhandv.Text = ""
        txtmadichvu.Text = ""
        txttendv.Text = ""
        btnxoadv.Enabled = False : btnhieuchinh.Enabled = False : btnthemdv.Enabled = False : btnthoatdv.Enabled = False
        btnghidv.Enabled = True : btnphuchoidv.Enabled = True
    End Sub

    Private Sub btnghidv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnghidv.ItemClick
        If txtmadichvu.Text.Trim = "" Then
            MsgBox("mã dịch vụ không được rỗng", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txttendv.Text.Trim = "" Then
            MsgBox("tên dịch vụ không được rỗng", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtkyhandv.Text.Trim = "" Then
            MsgBox("kỳ hạn dịch vụ không được rỗng", MsgBoxStyle.Information)

        End If
        If txtkyhandv.Text.Trim <= 0 Then
            MsgBox("kỳ hạn dịch vụ phải lớn hơn học bằng 0", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            DICHVUbds.EndEdit()
            DICHVUbds.ResetCurrentItem()
            If DS.HasChanges Then
                DICHVUAdapter.Update(DS.DICHVU)
            End If
        Catch ex As Exception
            Dim sp As String = "kiemtramadichvu"
            Dim cmd As SqlCommand = New SqlCommand(sp, Connect.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@madv", txtmadichvu.Text.Trim))
            Dim returnvalue As SqlParameter = New SqlParameter()
            returnvalue.Direction = ParameterDirection.ReturnValue
            cmd.Parameters.Add(returnvalue)
            If Connect.conn.State = ConnectionState.Closed Then
                Connect.KetNoi()
            End If

            cmd.ExecuteNonQuery()


            If returnvalue.Value = 1 Then

                MessageBox.Show("Mã dịch vụ đã tồn tại", "", MessageBoxButtons.OK)
                txtmadichvu.Focus()
                DICHVUbds.RemoveCurrent()

                DICHVUAdapter.Update(DS.DICHVU)
                Exit Sub
            End If


            Exit Sub
        End Try
        btnghidv.Enabled = False : btnphuchoidv.Enabled = False : gropboxdichvu.Enabled = False
        btnthemdv.Enabled = True : btnxoadv.Enabled = True : btnhieuchinh.Enabled = True : btnthoatdv.Enabled = True : griviewdichvu.Enabled = True

    End Sub

    Private Sub btnxoadv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnxoadv.ItemClick
        If (phieuguibds.Count > 0) Then
            MsgBox("dịch vụ bạn muốn xóa đã lập phiếu gửi, nên không thể xóa", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If (laisuatbds.Count > 0) Then
            MsgBox("dịch vụ bạn muốn xóa đã lập , nên không thể xóa", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If (MsgBox("Bạn có thật sự muốn xóa dịch vụ này ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Try
                DICHVUbds.RemoveCurrent()
                DICHVUAdapter.Update(DS.DICHVU)
            Catch ex As Exception
                MsgBox("Lỗi Xóa dịch vụ. " & vbCrLf & ex.Message)
            End Try
        End If
        If DICHVUbds.Count = 0 Then
            btnxoadv.Enabled = False
        End If
    End Sub

    Private Sub btnhieuchinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnhieuchinh.ItemClick
        btnthemdv.Enabled = False : btnhieuchinh.Enabled = False : btnxoadv.Enabled = False : btnthoatdv.Enabled = False : griviewdichvu.Enabled = False
        btnghidv.Enabled = True : gropboxdichvu.Enabled = True : btnphuchoidv.Enabled = True
        vitri = DICHVUbds.Position
    End Sub

    Private Sub btnphuchoidv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnphuchoidv.ItemClick
        DICHVUbds.CancelEdit()
        DICHVUbds.Position = vitri
        gropboxdichvu.Enabled = True
        btnthemdv.Enabled = True : btnxoadv.Enabled = True : btnhieuchinh.Enabled = True : btnthoatdv.Enabled = True
        gropboxdichvu.Enabled = False : btnghidv.Enabled = False
    End Sub
End Class