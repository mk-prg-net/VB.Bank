'------------------------------------------------------------------------------
' <auto-generated>
'     Der Code wurde von einer Vorlage generiert.
'
'     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
'     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class HimmelskoerperTab
    Public Property ID As Integer
    Public Property Name As String
    Public Property Masse_in_kg As Double
    Public Property HimmelskoerperTyp_ID As Integer
    Public Property SpektralklasseId As Nullable(Of Integer)

    Public Overridable Property BildTab As ICollection(Of BildTab) = New HashSet(Of BildTab)
    Public Overridable Property RaumschiffeTab As RaumschiffeTab
    Public Overridable Property Sterne_Planeten_MondeTab As Sterne_Planeten_MondeTab
    Public Overridable Property HimmelskoerperTypenTab As HimmelskoerperTypenTab
    Public Overridable Property SpektralklasseTab As SpektralklasseTab
    Public Overridable Property UmlaufbahnenTab As UmlaufbahnenTab
    Public Overridable Property UmlaufbahnenTrabanten As ICollection(Of UmlaufbahnenTab) = New HashSet(Of UmlaufbahnenTab)

End Class
