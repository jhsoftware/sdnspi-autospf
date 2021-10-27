Imports JHSoftware.SimpleDNS
Imports JHSoftware.SimpleDNS.Plugin

Public Class AutoSpfPlugin
  Implements ILookupTXT
  Implements IOptionsUI

  Public Property Host As IHost Implements IPlugInBase.Host

  Private CfgValue As String
  Private CfgTTL As Integer

  Public Function GetPlugInTypeInfo() As IPlugInBase.PlugInTypeInfo Implements IPlugInBase.GetTypeInfo
    Return New IPlugInBase.PlugInTypeInfo With {
        .Name = "Auto SPF",
        .Description = "Synthesize missing SPF records (TXT) for local domains",
        .InfoURL = "https://simpledns.plus/plugin-autospf"
    }
  End Function

  Public Sub LoadConfig(config As String, instanceID As Guid, dataPath As String) Implements IPlugInBase.LoadConfig
    Dim obj = DirectCast(Json.Parse(config), Json.Object)
    CfgValue = obj.GetString("value")
    CfgTTL = obj.GetInt("ttl")
  End Sub

  Public Function LookupTXT(name As DomName, ctx As IRequestContext) As Task(Of LookupResult(Of String)) Implements ILookupTXT.LookupTXT
    If Not ctx.AA OrElse name.ToString().StartsWith("_") Then Return Task.FromResult(Of LookupResult(Of String))(Nothing)
    Return Task.FromResult(New LookupResult(Of String) With {.Value = CfgValue, .TTL = CfgTTL})
  End Function

  Public Sub StopService() Implements IPlugInBase.StopService
    REM do nothing
  End Sub

  Public Sub LoadState(state As String) Implements IPlugInBase.LoadState
    REM do nothing
  End Sub

  Public Function InstanceConflict(config1 As String, config2 As String, ByRef errorMsg As String) As Boolean Implements IPlugInBase.InstanceConflict
    Return False
  End Function

  Public Function StartService() As Task Implements IPlugInBase.StartService
    Return Task.CompletedTask
  End Function

  Public Function SaveState() As String Implements IPlugInBase.SaveState
    Return Nothing
  End Function

  Public Function GetOptionsUI(instanceID As Guid, dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements IOptionsUI.GetOptionsUI
    Return New OptionsUI
  End Function
End Class
