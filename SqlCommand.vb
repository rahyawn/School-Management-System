Friend Class SqlCommand
    Private v As String
    Private conn As SqlConnection

    Public Sub New(v As String, conn As SqlConnection)
        Me.v = v
        Me.conn = conn
    End Sub
End Class
