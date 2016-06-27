﻿Public Class cuEmpleado

    Private id_emp As Integer
    Dim oEmp As cEmpleado
    Dim datosContrato As ds2planilla.ContratosActivosRow

    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

    End Sub
    Sub New(pid_emp As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id_emp = pid_emp
        Muestra(pid_emp)
    End Sub


    Sub Muestra(pid_emp As Integer)
        If pid_emp > 0 Then

            id_emp = pid_emp
            oEmp = New cEmpleado(pid_emp)

            If oEmp.datos IsNot Nothing Then
                tCedula.Text = oEmp.datos.cedula
                tNombre.Text = oEmp.datos.nombre
                tApellidos.Text = oEmp.datos.apellidos
            End If

            Dim oDS2 As New ds2planilla
            Dim dt As New ds2planillaTableAdapters.ContratosActivosTableAdapter
            Dim regs As Integer
            regs = dt.Fill_Id_emp(oDS2.ContratosActivos, pid_emp)

            If regs > 0 Then
                datosContrato = oDS2.ContratosActivos.Rows.Item(0)

                tContrato.Text = datosContrato.id_contrato
                tCategoria.Text = datosContrato.Nombre_categoria
            End If

            oDS2 = Nothing
            dt = Nothing
        End If

    End Sub



End Class
