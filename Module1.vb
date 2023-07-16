Module Module1
    Public con As New ADODB.Connection
    Public Sub opendb()
        If con.State = 1 Then con.Close()
        'con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\Database5.accdb;Persist Security Info=False")
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database5.accdb;Persist Security Info=False")
    End Sub
End Module
