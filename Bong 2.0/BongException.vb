﻿Public Class BongException
    Inherits Exception

    Public Sub New(ByVal mensaje As String)
        MyBase.New(mensaje)
    End Sub
End Class
