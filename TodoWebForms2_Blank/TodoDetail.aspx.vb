''' <summary>
''' TODO編集画面
''' </summary>
Public Class TodoDetail
    Inherits System.Web.UI.Page

    ''' <summary>
    ''' 初期画面表示
    ''' ・追加ボタンで画面呼び出された場合、追加モードで表示する
    ''' 　・入力欄は空欄
    ''' 　・アクションボタン名は「追加」
    ''' ・更新ボタンで画面呼び出しされた場合、更新
    ''' 　・入力欄は、選択されたTODOの内容を表示
    ''' 　・アクションボタン名は「更新」
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            '初期表示の場合
        Else
            'PostBackの場合（＝自画面再表示の場合）
        End If

    End Sub

    ''' <summary>
    ''' TODO一覧画面に戻る
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnBack_Click(sender As Object, e As EventArgs)
        Response.Redirect("TodoForm.aspx")
    End Sub

    ''' <summary>
    ''' 追加、または更新処理を実施
    ''' ・追加ボタンで画面呼び出された場合、追加
    ''' ・更新ボタンで画面呼び出しされた場合、更新
    ''' ・追加、または更新処理後は、TODO一覧画面に戻る。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnAction_Click(sender As Object, e As EventArgs)

        If Not InputChcek() Then Return

    End Sub

    ''' <summary>
    ''' 入力チェック
    ''' ・TODOタイトルが未入力の場合、エラー
    ''' ・期限がYYYY/M/D形式ではない場合、または、無効な日付の場合、エラー。
    ''' </summary>
    ''' <returns></returns>
    Private Function InputChcek() As Boolean
        Return True
    End Function

    ''' <summary>
    ''' 簡易エラーメッセージ表示（JavaScriptのalert）
    ''' </summary>
    ''' <param name="msg"></param>
    Private Sub ShowAlert(msg As String)
        Dim script As String = $"alert('{msg}');"
        ClientScript.RegisterStartupScript(Me.GetType(), "ErrorMessage", script, True)
    End Sub
End Class