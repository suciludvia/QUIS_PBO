Public Class User
    Dim strsql As String
    Dim info As String
    Private _username As String
    Private _passwd As String

    Public Property username()
        Get
            Return _username
        End Get
        Set(ByVal value)
            _username = value
        End Set
    End Property

    Public Property passwd()
        Get
            Return _passwd
        End Get
        Set(ByVal value)
            _passwd = value
        End Set
    End Property

    Public Function Login(ByVal uname As String, ByVal pwd As String) As Boolean
        Dim pwd_en As String
        pwd_en = pwd
        DBConnect()
        strsql = "SELECT * FROM tb_login WHERE ussername='" & uname & "' and password ='" & pwd_en & "'"

        mycommand.Connection = conn
        mycommand.CommandText = strsql
        DR = mycommand.ExecuteReader
        If (DR.HasRows = True) Then
            login_valid = True
        Else
            login_valid = False
        End If
        DBDisconnect()
        Return login_valid
    End Function
End Class
