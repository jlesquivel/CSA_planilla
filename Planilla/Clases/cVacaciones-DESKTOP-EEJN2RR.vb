﻿

Public Class cVacaciones

    Dim oConfig As cConfiguracion
    Dim repLegal As String
    Dim repCargo As String
    Dim adm As String
    Dim admCargo As String

    Public Sub New()
        oConfig = New cConfiguracion
        repLegal = oConfig.ValorConfiguracion("RepLegal", "Nombre")
        repCargo = oConfig.ValorConfiguracion("RepLegal", "Cargo")
        adm = oConfig.valores(15)
        admCargo = oConfig.valores(16)
    End Sub

    Sub carta(_id_emp As Int16, dgv_row As Object, directorio As String, adicionales As Boolean)

        Dim archivo = My.Application.Info.DirectoryPath & "\contVacaciones.docx"
        Dim emp1 As New cEmpleado(_id_emp)
        Dim fila = dgv_row
        Dim nombreEmp As String = emp1.datos.nombre & " " & emp1.datos.apellidos

        Dim valores As New ArrayList     '' Valores que se envian al documento Word   
        valores.Add({"suscrita", repLegal})
        valores.Add({"suscritaCargo", repCargo})
        valores.Add({"empleado", nombreEmp})

        Dim pfechaCarta As Date = IIf(IsDBNull(fila.fecha_carta), fila.fechaI, fila.fecha_carta)
        valores.Add({"fechaCarta", pfechaCarta.ToLongDateString})
        valores.Add({"fechaCarta2", pFechaCarta.ToString("dd 'de' MMMM 'del' yyyy")})
        valores.Add({"estimada", nombreEmp})

        valores.Add({"fechaIv", fila.fechaI.ToLongDateString})
        valores.Add({"fechaFv", fila.FechaF.ToLongDateString & " inclusive"})

        If Not IsDBNull(fila.itemarray(7)) Then
            valores.Add({"fechaIva", "Adicionales: " & fila.fechaI_adicionales.ToLongDateString})
            valores.Add({"fechaFva", "al " & fila.fechaF_adicionales.ToLongDateString & " inclusive"})
        End If

        valores.Add({"repLegal", repLegal})
        valores.Add({"repCargo", repCargo})

        valores.Add({"Adm", adm})
        valores.Add({"AdmCargo", admCargo})

        valores.Add({"nota", fila.nota})

        Dim wdDoc As New cWord(archivo)  'abre plantilla
        wdDoc.SustituyeValores(valores)
        If Not adicionales Then             '' borra vacaciones adicionales
            wdDoc.borraLinea_con("Adicionales:")
        End If

        Dim guardaComo = "vac_" & nombreEmp
        If directorio = "" Then
            wdDoc.guarda(guardaComo)
        Else
            wdDoc.guarda(guardaComo, directorio)
        End If
    End Sub
End Class