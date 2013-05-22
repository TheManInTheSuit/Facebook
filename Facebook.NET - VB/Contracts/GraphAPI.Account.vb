Imports System
Imports System.Runtime.Serialization

Namespace Facebook
	Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Partial Public NotInheritable Class Account
            <DataMember(Name:="data")>
            Public Property Data() As GraphApi.AccountData()
            <DataMember(Name:="paging")>
            Public Property Paging() As GraphApi.Pagination
        End Class
	End Class
End Namespace
