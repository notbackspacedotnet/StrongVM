Imports System.Reflection

Module Module1

    Sub Main()
        WriteSecretMessage()
        WriteSecretMessage2()
    End Sub

    ''' <summary>
    ''' Custom Rename Attribute Example
    ''' Replace 'RelaceMe' With New Method Name
    ''' </summary>
    ''' <remarks></remarks>
    <Obfuscation(Feature:="rename=RelaceMe", Exclude:=False)>
    Sub WriteSecretMessage()
        Console.WriteLine(Text.Encoding.ASCII.GetString(Convert.FromBase64String("SGVsbG8gV29ybGQ=")))
    End Sub

    ''' <summary>
    ''' Custom Rename Attribute Example 2
    ''' New Method Name '44BDBFBFD'
    ''' </summary>
    ''' <remarks></remarks>
    <Obfuscation(Feature:="rename=44BDBFBFD", Exclude:=False)>
    Sub WriteSecretMessage2()
        Console.WriteLine(Text.Encoding.ASCII.GetString(Convert.FromBase64String("SGVsbG8gV29ybGQ=")))
    End Sub

End Module
