Imports MySql.Data.MySqlClient

Public Class About
    Inherits Page


    Public Sub Page_Load(obj As Object, args As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ShowData()

        End If


    End Sub

    Public Sub handleInsert(obj As Object, args As EventArgs)
        Dim connString As String = "server=localhost;Database=loggin;User ID=root;Password=;"
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim query As String = "insert into loggin (user,pass) values(@name,@pass)"
        Dim Command As New MySqlCommand(query, con)
        Command.Parameters.AddWithValue("@name", txtUser.Text)
        Command.Parameters.AddWithValue("@pass", txtPass.Text)
        Command.ExecuteNonQuery()

        ShowData()

    End Sub

    Public Sub ShowData()
        Dim connString As String = "server=localhost;Database=loggin;User ID=root;Password=;"
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim query As String = "select * from loggin"
        Dim Command As New MySqlCommand(query, con)

        Command.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim Adapters As New MySqlDataAdapter(Command)
        Adapters.Fill(dt)
        gridView.DataSource = dt
        gridView.DataBind()

        con.Close()


    End Sub

    Public Sub DeleteData(Obj As Object, Args As EventArgs)
        Dim ab As String = "server=localhost;Database=loggin;User name=root;pass="
        Dim con As New MySqlConnection(ab)
        Dim query As String = "Delete from loggin where id=@id"
        con.Open()
        Dim command As New MySqlCommand(query, con)
        command.Parameters.AddWithValue("@id", txtId.Text)
        command.ExecuteNonQuery()
        ShowData()
    End Sub

    Public Sub UpdateData(Obj As Object, Evg As EventArgs)
        Dim ab As String = "server=localhost;Database=loggin;User name=root;pass="
        Dim con As New MySqlConnection(ab)
        con.Open()
        Dim query As String = "Update loggin Set user = @name,pass = @pass where id=@id"
        Dim command As New MySqlCommand(query, con)
        command.Parameters.AddWithValue("@id", txtId.Text)
        command.Parameters.AddWithValue("@name", txtUser.Text)
        command.Parameters.AddWithValue("@pass", txtPass.Text)

        command.ExecuteNonQuery()
        ShowData()
    End Sub

    Public Sub btnSearch_Click(obj As Object, Args As EventArgs)
        Dim ab As String = "server=localhost;Database=loggin;User name=root;pass="
        Dim con As New MySqlConnection(ab)
        con.Open()
        Dim query As String = "select * from loggin where user like @name"
        Dim command As New MySqlCommand(query, con)
        command.Parameters.AddWithValue("@name", txtSearch.Text)
        Dim DataTable As New DataTable()
        Dim DataAdapter As New MySqlDataAdapter(command)
        DataAdapter.Fill(DataTable)
        gridView.DataSource = DataTable
        gridView.DataBind()
        con.Close()
    End Sub






End Class