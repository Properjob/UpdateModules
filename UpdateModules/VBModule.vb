Public Class VBModule

    Private pChecked As String
    Private pName As String
    Private pDesc As String
    Private pLoc As String

    Property Checked() As String
        Get
            Checked = pChecked
        End Get

        Set(value As String)
            pChecked = value
        End Set
    End Property

    Property Name() As String
        Get
            Name = pName
        End Get
        Set(value As String)
            pName = value
        End Set
    End Property

    Property Desc() As String
        Get
            Desc = pDesc
        End Get
        Set(value As String)
            pDesc = value
        End Set
    End Property

    Property Loc() As String
        Get
            Loc = pLoc
        End Get
        Set(value As String)
            pLoc = value
        End Set
    End Property

    Public Function Create(Name As String, Desc As String, Loc As String) As VBModule
        pChecked = "N"
        pName = Name
        pDesc = Desc
        pLoc = Loc
        Create = Me
    End Function




End Class
