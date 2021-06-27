Imports System.Diagnostics

''' <summary>
''' TODO一覧画面
''' </summary>
Public Class TodoForm
    Inherits System.Web.UI.Page

    ''' <summary>
    ''' 初期表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '初期データのサンプルは、Global.aspx.vbにて登録しています。
        '不要であれば、コメントアウトすること。
        If Not IsPostBack Then
            'リピーターの初期化は、初期表示の1回だけにしないとNG
            UpdateList()
        End If

    End Sub

    ''' <summary>
    ''' TODO編集画面に遷移する。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnAddTodo_Click(sender As Object, e As EventArgs) Handles btnAddTodo.Click
        Session("MODE") = "NEW"
        Server.Transfer("TodoDetail.aspx")
    End Sub

    ''' <summary>
    ''' ・選択されたTODOを完了状態に更新する
    ''' ・リピーターの状態を更新する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnComplete_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim selectedTodoId As Integer = Integer.Parse(btn.CommandArgument)
    End Sub


    ''' <summary>
    ''' リピーターデータの最新化
    ''' </summary>
    Private Sub UpdateList()
        rptInCompleteList.DataSource = DBManager.GetInCompleteTodoList
        rptInCompleteList.DataBind()
    End Sub


End Class