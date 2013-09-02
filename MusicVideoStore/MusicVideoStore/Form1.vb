Imports System.Data
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Form
    Dim dbConnect As New MySqlConnection("Server=127.0.0.1;Database=music_video_store_db;Uid=root;")
    Dim afterAdding As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim addAlbumAdapter As New MySqlDataAdapter
            Dim addAlbumDT As New DataTable
            Dim addConArtAdapter As New MySqlDataAdapter
            Dim addConArtDT As New DataTable
            Dim addMusGenreAdapter As New MySqlDataAdapter
            Dim addMusGenreDT As New DataTable
            Dim addMovieAdapter As New MySqlDataAdapter
            Dim addMovieDT As New DataTable
            Dim addStrArtAdapter As New MySqlDataAdapter
            Dim addStrArtDT As New DataTable
            Dim addMovGenreAdapter As New MySqlDataAdapter
            Dim addMovGenreDT As New DataTable

            If afterAdding = False Then
                dbConnect.Open()
            End If
            afterAdding = True

            'Display all album names
            addAlbumAdapter = New MySqlDataAdapter("SELECT * FROM album_music_table;", dbConnect)
            addAlbumAdapter.Fill(addAlbumDT)

            ListBox2.DataSource = Nothing
            ListBox2.Items.Clear()
            ListBox2.DataSource = addAlbumDT
            ListBox2.DisplayMember = "albumName"

            For Each viewAlbumItems As DataRowView In ListBox2.SelectedItems
                ViewAlbumProductCodeTextBox.Text = viewAlbumItems.Item(1).ToString
                ViewAlbumAlbumNameTextBox.Text = viewAlbumItems.Item(2).ToString
                ViewAlbumContribArtistTextBox.Text = viewAlbumItems.Item(3).ToString
                ViewAlbumMusicGenreTextBox.Text = viewAlbumItems.Item(4).ToString
                ViewAlbumNumTracksTextBox.Text = viewAlbumItems.Item(5).ToString
                ViewAlbumPriceTextBox.Text = viewAlbumItems.Item(6).ToString
            Next

            ListBox1.DataSource = Nothing
            ListBox1.Items.Clear()
            ListBox1.DataSource = addAlbumDT
            ListBox1.DisplayMember = "albumName"

            For Each editAlbumItems As DataRowView In ListBox1.SelectedItems
                EditAlbumProductCodeTextBox.Text = editAlbumItems.Item(1).ToString
                EditAlbumAlbumNameTextBox.Text = editAlbumItems.Item(2).ToString
                EditAlbumContribArtistComboBox.Text = editAlbumItems.Item(3).ToString
                EditAlbumMusicGenreComboBox.Text = editAlbumItems.Item(4).ToString
                EditAlbumNumTracksNumericUpDown.Value = Convert.ToDecimal(editAlbumItems.Item(5))
                EditAlbumPriceTextBox.Text = editAlbumItems.Item(6).ToString
            Next

            'Display distinct contributing artists
            addConArtAdapter = New MySqlDataAdapter("SELECT DISTINCT contribArtist FROM album_music_table WHERE contribArtist != '';", dbConnect)
            addConArtAdapter.Fill(addConArtDT)

            AddAlbumContribArtistComboBox.DataSource = Nothing
            AddAlbumContribArtistComboBox.Items.Clear()
            AddAlbumContribArtistComboBox.DataSource = addConArtDT
            AddAlbumContribArtistComboBox.DisplayMember = "contribArtist"

            EditAlbumContribArtistComboBox.DataSource = Nothing
            EditAlbumContribArtistComboBox.Items.Clear()
            EditAlbumContribArtistComboBox.DataSource = addConArtDT
            EditAlbumContribArtistComboBox.DisplayMember = "contribArtist"

            'Display distinct music genre
            addMusGenreAdapter = New MySqlDataAdapter("SELECT DISTINCT musicGenre FROM album_music_table WHERE musicGenre != '';", dbConnect)
            addMusGenreAdapter.Fill(addMusGenreDT)

            AddAlbumMusicGenreComboBox.DataSource = Nothing
            AddAlbumMusicGenreComboBox.Items.Clear()
            AddAlbumMusicGenreComboBox.DataSource = addMusGenreDT
            AddAlbumMusicGenreComboBox.DisplayMember = "musicGenre"

            EditAlbumMusicGenreComboBox.DataSource = Nothing
            EditAlbumMusicGenreComboBox.Items.Clear()
            EditAlbumMusicGenreComboBox.DataSource = addMusGenreDT
            EditAlbumMusicGenreComboBox.DisplayMember = "musicGenre"

            'Display all movie names
            addMovieAdapter = New MySqlDataAdapter("SELECT * FROM movie_video_table;", dbConnect)
            addMovieAdapter.Fill(addMovieDT)

            ListBox4.DataSource = Nothing
            ListBox4.Items.Clear()
            ListBox4.DataSource = addMovieDT
            ListBox4.DisplayMember = "movieName"

            For Each viewMovieItems As DataRowView In ListBox4.SelectedItems
                ViewMovieProductCodeTextBox.Text = viewMovieItems.Item(1).ToString
                ViewMovieMovieNameTextBox.Text = viewMovieItems.Item(2).ToString
                ViewMovieStarringArtistTextBox.Text = viewMovieItems.Item(3).ToString
                ViewMovieMovieGenreTextBox.Text = viewMovieItems.Item(4).ToString
                ViewMovieMovieDescriptionTextBox.Text = viewMovieItems.Item(5).ToString
                ViewMoviePriceTextBox.Text = viewMovieItems.Item(6).ToString
            Next

            ListBox3.DataSource = Nothing
            ListBox3.Items.Clear()
            ListBox3.DataSource = addMovieDT
            ListBox3.DisplayMember = "movieName"

            For Each editMovieItems As DataRowView In ListBox3.SelectedItems
                EditMovieProductCodeTextBox.Text = editMovieItems.Item(1).ToString
                EditMovieMovieNameTextBox.Text = editMovieItems.Item(2).ToString
                EditMovieStarringArtistComboBox.Text = editMovieItems.Item(3).ToString
                EditMovieMovieGenreComboBox.Text = editMovieItems.Item(4).ToString
                EditMovieMovieDescriptionTextBox.Text = editMovieItems.Item(5).ToString
                EditMoviePriceTextBox.Text = editMovieItems.Item(6).ToString
            Next

            'Display distinct starring artists
            addStrArtAdapter = New MySqlDataAdapter("SELECT DISTINCT starringArtist FROM movie_video_table WHERE starringArtist != '';", dbConnect)
            addStrArtAdapter.Fill(addStrArtDT)

            AddMovieStarringArtistComboBox.DataSource = Nothing
            AddMovieStarringArtistComboBox.Items.Clear()
            AddMovieStarringArtistComboBox.DataSource = addStrArtDT
            AddMovieStarringArtistComboBox.DisplayMember = "starringArtist"

            EditMovieStarringArtistComboBox.DataSource = Nothing
            EditMovieStarringArtistComboBox.Items.Clear()
            EditMovieStarringArtistComboBox.DataSource = addStrArtDT
            EditMovieStarringArtistComboBox.DisplayMember = "starringArtist"

            'Display distinct movie genre
            addMovGenreAdapter = New MySqlDataAdapter("SELECT DISTINCT movieGenre FROM movie_video_table WHERE movieGenre != '';", dbConnect)
            addMovGenreAdapter.Fill(addMovGenreDT)

            AddMovieMovieGenreComboBox.DataSource = Nothing
            AddMovieMovieGenreComboBox.Items.Clear()
            AddMovieMovieGenreComboBox.DataSource = addMovGenreDT
            AddMovieMovieGenreComboBox.DisplayMember = "movieGenre"

            EditMovieMovieGenreComboBox.DataSource = Nothing
            EditMovieMovieGenreComboBox.Items.Clear()
            EditMovieMovieGenreComboBox.DataSource = addMovGenreDT
            EditMovieMovieGenreComboBox.DisplayMember = "movieGenre"

            'Album code declaration
            Dim albumIndex As Integer = ListBox2.SelectedIndex() + 1
            Dim albumCode As String = "AM-00001"

            'Movie code declaration
            Dim movieIndex As Integer = ListBox4.SelectedIndex() + 1
            Dim movieCode As String = "MV-00001"

            If afterAdding = False Then
                dbConnect.Open()
            End If
            afterAdding = True

            'Automatically generate album product code
            Dim albumProdCode As Integer = ListBox2.Items.Count() + 1

            If albumProdCode.ToString.Length.Equals(1) Then
                AddAlbumProductCodeTextBox.Text = "AM-0000" + albumProdCode.ToString
            ElseIf albumProdCode.ToString.Length.Equals(2) Then
                AddAlbumProductCodeTextBox.Text = "AM-000" + albumProdCode.ToString
            ElseIf albumProdCode.ToString.Length.Equals(3) Then
                AddAlbumProductCodeTextBox.Text = "AM-00" + albumProdCode.ToString
            ElseIf albumProdCode.ToString.Length.Equals(4) Then
                AddAlbumProductCodeTextBox.Text = "AM-0" + albumProdCode.ToString
            ElseIf albumProdCode.ToString.Length.Equals(5) Then
                AddAlbumProductCodeTextBox.Text = "AM-" + albumProdCode.ToString
            End If

            'Automatically generate movie product code
            Dim movieProdCode As Integer = ListBox4.Items.Count() + 1

            If movieProdCode.ToString.Length.Equals(1) Then
                AddMovieProductCodeTextBox.Text = "MV-0000" + movieProdCode.ToString
            ElseIf movieProdCode.ToString.Length.Equals(2) Then
                AddMovieProductCodeTextBox.Text = "MV-000" + movieProdCode.ToString
            ElseIf movieProdCode.ToString.Length.Equals(3) Then
                AddMovieProductCodeTextBox.Text = "MV-00" + movieProdCode.ToString
            ElseIf movieProdCode.ToString.Length.Equals(4) Then
                AddMovieProductCodeTextBox.Text = "MV-0" + movieProdCode.ToString
            ElseIf movieProdCode.ToString.Length.Equals(5) Then
                AddMovieProductCodeTextBox.Text = "MV-" + movieProdCode.ToString
            End If

            dbConnect.Close()
            afterAdding = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ResetAlbumBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetAlbumBtn.Click
        AddAlbumAlbumNameTextBox.Text = ""
        AddAlbumContribArtistComboBox.Text = ""
        AddAlbumMusicGenreComboBox.Text = ""
        AddAlbumNumTracksNumericUpDown.Value = "0"
        AddAlbumPriceTextBox.Text = ""
    End Sub

    Private Sub ResetMovieBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetMovieBtn.Click
        AddMovieMovieNameTextBox.Text = ""
        AddMovieStarringArtistComboBox.Text = ""
        AddMovieMovieGenreComboBox.Text = ""
        AddMovieMovieDescriptionTextBox.Text = ""
        AddMoviePriceTextBox.Text = ""
    End Sub

    Private Sub AddAlbumBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAlbumBtn.Click
        Dim addAlbum As Boolean = True

        If AddAlbumAlbumNameTextBox.Text.Trim = "" And AddAlbumPriceTextBox.Text.Trim = "" Then
            MsgBox("Blank album name and album price.")
            addAlbum = False
        ElseIf AddAlbumAlbumNameTextBox.Text.Trim = "" Then
            MsgBox("Blank album name.")
            addAlbum = False
        ElseIf AddAlbumPriceTextBox.Text.Trim = "" Then
            MsgBox("Blank album price.")
            addAlbum = False
        End If

        If Not Regex.Match(AddAlbumPriceTextBox.Text, "^[0-9]+(\.[0-9]{1,2})?$", RegexOptions.IgnoreCase).Success And Not AddAlbumPriceTextBox.Text.Trim = "" Then
            MsgBox("Invalid album price.")
            addAlbum = False
        End If

        If addAlbum = True Then
            Try
                Dim addAlbumAdapter As New MySqlDataAdapter
                Dim addAlbumDT As New DataTable
                Dim addConArtAdapter As New MySqlDataAdapter
                Dim addConArtDT As New DataTable
                Dim addMusGenreAdapter As New MySqlDataAdapter
                Dim addMusGenreDT As New DataTable

                If afterAdding = False Then
                    dbConnect.Open()
                End If
                afterAdding = True
                Dim addAlbumCmd As MySqlCommand = New MySqlCommand("INSERT INTO album_music_table (productCode, albumName, contribArtist, musicGenre, numTracks, price) VALUES ('" & AddAlbumProductCodeTextBox.Text & "','" & AddAlbumAlbumNameTextBox.Text & "','" & AddAlbumContribArtistComboBox.Text & "','" & AddAlbumMusicGenreComboBox.Text & "','" & AddAlbumNumTracksNumericUpDown.Value & "','" & AddAlbumPriceTextBox.Text & "');", dbConnect)
                Dim addAlbumRdr As MySqlDataReader = addAlbumCmd.ExecuteReader()
                MsgBox("Successfully added " & AddAlbumAlbumNameTextBox.Text & ".")
                addAlbumRdr.Close()

                addAlbumAdapter = New MySqlDataAdapter("SELECT * FROM album_music_table;", dbConnect)
                addAlbumAdapter.Fill(addAlbumDT)

                ListBox2.DataSource = Nothing
                ListBox2.Items.Clear()
                ListBox2.DataSource = addAlbumDT
                ListBox2.DisplayMember = "albumName"

                ListBox1.DataSource = Nothing
                ListBox1.Items.Clear()
                ListBox1.DataSource = addAlbumDT
                ListBox1.DisplayMember = "albumName"

                addConArtAdapter = New MySqlDataAdapter("SELECT DISTINCT contribArtist FROM album_music_table WHERE contribArtist != '';", dbConnect)
                addConArtAdapter.Fill(addConArtDT)

                AddAlbumContribArtistComboBox.DataSource = Nothing
                AddAlbumContribArtistComboBox.Items.Clear()
                AddAlbumContribArtistComboBox.DataSource = addConArtDT
                AddAlbumContribArtistComboBox.DisplayMember = "contribArtist"

                EditAlbumContribArtistComboBox.DataSource = Nothing
                EditAlbumContribArtistComboBox.Items.Clear()
                EditAlbumContribArtistComboBox.DataSource = addConArtDT
                EditAlbumContribArtistComboBox.DisplayMember = "contribArtist"

                addMusGenreAdapter = New MySqlDataAdapter("SELECT DISTINCT musicGenre FROM album_music_table WHERE musicGenre != '';", dbConnect)
                addMusGenreAdapter.Fill(addMusGenreDT)

                AddAlbumMusicGenreComboBox.DataSource = Nothing
                AddAlbumMusicGenreComboBox.Items.Clear()
                AddAlbumMusicGenreComboBox.DataSource = addMusGenreDT
                AddAlbumMusicGenreComboBox.DisplayMember = "musicGenre"

                EditAlbumMusicGenreComboBox.DataSource = Nothing
                EditAlbumMusicGenreComboBox.Items.Clear()
                EditAlbumMusicGenreComboBox.DataSource = addMusGenreDT
                EditAlbumMusicGenreComboBox.DisplayMember = "musicGenre"

                dbConnect.Close()
                afterAdding = False

                Dim albumProdCode As Integer = ListBox2.Items.Count() + 1

                If albumProdCode.ToString.Length.Equals(1) Then
                    AddAlbumProductCodeTextBox.Text = "AM-0000" + albumProdCode.ToString
                ElseIf albumProdCode.ToString.Length.Equals(2) Then
                    AddAlbumProductCodeTextBox.Text = "AM-000" + albumProdCode.ToString
                ElseIf albumProdCode.ToString.Length.Equals(3) Then
                    AddAlbumProductCodeTextBox.Text = "AM-00" + albumProdCode.ToString
                ElseIf albumProdCode.ToString.Length.Equals(4) Then
                    AddAlbumProductCodeTextBox.Text = "AM-0" + albumProdCode.ToString
                ElseIf albumProdCode.ToString.Length.Equals(5) Then
                    AddAlbumProductCodeTextBox.Text = "AM-" + albumProdCode.ToString
                End If

                AddAlbumAlbumNameTextBox.Text = ""
                AddAlbumContribArtistComboBox.Text = ""
                AddAlbumMusicGenreComboBox.Text = ""
                AddAlbumNumTracksNumericUpDown.Value = "0"
                AddAlbumPriceTextBox.Text = ""
                SearchViewAlbum.Text = ""
                SearchEditAlbum.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub AddMovieBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMovieBtn.Click
        Dim addMovie As Boolean = True

        If AddMovieMovieNameTextBox.Text.Trim = "" And AddMoviePriceTextBox.Text.Trim = "" Then
            MsgBox("Blank movie name and movie price.")
            addMovie = False
        ElseIf AddMovieMovieNameTextBox.Text.Trim = "" Then
            MsgBox("Blank movie name.")
            addMovie = False
        ElseIf AddMoviePriceTextBox.Text.Trim = "" Then
            MsgBox("Blank movie price.")
            addMovie = False
        End If

        If Not Regex.Match(AddMoviePriceTextBox.Text, "^[0-9]+(\.[0-9]{1,2})?$", RegexOptions.IgnoreCase).Success And Not AddMoviePriceTextBox.Text.Trim = "" Then
            MsgBox("Invalid movie price.")
            addMovie = False
        End If

        If addMovie = True Then
            Try
                Dim addMovieAdapter As New MySqlDataAdapter
                Dim addMovieDT As New DataTable
                Dim addStrArtAdapter As New MySqlDataAdapter
                Dim addStrArtDT As New DataTable
                Dim addMovGenreAdapter As New MySqlDataAdapter
                Dim addMovGenreDT As New DataTable

                If afterAdding = False Then
                    dbConnect.Open()
                End If
                afterAdding = True

                Dim addMovieCmd As MySqlCommand = New MySqlCommand("INSERT INTO movie_video_table (productCode, movieName, starringArtist, movieGenre, movieDescription, price) VALUES ('" & AddMovieProductCodeTextBox.Text & "','" & AddMovieMovieNameTextBox.Text & "','" & AddMovieStarringArtistComboBox.Text & "','" & AddMovieMovieGenreComboBox.Text & "','" & AddMovieMovieDescriptionTextBox.Text & "','" & AddMoviePriceTextBox.Text & "');", dbConnect)
                Dim addMovieRdr As MySqlDataReader = addMovieCmd.ExecuteReader()
                MsgBox("Successfully added " & AddMovieMovieNameTextBox.Text & ".")
                addMovieRdr.Close()

                addMovieAdapter = New MySqlDataAdapter("SELECT * FROM movie_video_table;", dbConnect)
                addMovieAdapter.Fill(addMovieDT)

                ListBox4.DataSource = Nothing
                ListBox4.Items.Clear()
                ListBox4.DataSource = addMovieDT
                ListBox4.DisplayMember = "movieName"

                ListBox3.DataSource = Nothing
                ListBox3.Items.Clear()
                ListBox3.DataSource = addMovieDT
                ListBox3.DisplayMember = "movieName"

                addStrArtAdapter = New MySqlDataAdapter("SELECT DISTINCT starringArtist FROM movie_video_table WHERE starringArtist != '';", dbConnect)
                addStrArtAdapter.Fill(addStrArtDT)

                AddMovieStarringArtistComboBox.DataSource = Nothing
                AddMovieStarringArtistComboBox.Items.Clear()
                AddMovieStarringArtistComboBox.DataSource = addStrArtDT
                AddMovieStarringArtistComboBox.DisplayMember = "starringArtist"
                AddMovieStarringArtistComboBox.Text = ""

                EditMovieStarringArtistComboBox.DataSource = Nothing
                EditMovieStarringArtistComboBox.Items.Clear()
                EditMovieStarringArtistComboBox.DataSource = addStrArtDT
                EditMovieStarringArtistComboBox.DisplayMember = "starringArtist"

                addMovGenreAdapter = New MySqlDataAdapter("SELECT DISTINCT movieGenre FROM movie_video_table WHERE movieGenre != '';", dbConnect)
                addMovGenreAdapter.Fill(addMovGenreDT)

                AddMovieMovieGenreComboBox.DataSource = Nothing
                AddMovieMovieGenreComboBox.Items.Clear()
                AddMovieMovieGenreComboBox.DataSource = addMovGenreDT
                AddMovieMovieGenreComboBox.DisplayMember = "movieGenre"

                EditMovieMovieGenreComboBox.DataSource = Nothing
                EditMovieMovieGenreComboBox.Items.Clear()
                EditMovieMovieGenreComboBox.DataSource = addMovGenreDT
                EditMovieMovieGenreComboBox.DisplayMember = "movieGenre"

                dbConnect.Close()
                afterAdding = False

                Dim movieProdCode As Integer = ListBox4.Items.Count() + 1

                If movieProdCode.ToString.Length.Equals(1) Then
                    AddMovieProductCodeTextBox.Text = "MV-0000" + movieProdCode.ToString
                ElseIf movieProdCode.ToString.Length.Equals(2) Then
                    AddMovieProductCodeTextBox.Text = "MV-000" + movieProdCode.ToString
                ElseIf movieProdCode.ToString.Length.Equals(3) Then
                    AddMovieProductCodeTextBox.Text = "MV-00" + movieProdCode.ToString
                ElseIf movieProdCode.ToString.Length.Equals(4) Then
                    AddMovieProductCodeTextBox.Text = "MV-0" + movieProdCode.ToString
                ElseIf movieProdCode.ToString.Length.Equals(5) Then
                    AddMovieProductCodeTextBox.Text = "MV-" + movieProdCode.ToString
                End If

                AddMovieMovieNameTextBox.Text = ""
                AddMovieStarringArtistComboBox.Text = ""
                AddMovieMovieGenreComboBox.Text = ""
                AddMovieMovieDescriptionTextBox.Text = ""
                AddMoviePriceTextBox.Text = ""
                SearchViewMovie.Text = ""
                SearchEditMovie.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SaveAlbumBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAlbumBtn.Click
        Dim editAlbum As Boolean = True

        If EditAlbumAlbumNameTextBox.Text.Trim = "" And EditAlbumPriceTextBox.Text.Trim = "" Then
            MsgBox("Blank album name and album price.")
            editAlbum = False
        ElseIf EditAlbumAlbumNameTextBox.Text.Trim = "" Then
            MsgBox("Blank album name.")
            editAlbum = False
        ElseIf EditAlbumPriceTextBox.Text.Trim = "" Then
            MsgBox("Blank album price.")
            editAlbum = False
        End If

        If Not Regex.Match(EditAlbumPriceTextBox.Text, "^[0-9]+(\.[0-9]{1,2})?$", RegexOptions.IgnoreCase).Success And Not EditAlbumPriceTextBox.Text.Trim = "" Then
            MsgBox("Invalid album price.")
            editAlbum = False
        End If

        If editAlbum = True Then
            Try
                Dim editAlbumAdapter As New MySqlDataAdapter
                Dim editAlbumDT As New DataTable
                Dim editConArtAdapter As New MySqlDataAdapter
                Dim editConArtDT As New DataTable
                Dim editMusGenreAdapter As New MySqlDataAdapter
                Dim editMusGenreDT As New DataTable

                If afterAdding = False Then
                    dbConnect.Open()
                End If
                afterAdding = True

                Dim editAlbumCmd As MySqlCommand = New MySqlCommand("UPDATE album_music_table SET albumName = '" & EditAlbumAlbumNameTextBox.Text & "', contribArtist = '" & EditAlbumContribArtistComboBox.Text & "', musicGenre = '" & EditAlbumMusicGenreComboBox.Text & "', numTracks = '" & EditAlbumNumTracksNumericUpDown.Value & "', price = '" & EditAlbumPriceTextBox.Text & "' WHERE productCode = '" & EditAlbumProductCodeTextBox.Text & "';", dbConnect)
                Dim editAlbumRdr As MySqlDataReader = editAlbumCmd.ExecuteReader()
                MsgBox("Successfully edited " & EditAlbumProductCodeTextBox.Text & ".")
                editAlbumRdr.Close()

                editAlbumAdapter = New MySqlDataAdapter("SELECT * FROM album_music_table;", dbConnect)
                editAlbumAdapter.Fill(editAlbumDT)

                ListBox2.DataSource = Nothing
                ListBox2.Items.Clear()
                ListBox2.DataSource = editAlbumDT
                ListBox2.DisplayMember = "albumName"

                ListBox1.DataSource = Nothing
                ListBox1.Items.Clear()
                ListBox1.DataSource = editAlbumDT
                ListBox1.DisplayMember = "albumName"

                editConArtAdapter = New MySqlDataAdapter("SELECT DISTINCT contribArtist FROM album_music_table WHERE contribArtist != '';", dbConnect)
                editConArtAdapter.Fill(editConArtDT)

                AddAlbumContribArtistComboBox.DataSource = Nothing
                AddAlbumContribArtistComboBox.Items.Clear()
                AddAlbumContribArtistComboBox.DataSource = editConArtDT
                AddAlbumContribArtistComboBox.DisplayMember = "contribArtist"

                EditAlbumContribArtistComboBox.DataSource = Nothing
                EditAlbumContribArtistComboBox.Items.Clear()
                EditAlbumContribArtistComboBox.DataSource = editConArtDT
                EditAlbumContribArtistComboBox.DisplayMember = "contribArtist"

                editMusGenreAdapter = New MySqlDataAdapter("SELECT DISTINCT musicGenre FROM album_music_table WHERE musicGenre != '';", dbConnect)
                editMusGenreAdapter.Fill(editMusGenreDT)

                AddAlbumMusicGenreComboBox.DataSource = Nothing
                AddAlbumMusicGenreComboBox.Items.Clear()
                AddAlbumMusicGenreComboBox.DataSource = editMusGenreDT
                AddAlbumMusicGenreComboBox.DisplayMember = "musicGenre"

                EditAlbumMusicGenreComboBox.DataSource = Nothing
                EditAlbumMusicGenreComboBox.Items.Clear()
                EditAlbumMusicGenreComboBox.DataSource = editMusGenreDT
                EditAlbumMusicGenreComboBox.DisplayMember = "musicGenre"

                dbConnect.Close()
                afterAdding = False

                SearchViewAlbum.Text = ""
                SearchEditAlbum.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SaveMovieBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveMovieBtn.Click
        Dim editMovie As Boolean = True

        If EditMovieMovieNameTextBox.Text.Trim = "" And EditMoviePriceTextBox.Text.Trim = "" Then
            MsgBox("Blank movie name and movie price.")
            editMovie = False
        ElseIf EditMovieMovieNameTextBox.Text.Trim = "" Then
            MsgBox("Blank movie name.")
            editMovie = False
        ElseIf EditMoviePriceTextBox.Text.Trim = "" Then
            MsgBox("Blank movie price.")
            editMovie = False
        End If

        If Not Regex.Match(EditMoviePriceTextBox.Text, "^[0-9]+(\.[0-9]{1,2})?$", RegexOptions.IgnoreCase).Success And Not EditMoviePriceTextBox.Text.Trim = "" Then
            MsgBox("Invalid movie price.")
            editMovie = False
        End If

        If editMovie = True Then
            Try
                Dim editMovieAdapter As New MySqlDataAdapter
                Dim editMovieDT As New DataTable
                Dim editStrArtAdapter As New MySqlDataAdapter
                Dim editStrArtDT As New DataTable
                Dim editMovGenreAdapter As New MySqlDataAdapter
                Dim editMovGenreDT As New DataTable

                If afterAdding = False Then
                    dbConnect.Open()
                End If
                afterAdding = True

                Dim editMovieCmd As MySqlCommand = New MySqlCommand("UPDATE movie_video_table SET movieName = '" & EditMovieMovieNameTextBox.Text & "', starringArtist = '" & EditMovieStarringArtistComboBox.Text & "', movieGenre = '" & EditMovieMovieGenreComboBox.Text & "', movieDescription = '" & EditMovieMovieDescriptionTextBox.Text & "', price = '" & EditMoviePriceTextBox.Text & "' WHERE productCode = '" & EditMovieProductCodeTextBox.Text & "';", dbConnect)
                Dim editMovieRdr As MySqlDataReader = editMovieCmd.ExecuteReader()
                MsgBox("Successfully edited " & EditMovieProductCodeTextBox.Text & ".")
                editMovieRdr.Close()

                editMovieAdapter = New MySqlDataAdapter("SELECT * FROM movie_video_table;", dbConnect)
                editMovieAdapter.Fill(editMovieDT)

                ListBox4.DataSource = Nothing
                ListBox4.Items.Clear()
                ListBox4.DataSource = editMovieDT
                ListBox4.DisplayMember = "movieName"

                ListBox3.DataSource = Nothing
                ListBox3.Items.Clear()
                ListBox3.DataSource = editMovieDT
                ListBox3.DisplayMember = "movieName"

                editStrArtAdapter = New MySqlDataAdapter("SELECT DISTINCT starringArtist FROM movie_video_table WHERE starringArtist != '';", dbConnect)
                editStrArtAdapter.Fill(editStrArtDT)

                AddMovieStarringArtistComboBox.DataSource = Nothing
                AddMovieStarringArtistComboBox.Items.Clear()
                AddMovieStarringArtistComboBox.DataSource = editStrArtDT
                AddMovieStarringArtistComboBox.DisplayMember = "starringArtist"
                AddMovieStarringArtistComboBox.Text = ""

                EditMovieStarringArtistComboBox.DataSource = Nothing
                EditMovieStarringArtistComboBox.Items.Clear()
                EditMovieStarringArtistComboBox.DataSource = editStrArtDT
                EditMovieStarringArtistComboBox.DisplayMember = "starringArtist"

                editMovGenreAdapter = New MySqlDataAdapter("SELECT DISTINCT movieGenre FROM movie_video_table WHERE movieGenre != '';", dbConnect)
                editMovGenreAdapter.Fill(editMovGenreDT)

                AddMovieMovieGenreComboBox.DataSource = Nothing
                AddMovieMovieGenreComboBox.Items.Clear()
                AddMovieMovieGenreComboBox.DataSource = editMovGenreDT
                AddMovieMovieGenreComboBox.DisplayMember = "movieGenre"

                EditMovieMovieGenreComboBox.DataSource = Nothing
                EditMovieMovieGenreComboBox.Items.Clear()
                EditMovieMovieGenreComboBox.DataSource = editMovGenreDT
                EditMovieMovieGenreComboBox.DisplayMember = "movieGenre"

                dbConnect.Close()
                afterAdding = False

                SearchViewMovie.Text = ""
                SearchEditMovie.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            For Each albumItem As DataRowView In ListBox1.SelectedItems
                EditAlbumProductCodeTextBox.Text = albumItem.Item(1).ToString
                EditAlbumAlbumNameTextBox.Text = albumItem.Item(2).ToString
                EditAlbumContribArtistComboBox.Text = albumItem.Item(3).ToString
                EditAlbumMusicGenreComboBox.Text = albumItem.Item(4).ToString
                EditAlbumNumTracksNumericUpDown.Value = Convert.ToDecimal(albumItem.Item(5))
                EditAlbumPriceTextBox.Text = albumItem.Item(6).ToString
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Try
            For Each albumItem As DataRowView In ListBox2.SelectedItems
                ViewAlbumProductCodeTextBox.Text = albumItem.Item(1).ToString
                ViewAlbumAlbumNameTextBox.Text = albumItem.Item(2).ToString
                ViewAlbumContribArtistTextBox.Text = albumItem.Item(3).ToString
                ViewAlbumMusicGenreTextBox.Text = albumItem.Item(4).ToString
                ViewAlbumNumTracksTextBox.Text = albumItem.Item(5).ToString
                ViewAlbumPriceTextBox.Text = albumItem.Item(6).ToString
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged
        Try
            For Each movieItem As DataRowView In ListBox3.SelectedItems
                EditMovieProductCodeTextBox.Text = movieItem.Item(1).ToString
                EditMovieMovieNameTextBox.Text = movieItem.Item(2).ToString
                EditMovieStarringArtistComboBox.Text = movieItem.Item(3).ToString
                EditMovieMovieGenreComboBox.Text = movieItem.Item(4).ToString
                EditMovieMovieDescriptionTextBox.Text = movieItem.Item(5).ToString
                EditMoviePriceTextBox.Text = movieItem.Item(6).ToString
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox4.SelectedIndexChanged
        Try
            For Each movieItem As DataRowView In ListBox4.SelectedItems
                ViewMovieProductCodeTextBox.Text = movieItem.Item(1).ToString
                ViewMovieMovieNameTextBox.Text = movieItem.Item(2).ToString
                ViewMovieStarringArtistTextBox.Text = movieItem.Item(3).ToString
                ViewMovieMovieGenreTextBox.Text = movieItem.Item(4).ToString
                ViewMovieMovieDescriptionTextBox.Text = movieItem.Item(5).ToString
                ViewMoviePriceTextBox.Text = movieItem.Item(6).ToString
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchViewAlbum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchViewAlbum.TextChanged
        Try
            Dim searchAlbumAdapter As New MySqlDataAdapter
            Dim searchAlbumDT As New DataTable

            If afterAdding = False Then
                dbConnect.Open()
            End If
            afterAdding = True

            searchAlbumAdapter = New MySqlDataAdapter("SELECT * FROM album_music_table WHERE albumName LIKE '%" & SearchViewAlbum.Text & "%';", dbConnect)
            searchAlbumAdapter.Fill(searchAlbumDT)

            ListBox2.DataSource = Nothing
            ListBox2.Items.Clear()
            ListBox2.DataSource = searchAlbumDT
            ListBox2.DisplayMember = "albumName"

            If searchAlbumDT.Rows.Count().Equals(0) Then
                ListBox2.DataSource = Nothing
                ListBox2.Items.Add("No album found.")
                ListBox2.Enabled = False

                ViewAlbumProductCodeTextBox.Text = ""
                ViewAlbumAlbumNameTextBox.Text = ""
                ViewAlbumContribArtistTextBox.Text = ""
                ViewAlbumMusicGenreTextBox.Text = ""
                ViewAlbumNumTracksTextBox.Text = ""
                ViewAlbumPriceTextBox.Text = ""
            Else
                ListBox2.Enabled = True
                ListBox2.Items.Remove("No album found.")
            End If

            dbConnect.Close()
            afterAdding = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchEditAlbum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchEditAlbum.TextChanged
        Try
            Dim searchAlbumAdapter As New MySqlDataAdapter
            Dim searchAlbumDT As New DataTable

            If afterAdding = False Then
                dbConnect.Open()
            End If
            afterAdding = True

            searchAlbumAdapter = New MySqlDataAdapter("SELECT * FROM album_music_table WHERE albumName LIKE '%" & SearchEditAlbum.Text & "%';", dbConnect)
            searchAlbumAdapter.Fill(searchAlbumDT)

            ListBox1.DataSource = Nothing
            ListBox1.Items.Clear()
            ListBox1.DataSource = searchAlbumDT
            ListBox1.DisplayMember = "albumName"

            If searchAlbumDT.Rows.Count().Equals(0) Then
                ListBox1.DataSource = Nothing
                ListBox1.Items.Add("No album found.")
                ListBox1.Enabled = False
                SaveAlbumBtn.Enabled = False

                EditAlbumProductCodeTextBox.Text = ""
                EditAlbumAlbumNameTextBox.Text = ""
                EditAlbumContribArtistComboBox.Text = ""
                EditAlbumMusicGenreComboBox.Text = ""
                EditAlbumNumTracksNumericUpDown.Value = "0"
                EditAlbumPriceTextBox.Text = ""
            Else
                ListBox1.Enabled = True
                SaveAlbumBtn.Enabled = True
                ListBox1.Items.Remove("No album found.")
            End If

            dbConnect.Close()
            afterAdding = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchViewMovie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchViewMovie.TextChanged
        Try
            Dim searchMovieAdapter As New MySqlDataAdapter
            Dim searchMovieDT As New DataTable

            If afterAdding = False Then
                dbConnect.Open()
            End If
            afterAdding = True

            searchMovieAdapter = New MySqlDataAdapter("SELECT * FROM movie_video_table WHERE movieName LIKE '%" & SearchViewMovie.Text & "%';", dbConnect)
            searchMovieAdapter.Fill(searchMovieDT)

            ListBox4.DataSource = Nothing
            ListBox4.Items.Clear()
            ListBox4.DataSource = searchMovieDT
            ListBox4.DisplayMember = "movieName"

            If searchMovieDT.Rows.Count().Equals(0) Then
                ListBox4.DataSource = Nothing
                ListBox4.Items.Add("No movie found.")
                ListBox4.Enabled = False

                ViewMovieProductCodeTextBox.Text = ""
                ViewMovieMovieNameTextBox.Text = ""
                ViewMovieStarringArtistTextBox.Text = ""
                ViewMovieMovieGenreTextBox.Text = ""
                ViewMovieMovieDescriptionTextBox.Text = ""
                ViewMoviePriceTextBox.Text = ""
            Else
                ListBox4.Enabled = True
                ListBox4.Items.Remove("No movie found.")
            End If

            dbConnect.Close()
            afterAdding = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchEditMovie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchEditMovie.TextChanged
        Try
            Dim searchMovieAdapter As New MySqlDataAdapter
            Dim searchMovieDT As New DataTable

            If afterAdding = False Then
                dbConnect.Open()
            End If
            afterAdding = True

            searchMovieAdapter = New MySqlDataAdapter("SELECT * FROM movie_video_table WHERE movieName LIKE '%" & SearchEditMovie.Text & "%';", dbConnect)
            searchMovieAdapter.Fill(searchMovieDT)

            ListBox3.DataSource = Nothing
            ListBox3.Items.Clear()
            ListBox3.DataSource = searchMovieDT
            ListBox3.DisplayMember = "movieName"

            If searchMovieDT.Rows.Count().Equals(0) Then
                ListBox3.DataSource = Nothing
                ListBox3.Items.Add("No movie found.")
                ListBox3.Enabled = False
                SaveMovieBtn.Enabled = False

                EditMovieProductCodeTextBox.Text = ""
                EditMovieMovieNameTextBox.Text = ""
                EditMovieStarringArtistComboBox.Text = ""
                EditMovieMovieGenreComboBox.Text = ""
                EditMovieMovieDescriptionTextBox.Text = ""
                EditMoviePriceTextBox.Text = ""
            Else
                ListBox3.Enabled = True
                SaveMovieBtn.Enabled = True
                ListBox3.Items.Remove("No movie found.")
            End If

            dbConnect.Close()
            afterAdding = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
