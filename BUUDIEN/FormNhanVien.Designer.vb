<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNhanVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MAGDVLabel As System.Windows.Forms.Label
        Dim HOTENLabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim CMNDLabel As System.Windows.Forms.Label
        Dim SODTLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNhanVien))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnthemnv = New DevExpress.XtraBars.BarButtonItem()
        Me.btnghiNV = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxoagdv = New DevExpress.XtraBars.BarButtonItem()
        Me.btnphuchoigdv = New DevExpress.XtraBars.BarButtonItem()
        Me.btnhieuchinhgdv = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.DS = New BUUDIEN.DS()
        Me.bdsGDV = New System.Windows.Forms.BindingSource(Me.components)
        Me.GDVTableAdapter = New BUUDIEN.DSTableAdapters.GDVTableAdapter()
        Me.TableAdapterManager = New BUUDIEN.DSTableAdapters.TableAdapterManager()
        Me.GriviewGDV = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMAGDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHOTEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIACHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCMND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSODT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GboxNhanVien = New System.Windows.Forms.GroupBox()
        Me.txtsdtgdv = New DevExpress.XtraEditors.TextEdit()
        Me.txtcmndgdv = New DevExpress.XtraEditors.TextEdit()
        Me.txtdcGDV = New DevExpress.XtraEditors.TextEdit()
        Me.txthotengdv = New DevExpress.XtraEditors.TextEdit()
        Me.txtmagdv = New DevExpress.XtraEditors.TextEdit()
        Me.PHIEUGUIbds = New System.Windows.Forms.BindingSource(Me.components)
        Me.PHIEUGUITableAdapter = New BUUDIEN.DSTableAdapters.PHIEUGUITableAdapter()
        Me.PHIEURUTbds = New System.Windows.Forms.BindingSource(Me.components)
        Me.PHIEURUTTableAdapter = New BUUDIEN.DSTableAdapters.PHIEURUTTableAdapter()
        MAGDVLabel = New System.Windows.Forms.Label()
        HOTENLabel = New System.Windows.Forms.Label()
        DIACHILabel = New System.Windows.Forms.Label()
        CMNDLabel = New System.Windows.Forms.Label()
        SODTLabel = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsGDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GriviewGDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxNhanVien.SuspendLayout()
        CType(Me.txtsdtgdv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcmndgdv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdcGDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txthotengdv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmagdv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHIEUGUIbds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHIEURUTbds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MAGDVLabel
        '
        MAGDVLabel.AutoSize = True
        MAGDVLabel.Location = New System.Drawing.Point(6, 36)
        MAGDVLabel.Name = "MAGDVLabel"
        MAGDVLabel.Size = New System.Drawing.Size(91, 13)
        MAGDVLabel.TabIndex = 0
        MAGDVLabel.Text = "Mã giao dịch viên"
        '
        'HOTENLabel
        '
        HOTENLabel.AutoSize = True
        HOTENLabel.Location = New System.Drawing.Point(334, 36)
        HOTENLabel.Name = "HOTENLabel"
        HOTENLabel.Size = New System.Drawing.Size(37, 13)
        HOTENLabel.TabIndex = 2
        HOTENLabel.Text = "họ tên"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Location = New System.Drawing.Point(6, 74)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(39, 13)
        DIACHILabel.TabIndex = 4
        DIACHILabel.Text = "địa chỉ"
        '
        'CMNDLabel
        '
        CMNDLabel.AutoSize = True
        CMNDLabel.Location = New System.Drawing.Point(340, 74)
        CMNDLabel.Name = "CMNDLabel"
        CMNDLabel.Size = New System.Drawing.Size(42, 13)
        CMNDLabel.TabIndex = 6
        CMNDLabel.Text = "CMND:"
        '
        'SODTLabel
        '
        SODTLabel.AutoSize = True
        SODTLabel.Location = New System.Drawing.Point(6, 111)
        SODTLabel.Name = "SODTLabel"
        SODTLabel.Size = New System.Drawing.Size(68, 13)
        SODTLabel.TabIndex = 8
        SODTLabel.Text = "số điện thoại"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnthemnv, Me.btnghiNV, Me.btnxoagdv, Me.btnphuchoigdv, Me.btnhieuchinhgdv})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthemnv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnghiNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxoagdv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnphuchoigdv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnhieuchinhgdv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btnthemnv
        '
        Me.btnthemnv.Caption = "Thêm"
        Me.btnthemnv.Id = 0
        Me.btnthemnv.ImageOptions.Image = CType(resources.GetObject("btnthemnv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnthemnv.Name = "btnthemnv"
        '
        'btnghiNV
        '
        Me.btnghiNV.Caption = "Ghi"
        Me.btnghiNV.Id = 1
        Me.btnghiNV.ImageOptions.Image = CType(resources.GetObject("btnghiNV.ImageOptions.Image"), System.Drawing.Image)
        Me.btnghiNV.Name = "btnghiNV"
        '
        'btnxoagdv
        '
        Me.btnxoagdv.Caption = "xóa"
        Me.btnxoagdv.Id = 2
        Me.btnxoagdv.ImageOptions.Image = CType(resources.GetObject("btnxoagdv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnxoagdv.Name = "btnxoagdv"
        '
        'btnphuchoigdv
        '
        Me.btnphuchoigdv.Caption = "phục hồi"
        Me.btnphuchoigdv.Id = 3
        Me.btnphuchoigdv.ImageOptions.Image = CType(resources.GetObject("btnphuchoigdv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnphuchoigdv.Name = "btnphuchoigdv"
        '
        'btnhieuchinhgdv
        '
        Me.btnhieuchinhgdv.Caption = "hiêu chỉnh"
        Me.btnhieuchinhgdv.Id = 4
        Me.btnhieuchinhgdv.ImageOptions.Image = CType(resources.GetObject("btnhieuchinhgdv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnhieuchinhgdv.Name = "btnhieuchinhgdv"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(891, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 517)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(891, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 477)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(891, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 477)
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.Name = "SqlDataSource1"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bdsGDV
        '
        Me.bdsGDV.DataMember = "GDV"
        Me.bdsGDV.DataSource = Me.DS
        '
        'GDVTableAdapter
        '
        Me.GDVTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DICHVUTableAdapter = Nothing
        Me.TableAdapterManager.GDVTableAdapter = Me.GDVTableAdapter
        Me.TableAdapterManager.KHACHHANGTableAdapter = Nothing
        Me.TableAdapterManager.LAISUATTableAdapter = Nothing
        Me.TableAdapterManager.PHIEUGUITableAdapter = Nothing
        Me.TableAdapterManager.PHIEURUTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BUUDIEN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GriviewGDV
        '
        Me.GriviewGDV.DataSource = Me.bdsGDV
        Me.GriviewGDV.Dock = System.Windows.Forms.DockStyle.Top
        Me.GriviewGDV.Location = New System.Drawing.Point(0, 40)
        Me.GriviewGDV.MainView = Me.GridView1
        Me.GriviewGDV.MenuManager = Me.BarManager1
        Me.GriviewGDV.Name = "GriviewGDV"
        Me.GriviewGDV.Size = New System.Drawing.Size(891, 287)
        Me.GriviewGDV.TabIndex = 5
        Me.GriviewGDV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMAGDV, Me.colHOTEN, Me.colDIACHI, Me.colCMND, Me.colSODT})
        Me.GridView1.GridControl = Me.GriviewGDV
        Me.GridView1.Name = "GridView1"
        '
        'colMAGDV
        '
        Me.colMAGDV.Caption = "Mã nhân viên"
        Me.colMAGDV.FieldName = "MAGDV"
        Me.colMAGDV.Name = "colMAGDV"
        Me.colMAGDV.Visible = True
        Me.colMAGDV.VisibleIndex = 0
        '
        'colHOTEN
        '
        Me.colHOTEN.Caption = "Họ Tên"
        Me.colHOTEN.FieldName = "HOTEN"
        Me.colHOTEN.Name = "colHOTEN"
        Me.colHOTEN.Visible = True
        Me.colHOTEN.VisibleIndex = 1
        '
        'colDIACHI
        '
        Me.colDIACHI.Caption = "Địa chỉ"
        Me.colDIACHI.FieldName = "DIACHI"
        Me.colDIACHI.Name = "colDIACHI"
        Me.colDIACHI.Visible = True
        Me.colDIACHI.VisibleIndex = 2
        '
        'colCMND
        '
        Me.colCMND.Caption = "CMND"
        Me.colCMND.FieldName = "CMND"
        Me.colCMND.Name = "colCMND"
        Me.colCMND.Visible = True
        Me.colCMND.VisibleIndex = 3
        '
        'colSODT
        '
        Me.colSODT.Caption = "số điện thoại"
        Me.colSODT.FieldName = "SODT"
        Me.colSODT.Name = "colSODT"
        Me.colSODT.Visible = True
        Me.colSODT.VisibleIndex = 4
        '
        'GboxNhanVien
        '
        Me.GboxNhanVien.Controls.Add(SODTLabel)
        Me.GboxNhanVien.Controls.Add(Me.txtsdtgdv)
        Me.GboxNhanVien.Controls.Add(CMNDLabel)
        Me.GboxNhanVien.Controls.Add(Me.txtcmndgdv)
        Me.GboxNhanVien.Controls.Add(DIACHILabel)
        Me.GboxNhanVien.Controls.Add(Me.txtdcGDV)
        Me.GboxNhanVien.Controls.Add(HOTENLabel)
        Me.GboxNhanVien.Controls.Add(Me.txthotengdv)
        Me.GboxNhanVien.Controls.Add(MAGDVLabel)
        Me.GboxNhanVien.Controls.Add(Me.txtmagdv)
        Me.GboxNhanVien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GboxNhanVien.Location = New System.Drawing.Point(0, 327)
        Me.GboxNhanVien.Name = "GboxNhanVien"
        Me.GboxNhanVien.Size = New System.Drawing.Size(891, 190)
        Me.GboxNhanVien.TabIndex = 6
        Me.GboxNhanVien.TabStop = False
        Me.GboxNhanVien.Text = "GroupBox1"
        '
        'txtsdtgdv
        '
        Me.txtsdtgdv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bdsGDV, "SODT", True))
        Me.txtsdtgdv.Location = New System.Drawing.Point(103, 108)
        Me.txtsdtgdv.MenuManager = Me.BarManager1
        Me.txtsdtgdv.Name = "txtsdtgdv"
        Me.txtsdtgdv.Size = New System.Drawing.Size(190, 20)
        Me.txtsdtgdv.TabIndex = 9
        '
        'txtcmndgdv
        '
        Me.txtcmndgdv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bdsGDV, "CMND", True))
        Me.txtcmndgdv.Location = New System.Drawing.Point(388, 71)
        Me.txtcmndgdv.MenuManager = Me.BarManager1
        Me.txtcmndgdv.Name = "txtcmndgdv"
        Me.txtcmndgdv.Size = New System.Drawing.Size(198, 20)
        Me.txtcmndgdv.TabIndex = 7
        '
        'txtdcGDV
        '
        Me.txtdcGDV.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bdsGDV, "DIACHI", True))
        Me.txtdcGDV.Location = New System.Drawing.Point(103, 71)
        Me.txtdcGDV.MenuManager = Me.BarManager1
        Me.txtdcGDV.Name = "txtdcGDV"
        Me.txtdcGDV.Size = New System.Drawing.Size(190, 20)
        Me.txtdcGDV.TabIndex = 5
        '
        'txthotengdv
        '
        Me.txthotengdv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bdsGDV, "HOTEN", True))
        Me.txthotengdv.Location = New System.Drawing.Point(388, 33)
        Me.txthotengdv.MenuManager = Me.BarManager1
        Me.txthotengdv.Name = "txthotengdv"
        Me.txthotengdv.Size = New System.Drawing.Size(198, 20)
        Me.txthotengdv.TabIndex = 3
        '
        'txtmagdv
        '
        Me.txtmagdv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bdsGDV, "MAGDV", True))
        Me.txtmagdv.Location = New System.Drawing.Point(103, 33)
        Me.txtmagdv.MenuManager = Me.BarManager1
        Me.txtmagdv.Name = "txtmagdv"
        Me.txtmagdv.Size = New System.Drawing.Size(190, 20)
        Me.txtmagdv.TabIndex = 1
        '
        'PHIEUGUIbds
        '
        Me.PHIEUGUIbds.DataMember = "FK_PHIEUGUI_GDV"
        Me.PHIEUGUIbds.DataSource = Me.bdsGDV
        '
        'PHIEUGUITableAdapter
        '
        Me.PHIEUGUITableAdapter.ClearBeforeFill = True
        '
        'PHIEURUTbds
        '
        Me.PHIEURUTbds.DataMember = "FK_PHIEURUT_GDV"
        Me.PHIEURUTbds.DataSource = Me.bdsGDV
        '
        'PHIEURUTTableAdapter
        '
        Me.PHIEURUTTableAdapter.ClearBeforeFill = True
        '
        'FormNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 540)
        Me.Controls.Add(Me.GboxNhanVien)
        Me.Controls.Add(Me.GriviewGDV)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FormNhanVien"
        Me.Text = "FormNhanVien"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsGDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GriviewGDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxNhanVien.ResumeLayout(False)
        Me.GboxNhanVien.PerformLayout()
        CType(Me.txtsdtgdv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcmndgdv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdcGDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txthotengdv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmagdv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHIEUGUIbds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHIEURUTbds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnthemnv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents bdsGDV As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents GDVTableAdapter As DSTableAdapters.GDVTableAdapter
    Friend WithEvents TableAdapterManager As DSTableAdapters.TableAdapterManager
    Friend WithEvents GriviewGDV As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GboxNhanVien As GroupBox
    Friend WithEvents colMAGDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHOTEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIACHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCMND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSODT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtsdtgdv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcmndgdv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdcGDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txthotengdv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmagdv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnghiNV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PHIEUGUIbds As BindingSource
    Friend WithEvents PHIEUGUITableAdapter As DSTableAdapters.PHIEUGUITableAdapter
    Friend WithEvents PHIEURUTbds As BindingSource
    Friend WithEvents PHIEURUTTableAdapter As DSTableAdapters.PHIEURUTTableAdapter
    Friend WithEvents btnxoagdv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnphuchoigdv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnhieuchinhgdv As DevExpress.XtraBars.BarButtonItem
End Class
