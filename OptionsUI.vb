Imports JHSoftware.SimpleDNS

Public Class OptionsUI

  Public Overrides Sub LoadData(config As String)
    Dim obj = DirectCast(Json.Parse(config), Json.Object)
    txtValue.Text = obj.GetString("value")
    CtlTTL1.Value = obj.GetInt("ttl")
  End Sub

  Public Overrides Function ValidateData() As Boolean
    If txtValue.Text.Trim.StartsWith("v=spf") Then
      MsgBox("SPF-record data must begin with 'v=spf'", MsgBoxStyle.Exclamation, "Auto SPF plug-in")
      Return False
    End If
    Return True
  End Function

  Public Overrides Function SaveData() As String
    Dim obj = New Json.Object From {
      {"value", txtValue.Text.Trim()},
      {"ttl", CtlTTL1.Value}
    }
    Return obj.EncodeJson(False)
  End Function


End Class
