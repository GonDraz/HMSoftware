Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class Model

    Public dbName As String = "hmsoftware_database.db"
    Public dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & dbName
    Public connString As String = "Data Source=" & dbPath & "; Version=3 ;PRAGMA legacy_file_format = TRUE; Integrated Security=true"
    Public connection As New SQLiteConnection(connString)
    Public command As New SQLiteCommand("", connection)

    Public table As New DataTable


    Public Sub CreateDataBase()

        connection.Open()
        command.Connection = connection
        command.CommandText = "Select * from customer"

        Try
            command.ExecuteNonQuery()

        Catch ex As Exception
            Debug.Print("ex: " & ex.ToString)
            command.CommandText = "
CREATE TABLE customer (
    id     INTEGER UNIQUE PRIMARY KEY
                   NOT NULL,
    name  TEXT    NOT NULL,
    phone TEXT    NOT NULL,
    gender TEXT    NOT NULL
);

CREATE TABLE employee (
    id           INTEGER UNIQUE PRIMARY KEY
                          NOT NULL,
      user    TEXT     NOT NULL,
    password     TEXT     NOT NULL,
    phone       TEXT     NOT NULL,
    gender       TEXT     NOT NULL,
    admin_rights INTEGER NOT NULL
);

CREATE TABLE room (
    id     INTEGER UNIQUE PRIMARY KEY,
    type INTEGER    NOT NULL,
    empty  INTEGER    NOT NULL,
    rate  TEXT    NOT NULL
);

CREATE TABLE check_HM (
   id INTEGER NOT NULL PRIMARY KEY,
   customer_id     INTEGER NOT NULL,
   room_id INTEGER    NOT NULL,
   FOREIGN KEY (customer_id) REFERENCES customer (id)
   FOREIGN KEY (room_id) REFERENCES room (id)

);

insert into employee(user,password,phone,gender,admin_rights) values ('admin','admin','0000000000','Nam',1)
"
            command.ExecuteNonQuery()
        End Try

        Debug.Print("database tại : " & dbPath)
    End Sub
End Class