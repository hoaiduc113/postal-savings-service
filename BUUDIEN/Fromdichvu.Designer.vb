<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fromdichvu
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
        Dim MADVLabel As System.Windows.Forms.Label
        Dim KYHANLabel As System.Windows.Forms.Label
        Dim TENDVLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fromdichvu))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnthemdv = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxoadv = New DevExpress.XtraBars.BarButtonItem()
        Me.btnhieuchinh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnphuchoidv = New DevExpress.XtraBars.BarButtonItem()
        Me.btnthoatdv = New DevExpress.XtraBars.BarButtonItem()
        Me.btnghidv = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnsuadv = New DevExpress.XtraBars.BarButtonItem()
        Me.DS = New BUUDIEN.DS()
        Me.DICHVUbds = New System.Windows.Forms.BindingSource(Me.components)
        Me.DICHVUAdapter = New BUUDIEN.DSTableAdapters.DICHVUTableAdapter()
        Me.TableAdapterManager = New BUUDIEN.DSTableAdapters.TableAdapterManager()
        Me.griviewdichvu = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMADV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKYHAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTENDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gropboxdichvu = New System.Windows.Forms.GroupBox()
        Me.txttendv = New DevExpress.XtraEditors.TextEdit()
        Me.txtkyhandv = New DevExpress.XtraEditors.SpinEdit()
        Me.txtmadichvu = New DevExpress.XtraEditors.TextEdit()
        Me.phieuguibds = New System.Windows.Forms.BindingSource(Me.components)
        Me.PHIEUGUITableAdapter = New BUUDIEN.DSTableAdapters.PHIEUGUITableAdapter()
        Me.laisuatbds = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAISUATTableAdapter = New BUUDIEN.DSTableAdapters.LAISUATTableAdapter()
        MADVLabel = New System.Windows.Forms.Label()
        KYHANLabel = New System.Windows.Forms.Label()
        TENDVLabel = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DICHVUbds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griviewdichvu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gropboxdichvu.SuspendLayout()
        CType(Me.txttendv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkyhandv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmadichvu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phieuguibds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laisuatbds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MADVLabel
        '
        MADVLabel.AutoSize = True
        MADVLabel.Location = New System.Drawing.Point(32, 35)
        MADVLabel.Name = "MADVLabel"
        MADVLabel.Size = New System.Drawing.Size(59, 13)
        MADVLabel.TabIndex = 0
        MADVLabel.Text = "mã dịch vụ"
        '
        'KYHANLabel
        '
        KYHANLabel.AutoSize = True
        KYHANLabel.Location = New System.Drawing.Point(349, 39)
        KYHANLabel.Name = "KYHANLabel"
        KYHANLabel.Size = New System.Drawing.Size(39, 13)
        KYHANLabel.TabIndex = 2
        KYHANLabel.Text = "kỳ hạn"
        '
        'TENDVLabel
        '
        TENDVLabel.AutoSize = True
        TENDVLabel.Location = New System.Drawing.Point(32, 81)
        TENDVLabel.Name = "TENDVLabel"
        TENDVLabel.Size = New System.Drawing.Size(60, 13)
        TENDVLabel.TabIndex = 4
        TENDVLabel.Text = "tên dịch vụ"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnthemdv, Me.btnsuadv, Me.btnxoadv, Me.btnhieuchinh, Me.btnphuchoidv, Me.btnthoatdv, Me.btnghidv})
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
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthemdv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxoadv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnhieuchinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnphuchoidv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthoatdv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnghidv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btnthemdv
        '
        Me.btnthemdv.Caption = "thêm"
        Me.btnthemdv.Id = 0
        Me.btnthemdv.ImageOptions.Image = CType(resources.GetObject("btnthemdv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnthemdv.Name = "btnthemdv"
        '
        'btnxoadv
        '
        Me.btnxoadv.Caption = "xóa"
        Me.btnxoadv.Id = 2
        Me.btnxoadv.ImageOptions.Image = CType(resources.GetObject("btnxoadv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnxoadv.Name = "btnxoadv"
        '
        'btnhieuchinh
        '
        Me.btnhieuchinh.Caption = "hiệu chỉnh"
        Me.btnhieuchinh.Id = 3
        Me.btnhieuchinh.ImageOptions.Image = CType(resources.GetObject("btnhieuchinh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnhieuchinh.Name = "btnhieuchinh"
        '
        'btnphuchoidv
        '
        Me.btnphuchoidv.Caption = "phục hồi"
        Me.btnphuchoidv.Id = 4
        Me.btnphuchoidv.ImageOptions.Image = CType(resources.GetObject("btnphuchoidv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnphuchoidv.Name = "btnphuchoidv"
        '
        'btnthoatdv
        '
        Me.btnthoatdv.Caption = "thoát"
        Me.btnthoatdv.Id = 5
        Me.btnthoatdv.ImageOptions.Image = CType(resources.GetObject("btnthoatdv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnthoatdv.Name = "btnthoatdv"
        '
        'btnghidv
        '
        Me.btnghidv.Caption = "ghi"
        Me.btnghidv.Id = 6
        Me.btnghidv.ImageOptions.Image = CType(resources.GetObject("btnghidv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnghidv.Name = "btnghidv"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(990, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 469)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(990, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 429)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(990, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 429)
        '
        'btnsuadv
        '
        Me.btnsuadv.Caption = "sửa"
        Me.btnsuadv.Id = 1
        Me.btnsuadv.ImageOptions.Image = CType(resources.GetObject("btnsuadv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsuadv.Name = "btnsuadv"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DICHVUbds
        '
        Me.DICHVUbds.DataMember = "DICHVU"
        Me.DICHVUbds.DataSource = Me.DS
        '
        'DICHVUAdapter
        '
        Me.DICHVUAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DICHVUTableAdapter = Me.DICHVUAdapter
        Me.TableAdapterManager.GDVTableAdapter = Nothing
        Me.TableAdapterManager.KHACHHANGTableAdapter = Nothing
        Me.TableAdapterManager.LAISUATTableAdapter = Nothing
        Me.TableAdapterManager.PHIEUGUITableAdapter = Nothing
        Me.TableAdapterManager.PHIEURUTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BUUDIEN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'griviewdichvu
        '
        Me.griviewdichvu.DataSource = Me.DICHVUbds
        Me.griviewdichvu.Dock = System.Windows.Forms.DockStyle.Top
        Me.griviewdichvu.Location = New System.Drawing.Point(0, 40)
        Me.griviewdichvu.MainView = Me.GridView1
        Me.griviewdichvu.MenuManager = Me.BarManager1
        Me.griviewdichvu.Name = "griviewdichvu"
        Me.griviewdichvu.Size = New System.Drawing.Size(990, 220)
        Me.griviewdichvu.TabIndex = 5
        Me.griviewdichvu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMADV, Me.colKYHAN, Me.colTENDV})
        Me.GridView1.GridControl = Me.griviewdichvu
        Me.GridView1.Name = "GridView1"
        '
        'colMADV
        '
        Me.colMADV.Caption = "mã dịch vụ"
        Me.colMADV.FieldName = "MADV"
        Me.colMADV.Name = "colMADV"
        Me.colMADV.Visible = True
        Me.colMADV.VisibleIndex = 0
        '
        'colKYHAN
        '
        Me.colKYHAN.Caption = "kỳ hạn"
        Me.colKYHAN.FieldName = "KYHAN"
        Me.colKYHAN.Name = "colKYHAN"
        Me.colKYHAN.Visible = True
        Me.colKYHAN.VisibleIndex = 1
        '
        'colTENDV
        '
        Me.colTENDV.Caption = "tên dịch vụ"
        Me.colTENDV.FieldName = "TENDV"
        Me.colTENDV.Name = "colTENDV"
        Me.colTENDV.Visible = True
        Me.colTENDV.VisibleIndex = 2
        '
        'gropboxdichvu
        '
        Me.gropboxdichvu.Controls.Add(TENDVLabel)
        Me.gropboxdichvu.Controls.Add(Me.txttendv)
        Me.gropboxdichvu.Controls.Add(KYHANLabel)
        Me.gropboxdichvu.Controls.Add(Me.txtkyhandv)
        Me.gropboxdichvu.Controls.Add(MADVLabel)
        Me.gropboxdichvu.Controls.Add(Me.txtmadichvu)
        Me.gropboxdichvu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gropboxdichvu.Location = New System.Drawing.Point(0, 260)
        Me.gropboxdichvu.Name = "gropboxdichvu"
        Me.gropboxdichvu.Size = New System.Drawing.Size(990, 209)
        Me.gropboxdichvu.TabIndex = 8
        Me.gropboxdichvu.TabStop = False
        Me.gropboxdichvu.Text = "GroupBox3"
        '
        'txttendv
        '
        Me.txttendv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DICHVUbds, "TENDV", True))
        Me.txttendv.Location = New System.Drawing.Point(112, 78)
        Me.txttendv.MenuManager = Me.BarManager1
        Me.txttendv.Name = "txttendv"
        Me.txttendv.Size = New System.Drawing.Size(156, 20)
        Me.txttendv.TabIndex = 5
        '
        'txtkyhandv
        '
        Me.txtkyhandv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DICHVUbds, "KYHAN", True))
        Me.txtkyhandv.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtkyhandv.Location = New System.Drawing.Point(432, 36)
        Me.txtkyhandv.MenuManager = Me.BarManager1
        Me.txtkyhandv.Name = "txtkyhandv"
        Me.txtkyhandv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtkyhandv.Size = New System.Drawing.Size(211, 20)
        Me.txtkyhandv.TabIndex = 3
        '
        'txtmadichvu
        '
        Me.txtmadichvu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DICHVUbds, "MADV", True))
        Me.txtmadichvu.Location = New System.Drawing.Point(112, 32)
        Me.txtmadichvu.MenuManager = Me.BarManager1
        Me.txtmadichvu.Name = "txtmadichvu"
        Me.txtmadichvu.Size = New System.Drawing.Size(156, 20)
        Me.txtmadichvu.TabIndex = 1
        '
        'phieuguibds
        '
        Me.phieuguibds.DataMember = "FK_PHIEUGUI_DICHVU"
        Me.phieuguibds.DataSource = Me.DICHVUbds
        '
        'PHIEUGUITableAdapter
        '
        Me.PHIEUGUITableAdapter.ClearBeforeFill = True
        '
        'laisuatbds
        '
        Me.laisuatbds.DataMember = "FK_LAISUAT_DICHVU"
        Me.laisuatbds.DataSource = Me.DICHVUbds
        '
        'LAISUATTableAdapter
        '
        Me.LAISUATTableAdapter.ClearBeforeFill = True
        '
        'Fromdichvu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 492)
        Me.Controls.Add(Me.gropboxdichvu)
        Me.Controls.Add(Me.griviewdichvu)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Fromdichvu"
        Me.Text = "Fromdichvu"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DICHVUbds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griviewdichvu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gropboxdichvu.ResumeLayout(False)
        Me.gropboxdichvu.PerformLayout()
        CType(Me.txttendv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkyhandv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmadichvu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phieuguibds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laisuatbds, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnthemdv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnsuadv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxoadv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnhieuchinh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnphuchoidv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnthoatdv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DICHVUbds As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents DICHVUAdapter As DSTableAdapters.DICHVUTableAdapter
    Friend WithEvents TableAdapterManager As DSTableAdapters.TableAdapterManager
    Friend WithEvents griviewdichvu As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gropboxdichvu As GroupBox
    Friend WithEvents colMADV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKYHAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTENDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtmadichvu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttendv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtkyhandv As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnghidv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents phieuguibds As BindingSource
    Friend WithEvents PHIEUGUITableAdapter As DSTableAdapters.PHIEUGUITableAdapter
    Friend WithEvents laisuatbds As BindingSource
    Friend WithEvents LAISUATTableAdapter As DSTableAdapters.LAISUATTableAdapter
End Class
