<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim AlbumNameLabel As System.Windows.Forms.Label
        Dim ContribArtistLabel As System.Windows.Forms.Label
        Dim MusicGenreLabel As System.Windows.Forms.Label
        Dim NumTracksLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim ProductCodeLabel3 As System.Windows.Forms.Label
        Dim MovieNameLabel As System.Windows.Forms.Label
        Dim StarringArtistLabel As System.Windows.Forms.Label
        Dim MovieGenreLabel As System.Windows.Forms.Label
        Dim MovieDescriptionLabel As System.Windows.Forms.Label
        Dim PriceLabel1 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim Label38 As System.Windows.Forms.Label
        Dim Label39 As System.Windows.Forms.Label
        Dim Label40 As System.Windows.Forms.Label
        Dim Label41 As System.Windows.Forms.Label
        Dim Label42 As System.Windows.Forms.Label
        Dim Label43 As System.Windows.Forms.Label
        Dim Label44 As System.Windows.Forms.Label
        Dim Label45 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.albumsTab = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.viewAlbumTab = New System.Windows.Forms.TabPage()
        Me.SearchViewAlbum = New System.Windows.Forms.TextBox()
        Me.ViewAlbumProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ViewAlbumNumTracksTextBox = New System.Windows.Forms.TextBox()
        Me.ViewAlbumMusicGenreTextBox = New System.Windows.Forms.TextBox()
        Me.ViewAlbumAlbumNameTextBox = New System.Windows.Forms.TextBox()
        Me.ViewAlbumContribArtistTextBox = New System.Windows.Forms.TextBox()
        Me.ViewAlbumPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.addAlbumTab = New System.Windows.Forms.TabPage()
        Me.AddAlbumMusicGenreComboBox = New System.Windows.Forms.ComboBox()
        Me.AddAlbumContribArtistComboBox = New System.Windows.Forms.ComboBox()
        Me.AddAlbumProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddAlbumAlbumNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResetAlbumBtn = New System.Windows.Forms.Button()
        Me.AddAlbumBtn = New System.Windows.Forms.Button()
        Me.AddAlbumNumTracksNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AddAlbumPriceTextBox = New System.Windows.Forms.TextBox()
        Me.editAlbumTab = New System.Windows.Forms.TabPage()
        Me.EditAlbumMusicGenreComboBox = New System.Windows.Forms.ComboBox()
        Me.EditAlbumContribArtistComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchEditAlbum = New System.Windows.Forms.TextBox()
        Me.EditAlbumProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SaveAlbumBtn = New System.Windows.Forms.Button()
        Me.EditAlbumAlbumNameTextBox = New System.Windows.Forms.TextBox()
        Me.EditAlbumNumTracksNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.EditAlbumPriceTextBox = New System.Windows.Forms.TextBox()
        Me.moviesTab = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.viewMovieTab = New System.Windows.Forms.TabPage()
        Me.SearchViewMovie = New System.Windows.Forms.TextBox()
        Me.ViewMovieProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ViewMovieMovieGenreTextBox = New System.Windows.Forms.TextBox()
        Me.ViewMovieMovieNameTextBox = New System.Windows.Forms.TextBox()
        Me.ViewMovieStarringArtistTextBox = New System.Windows.Forms.TextBox()
        Me.ViewMovieMovieDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ViewMoviePriceTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.addMovieTab = New System.Windows.Forms.TabPage()
        Me.AddMovieMovieGenreComboBox = New System.Windows.Forms.ComboBox()
        Me.AddMovieStarringArtistComboBox = New System.Windows.Forms.ComboBox()
        Me.AddMovieProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ResetMovieBtn = New System.Windows.Forms.Button()
        Me.AddMovieBtn = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.AddMovieMovieNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddMovieMovieDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AddMoviePriceTextBox = New System.Windows.Forms.TextBox()
        Me.editMovieTab = New System.Windows.Forms.TabPage()
        Me.EditMovieMovieGenreComboBox = New System.Windows.Forms.ComboBox()
        Me.EditMovieStarringArtistComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchEditMovie = New System.Windows.Forms.TextBox()
        Me.EditMovieProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SaveMovieBtn = New System.Windows.Forms.Button()
        Me.EditMovieMovieNameTextBox = New System.Windows.Forms.TextBox()
        Me.EditMovieMovieDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.EditMoviePriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        ProductCodeLabel = New System.Windows.Forms.Label()
        AlbumNameLabel = New System.Windows.Forms.Label()
        ContribArtistLabel = New System.Windows.Forms.Label()
        MusicGenreLabel = New System.Windows.Forms.Label()
        NumTracksLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        ProductCodeLabel3 = New System.Windows.Forms.Label()
        MovieNameLabel = New System.Windows.Forms.Label()
        StarringArtistLabel = New System.Windows.Forms.Label()
        MovieGenreLabel = New System.Windows.Forms.Label()
        MovieDescriptionLabel = New System.Windows.Forms.Label()
        PriceLabel1 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label35 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        Label38 = New System.Windows.Forms.Label()
        Label39 = New System.Windows.Forms.Label()
        Label40 = New System.Windows.Forms.Label()
        Label41 = New System.Windows.Forms.Label()
        Label42 = New System.Windows.Forms.Label()
        Label43 = New System.Windows.Forms.Label()
        Label44 = New System.Windows.Forms.Label()
        Label45 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.albumsTab.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.viewAlbumTab.SuspendLayout()
        Me.addAlbumTab.SuspendLayout()
        CType(Me.AddAlbumNumTracksNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.editAlbumTab.SuspendLayout()
        CType(Me.EditAlbumNumTracksNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.moviesTab.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.viewMovieTab.SuspendLayout()
        Me.addMovieTab.SuspendLayout()
        Me.editMovieTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.AutoSize = True
        ProductCodeLabel.Location = New System.Drawing.Point(229, 19)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(83, 15)
        ProductCodeLabel.TabIndex = 0
        ProductCodeLabel.Text = "Product Code:"
        ProductCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AlbumNameLabel
        '
        AlbumNameLabel.AutoSize = True
        AlbumNameLabel.Location = New System.Drawing.Point(233, 48)
        AlbumNameLabel.Name = "AlbumNameLabel"
        AlbumNameLabel.Size = New System.Drawing.Size(79, 15)
        AlbumNameLabel.TabIndex = 2
        AlbumNameLabel.Text = "Album Name:"
        AlbumNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContribArtistLabel
        '
        ContribArtistLabel.AutoSize = True
        ContribArtistLabel.Location = New System.Drawing.Point(202, 78)
        ContribArtistLabel.Name = "ContribArtistLabel"
        ContribArtistLabel.Size = New System.Drawing.Size(110, 15)
        ContribArtistLabel.TabIndex = 4
        ContribArtistLabel.Text = "Contributing Artist:"
        ContribArtistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MusicGenreLabel
        '
        MusicGenreLabel.AutoSize = True
        MusicGenreLabel.Location = New System.Drawing.Point(233, 106)
        MusicGenreLabel.Name = "MusicGenreLabel"
        MusicGenreLabel.Size = New System.Drawing.Size(79, 15)
        MusicGenreLabel.TabIndex = 6
        MusicGenreLabel.Text = "Music Genre:"
        MusicGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumTracksLabel
        '
        NumTracksLabel.AutoSize = True
        NumTracksLabel.Location = New System.Drawing.Point(207, 135)
        NumTracksLabel.Name = "NumTracksLabel"
        NumTracksLabel.Size = New System.Drawing.Size(105, 15)
        NumTracksLabel.TabIndex = 8
        NumTracksLabel.Text = "Number of Tracks:"
        NumTracksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(217, 163)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(95, 15)
        PriceLabel.TabIndex = 10
        PriceLabel.Text = "Price (in Pesos):"
        PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(229, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 15)
        Label1.TabIndex = 28
        Label1.Text = "Product Code:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(233, 48)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(79, 15)
        Label3.TabIndex = 30
        Label3.Text = "Album Name:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(202, 78)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(110, 15)
        Label4.TabIndex = 32
        Label4.Text = "Contributing Artist:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(233, 106)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(79, 15)
        Label5.TabIndex = 34
        Label5.Text = "Music Genre:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(207, 135)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(105, 15)
        Label6.TabIndex = 36
        Label6.Text = "Number of Tracks:"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(217, 163)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(95, 15)
        Label7.TabIndex = 38
        Label7.Text = "Price (in Pesos):"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(233, 48)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(79, 15)
        Label18.TabIndex = 77
        Label18.Text = "Album Name:"
        Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(229, 19)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(83, 15)
        Label20.TabIndex = 76
        Label20.Text = "Product Code:"
        Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(202, 78)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(110, 15)
        Label21.TabIndex = 78
        Label21.Text = "Contributing Artist:"
        Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(233, 106)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(79, 15)
        Label22.TabIndex = 79
        Label22.Text = "Music Genre:"
        Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(207, 135)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(105, 15)
        Label23.TabIndex = 80
        Label23.Text = "Number of Tracks:"
        Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(217, 163)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(95, 15)
        Label24.TabIndex = 81
        Label24.Text = "Price (in Pesos):"
        Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductCodeLabel3
        '
        ProductCodeLabel3.AutoSize = True
        ProductCodeLabel3.Location = New System.Drawing.Point(232, 16)
        ProductCodeLabel3.Name = "ProductCodeLabel3"
        ProductCodeLabel3.Size = New System.Drawing.Size(83, 15)
        ProductCodeLabel3.TabIndex = 0
        ProductCodeLabel3.Text = "Product Code:"
        '
        'MovieNameLabel
        '
        MovieNameLabel.AutoSize = True
        MovieNameLabel.Location = New System.Drawing.Point(237, 45)
        MovieNameLabel.Name = "MovieNameLabel"
        MovieNameLabel.Size = New System.Drawing.Size(78, 15)
        MovieNameLabel.TabIndex = 2
        MovieNameLabel.Text = "Movie Name:"
        '
        'StarringArtistLabel
        '
        StarringArtistLabel.AutoSize = True
        StarringArtistLabel.Location = New System.Drawing.Point(229, 73)
        StarringArtistLabel.Name = "StarringArtistLabel"
        StarringArtistLabel.Size = New System.Drawing.Size(86, 15)
        StarringArtistLabel.TabIndex = 4
        StarringArtistLabel.Text = "Starring Artist:"
        '
        'MovieGenreLabel
        '
        MovieGenreLabel.AutoSize = True
        MovieGenreLabel.Location = New System.Drawing.Point(236, 102)
        MovieGenreLabel.Name = "MovieGenreLabel"
        MovieGenreLabel.Size = New System.Drawing.Size(79, 15)
        MovieGenreLabel.TabIndex = 6
        MovieGenreLabel.Text = "Movie Genre:"
        '
        'MovieDescriptionLabel
        '
        MovieDescriptionLabel.AutoSize = True
        MovieDescriptionLabel.Location = New System.Drawing.Point(205, 132)
        MovieDescriptionLabel.Name = "MovieDescriptionLabel"
        MovieDescriptionLabel.Size = New System.Drawing.Size(110, 15)
        MovieDescriptionLabel.TabIndex = 8
        MovieDescriptionLabel.Text = "Movie Description:"
        '
        'PriceLabel1
        '
        PriceLabel1.AutoSize = True
        PriceLabel1.Location = New System.Drawing.Point(220, 199)
        PriceLabel1.Name = "PriceLabel1"
        PriceLabel1.Size = New System.Drawing.Size(95, 15)
        PriceLabel1.TabIndex = 10
        PriceLabel1.Text = "Price (in Pesos):"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(232, 16)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(83, 15)
        Label25.TabIndex = 63
        Label25.Text = "Product Code:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(237, 45)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(78, 15)
        Label26.TabIndex = 64
        Label26.Text = "Movie Name:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(229, 73)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(86, 15)
        Label27.TabIndex = 65
        Label27.Text = "Starring Artist:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Location = New System.Drawing.Point(236, 102)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(79, 15)
        Label28.TabIndex = 66
        Label28.Text = "Movie Genre:"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Location = New System.Drawing.Point(205, 132)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(110, 15)
        Label29.TabIndex = 67
        Label29.Text = "Movie Description:"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Location = New System.Drawing.Point(219, 241)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(95, 15)
        Label30.TabIndex = 68
        Label30.Text = "Price (in Pesos):"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Location = New System.Drawing.Point(232, 16)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(83, 15)
        Label35.TabIndex = 53
        Label35.Text = "Product Code:"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Location = New System.Drawing.Point(237, 45)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(78, 15)
        Label37.TabIndex = 55
        Label37.Text = "Movie Name:"
        '
        'Label38
        '
        Label38.AutoSize = True
        Label38.Location = New System.Drawing.Point(229, 73)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(86, 15)
        Label38.TabIndex = 57
        Label38.Text = "Starring Artist:"
        '
        'Label39
        '
        Label39.AutoSize = True
        Label39.Location = New System.Drawing.Point(236, 102)
        Label39.Name = "Label39"
        Label39.Size = New System.Drawing.Size(79, 15)
        Label39.TabIndex = 59
        Label39.Text = "Movie Genre:"
        '
        'Label40
        '
        Label40.AutoSize = True
        Label40.Location = New System.Drawing.Point(205, 132)
        Label40.Name = "Label40"
        Label40.Size = New System.Drawing.Size(110, 15)
        Label40.TabIndex = 61
        Label40.Text = "Movie Description:"
        '
        'Label41
        '
        Label41.AutoSize = True
        Label41.Location = New System.Drawing.Point(220, 199)
        Label41.Name = "Label41"
        Label41.Size = New System.Drawing.Size(95, 15)
        Label41.TabIndex = 63
        Label41.Text = "Price (in Pesos):"
        '
        'Label42
        '
        Label42.AutoSize = True
        Label42.Location = New System.Drawing.Point(15, 22)
        Label42.Name = "Label42"
        Label42.Size = New System.Drawing.Size(44, 15)
        Label42.TabIndex = 92
        Label42.Text = "Search"
        Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Label43.AutoSize = True
        Label43.Location = New System.Drawing.Point(15, 22)
        Label43.Name = "Label43"
        Label43.Size = New System.Drawing.Size(44, 15)
        Label43.TabIndex = 95
        Label43.Text = "Search"
        Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label44
        '
        Label44.AutoSize = True
        Label44.Location = New System.Drawing.Point(15, 22)
        Label44.Name = "Label44"
        Label44.Size = New System.Drawing.Size(44, 15)
        Label44.TabIndex = 97
        Label44.Text = "Search"
        Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Label45.AutoSize = True
        Label45.Location = New System.Drawing.Point(15, 22)
        Label45.Name = "Label45"
        Label45.Size = New System.Drawing.Size(44, 15)
        Label45.TabIndex = 99
        Label45.Text = "Search"
        Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.albumsTab)
        Me.TabControl1.Controls.Add(Me.moviesTab)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(553, 357)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'albumsTab
        '
        Me.albumsTab.BackColor = System.Drawing.SystemColors.Control
        Me.albumsTab.Controls.Add(Me.TabControl2)
        Me.albumsTab.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.albumsTab.Location = New System.Drawing.Point(4, 32)
        Me.albumsTab.Name = "albumsTab"
        Me.albumsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.albumsTab.Size = New System.Drawing.Size(545, 321)
        Me.albumsTab.TabIndex = 0
        Me.albumsTab.Text = "Albums"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.viewAlbumTab)
        Me.TabControl2.Controls.Add(Me.addAlbumTab)
        Me.TabControl2.Controls.Add(Me.editAlbumTab)
        Me.TabControl2.Location = New System.Drawing.Point(4, 7)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(538, 311)
        Me.TabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl2.TabIndex = 0
        '
        'viewAlbumTab
        '
        Me.viewAlbumTab.AutoScroll = True
        Me.viewAlbumTab.Controls.Add(Label42)
        Me.viewAlbumTab.Controls.Add(Me.SearchViewAlbum)
        Me.viewAlbumTab.Controls.Add(Me.ViewAlbumProductCodeTextBox)
        Me.viewAlbumTab.Controls.Add(Me.ViewAlbumNumTracksTextBox)
        Me.viewAlbumTab.Controls.Add(Me.ViewAlbumMusicGenreTextBox)
        Me.viewAlbumTab.Controls.Add(Me.ViewAlbumAlbumNameTextBox)
        Me.viewAlbumTab.Controls.Add(Me.ViewAlbumContribArtistTextBox)
        Me.viewAlbumTab.Controls.Add(Me.ViewAlbumPriceTextBox)
        Me.viewAlbumTab.Controls.Add(Label18)
        Me.viewAlbumTab.Controls.Add(Label20)
        Me.viewAlbumTab.Controls.Add(Label21)
        Me.viewAlbumTab.Controls.Add(Label22)
        Me.viewAlbumTab.Controls.Add(Label23)
        Me.viewAlbumTab.Controls.Add(Label24)
        Me.viewAlbumTab.Controls.Add(Me.ListBox2)
        Me.viewAlbumTab.Location = New System.Drawing.Point(4, 24)
        Me.viewAlbumTab.Name = "viewAlbumTab"
        Me.viewAlbumTab.Padding = New System.Windows.Forms.Padding(3)
        Me.viewAlbumTab.Size = New System.Drawing.Size(530, 283)
        Me.viewAlbumTab.TabIndex = 0
        Me.viewAlbumTab.Text = "View Albums"
        Me.viewAlbumTab.UseVisualStyleBackColor = True
        '
        'SearchViewAlbum
        '
        Me.SearchViewAlbum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchViewAlbum.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchViewAlbum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SearchViewAlbum.Location = New System.Drawing.Point(65, 19)
        Me.SearchViewAlbum.Name = "SearchViewAlbum"
        Me.SearchViewAlbum.Size = New System.Drawing.Size(121, 21)
        Me.SearchViewAlbum.TabIndex = 91
        '
        'ViewAlbumProductCodeTextBox
        '
        Me.ViewAlbumProductCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewAlbumProductCodeTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAlbumProductCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewAlbumProductCodeTextBox.Location = New System.Drawing.Point(328, 16)
        Me.ViewAlbumProductCodeTextBox.Name = "ViewAlbumProductCodeTextBox"
        Me.ViewAlbumProductCodeTextBox.ReadOnly = True
        Me.ViewAlbumProductCodeTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewAlbumProductCodeTextBox.TabIndex = 90
        '
        'ViewAlbumNumTracksTextBox
        '
        Me.ViewAlbumNumTracksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewAlbumNumTracksTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAlbumNumTracksTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewAlbumNumTracksTextBox.Location = New System.Drawing.Point(328, 131)
        Me.ViewAlbumNumTracksTextBox.Name = "ViewAlbumNumTracksTextBox"
        Me.ViewAlbumNumTracksTextBox.ReadOnly = True
        Me.ViewAlbumNumTracksTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewAlbumNumTracksTextBox.TabIndex = 89
        '
        'ViewAlbumMusicGenreTextBox
        '
        Me.ViewAlbumMusicGenreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewAlbumMusicGenreTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAlbumMusicGenreTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewAlbumMusicGenreTextBox.Location = New System.Drawing.Point(328, 103)
        Me.ViewAlbumMusicGenreTextBox.Name = "ViewAlbumMusicGenreTextBox"
        Me.ViewAlbumMusicGenreTextBox.ReadOnly = True
        Me.ViewAlbumMusicGenreTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewAlbumMusicGenreTextBox.TabIndex = 88
        '
        'ViewAlbumAlbumNameTextBox
        '
        Me.ViewAlbumAlbumNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewAlbumAlbumNameTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAlbumAlbumNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewAlbumAlbumNameTextBox.Location = New System.Drawing.Point(328, 44)
        Me.ViewAlbumAlbumNameTextBox.Name = "ViewAlbumAlbumNameTextBox"
        Me.ViewAlbumAlbumNameTextBox.ReadOnly = True
        Me.ViewAlbumAlbumNameTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewAlbumAlbumNameTextBox.TabIndex = 83
        '
        'ViewAlbumContribArtistTextBox
        '
        Me.ViewAlbumContribArtistTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewAlbumContribArtistTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAlbumContribArtistTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewAlbumContribArtistTextBox.Location = New System.Drawing.Point(328, 73)
        Me.ViewAlbumContribArtistTextBox.Name = "ViewAlbumContribArtistTextBox"
        Me.ViewAlbumContribArtistTextBox.ReadOnly = True
        Me.ViewAlbumContribArtistTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewAlbumContribArtistTextBox.TabIndex = 84
        '
        'ViewAlbumPriceTextBox
        '
        Me.ViewAlbumPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewAlbumPriceTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAlbumPriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewAlbumPriceTextBox.Location = New System.Drawing.Point(328, 160)
        Me.ViewAlbumPriceTextBox.Name = "ViewAlbumPriceTextBox"
        Me.ViewAlbumPriceTextBox.ReadOnly = True
        Me.ViewAlbumPriceTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewAlbumPriceTextBox.TabIndex = 87
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.ForeColor = System.Drawing.Color.DarkViolet
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(16, 50)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(170, 214)
        Me.ListBox2.TabIndex = 60
        '
        'addAlbumTab
        '
        Me.addAlbumTab.AutoScroll = True
        Me.addAlbumTab.Controls.Add(Me.AddAlbumMusicGenreComboBox)
        Me.addAlbumTab.Controls.Add(Me.AddAlbumContribArtistComboBox)
        Me.addAlbumTab.Controls.Add(Me.AddAlbumProductCodeTextBox)
        Me.addAlbumTab.Controls.Add(Me.Label13)
        Me.addAlbumTab.Controls.Add(Me.Label14)
        Me.addAlbumTab.Controls.Add(Me.Label8)
        Me.addAlbumTab.Controls.Add(AlbumNameLabel)
        Me.addAlbumTab.Controls.Add(Me.AddAlbumAlbumNameTextBox)
        Me.addAlbumTab.Controls.Add(Me.Label2)
        Me.addAlbumTab.Controls.Add(ProductCodeLabel)
        Me.addAlbumTab.Controls.Add(Me.ResetAlbumBtn)
        Me.addAlbumTab.Controls.Add(Me.AddAlbumBtn)
        Me.addAlbumTab.Controls.Add(ContribArtistLabel)
        Me.addAlbumTab.Controls.Add(MusicGenreLabel)
        Me.addAlbumTab.Controls.Add(NumTracksLabel)
        Me.addAlbumTab.Controls.Add(Me.AddAlbumNumTracksNumericUpDown)
        Me.addAlbumTab.Controls.Add(PriceLabel)
        Me.addAlbumTab.Controls.Add(Me.AddAlbumPriceTextBox)
        Me.addAlbumTab.Location = New System.Drawing.Point(4, 24)
        Me.addAlbumTab.Name = "addAlbumTab"
        Me.addAlbumTab.Padding = New System.Windows.Forms.Padding(3)
        Me.addAlbumTab.Size = New System.Drawing.Size(530, 283)
        Me.addAlbumTab.TabIndex = 1
        Me.addAlbumTab.Text = "Add Albums"
        Me.addAlbumTab.UseVisualStyleBackColor = True
        '
        'AddAlbumMusicGenreComboBox
        '
        Me.AddAlbumMusicGenreComboBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAlbumMusicGenreComboBox.FormattingEnabled = True
        Me.AddAlbumMusicGenreComboBox.Location = New System.Drawing.Point(328, 102)
        Me.AddAlbumMusicGenreComboBox.Name = "AddAlbumMusicGenreComboBox"
        Me.AddAlbumMusicGenreComboBox.Size = New System.Drawing.Size(185, 23)
        Me.AddAlbumMusicGenreComboBox.TabIndex = 95
        '
        'AddAlbumContribArtistComboBox
        '
        Me.AddAlbumContribArtistComboBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAlbumContribArtistComboBox.FormattingEnabled = True
        Me.AddAlbumContribArtistComboBox.Location = New System.Drawing.Point(328, 73)
        Me.AddAlbumContribArtistComboBox.Name = "AddAlbumContribArtistComboBox"
        Me.AddAlbumContribArtistComboBox.Size = New System.Drawing.Size(185, 23)
        Me.AddAlbumContribArtistComboBox.TabIndex = 94
        '
        'AddAlbumProductCodeTextBox
        '
        Me.AddAlbumProductCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddAlbumProductCodeTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAlbumProductCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddAlbumProductCodeTextBox.Location = New System.Drawing.Point(328, 16)
        Me.AddAlbumProductCodeTextBox.MaxLength = 8
        Me.AddAlbumProductCodeTextBox.Name = "AddAlbumProductCodeTextBox"
        Me.AddAlbumProductCodeTextBox.ReadOnly = True
        Me.AddAlbumProductCodeTextBox.Size = New System.Drawing.Size(185, 21)
        Me.AddAlbumProductCodeTextBox.TabIndex = 91
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(421, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 14)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "required fields"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(495, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 15)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(309, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "*"
        '
        'AddAlbumAlbumNameTextBox
        '
        Me.AddAlbumAlbumNameTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAlbumAlbumNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddAlbumAlbumNameTextBox.Location = New System.Drawing.Point(328, 44)
        Me.AddAlbumAlbumNameTextBox.MaxLength = 200
        Me.AddAlbumAlbumNameTextBox.Name = "AddAlbumAlbumNameTextBox"
        Me.AddAlbumAlbumNameTextBox.Size = New System.Drawing.Size(185, 21)
        Me.AddAlbumAlbumNameTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(309, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "*"
        '
        'ResetAlbumBtn
        '
        Me.ResetAlbumBtn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetAlbumBtn.Location = New System.Drawing.Point(378, 202)
        Me.ResetAlbumBtn.Name = "ResetAlbumBtn"
        Me.ResetAlbumBtn.Size = New System.Drawing.Size(57, 25)
        Me.ResetAlbumBtn.TabIndex = 26
        Me.ResetAlbumBtn.Text = "RESET"
        Me.ResetAlbumBtn.UseVisualStyleBackColor = True
        '
        'AddAlbumBtn
        '
        Me.AddAlbumBtn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAlbumBtn.Location = New System.Drawing.Point(441, 196)
        Me.AddAlbumBtn.Name = "AddAlbumBtn"
        Me.AddAlbumBtn.Size = New System.Drawing.Size(72, 33)
        Me.AddAlbumBtn.TabIndex = 25
        Me.AddAlbumBtn.Text = "ADD"
        Me.AddAlbumBtn.UseVisualStyleBackColor = True
        '
        'AddAlbumNumTracksNumericUpDown
        '
        Me.AddAlbumNumTracksNumericUpDown.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAlbumNumTracksNumericUpDown.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddAlbumNumTracksNumericUpDown.Location = New System.Drawing.Point(328, 131)
        Me.AddAlbumNumTracksNumericUpDown.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.AddAlbumNumTracksNumericUpDown.Name = "AddAlbumNumTracksNumericUpDown"
        Me.AddAlbumNumTracksNumericUpDown.Size = New System.Drawing.Size(185, 21)
        Me.AddAlbumNumTracksNumericUpDown.TabIndex = 9
        '
        'AddAlbumPriceTextBox
        '
        Me.AddAlbumPriceTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAlbumPriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddAlbumPriceTextBox.Location = New System.Drawing.Point(328, 160)
        Me.AddAlbumPriceTextBox.MaxLength = 8
        Me.AddAlbumPriceTextBox.Name = "AddAlbumPriceTextBox"
        Me.AddAlbumPriceTextBox.Size = New System.Drawing.Size(185, 21)
        Me.AddAlbumPriceTextBox.TabIndex = 11
        '
        'editAlbumTab
        '
        Me.editAlbumTab.Controls.Add(Me.EditAlbumMusicGenreComboBox)
        Me.editAlbumTab.Controls.Add(Me.EditAlbumContribArtistComboBox)
        Me.editAlbumTab.Controls.Add(Label43)
        Me.editAlbumTab.Controls.Add(Me.SearchEditAlbum)
        Me.editAlbumTab.Controls.Add(Me.EditAlbumProductCodeTextBox)
        Me.editAlbumTab.Controls.Add(Me.Label12)
        Me.editAlbumTab.Controls.Add(Me.Label11)
        Me.editAlbumTab.Controls.Add(Label7)
        Me.editAlbumTab.Controls.Add(Me.Label10)
        Me.editAlbumTab.Controls.Add(Me.Label9)
        Me.editAlbumTab.Controls.Add(Me.ListBox1)
        Me.editAlbumTab.Controls.Add(Me.SaveAlbumBtn)
        Me.editAlbumTab.Controls.Add(Label1)
        Me.editAlbumTab.Controls.Add(Label3)
        Me.editAlbumTab.Controls.Add(Me.EditAlbumAlbumNameTextBox)
        Me.editAlbumTab.Controls.Add(Label4)
        Me.editAlbumTab.Controls.Add(Label5)
        Me.editAlbumTab.Controls.Add(Label6)
        Me.editAlbumTab.Controls.Add(Me.EditAlbumNumTracksNumericUpDown)
        Me.editAlbumTab.Controls.Add(Me.EditAlbumPriceTextBox)
        Me.editAlbumTab.Location = New System.Drawing.Point(4, 24)
        Me.editAlbumTab.Name = "editAlbumTab"
        Me.editAlbumTab.Padding = New System.Windows.Forms.Padding(3)
        Me.editAlbumTab.Size = New System.Drawing.Size(530, 283)
        Me.editAlbumTab.TabIndex = 2
        Me.editAlbumTab.Text = "Edit Albums"
        Me.editAlbumTab.UseVisualStyleBackColor = True
        '
        'EditAlbumMusicGenreComboBox
        '
        Me.EditAlbumMusicGenreComboBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAlbumMusicGenreComboBox.FormattingEnabled = True
        Me.EditAlbumMusicGenreComboBox.Location = New System.Drawing.Point(328, 102)
        Me.EditAlbumMusicGenreComboBox.Name = "EditAlbumMusicGenreComboBox"
        Me.EditAlbumMusicGenreComboBox.Size = New System.Drawing.Size(185, 23)
        Me.EditAlbumMusicGenreComboBox.TabIndex = 97
        '
        'EditAlbumContribArtistComboBox
        '
        Me.EditAlbumContribArtistComboBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAlbumContribArtistComboBox.FormattingEnabled = True
        Me.EditAlbumContribArtistComboBox.Location = New System.Drawing.Point(328, 73)
        Me.EditAlbumContribArtistComboBox.Name = "EditAlbumContribArtistComboBox"
        Me.EditAlbumContribArtistComboBox.Size = New System.Drawing.Size(185, 23)
        Me.EditAlbumContribArtistComboBox.TabIndex = 96
        '
        'SearchEditAlbum
        '
        Me.SearchEditAlbum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchEditAlbum.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchEditAlbum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SearchEditAlbum.Location = New System.Drawing.Point(65, 19)
        Me.SearchEditAlbum.Name = "SearchEditAlbum"
        Me.SearchEditAlbum.Size = New System.Drawing.Size(121, 21)
        Me.SearchEditAlbum.TabIndex = 94
        '
        'EditAlbumProductCodeTextBox
        '
        Me.EditAlbumProductCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EditAlbumProductCodeTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAlbumProductCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EditAlbumProductCodeTextBox.Location = New System.Drawing.Point(328, 16)
        Me.EditAlbumProductCodeTextBox.MaxLength = 8
        Me.EditAlbumProductCodeTextBox.Name = "EditAlbumProductCodeTextBox"
        Me.EditAlbumProductCodeTextBox.ReadOnly = True
        Me.EditAlbumProductCodeTextBox.Size = New System.Drawing.Size(185, 21)
        Me.EditAlbumProductCodeTextBox.TabIndex = 91
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(421, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 14)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "required fields"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(495, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 15)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(309, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 15)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(309, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 15)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "*"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.DarkViolet
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(16, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(170, 214)
        Me.ListBox1.TabIndex = 42
        '
        'SaveAlbumBtn
        '
        Me.SaveAlbumBtn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAlbumBtn.Location = New System.Drawing.Point(386, 192)
        Me.SaveAlbumBtn.Name = "SaveAlbumBtn"
        Me.SaveAlbumBtn.Size = New System.Drawing.Size(127, 33)
        Me.SaveAlbumBtn.TabIndex = 40
        Me.SaveAlbumBtn.Text = "SAVE CHANGES"
        Me.SaveAlbumBtn.UseVisualStyleBackColor = True
        '
        'EditAlbumAlbumNameTextBox
        '
        Me.EditAlbumAlbumNameTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAlbumAlbumNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EditAlbumAlbumNameTextBox.Location = New System.Drawing.Point(328, 44)
        Me.EditAlbumAlbumNameTextBox.MaxLength = 200
        Me.EditAlbumAlbumNameTextBox.Name = "EditAlbumAlbumNameTextBox"
        Me.EditAlbumAlbumNameTextBox.Size = New System.Drawing.Size(185, 21)
        Me.EditAlbumAlbumNameTextBox.TabIndex = 31
        '
        'EditAlbumNumTracksNumericUpDown
        '
        Me.EditAlbumNumTracksNumericUpDown.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAlbumNumTracksNumericUpDown.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EditAlbumNumTracksNumericUpDown.Location = New System.Drawing.Point(328, 131)
        Me.EditAlbumNumTracksNumericUpDown.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.EditAlbumNumTracksNumericUpDown.Name = "EditAlbumNumTracksNumericUpDown"
        Me.EditAlbumNumTracksNumericUpDown.Size = New System.Drawing.Size(185, 21)
        Me.EditAlbumNumTracksNumericUpDown.TabIndex = 37
        '
        'EditAlbumPriceTextBox
        '
        Me.EditAlbumPriceTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAlbumPriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EditAlbumPriceTextBox.Location = New System.Drawing.Point(328, 160)
        Me.EditAlbumPriceTextBox.MaxLength = 8
        Me.EditAlbumPriceTextBox.Name = "EditAlbumPriceTextBox"
        Me.EditAlbumPriceTextBox.Size = New System.Drawing.Size(185, 21)
        Me.EditAlbumPriceTextBox.TabIndex = 39
        '
        'moviesTab
        '
        Me.moviesTab.BackColor = System.Drawing.SystemColors.Control
        Me.moviesTab.Controls.Add(Me.TabControl3)
        Me.moviesTab.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moviesTab.Location = New System.Drawing.Point(4, 32)
        Me.moviesTab.Name = "moviesTab"
        Me.moviesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.moviesTab.Size = New System.Drawing.Size(545, 321)
        Me.moviesTab.TabIndex = 1
        Me.moviesTab.Text = "Movies"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.viewMovieTab)
        Me.TabControl3.Controls.Add(Me.addMovieTab)
        Me.TabControl3.Controls.Add(Me.editMovieTab)
        Me.TabControl3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(4, 7)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(538, 311)
        Me.TabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl3.TabIndex = 1
        '
        'viewMovieTab
        '
        Me.viewMovieTab.AutoScroll = True
        Me.viewMovieTab.Controls.Add(Label45)
        Me.viewMovieTab.Controls.Add(Me.SearchViewMovie)
        Me.viewMovieTab.Controls.Add(Me.ViewMovieProductCodeTextBox)
        Me.viewMovieTab.Controls.Add(Me.ViewMovieMovieGenreTextBox)
        Me.viewMovieTab.Controls.Add(Me.ViewMovieMovieNameTextBox)
        Me.viewMovieTab.Controls.Add(Me.ViewMovieStarringArtistTextBox)
        Me.viewMovieTab.Controls.Add(Me.ViewMovieMovieDescriptionTextBox)
        Me.viewMovieTab.Controls.Add(Me.ViewMoviePriceTextBox)
        Me.viewMovieTab.Controls.Add(Label25)
        Me.viewMovieTab.Controls.Add(Label26)
        Me.viewMovieTab.Controls.Add(Label27)
        Me.viewMovieTab.Controls.Add(Label28)
        Me.viewMovieTab.Controls.Add(Label29)
        Me.viewMovieTab.Controls.Add(Label30)
        Me.viewMovieTab.Controls.Add(Me.ListBox4)
        Me.viewMovieTab.Location = New System.Drawing.Point(4, 24)
        Me.viewMovieTab.Name = "viewMovieTab"
        Me.viewMovieTab.Padding = New System.Windows.Forms.Padding(3)
        Me.viewMovieTab.Size = New System.Drawing.Size(530, 283)
        Me.viewMovieTab.TabIndex = 0
        Me.viewMovieTab.Text = "View Movies"
        Me.viewMovieTab.UseVisualStyleBackColor = True
        '
        'SearchViewMovie
        '
        Me.SearchViewMovie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchViewMovie.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchViewMovie.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SearchViewMovie.Location = New System.Drawing.Point(65, 19)
        Me.SearchViewMovie.Name = "SearchViewMovie"
        Me.SearchViewMovie.Size = New System.Drawing.Size(121, 21)
        Me.SearchViewMovie.TabIndex = 98
        '
        'ViewMovieProductCodeTextBox
        '
        Me.ViewMovieProductCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewMovieProductCodeTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMovieProductCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewMovieProductCodeTextBox.Location = New System.Drawing.Point(328, 13)
        Me.ViewMovieProductCodeTextBox.Name = "ViewMovieProductCodeTextBox"
        Me.ViewMovieProductCodeTextBox.ReadOnly = True
        Me.ViewMovieProductCodeTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewMovieProductCodeTextBox.TabIndex = 76
        '
        'ViewMovieMovieGenreTextBox
        '
        Me.ViewMovieMovieGenreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewMovieMovieGenreTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMovieMovieGenreTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewMovieMovieGenreTextBox.Location = New System.Drawing.Point(328, 99)
        Me.ViewMovieMovieGenreTextBox.Name = "ViewMovieMovieGenreTextBox"
        Me.ViewMovieMovieGenreTextBox.ReadOnly = True
        Me.ViewMovieMovieGenreTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewMovieMovieGenreTextBox.TabIndex = 75
        '
        'ViewMovieMovieNameTextBox
        '
        Me.ViewMovieMovieNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewMovieMovieNameTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMovieMovieNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewMovieMovieNameTextBox.Location = New System.Drawing.Point(328, 43)
        Me.ViewMovieMovieNameTextBox.Name = "ViewMovieMovieNameTextBox"
        Me.ViewMovieMovieNameTextBox.ReadOnly = True
        Me.ViewMovieMovieNameTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewMovieMovieNameTextBox.TabIndex = 70
        '
        'ViewMovieStarringArtistTextBox
        '
        Me.ViewMovieStarringArtistTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewMovieStarringArtistTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMovieStarringArtistTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewMovieStarringArtistTextBox.Location = New System.Drawing.Point(328, 70)
        Me.ViewMovieStarringArtistTextBox.Name = "ViewMovieStarringArtistTextBox"
        Me.ViewMovieStarringArtistTextBox.ReadOnly = True
        Me.ViewMovieStarringArtistTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewMovieStarringArtistTextBox.TabIndex = 71
        '
        'ViewMovieMovieDescriptionTextBox
        '
        Me.ViewMovieMovieDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewMovieMovieDescriptionTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMovieMovieDescriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewMovieMovieDescriptionTextBox.Location = New System.Drawing.Point(328, 128)
        Me.ViewMovieMovieDescriptionTextBox.Multiline = True
        Me.ViewMovieMovieDescriptionTextBox.Name = "ViewMovieMovieDescriptionTextBox"
        Me.ViewMovieMovieDescriptionTextBox.ReadOnly = True
        Me.ViewMovieMovieDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ViewMovieMovieDescriptionTextBox.Size = New System.Drawing.Size(185, 104)
        Me.ViewMovieMovieDescriptionTextBox.TabIndex = 73
        '
        'ViewMoviePriceTextBox
        '
        Me.ViewMoviePriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ViewMoviePriceTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMoviePriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ViewMoviePriceTextBox.Location = New System.Drawing.Point(328, 238)
        Me.ViewMoviePriceTextBox.Name = "ViewMoviePriceTextBox"
        Me.ViewMoviePriceTextBox.ReadOnly = True
        Me.ViewMoviePriceTextBox.Size = New System.Drawing.Size(185, 21)
        Me.ViewMoviePriceTextBox.TabIndex = 74
        '
        'ListBox4
        '
        Me.ListBox4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.ForeColor = System.Drawing.Color.DarkViolet
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 15
        Me.ListBox4.Location = New System.Drawing.Point(16, 50)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(170, 214)
        Me.ListBox4.TabIndex = 51
        '
        'addMovieTab
        '
        Me.addMovieTab.Controls.Add(Me.AddMovieMovieGenreComboBox)
        Me.addMovieTab.Controls.Add(Me.AddMovieStarringArtistComboBox)
        Me.addMovieTab.Controls.Add(Me.AddMovieProductCodeTextBox)
        Me.addMovieTab.Controls.Add(Me.ResetMovieBtn)
        Me.addMovieTab.Controls.Add(Me.AddMovieBtn)
        Me.addMovieTab.Controls.Add(Me.Label31)
        Me.addMovieTab.Controls.Add(Me.Label32)
        Me.addMovieTab.Controls.Add(Me.Label33)
        Me.addMovieTab.Controls.Add(Me.Label34)
        Me.addMovieTab.Controls.Add(Label35)
        Me.addMovieTab.Controls.Add(Label37)
        Me.addMovieTab.Controls.Add(Me.AddMovieMovieNameTextBox)
        Me.addMovieTab.Controls.Add(Label38)
        Me.addMovieTab.Controls.Add(Label39)
        Me.addMovieTab.Controls.Add(Label40)
        Me.addMovieTab.Controls.Add(Me.AddMovieMovieDescriptionTextBox)
        Me.addMovieTab.Controls.Add(Label41)
        Me.addMovieTab.Controls.Add(Me.AddMoviePriceTextBox)
        Me.addMovieTab.Location = New System.Drawing.Point(4, 24)
        Me.addMovieTab.Name = "addMovieTab"
        Me.addMovieTab.Padding = New System.Windows.Forms.Padding(3)
        Me.addMovieTab.Size = New System.Drawing.Size(530, 283)
        Me.addMovieTab.TabIndex = 1
        Me.addMovieTab.Text = "Add Movies"
        Me.addMovieTab.UseVisualStyleBackColor = True
        '
        'AddMovieMovieGenreComboBox
        '
        Me.AddMovieMovieGenreComboBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMovieMovieGenreComboBox.FormattingEnabled = True
        Me.AddMovieMovieGenreComboBox.Location = New System.Drawing.Point(328, 98)
        Me.AddMovieMovieGenreComboBox.Name = "AddMovieMovieGenreComboBox"
        Me.AddMovieMovieGenreComboBox.Size = New System.Drawing.Size(185, 23)
        Me.AddMovieMovieGenreComboBox.TabIndex = 96
        '
        'AddMovieStarringArtistComboBox
        '
        Me.AddMovieStarringArtistComboBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMovieStarringArtistComboBox.FormattingEnabled = True
        Me.AddMovieStarringArtistComboBox.Location = New System.Drawing.Point(328, 69)
        Me.AddMovieStarringArtistComboBox.Name = "AddMovieStarringArtistComboBox"
        Me.AddMovieStarringArtistComboBox.Size = New System.Drawing.Size(185, 23)
        Me.AddMovieStarringArtistComboBox.TabIndex = 80
        '
        'AddMovieProductCodeTextBox
        '
        Me.AddMovieProductCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddMovieProductCodeTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMovieProductCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddMovieProductCodeTextBox.Location = New System.Drawing.Point(328, 13)
        Me.AddMovieProductCodeTextBox.Name = "AddMovieProductCodeTextBox"
        Me.AddMovieProductCodeTextBox.ReadOnly = True
        Me.AddMovieProductCodeTextBox.Size = New System.Drawing.Size(185, 21)
        Me.AddMovieProductCodeTextBox.TabIndex = 77
        '
        'ResetMovieBtn
        '
        Me.ResetMovieBtn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetMovieBtn.Location = New System.Drawing.Point(378, 236)
        Me.ResetMovieBtn.Name = "ResetMovieBtn"
        Me.ResetMovieBtn.Size = New System.Drawing.Size(57, 25)
        Me.ResetMovieBtn.TabIndex = 71
        Me.ResetMovieBtn.Text = "RESET"
        Me.ResetMovieBtn.UseVisualStyleBackColor = True
        '
        'AddMovieBtn
        '
        Me.AddMovieBtn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMovieBtn.Location = New System.Drawing.Point(441, 230)
        Me.AddMovieBtn.Name = "AddMovieBtn"
        Me.AddMovieBtn.Size = New System.Drawing.Size(72, 33)
        Me.AddMovieBtn.TabIndex = 70
        Me.AddMovieBtn.Text = "ADD"
        Me.AddMovieBtn.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(311, 199)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 15)
        Me.Label31.TabIndex = 69
        Me.Label31.Text = "*"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(311, 45)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 15)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "*"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(270, 242)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 14)
        Me.Label33.TabIndex = 67
        Me.Label33.Text = "required fields"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Red
        Me.Label34.Location = New System.Drawing.Point(344, 237)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 15)
        Me.Label34.TabIndex = 66
        Me.Label34.Text = "*"
        '
        'AddMovieMovieNameTextBox
        '
        Me.AddMovieMovieNameTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMovieMovieNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddMovieMovieNameTextBox.Location = New System.Drawing.Point(328, 42)
        Me.AddMovieMovieNameTextBox.Name = "AddMovieMovieNameTextBox"
        Me.AddMovieMovieNameTextBox.Size = New System.Drawing.Size(185, 21)
        Me.AddMovieMovieNameTextBox.TabIndex = 56
        '
        'AddMovieMovieDescriptionTextBox
        '
        Me.AddMovieMovieDescriptionTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMovieMovieDescriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddMovieMovieDescriptionTextBox.Location = New System.Drawing.Point(328, 128)
        Me.AddMovieMovieDescriptionTextBox.Multiline = True
        Me.AddMovieMovieDescriptionTextBox.Name = "AddMovieMovieDescriptionTextBox"
        Me.AddMovieMovieDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AddMovieMovieDescriptionTextBox.Size = New System.Drawing.Size(185, 62)
        Me.AddMovieMovieDescriptionTextBox.TabIndex = 62
        '
        'AddMoviePriceTextBox
        '
        Me.AddMoviePriceTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMoviePriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddMoviePriceTextBox.Location = New System.Drawing.Point(328, 196)
        Me.AddMoviePriceTextBox.Name = "AddMoviePriceTextBox"
        Me.AddMoviePriceTextBox.Size = New System.Drawing.Size(185, 21)
        Me.AddMoviePriceTextBox.TabIndex = 64
        '
        'editMovieTab
        '
        Me.editMovieTab.AutoScroll = True
        Me.editMovieTab.Controls.Add(Me.EditMovieMovieGenreComboBox)
        Me.editMovieTab.Controls.Add(Me.EditMovieStarringArtistComboBox)
        Me.editMovieTab.Controls.Add(Label44)
        Me.editMovieTab.Controls.Add(Me.SearchEditMovie)
        Me.editMovieTab.Controls.Add(Me.EditMovieProductCodeTextBox)
        Me.editMovieTab.Controls.Add(Me.Label19)
        Me.editMovieTab.Controls.Add(Me.Label17)
        Me.editMovieTab.Controls.Add(Me.ListBox3)
        Me.editMovieTab.Controls.Add(Me.Label15)
        Me.editMovieTab.Controls.Add(Me.Label16)
        Me.editMovieTab.Controls.Add(Me.SaveMovieBtn)
        Me.editMovieTab.Controls.Add(ProductCodeLabel3)
        Me.editMovieTab.Controls.Add(MovieNameLabel)
        Me.editMovieTab.Controls.Add(Me.EditMovieMovieNameTextBox)
        Me.editMovieTab.Controls.Add(StarringArtistLabel)
        Me.editMovieTab.Controls.Add(MovieGenreLabel)
        Me.editMovieTab.Controls.Add(MovieDescriptionLabel)
        Me.editMovieTab.Controls.Add(Me.EditMovieMovieDescriptionTextBox)
        Me.editMovieTab.Controls.Add(PriceLabel1)
        Me.editMovieTab.Controls.Add(Me.EditMoviePriceTextBox)
        Me.editMovieTab.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editMovieTab.Location = New System.Drawing.Point(4, 24)
        Me.editMovieTab.Name = "editMovieTab"
        Me.editMovieTab.Padding = New System.Windows.Forms.Padding(3)
        Me.editMovieTab.Size = New System.Drawing.Size(530, 283)
        Me.editMovieTab.TabIndex = 2
        Me.editMovieTab.Text = "Edit Movies"
        Me.editMovieTab.UseVisualStyleBackColor = True
        '
        'EditMovieMovieGenreComboBox
        '
        Me.EditMovieMovieGenreComboBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMovieMovieGenreComboBox.FormattingEnabled = True
        Me.EditMovieMovieGenreComboBox.Location = New System.Drawing.Point(328, 98)
        Me.EditMovieMovieGenreComboBox.Name = "EditMovieMovieGenreComboBox"
        Me.EditMovieMovieGenreComboBox.Size = New System.Drawing.Size(185, 23)
        Me.EditMovieMovieGenreComboBox.TabIndex = 99
        '
        'EditMovieStarringArtistComboBox
        '
        Me.EditMovieStarringArtistComboBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMovieStarringArtistComboBox.FormattingEnabled = True
        Me.EditMovieStarringArtistComboBox.Location = New System.Drawing.Point(328, 69)
        Me.EditMovieStarringArtistComboBox.Name = "EditMovieStarringArtistComboBox"
        Me.EditMovieStarringArtistComboBox.Size = New System.Drawing.Size(185, 23)
        Me.EditMovieStarringArtistComboBox.TabIndex = 98
        '
        'SearchEditMovie
        '
        Me.SearchEditMovie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchEditMovie.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchEditMovie.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SearchEditMovie.Location = New System.Drawing.Point(65, 19)
        Me.SearchEditMovie.Name = "SearchEditMovie"
        Me.SearchEditMovie.Size = New System.Drawing.Size(121, 21)
        Me.SearchEditMovie.TabIndex = 96
        '
        'EditMovieProductCodeTextBox
        '
        Me.EditMovieProductCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EditMovieProductCodeTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMovieProductCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EditMovieProductCodeTextBox.Location = New System.Drawing.Point(328, 13)
        Me.EditMovieProductCodeTextBox.MaxLength = 8
        Me.EditMovieProductCodeTextBox.Name = "EditMovieProductCodeTextBox"
        Me.EditMovieProductCodeTextBox.ReadOnly = True
        Me.EditMovieProductCodeTextBox.Size = New System.Drawing.Size(185, 21)
        Me.EditMovieProductCodeTextBox.TabIndex = 77
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(311, 199)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 15)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(311, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 15)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "*"
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.ForeColor = System.Drawing.Color.DarkViolet
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Location = New System.Drawing.Point(16, 50)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(170, 214)
        Me.ListBox3.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(282, 245)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 14)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "required fields"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(356, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 15)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "*"
        '
        'SaveMovieBtn
        '
        Me.SaveMovieBtn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveMovieBtn.Location = New System.Drawing.Point(386, 235)
        Me.SaveMovieBtn.Name = "SaveMovieBtn"
        Me.SaveMovieBtn.Size = New System.Drawing.Size(127, 33)
        Me.SaveMovieBtn.TabIndex = 47
        Me.SaveMovieBtn.Text = "SAVE CHANGES"
        Me.SaveMovieBtn.UseVisualStyleBackColor = True
        '
        'EditMovieMovieNameTextBox
        '
        Me.EditMovieMovieNameTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMovieMovieNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EditMovieMovieNameTextBox.Location = New System.Drawing.Point(328, 42)
        Me.EditMovieMovieNameTextBox.MaxLength = 400
        Me.EditMovieMovieNameTextBox.Name = "EditMovieMovieNameTextBox"
        Me.EditMovieMovieNameTextBox.Size = New System.Drawing.Size(185, 21)
        Me.EditMovieMovieNameTextBox.TabIndex = 3
        '
        'EditMovieMovieDescriptionTextBox
        '
        Me.EditMovieMovieDescriptionTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMovieMovieDescriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EditMovieMovieDescriptionTextBox.Location = New System.Drawing.Point(328, 128)
        Me.EditMovieMovieDescriptionTextBox.MaxLength = 4000
        Me.EditMovieMovieDescriptionTextBox.Multiline = True
        Me.EditMovieMovieDescriptionTextBox.Name = "EditMovieMovieDescriptionTextBox"
        Me.EditMovieMovieDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EditMovieMovieDescriptionTextBox.Size = New System.Drawing.Size(185, 62)
        Me.EditMovieMovieDescriptionTextBox.TabIndex = 9
        '
        'EditMoviePriceTextBox
        '
        Me.EditMoviePriceTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMoviePriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EditMoviePriceTextBox.Location = New System.Drawing.Point(328, 196)
        Me.EditMoviePriceTextBox.MaxLength = 8
        Me.EditMoviePriceTextBox.Name = "EditMoviePriceTextBox"
        Me.EditMoviePriceTextBox.Size = New System.Drawing.Size(185, 21)
        Me.EditMoviePriceTextBox.TabIndex = 11
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Peach Milk", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(240, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(333, 51)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Music Video Store"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(566, 396)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MusicVideoStore"
        Me.TransparencyKey = System.Drawing.Color.Orchid
        Me.TabControl1.ResumeLayout(False)
        Me.albumsTab.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.viewAlbumTab.ResumeLayout(False)
        Me.viewAlbumTab.PerformLayout()
        Me.addAlbumTab.ResumeLayout(False)
        Me.addAlbumTab.PerformLayout()
        CType(Me.AddAlbumNumTracksNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.editAlbumTab.ResumeLayout(False)
        Me.editAlbumTab.PerformLayout()
        CType(Me.EditAlbumNumTracksNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.moviesTab.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.viewMovieTab.ResumeLayout(False)
        Me.viewMovieTab.PerformLayout()
        Me.addMovieTab.ResumeLayout(False)
        Me.addMovieTab.PerformLayout()
        Me.editMovieTab.ResumeLayout(False)
        Me.editMovieTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents albumsTab As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents viewAlbumTab As System.Windows.Forms.TabPage
    Friend WithEvents addAlbumTab As System.Windows.Forms.TabPage
    Friend WithEvents editAlbumTab As System.Windows.Forms.TabPage
    Friend WithEvents moviesTab As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents viewMovieTab As System.Windows.Forms.TabPage
    Friend WithEvents addMovieTab As System.Windows.Forms.TabPage
    Friend WithEvents editMovieTab As System.Windows.Forms.TabPage
    Friend WithEvents ResetAlbumBtn As System.Windows.Forms.Button
    Friend WithEvents AddAlbumBtn As System.Windows.Forms.Button
    Friend WithEvents AddAlbumAlbumNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddAlbumNumTracksNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AddAlbumPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SaveAlbumBtn As System.Windows.Forms.Button
    Friend WithEvents EditAlbumAlbumNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditAlbumNumTracksNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents EditAlbumPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SaveMovieBtn As System.Windows.Forms.Button
    Friend WithEvents EditMovieMovieNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditMovieMovieDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditMoviePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents AddMovieMovieNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddMovieMovieDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddMoviePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResetMovieBtn As System.Windows.Forms.Button
    Friend WithEvents AddMovieBtn As System.Windows.Forms.Button
    Friend WithEvents ViewAlbumAlbumNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewAlbumContribArtistTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewAlbumPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewMovieMovieNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewMovieStarringArtistTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewMovieMovieDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewMoviePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewAlbumNumTracksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewAlbumMusicGenreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewMovieMovieGenreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewAlbumProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddAlbumProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditAlbumProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViewMovieProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddMovieProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditMovieProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents SearchViewAlbum As System.Windows.Forms.TextBox
    Friend WithEvents SearchEditAlbum As System.Windows.Forms.TextBox
    Friend WithEvents SearchViewMovie As System.Windows.Forms.TextBox
    Friend WithEvents SearchEditMovie As System.Windows.Forms.TextBox
    Friend WithEvents AddAlbumContribArtistComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EditAlbumContribArtistComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddMovieStarringArtistComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EditMovieStarringArtistComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddAlbumMusicGenreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EditAlbumMusicGenreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddMovieMovieGenreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EditMovieMovieGenreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
