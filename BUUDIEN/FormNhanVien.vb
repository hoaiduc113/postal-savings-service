Public Class FormNhanVien
    Dim vitri As Int32 = 0
    Private Sub GDVBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.bdsGDV.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub FormNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GDVTableAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.GDVTableAdapter.Fill(Me.DS.GDV)
        PHIEURUTTableAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.PHIEURUTTableAdapter.Fill(Me.DS.PHIEURUT)
        PHIEUGUITableAdapter.Connection.ConnectionString = Connect.ConnStr
        Me.PHIEUGUITableAdapter.Fill(Me.DS.PHIEUGUI)



    End Sub

    Private Sub btnthemnv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthemnv.ItemClick
        vitri = bdsGDV.Position
        'giữ lại vị trí đang đứng để undo ,vì nó luôn nhảy về mẫu tin cuối cùng
        GboxNhanVien.Enabled = True
        GriviewGDV.Enabled = False
        bdsGDV.AddNew()
        txtmagdv.Text = ""
        txtdcGDV.Text = ""
        txthotengdv.Text = ""
        txtcmndgdv.Text = ""
        btnthemnv.Enabled = False 'tránh bấm nút thêm 2 lần
        btnhieuchinhgdv.Enabled = False
        btnxoagdv.Enabled = False
        btnghiNV.Enabled = True

        txtmagdv.Focus()
    End Sub

    Private Sub btnghiNV_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnghiNV.ItemClick
        If txtmagdv.Text.Trim = "" Then
            MsgBox("mã nhân viên không được rỗng", MsgBoxStyle.Information)
            txtmagdv.Focus()

            Exit Sub
        End If
        If txtdcGDV.Text.Trim = "" Then
            MsgBox("địa chỉ không được rỗng", MsgBoxStyle.Information)
            txtdcGDV.Focus()
            Exit Sub
        End If
        If txtsdtgdv.Text.Trim = "" Then
            MsgBox("số điện thoại không được rỗng", MsgBoxStyle.Information)
            txtsdtgdv.Focus()
            Exit Sub
        End If
        If txthotengdv.Text.Trim = "" Then
            MsgBox("họ tên không được rỗng", MsgBoxStyle.Information)
            txthotengdv.Focus()
            Exit Sub
        End If
        If txtcmndgdv.Text.Trim = "" Then
            MsgBox("chứng minh nhân được rỗng", MsgBoxStyle.Information)
            txtcmndgdv.Focus()
            Exit Sub
        End If
        Try
            bdsGDV.EndEdit()
            bdsGDV.ResetCurrentItem()

            If DS.HasChanges() Then
                GDVTableAdapter.Update(DS.GDV)
            End If

        Catch ex As Exception

        End Try
        GriviewGDV.Enabled = True
        btnthemnv.Enabled = True
        btnhieuchinhgdv.Enabled = True
        btnxoagdv.Enabled = True
        btnghiNV.Enabled = False
        btnphuchoigdv.Enabled = False
        GboxNhanVien.Enabled = False
        GriviewGDV.Enabled = True


    End Sub

    Private Sub btnxoagdv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnxoagdv.ItemClick
        If PHIEUGUIbds.Count > 0 Then
            MsgBox("Nhân viên bạn muốn xóa đã lập phiếu nhập hoặc phiếu xuất, nên không thể xóa", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If (MsgBox("Bạn có thật sự muốn xóa nhân viên này ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Try
                bdsGDV.RemoveCurrent()
                GDVTableAdapter.Update(DS.GDV)
            Catch ex As Exception
                MsgBox("Lỗi Xóa nhân viên. " & vbCrLf & ex.Message)
            End Try
        End If
        If bdsGDV.Count = 0 Then
            btnxoagdv.Enabled = False
        End If
    End Sub

    Private Sub btnphuchoigdv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnphuchoigdv.ItemClick
        bdsGDV.CancelEdit()
        bdsGDV.Position = vitri
        GriviewGDV.Enabled = True
        GboxNhanVien.Enabled = False
    End Sub

    Private Sub btnhieuchinhgdv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnhieuchinhgdv.ItemClick
        btnthemnv.Enabled = False
        btnxoagdv.Enabled = False
        btnhieuchinhgdv.Enabled = False
        GriviewGDV.Enabled = False
        GboxNhanVien.Enabled = True
        btnghiNV.Enabled = True
        btnphuchoigdv.Enabled = True
        btnphuchoigdv.Enabled = False
        vitri = bdsGDV.Position
    End Sub
End Class