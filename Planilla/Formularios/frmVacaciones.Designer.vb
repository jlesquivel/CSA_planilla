﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVacaciones
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdvacacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaI = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.fechaF = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.MotivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaDataGridViewTextBoxColumn = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.fechaI_adicionales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaF_adicionales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VacacionregBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVacaciones = New Planilla.dsVacaciones()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.DiasRangoAdic = New DevComponents.Editors.IntegerInput()
        Me.fechaI_Adic = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.fechaF_Adic = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.DiasRango = New DevComponents.Editors.IntegerInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.DiasSaldo = New DevComponents.Editors.IntegerInput()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.motivo = New DevComponents.DotNetBar.Controls.TextBoxDropDown()
        Me.nota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.fechaF_ord = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.fechaI_ord = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Vacacion_regTableAdapter = New Planilla.dsVacacionesTableAdapters.Vacacion_regTableAdapter()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionregBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.DiasRangoAdic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaI_Adic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaF_Adic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasRango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaF_ord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaI_ord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdvacacionDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.fechaI, Me.fechaF, Me.MotivoDataGridViewTextBoxColumn, Me.NotaDataGridViewTextBoxColumn, Me.fechaI_adicionales, Me.fechaF_adicionales})
        Me.DataGridViewX1.DataSource = Me.VacacionregBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(894, 190)
        Me.DataGridViewX1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'IdvacacionDataGridViewTextBoxColumn
        '
        Me.IdvacacionDataGridViewTextBoxColumn.DataPropertyName = "id_vacacion"
        Me.IdvacacionDataGridViewTextBoxColumn.HeaderText = "id_vacacion"
        Me.IdvacacionDataGridViewTextBoxColumn.Name = "IdvacacionDataGridViewTextBoxColumn"
        Me.IdvacacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdvacacionDataGridViewTextBoxColumn.Visible = False
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "dias"
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiasDataGridViewTextBoxColumn.Width = 50
        '
        'fechaI
        '
        '
        '
        '
        Me.fechaI.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fechaI.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI.BackgroundStyle.TextColor = System.Drawing.Color.Black
        Me.fechaI.ButtonCustom.Visible = True
        Me.fechaI.ButtonDropDown.Visible = True
        Me.fechaI.DataPropertyName = "fechaI"
        Me.fechaI.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.fechaI.HeaderText = "Fecha Inicio"
        Me.fechaI.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        '
        '
        '
        Me.fechaI.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fechaI.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.fechaI.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI.Name = "fechaI"
        Me.fechaI.ReadOnly = True
        Me.fechaI.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaI.Width = 200
        '
        'fechaF
        '
        '
        '
        '
        Me.fechaF.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fechaF.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fechaF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF.BackgroundStyle.TextColor = System.Drawing.Color.Black
        Me.fechaF.ButtonDropDown.Visible = True
        Me.fechaF.DataPropertyName = "fechaF"
        Me.fechaF.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.fechaF.HeaderText = "Fecha Fin"
        Me.fechaF.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        '
        '
        '
        Me.fechaF.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fechaF.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.fechaF.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF.Name = "fechaF"
        Me.fechaF.ReadOnly = True
        Me.fechaF.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaF.Width = 200
        '
        'MotivoDataGridViewTextBoxColumn
        '
        Me.MotivoDataGridViewTextBoxColumn.DataPropertyName = "motivo"
        Me.MotivoDataGridViewTextBoxColumn.HeaderText = "motivo"
        Me.MotivoDataGridViewTextBoxColumn.Name = "MotivoDataGridViewTextBoxColumn"
        Me.MotivoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.NotaDataGridViewTextBoxColumn.BackgroundStyle.Class = "DataGridViewBorder"
        Me.NotaDataGridViewTextBoxColumn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NotaDataGridViewTextBoxColumn.Culture = New System.Globalization.CultureInfo("es-MX")
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "nota"
        Me.NotaDataGridViewTextBoxColumn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NotaDataGridViewTextBoxColumn.HeaderText = "nota"
        Me.NotaDataGridViewTextBoxColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NotaDataGridViewTextBoxColumn.Mask = ""
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        Me.NotaDataGridViewTextBoxColumn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NotaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotaDataGridViewTextBoxColumn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NotaDataGridViewTextBoxColumn.Text = ""
        '
        'fechaI_adicionales
        '
        Me.fechaI_adicionales.DataPropertyName = "fechaI_adicionales"
        Me.fechaI_adicionales.HeaderText = "Inicio Vac. adicionales"
        Me.fechaI_adicionales.Name = "fechaI_adicionales"
        Me.fechaI_adicionales.ReadOnly = True
        '
        'fechaF_adicionales
        '
        Me.fechaF_adicionales.DataPropertyName = "fechaF_adicionales"
        Me.fechaF_adicionales.HeaderText = "Fin Vac. adicionales"
        Me.fechaF_adicionales.Name = "fechaF_adicionales"
        Me.fechaF_adicionales.ReadOnly = True
        '
        'VacacionregBindingSource
        '
        Me.VacacionregBindingSource.DataMember = "Vacacion_reg"
        Me.VacacionregBindingSource.DataSource = Me.DsVacaciones
        '
        'DsVacaciones
        '
        Me.DsVacaciones.DataSetName = "dsVacaciones"
        Me.DsVacaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX9)
        Me.PanelEx1.Controls.Add(Me.LabelX8)
        Me.PanelEx1.Controls.Add(Me.DiasRangoAdic)
        Me.PanelEx1.Controls.Add(Me.fechaI_Adic)
        Me.PanelEx1.Controls.Add(Me.fechaF_Adic)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.DiasRango)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.DiasSaldo)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.motivo)
        Me.PanelEx1.Controls.Add(Me.nota)
        Me.PanelEx1.Controls.Add(Me.fechaF_ord)
        Me.PanelEx1.Controls.Add(Me.fechaI_ord)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(12, 208)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(547, 233)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 3
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(32, 66)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(119, 21)
        Me.LabelX9.TabIndex = 17
        Me.LabelX9.Text = "Vacaciones Ordinarias"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(32, 93)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(119, 21)
        Me.LabelX8.TabIndex = 16
        Me.LabelX8.Text = "Vacaciones Adicionales"
        '
        'DiasRangoAdic
        '
        '
        '
        '
        Me.DiasRangoAdic.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DiasRangoAdic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasRangoAdic.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DiasRangoAdic.Location = New System.Drawing.Point(405, 93)
        Me.DiasRangoAdic.Name = "DiasRangoAdic"
        Me.DiasRangoAdic.Size = New System.Drawing.Size(32, 22)
        Me.DiasRangoAdic.TabIndex = 15
        '
        'fechaI_Adic
        '
        '
        '
        '
        Me.fechaI_Adic.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaI_Adic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_Adic.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaI_Adic.ButtonDropDown.Visible = True
        Me.fechaI_Adic.IsPopupCalendarOpen = False
        Me.fechaI_Adic.Location = New System.Drawing.Point(157, 93)
        '
        '
        '
        '
        '
        '
        Me.fechaI_Adic.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_Adic.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaI_Adic.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_Adic.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.fechaI_Adic.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.fechaI_Adic.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaI_Adic.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaI_Adic.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaI_Adic.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_Adic.MonthCalendar.TodayButtonVisible = True
        Me.fechaI_Adic.Name = "fechaI_Adic"
        Me.fechaI_Adic.Size = New System.Drawing.Size(118, 22)
        Me.fechaI_Adic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaI_Adic.TabIndex = 14
        '
        'fechaF_Adic
        '
        '
        '
        '
        Me.fechaF_Adic.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaF_Adic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_Adic.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaF_Adic.ButtonDropDown.Visible = True
        Me.fechaF_Adic.IsPopupCalendarOpen = False
        Me.fechaF_Adic.Location = New System.Drawing.Point(281, 94)
        '
        '
        '
        '
        '
        '
        Me.fechaF_Adic.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_Adic.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaF_Adic.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_Adic.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.fechaF_Adic.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.fechaF_Adic.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaF_Adic.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaF_Adic.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaF_Adic.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_Adic.MonthCalendar.TodayButtonVisible = True
        Me.fechaF_Adic.Name = "fechaF_Adic"
        Me.fechaF_Adic.Size = New System.Drawing.Size(118, 22)
        Me.fechaF_Adic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaF_Adic.TabIndex = 13
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(377, 45)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(82, 20)
        Me.LabelX6.TabIndex = 12
        Me.LabelX6.Text = "Dias del Rango"
        '
        'DiasRango
        '
        '
        '
        '
        Me.DiasRango.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DiasRango.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasRango.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DiasRango.Location = New System.Drawing.Point(405, 66)
        Me.DiasRango.Name = "DiasRango"
        Me.DiasRango.Size = New System.Drawing.Size(32, 22)
        Me.DiasRango.TabIndex = 11
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(460, 40)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(45, 20)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "Saldo"
        '
        'DiasSaldo
        '
        '
        '
        '
        Me.DiasSaldo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DiasSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasSaldo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DiasSaldo.Location = New System.Drawing.Point(460, 66)
        Me.DiasSaldo.Name = "DiasSaldo"
        Me.DiasSaldo.Size = New System.Drawing.Size(32, 22)
        Me.DiasSaldo.TabIndex = 9
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(466, 140)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(58, 61)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 32.0!
        Me.ButtonX1.TabIndex = 8
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(42, 120)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(80, 14)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Nota"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(281, 48)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(80, 17)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Fecha Fin"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(157, 48)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(80, 17)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Fecha Inicio"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(71, 20)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(80, 14)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Motivo"
        '
        'motivo
        '
        Me.motivo.AutoCompleteCustomSource.AddRange(New String() {"Vacaciones", "Permiso", "Ausencia"})
        Me.motivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.motivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.motivo.BackgroundStyle.Class = "TextBoxBorder"
        Me.motivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.motivo.ButtonDropDown.Visible = True
        Me.motivo.Location = New System.Drawing.Point(157, 20)
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(115, 21)
        Me.motivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.motivo.TabIndex = 3
        Me.motivo.Text = ""
        '
        'nota
        '
        Me.nota.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nota.Border.Class = "TextBoxBorder"
        Me.nota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nota.DisabledBackColor = System.Drawing.Color.White
        Me.nota.ForeColor = System.Drawing.Color.Black
        Me.nota.Location = New System.Drawing.Point(42, 140)
        Me.nota.Multiline = True
        Me.nota.Name = "nota"
        Me.nota.PreventEnterBeep = True
        Me.nota.Size = New System.Drawing.Size(401, 61)
        Me.nota.TabIndex = 2
        '
        'fechaF_ord
        '
        '
        '
        '
        Me.fechaF_ord.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaF_ord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_ord.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaF_ord.ButtonDropDown.Visible = True
        Me.fechaF_ord.IsPopupCalendarOpen = False
        Me.fechaF_ord.Location = New System.Drawing.Point(281, 66)
        '
        '
        '
        '
        '
        '
        Me.fechaF_ord.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_ord.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaF_ord.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_ord.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.fechaF_ord.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.fechaF_ord.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaF_ord.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaF_ord.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaF_ord.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_ord.MonthCalendar.TodayButtonVisible = True
        Me.fechaF_ord.Name = "fechaF_ord"
        Me.fechaF_ord.Size = New System.Drawing.Size(118, 22)
        Me.fechaF_ord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaF_ord.TabIndex = 1
        '
        'fechaI_ord
        '
        '
        '
        '
        Me.fechaI_ord.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaI_ord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_ord.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaI_ord.ButtonDropDown.Visible = True
        Me.fechaI_ord.IsPopupCalendarOpen = False
        Me.fechaI_ord.Location = New System.Drawing.Point(157, 65)
        '
        '
        '
        '
        '
        '
        Me.fechaI_ord.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_ord.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaI_ord.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_ord.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.fechaI_ord.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.fechaI_ord.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaI_ord.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaI_ord.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaI_ord.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_ord.MonthCalendar.TodayButtonVisible = True
        Me.fechaI_ord.Name = "fechaI_ord"
        Me.fechaI_ord.Size = New System.Drawing.Size(118, 22)
        Me.fechaI_ord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaI_ord.TabIndex = 0
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX7.ImageTextSpacing = 0
        Me.LabelX7.Location = New System.Drawing.Point(763, 204)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(143, 138)
        Me.LabelX7.Symbol = ""
        Me.LabelX7.SymbolSize = 32.0!
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "<b>CARTA VACACIÓN:</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seleccione la fila de la vacacion con la flecha de l" &
    "a primer columna"
        '
        'Vacacion_regTableAdapter
        '
        Me.Vacacion_regTableAdapter.ClearBeforeFill = True
        '
        'frmVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 446)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVacaciones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacaciones"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionregBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.DiasRangoAdic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaI_Adic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaF_Adic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasRango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaF_ord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaI_ord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DsVacaciones As dsVacaciones
    Friend WithEvents VacacionregBindingSource As BindingSource
    Friend WithEvents Vacacion_regTableAdapter As dsVacacionesTableAdapters.Vacacion_regTableAdapter
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents motivo As DevComponents.DotNetBar.Controls.TextBoxDropDown
    Friend WithEvents nota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents fechaF_ord As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents fechaI_ord As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DiasSaldo As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DiasRango As DevComponents.Editors.IntegerInput
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdvacacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents fechaI As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents fechaF As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents MotivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotaDataGridViewTextBoxColumn As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DiasRangoAdic As DevComponents.Editors.IntegerInput
    Friend WithEvents fechaI_Adic As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents fechaF_Adic As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fechaI_adicionales As DataGridViewTextBoxColumn
    Friend WithEvents fechaF_adicionales As DataGridViewTextBoxColumn
End Class
