Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class FriendList
            ''' <summary>
            ''' Name: id
            ''' Description: The friend list ID
            ''' Permissions: read_friendlists
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: name
            ''' Description: The name of the friend list
            ''' Permissions: read_friendlists
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: list_type
            ''' Description: The type of the friends list; Possible values are: close_friends, acquaintances, restricted,user_created, education, work, current_city or family
            ''' Permissions: read_friendlists
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="list_type")>
            Public Property ListType() As String
        End Class
    End Class
End Namespace