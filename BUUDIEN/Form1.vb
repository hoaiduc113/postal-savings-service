Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms

Partial Public Class Form1


    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub dangnhap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles dangnhap.ItemClick
        Dim frm As Object
        frm = CheckExists(FormDangNhap.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmNhanvien chưa mở
            frm = New FormDangNhap       ' tạo đối/tg frmNhanvien trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If

    End Sub
    Private Function CheckExists(ByVal ftype As Type) As Form
        CheckExists = Me
        Dim f As Form
        For Each f In Me.MdiChildren
            If (f.GetType() = ftype) Then
                CheckExists = f
                Exit Function
            End If
        Next
    End Function
    Public Sub HienThiMenu()

        MANV.Text = "Mã NV : " + Connect.mManv
        TEN.Text = "Họ tên nhân viên : " + Connect.mHoten
        NHOM.Text = "Nhóm : " + Connect.mGroup

    End Sub

    Private Sub btndsnhanvien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btndsnhanvien.ItemClick
        Dim frm As Object
        frm = CheckExists(FormNhanVien.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmNhanvien chưa mở
            frm = New FormNhanVien      ' tạo đối/tg frmNhanvien trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub btnkhachhang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnkhachhang.ItemClick
        Dim frm As Object
        frm = CheckExists(FormNhanVien.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmNhanvien chưa mở
            frm = New Fromkhanghang
            ' tạo đối/tg frmNhanvien trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub btndichvu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btndichvu.ItemClick
        Dim frm As Object
        frm = CheckExists(FormNhanVien.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmNhanvien chưa mở
            frm = New Fromdichvu
            ' tạo đối/tg frmNhanvien trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim frm As Object
        frm = CheckExists(FormLai.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmNhanvien chưa mở
            frm = New FormLai
            ' tạo đối/tg frmNhanvien trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub
End Class
