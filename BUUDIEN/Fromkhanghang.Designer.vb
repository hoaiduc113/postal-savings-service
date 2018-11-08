<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fromkhanghang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim HOTENLabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim CMNDLabel As System.Windows.Forms.Label
        Dim txtngaycap As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fromkhanghang))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnthemkh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnhieuchinhkh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxoakh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnphuchoikh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnthoat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnnghikh = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.DS = New BUUDIEN.DS()
        Me.KHACHHANGAdapter = New BUUDIEN.DSTableAdapters.KHACHHANGTableAdapter()
        Me.TableAdapterManager = New BUUDIEN.DSTableAdapters.TableAdapterManager()
        Me.gridviewkh = New DevExpress.XtraGrid.GridControl()
        Me.khachangbds = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHOTEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIACHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCMND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNGAYCAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gropboxkh = New System.Windows.Forms.GroupBox()
        Me.NGAYCAPDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtcmnd = New DevExpress.XtraEditors.TextEdit()
        Me.txtdiachikh = New DevExpress.XtraEditors.TextEdit()
        Me.txthotenkh = New DevExpress.XtraEditors.TextEdit()
        Me.phieuguibds = New System.Windows.Forms.BindingSource(Me.components)
        Me.PHIEUGUITableAdapter = New BUUDIEN.DSTableAdapters.PHIEUGUITableAdapter()
        HOTENLabel = New System.Windows.Forms.Label()
        DIACHILabel = New System.Windows.Forms.Label()
        CMNDLabel = New System.Windows.Forms.Label()
        txtngaycap = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewkh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khachangbds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gropboxkh.SuspendLayout()
        CType(Me.txtcmnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdiachikh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txthotenkh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phieuguibds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HOTENLabel
        '
        HOTENLabel.AutoSize = True
        HOTENLabel.Location = New System.Drawing.Point(12, 42)
        HOTENLabel.Name = "HOTENLabel"
        HOTENLabel.Size = New System.Drawing.Size(37, 13)
        HOTENLabel.TabIndex = 0
        HOTENLabel.Text = "họ tên"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Location = New System.Drawing.Point(12, 80)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(39, 13)
        DIACHILabel.TabIndex = 2
        DIACHILabel.Text = "địa chỉ"
        '
        'CMNDLabel
        '
        CMNDLabel.AutoSize = True
        CMNDLabel.Location = New System.Drawing.Point(371, 42)
        CMNDLabel.Name = "CMNDLabel"
        CMNDLabel.Size = New System.Drawing.Size(42, 13)
        CMNDLabel.TabIndex = 4
        CMNDLabel.Text = "CMND:"
        '
        'txtngaycap
        '
        txtngaycap.AutoSize = True
        txtngaycap.Location = New System.Drawing.Point(371, 84)
        txtngaycap.Name = "txtngaycap"
        txtngaycap.Size = New System.Drawing.Size(51, 13)
        txtngaycap.TabIndex = 6
        txtngaycap.Text = "ngày cấp"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.btnthemkh, Me.btnhieuchinhkh, Me.btnxoakh, Me.btnphuchoikh, Me.btnthoat, Me.btnnghikh})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthemkh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnhieuchinhkh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxoakh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnphuchoikh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnnghikh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btnthemkh
        '
        Me.btnthemkh.Caption = "thêm "
        Me.btnthemkh.Id = 1
        Me.btnthemkh.ImageOptions.Image = CType(resources.GetObject("btnthemkh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnthemkh.Name = "btnthemkh"
        '
        'btnhieuchinhkh
        '
        Me.btnhieuchinhkh.Caption = "hiệu chỉnh"
        Me.btnhieuchinhkh.Id = 2
        Me.btnhieuchinhkh.ImageOptions.Image = CType(resources.GetObject("btnhieuchinhkh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnhieuchinhkh.Name = "btnhieuchinhkh"
        '
        'btnxoakh
        '
        Me.btnxoakh.Caption = "xóa"
        Me.btnxoakh.Id = 3
        Me.btnxoakh.ImageOptions.Image = CType(resources.GetObject("btnxoakh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnxoakh.Name = "btnxoakh"
        '
        'btnphuchoikh
        '
        Me.btnphuchoikh.Caption = "phục hồi"
        Me.btnphuchoikh.Id = 4
        Me.btnphuchoikh.ImageOptions.Image = CType(resources.GetObject("btnphuchoikh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnphuchoikh.Name = "btnphuchoikh"
        '
        'btnthoat
        '
        Me.btnthoat.Caption = "thoát"
        Me.btnthoat.Id = 5
        Me.btnthoat.ImageOptions.Image = CType(resources.GetObject("btnthoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnthoat.Name = "btnthoat"
        '
        'btnnghikh
        '
        Me.btnnghikh.Caption = "ghi"
        Me.btnnghikh.Id = 6
        Me.btnnghikh.ImageOptions.Image = CType(resources.GetObject("btnnghikh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnnghikh.Name = "btnnghikh"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(851, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 468)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(851, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 428)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(851, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 428)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KHACHHANGAdapter
        '
        Me.KHACHHANGAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DICHVUTableAdapter = Nothing
        Me.TableAdapterManager.GDVTableAdapter = Nothing
        Me.TableAdapterManager.KHACHHANGTableAdapter = Me.KHACHHANGAdapter
        Me.TableAdapterManager.LAISUATTableAdapter = Nothing
        Me.TableAdapterManager.PHIEUGUITableAdapter = Nothing
        Me.TableAdapterManager.PHIEURUTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BUUDIEN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'gridviewkh
        '
        Me.gridviewkh.DataSource = Me.khachangbds
        Me.gridviewkh.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridviewkh.Location = New System.Drawing.Point(0, 40)
        Me.gridviewkh.MainView = Me.GridView1
        Me.gridviewkh.MenuManager = Me.BarManager1
        Me.gridviewkh.Name = "gridviewkh"
        Me.gridviewkh.Size = New System.Drawing.Size(851, 220)
        Me.gridviewkh.TabIndex = 5
        Me.gridviewkh.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'khachangbds
        '
        Me.khachangbds.DataMember = "KHACHHANG"
        Me.khachangbds.DataSource = Me.DS
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHOTEN, Me.colDIACHI, Me.colCMND, Me.colNGAYCAP})
        Me.GridView1.GridControl = Me.gridviewkh
        Me.GridView1.Name = "GridView1"
        '
        'colHOTEN
        '
        Me.colHOTEN.Caption = "Họ tên"
        Me.colHOTEN.FieldName = "HOTEN"
        Me.colHOTEN.Name = "colHOTEN"
        Me.colHOTEN.Visible = True
        Me.colHOTEN.VisibleIndex = 0
        '
        'colDIACHI
        '
        Me.colDIACHI.Caption = "Địa chỉ "
        Me.colDIACHI.FieldName = "DIACHI"
        Me.colDIACHI.Name = "colDIACHI"
        Me.colDIACHI.Visible = True
        Me.colDIACHI.VisibleIndex = 1
        '
        'colCMND
        '
        Me.colCMND.Caption = "CMND"
        Me.colCMND.FieldName = "CMND"
        Me.colCMND.Name = "colCMND"
        Me.colCMND.Visible = True
        Me.colCMND.VisibleIndex = 2
        '
        'colNGAYCAP
        '
        Me.colNGAYCAP.Caption = "ngày cấp"
        Me.colNGAYCAP.FieldName = "NGAYCAP"
        Me.colNGAYCAP.Name = "colNGAYCAP"
        Me.colNGAYCAP.Visible = True
        Me.colNGAYCAP.VisibleIndex = 3
        '
        'gropboxkh
        '
        Me.gropboxkh.Controls.Add(txtngaycap)
        Me.gropboxkh.Controls.Add(Me.NGAYCAPDateTimePicker)
        Me.gropboxkh.Controls.Add(CMNDLabel)
        Me.gropboxkh.Controls.Add(Me.txtcmnd)
        Me.gropboxkh.Controls.Add(DIACHILabel)
        Me.gropboxkh.Controls.Add(Me.txtdiachikh)
        Me.gropboxkh.Controls.Add(HOTENLabel)
        Me.gropboxkh.Controls.Add(Me.txthotenkh)
        Me.gropboxkh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gropboxkh.Location = New System.Drawing.Point(0, 260)
        Me.gropboxkh.Name = "gropboxkh"
        Me.gropboxkh.Size = New System.Drawing.Size(851, 208)
        Me.gropboxkh.TabIndex = 10
        Me.gropboxkh.TabStop = False
        Me.gropboxkh.Text = "GroupBox1"
        '
        'NGAYCAPDateTimePicker
        '
        Me.NGAYCAPDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.khachangbds, "NGAYCAP", True))
        Me.NGAYCAPDateTimePicker.Location = New System.Drawing.Point(442, 84)
        Me.NGAYCAPDateTimePicker.Name = "NGAYCAPDateTimePicker"
        Me.NGAYCAPDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.NGAYCAPDateTimePicker.TabIndex = 7
        '
        'txtcmnd
        '
        Me.txtcmnd.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.khachangbds, "CMND", True))
        Me.txtcmnd.EditValue = ""
        Me.txtcmnd.Location = New System.Drawing.Point(442, 39)
        Me.txtcmnd.MenuManager = Me.BarManager1
        Me.txtcmnd.Name = "txtcmnd"
        Me.txtcmnd.Size = New System.Drawing.Size(200, 20)
        Me.txtcmnd.TabIndex = 5
        '
        'txtdiachikh
        '
        Me.txtdiachikh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.khachangbds, "DIACHI", True))
        Me.txtdiachikh.EditValue = ""
        Me.txtdiachikh.Location = New System.Drawing.Point(81, 77)
        Me.txtdiachikh.MenuManager = Me.BarManager1
        Me.txtdiachikh.Name = "txtdiachikh"
        Me.txtdiachikh.Size = New System.Drawing.Size(188, 20)
        Me.txtdiachikh.TabIndex = 3
        '
        'txthotenkh
        '
        Me.txthotenkh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.khachangbds, "HOTEN", True))
        Me.txthotenkh.EditValue = ""
        Me.txthotenkh.Location = New System.Drawing.Point(81, 35)
        Me.txthotenkh.MenuManager = Me.BarManager1
        Me.txthotenkh.Name = "txthotenkh"
        Me.txthotenkh.Size = New System.Drawing.Size(188, 20)
        Me.txthotenkh.TabIndex = 1
        '
        'phieuguibds
        '
        Me.phieuguibds.DataMember = "FK_KHACHHANG_PHIEUGUI"
        '
        'PHIEUGUITableAdapter
        '
        Me.PHIEUGUITableAdapter.ClearBeforeFill = True
        '
        'Fromkhanghang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 491)
        Me.Controls.Add(Me.gropboxkh)
        Me.Controls.Add(Me.gridviewkh)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Fromkhanghang"
        Me.Text = "khanghang"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewkh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.khachangbds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gropboxkh.ResumeLayout(False)
        Me.gropboxkh.PerformLayout()
        CType(Me.txtcmnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdiachikh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txthotenkh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phieuguibds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btnthemkh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DS As DS
    Friend WithEvents KHACHHANGAdapter As DSTableAdapters.KHACHHANGTableAdapter
    Friend WithEvents TableAdapterManager As DSTableAdapters.TableAdapterManager
    Friend WithEvents gridviewkh As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHOTEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIACHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCMND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNGAYCAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gropboxkh As GroupBox
    Friend WithEvents btnhieuchinhkh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxoakh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnphuchoikh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnthoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnnghikh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents phieuguibds As BindingSource
    Friend WithEvents PHIEUGUITableAdapter As DSTableAdapters.PHIEUGUITableAdapter
    Friend WithEvents khachangbds As BindingSource
    Friend WithEvents NGAYCAPDateTimePicker As DateTimePicker
    Friend WithEvents txtcmnd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdiachikh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txthotenkh As DevExpress.XtraEditors.TextEdit
End Class
