Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Comment
            Inherits GraphApi.MessageObject
            ''' <summary>
            ''' Name: like_count
            ''' Description: The number of times this comment was liked
            ''' Permissions: generic access_token
            ''' Return: integer
            ''' </summary>
            <DataMember(Name:="like_count")>
            Public Property LikeCount() As System.Nullable(Of Integer)
            ''' <summary>
            ''' Name: user_likes
            ''' Description: This field is returned only if the authenticated user likes this comment
            ''' Permissions: generic access_token
            ''' Return: string; always true
            ''' </summary>
            <DataMember(Name:="user_likes")>
            Public Property UserLikes() As String
            ''' <summary>
            ''' Name: parent
            ''' Description: If this comment is a reply, this field returns the parent comment, otherwise no value
            ''' Permissions: generic access_token
            ''' Return: reference
            ''' </summary>
            <DataMember(Name:="parent")>
            Public Property Parent() As MessageObject
            ''' <summary>
            ''' Name: can_comment
            ''' Description: Specifies whether you can reply to this comment
            ''' Permissions: generic access_token
            ''' Return: boolean
            ''' </summary>
            <DataMember(Name:="can_comment")>
            Public Property CanComment() As System.Nullable(Of Boolean)
            ''' <summary>
            ''' Name: comment_count
            ''' Description: The number of replies to this comment, if any
            ''' Permissions: generic access_token
            ''' Return: integer
            ''' </summary>
            <DataMember(Name:="comment_count")>
            Public Property CommentCount() As System.Nullable(Of Integer)
        End Class
    End Class
End Namespace
