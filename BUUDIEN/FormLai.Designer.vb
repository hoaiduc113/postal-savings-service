<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLai
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
        Dim MADVLabel As System.Windows.Forms.Label
        Dim NGAYADLabel As System.Windows.Forms.Label
        Dim LAISUATLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLai))
        Me.btnthoat = New DevExpress.XtraBars.BarManager()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnthemlaisuat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnhieuchinhlaisuat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxoalaixuat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnghilaisuat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnthoatlaisuat = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DS = New BUUDIEN.DS()
        Me.laisuatbds = New System.Windows.Forms.BindingSource()
        Me.LAISUATTableAdapter = New BUUDIEN.DSTableAdapters.LAISUATTableAdapter()
        Me.TableAdapterManager = New BUUDIEN.DSTableAdapters.TableAdapterManager()
        Me.grouboxlaixuat = New System.Windows.Forms.GroupBox()
        Me.txtmagvlaisuat = New System.Windows.Forms.ComboBox()
        Me.HienthimadvBindingSource = New System.Windows.Forms.BindingSource()
        Me.txtlaisuat = New DevExpress.XtraEditors.SpinEdit()
        Me.txtngayad = New DevExpress.XtraEditors.DateEdit()
        Me.HienthimadvTableAdapter = New BUUDIEN.DSTableAdapters.hienthimadvTableAdapter()
        Me.dichvibds = New System.Windows.Forms.BindingSource()
        Me.DICHVUTableAdapter = New BUUDIEN.DSTableAdapters.DICHVUTableAdapter()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMADV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNGAYAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLAISUAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridviewlaixuat = New DevExpress.XtraGrid.GridControl()
        Me.btnphuchoilaisuat = New DevExpress.XtraBars.BarButtonItem()
        MADVLabel = New System.Windows.Forms.Label()
        NGAYADLabel = New System.Windows.Forms.Label()
        LAISUATLabel = New System.Windows.Forms.Label()
        CType(Me.btnthoat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laisuatbds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouboxlaixuat.SuspendLayout()
        CType(Me.HienthimadvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlaisuat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtngayad.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtngayad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dichvibds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewlaixuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MADVLabel
        '
        MADVLabel.AutoSize = True
        MADVLabel.Location = New System.Drawing.Point(12, 42)
        MADVLabel.Name = "MADVLabel"
        MADVLabel.Size = New System.Drawing.Size(90, 13)
        MADVLabel.TabIndex = 0
        MADVLabel.Text = "mã giao dịch viên"
        '
        'NGAYADLabel
        '
        NGAYADLabel.AutoSize = True
        NGAYADLabel.Location = New System.Drawing.Point(417, 47)
        NGAYADLabel.Name = "NGAYADLabel"
        NGAYADLabel.Size = New System.Drawing.Size(72, 13)
        NGAYADLabel.TabIndex = 2
        NGAYADLabel.Text = "ngày áp dụng"
        '
        'LAISUATLabel
        '
        LAISUATLabel.AutoSize = True
        LAISUATLabel.Location = New System.Drawing.Point(12, 91)
        LAISUATLabel.Name = "LAISUATLabel"
        LAISUATLabel.Size = New System.Drawing.Size(40, 13)
        LAISUATLabel.TabIndex = 4
        LAISUATLabel.Text = "lãi xuất"
        '
        'btnthoat
        '
        Me.btnthoat.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.btnthoat.DockControls.Add(Me.barDockControlTop)
        Me.btnthoat.DockControls.Add(Me.barDockControlBottom)
        Me.btnthoat.DockControls.Add(Me.barDockControlLeft)
        Me.btnthoat.DockControls.Add(Me.barDockControlRight)
        Me.btnthoat.Form = Me
        Me.btnthoat.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnthemlaisuat, Me.btnhieuchinhlaisuat, Me.btnxoalaixuat, Me.btnghilaisuat, Me.btnthoatlaisuat, Me.btnphuchoilaisuat})
        Me.btnthoat.MainMenu = Me.Bar2
        Me.btnthoat.MaxItemId = 6
        Me.btnthoat.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthemlaisuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnhieuchinhlaisuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxoalaixuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnghilaisuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthoatlaisuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnphuchoilaisuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btnthemlaisuat
        '
        Me.btnthemlaisuat.Caption = "thêm"
        Me.btnthemlaisuat.Id = 0
        Me.btnthemlaisuat.ImageOptions.Image = CType(resources.GetObject("btnthemlaisuat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnthemlaisuat.Name = "btnthemlaisuat"
        '
        'btnhieuchinhlaisuat
        '
        Me.btnhieuchinhlaisuat.Caption = "hiệu chỉnh"
        Me.btnhieuchinhlaisuat.Id = 1
        Me.btnhieuchinhlaisuat.ImageOptions.Image = CType(resources.GetObject("btnhieuchinhlaisuat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnhieuchinhlaisuat.Name = "btnhieuchinhlaisuat"
        '
        'btnxoalaixuat
        '
        Me.btnxoalaixuat.Caption = "xóa"
        Me.btnxoalaixuat.Id = 2
        Me.btnxoalaixuat.ImageOptions.Image = CType(resources.GetObject("btnxoalaixuat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnxoalaixuat.Name = "btnxoalaixuat"
        '
        'btnghilaisuat
        '
        Me.btnghilaisuat.Caption = "ghi"
        Me.btnghilaisuat.Id = 3
        Me.btnghilaisuat.ImageOptions.Image = CType(resources.GetObject("btnghilaisuat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnghilaisuat.Name = "btnghilaisuat"
        '
        'btnthoatlaisuat
        '
        Me.btnthoatlaisuat.Caption = "thoát"
        Me.btnthoatlaisuat.Id = 4
        Me.btnthoatlaisuat.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.btnthoatlaisuat.Name = "btnthoatlaisuat"
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
        Me.barDockControlTop.Manager = Me.btnthoat
        Me.barDockControlTop.Size = New System.Drawing.Size(752, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 400)
        Me.barDockControlBottom.Manager = Me.btnthoat
        Me.barDockControlBottom.Size = New System.Drawing.Size(752, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.btnthoat
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 360)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(752, 40)
        Me.barDockControlRight.Manager = Me.btnthoat
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 360)
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'laisuatbds
        '
        Me.laisuatbds.DataMember = "LAISUAT"
        Me.laisuatbds.DataSource = Me.DS
        '
        'LAISUATTableAdapter
        '
        Me.LAISUATTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DICHVUTableAdapter = Nothing
        Me.TableAdapterManager.GDVTableAdapter = Nothing
        Me.TableAdapterManager.KHACHHANGTableAdapter = Nothing
        Me.TableAdapterManager.LAISUATTableAdapter = Me.LAISUATTableAdapter
        Me.TableAdapterManager.PHIEUGUITableAdapter = Nothing
        Me.TableAdapterManager.PHIEURUTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BUUDIEN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'grouboxlaixuat
        '
        Me.grouboxlaixuat.Controls.Add(Me.txtmagvlaisuat)
        Me.grouboxlaixuat.Controls.Add(LAISUATLabel)
        Me.grouboxlaixuat.Controls.Add(Me.txtlaisuat)
        Me.grouboxlaixuat.Controls.Add(NGAYADLabel)
        Me.grouboxlaixuat.Controls.Add(Me.txtngayad)
        Me.grouboxlaixuat.Controls.Add(MADVLabel)
        Me.grouboxlaixuat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grouboxlaixuat.Location = New System.Drawing.Point(0, 260)
        Me.grouboxlaixuat.Name = "grouboxlaixuat"
        Me.grouboxlaixuat.Size = New System.Drawing.Size(752, 140)
        Me.grouboxlaixuat.TabIndex = 6
        Me.grouboxlaixuat.TabStop = False
        Me.grouboxlaixuat.Text = "GroupBox1"
        '
        'txtmagvlaisuat
        '
        Me.txtmagvlaisuat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.laisuatbds, "MADV", True))
        Me.txtmagvlaisuat.DataSource = Me.HienthimadvBindingSource
        Me.txtmagvlaisuat.DisplayMember = "MADV"
        Me.txtmagvlaisuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtmagvlaisuat.FormattingEnabled = True
        Me.txtmagvlaisuat.Location = New System.Drawing.Point(139, 39)
        Me.txtmagvlaisuat.Name = "txtmagvlaisuat"
        Me.txtmagvlaisuat.Size = New System.Drawing.Size(176, 21)
        Me.txtmagvlaisuat.TabIndex = 6
        Me.txtmagvlaisuat.ValueMember = "MADV"
        '
        'HienthimadvBindingSource
        '
        Me.HienthimadvBindingSource.DataMember = "hienthimadv"
        Me.HienthimadvBindingSource.DataSource = Me.DS
        '
        'txtlaisuat
        '
        Me.txtlaisuat.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.laisuatbds, "LAISUAT", True))
        Me.txtlaisuat.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlaisuat.Location = New System.Drawing.Point(139, 84)
        Me.txtlaisuat.MenuManager = Me.btnthoat
        Me.txtlaisuat.Name = "txtlaisuat"
        Me.txtlaisuat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtlaisuat.Size = New System.Drawing.Size(176, 20)
        Me.txtlaisuat.TabIndex = 5
        '
        'txtngayad
        '
        Me.txtngayad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.laisuatbds, "NGAYAD", True))
        Me.txtngayad.EditValue = Nothing
        Me.txtngayad.Location = New System.Drawing.Point(509, 44)
        Me.txtngayad.MenuManager = Me.btnthoat
        Me.txtngayad.Name = "txtngayad"
        Me.txtngayad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtngayad.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtngayad.Size = New System.Drawing.Size(155, 20)
        Me.txtngayad.TabIndex = 3
        '
        'HienthimadvTableAdapter
        '
        Me.HienthimadvTableAdapter.ClearBeforeFill = True
        '
        'dichvibds
        '
        Me.dichvibds.DataMember = "DICHVU"
        Me.dichvibds.DataSource = Me.DS
        '
        'DICHVUTableAdapter
        '
        Me.DICHVUTableAdapter.ClearBeforeFill = True
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMADV, Me.colNGAYAD, Me.colLAISUAT})
        Me.GridView1.GridControl = Me.gridviewlaixuat
        Me.GridView1.Name = "GridView1"
        '
        'colMADV
        '
        Me.colMADV.Caption = "mã giao dịch viên"
        Me.colMADV.FieldName = "MADV"
        Me.colMADV.Name = "colMADV"
        Me.colMADV.Visible = True
        Me.colMADV.VisibleIndex = 0
        '
        'colNGAYAD
        '
        Me.colNGAYAD.Caption = "ngày áp dụng"
        Me.colNGAYAD.FieldName = "NGAYAD"
        Me.colNGAYAD.Name = "colNGAYAD"
        Me.colNGAYAD.Visible = True
        Me.colNGAYAD.VisibleIndex = 1
        '
        'colLAISUAT
        '
        Me.colLAISUAT.Caption = "lãi xuất"
        Me.colLAISUAT.FieldName = "LAISUAT"
        Me.colLAISUAT.Name = "colLAISUAT"
        Me.colLAISUAT.Visible = True
        Me.colLAISUAT.VisibleIndex = 2
        '
        'gridviewlaixuat
        '
        Me.gridviewlaixuat.DataSource = Me.laisuatbds
        Me.gridviewlaixuat.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridviewlaixuat.Location = New System.Drawing.Point(0, 40)
        Me.gridviewlaixuat.MainView = Me.GridView1
        Me.gridviewlaixuat.MenuManager = Me.btnthoat
        Me.gridviewlaixuat.Name = "gridviewlaixuat"
        Me.gridviewlaixuat.Size = New System.Drawing.Size(752, 220)
        Me.gridviewlaixuat.TabIndex = 5
        Me.gridviewlaixuat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'btnphuchoilaisuat
        '
        Me.btnphuchoilaisuat.Caption = "phục hồi"
        Me.btnphuchoilaisuat.Id = 5
        Me.btnphuchoilaisuat.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.btnphuchoilaisuat.Name = "btnphuchoilaisuat"
        '
        'FormLai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 423)
        Me.Controls.Add(Me.grouboxlaixuat)
        Me.Controls.Add(Me.gridviewlaixuat)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FormLai"
        Me.Text = "FormLai"
        CType(Me.btnthoat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laisuatbds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grouboxlaixuat.ResumeLayout(False)
        Me.grouboxlaixuat.PerformLayout()
        CType(Me.HienthimadvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlaisuat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtngayad.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtngayad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dichvibds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewlaixuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnthoat As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btnthemlaisuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnhieuchinhlaisuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxoalaixuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnghilaisuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnthoatlaisuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents laisuatbds As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents LAISUATTableAdapter As DSTableAdapters.LAISUATTableAdapter
    Friend WithEvents TableAdapterManager As DSTableAdapters.TableAdapterManager
    Friend WithEvents grouboxlaixuat As GroupBox
    Friend WithEvents HienthimadvBindingSource As BindingSource
    Friend WithEvents HienthimadvTableAdapter As DSTableAdapters.hienthimadvTableAdapter
    Friend WithEvents txtlaisuat As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtngayad As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dichvibds As BindingSource
    Friend WithEvents DICHVUTableAdapter As DSTableAdapters.DICHVUTableAdapter
    Friend WithEvents gridviewlaixuat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMADV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNGAYAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLAISUAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtmagvlaisuat As ComboBox
    Friend WithEvents btnphuchoilaisuat As DevExpress.XtraBars.BarButtonItem
End Class
