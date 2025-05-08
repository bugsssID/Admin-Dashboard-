Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AbsenDC
    Public sql As String
    Public str As String
    Dim st = "st" & DateTime.Now.AddDays(-1).ToString("yyyyMMdd")
    Dim pr = "pr" & DateTime.Now.AddDays(-1).ToString("yyyyMMdd")
    Dim wt = "wt" & DateTime.Now.AddDays(-1).ToString("yyyyMMdd")
    Dim dt = "dt" & DateTime.Now.AddDays(-1).ToString("yyyyMMdd")
    Dim tmpst = "tmpst" & DateTime.Now.AddDays(-1).ToString("yyyyMMdd")
    Dim max As Integer
    Dim d As Integer
    Dim bt As String
    Private strsql As String
    Delegate Sub SetLabelText_Delegate(ByVal [Label] As Label, ByVal [text] As String)
    Private Sub UpdateLabel(ByVal [Label] As Label, ByVal [text] As String)
        If [Label].InvokeRequired Then
            Dim MyDelegate As New  _
            SetLabelText_Delegate(AddressOf UpdateLabel)
            Me.Invoke(MyDelegate, New Object() _
            {[Label], [text]})
        Else
            [Label].Text = [text]
        End If
    End Sub
    Private Sub jlnSql(ByVal sql As String)
        Try
            konek()
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error : " & sql & "-" & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub droptable()
        Dim prd = "pr" & DateTime.Now.AddDays(-3).ToString("yyyyMMdd")
        Dim std = "st" & DateTime.Now.AddDays(-3).ToString("yyyyMMdd")
        Dim wtd = "wt" & DateTime.Now.AddDays(-3).ToString("yyyyMMdd")
        Dim tmpstd = "tmpst" & DateTime.Now.AddDays(-3).ToString("yyyyMMdd")
        Dim dtd = "dt" & DateTime.Now.AddDays(-3).ToString("yyyyMMdd")
        konek()
        str = "DROP TABLE " & prd & ""
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()

        str = "DROP TABLE " & std & ""
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()

        str = "DROP TABLE " & dtd & ""
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()

        str = "DROP TABLE " & tmpstd & ""
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()

        str = "DROP TABLE " & wt & ""
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()

        conn.Close()
    End Sub
    Private Sub AbsenDC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Me.DateTimePicker1.Value = DateTime.Today.AddDays(-1)
        Me.tablewt()
        Me.tablepr()
        Me.tablest()
        Me.Tabledt()
        Me.tmpsttoko()
        'Me.droptable()
    End Sub
    Sub buatfolder()
        Dim csv As DirectoryInfo = New DirectoryInfo("D:\admin\datacsv")
        Dim data As DirectoryInfo = New DirectoryInfo("D:\idm\data")
        Try
            If data.Exists Or csv.Exists Then
                'Console.WriteLine("That path exists already.")
                Return
            End If
            csv.Create()
            data.Create()
            'Console.WriteLine("The directory was created successfully.")
        Catch e As Exception
            MsgBox("gagal membuat folder!", vbCritical, "info")
        End Try
    End Sub
    Public Sub tablewt()
        konek()
        Me.str = "select table_name from information_schema.tables where table_name='" & wt & "';"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
        Else
            Dim table_WT = "wt" & Format(DateTimePicker1.Value, "yyyyMMdd")
            Me.sql = "CREATE TABLE IF NOT EXISTS `" & table_WT & "` ("
            sql = sql + " `RECID` varchar(2) NOT NULL DEFAULT '',"
            sql = sql + " `RTYPE` char(2)  DEFAULT NULL,"
            sql = sql + " `DOCNO` char(8)  DEFAULT NULL,"
            sql = sql + " `SEQNO` char(2) DEFAULT NULL,"
            sql = sql + " `DIV` char(3)  DEFAULT NULL,"
            sql = sql + " `PRDCD` int(8)  DEFAULT NULL,"
            sql = sql + " `QTY` char(10)  DEFAULT NULL,"
            sql = sql + " `PRICE` char(10) DEFAULT NULL,"
            sql = sql + " `GROSS` char(10)  DEFAULT NULL,"
            sql = sql + " `CTREM` char(2) DEFAULT NULL,"
            sql = sql + " `DOCNO2` char(15) DEFAULT NULL,"
            sql = sql + " `ISTYPE` char(2)  DEFAULT NULL,"
            sql = sql + " `INVNO` char(15)  DEFAULT NULL,"
            sql = sql + " `TOKO_1` char(4) DEFAULT NULL,"
            sql = sql + " `DATE` char(15)  DEFAULT NULL,"
            sql = sql + " `DATE2` char(15) DEFAULT NULL,"
            sql = sql + " `KETERANGAN` char(100) DEFAULT NULL,"
            sql = sql + " `FTAG` char(2) DEFAULT NULL,"
            sql = sql + " `CATCOD` char(5) DEFAULT NULL,"
            sql = sql + " `LOKASI` char(3) DEFAULT NULL,"
            sql = sql + " `TGL1` char(15) DEFAULT NULL,"
            sql = sql + " `TGL2` char(15) DEFAULT NULL,"
            sql = sql + " `PPN` char(3) DEFAULT NULL,"
            sql = sql + " `TOKO_2` char(3) DEFAULT NULL,"
            sql = sql + " `DATE3` char(3) DEFAULT NULL,"
            sql = sql + " `DOCNO3` char(3) DEFAULT NULL,"
            sql = sql + " `SHOP` char(4) DEFAULT NULL,"
            sql = sql + " `PRICE_IDM` char(15) DEFAULT NULL,"
            sql = sql + " `PPNBM_IDM` char(15) DEFAULT NULL,"
            sql = sql + " `PPNRP_IDM` char(15) DEFAULT NULL,"
            sql = sql + " `LT` char(3) DEFAULT NULL,"
            sql = sql + " `RAK` char(3) DEFAULT NULL,"
            sql = sql + " `BAR` char(3) DEFAULT NULL,"
            sql = sql + " `BKP` char(3) DEFAULT NULL,"
            sql = sql + " `SUB_BKP` char(3) DEFAULT NULL,"
            sql = sql + " `PLUMD` char(10) DEFAULT NULL,"
            sql = sql + " `GROSS_JUAL` char(15) DEFAULT NULL,"
            sql = sql + " `PRICE_JUAL` char(15) DEFAULT NULL,"
            sql = sql + " `KODE_SUPPLIER` char(10) DEFAULT NULL,"
            sql = sql + " `TOKO` char(4) DEFAULT NULL,"
            sql = sql + " `TANGGAL` date,"
            sql = sql + "  PRIMARY KEY (`TOKO`,`TANGGAL`,`PRDCD`,`SHOP`,`DOCNO`,`CATCOD`,`INVNO`,`RTYPE`,`DIV`,`ISTYPE`,`TGL1`)"
            sql = sql + " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;"
            jlnSql(sql)
        End If
    End Sub
    Public Sub tablepr()
        konek()
        Me.str = "select table_name from information_schema.tables where table_name='" & pr & "';"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
        Else
            Dim table_PR = "pr" & Format(DateTimePicker1.Value, "yyyyMMdd")
            Me.sql = "CREATE TABLE IF NOT EXISTS `" & table_PR & "` ("
            sql = sql + " `RECID` varchar(2) NOT NULL DEFAULT '',"
            sql = sql + " `CATCODE` int(5)  DEFAULT NULL,"
            sql = sql + " `PRDCD` int(8)  DEFAULT NULL,"
            sql = sql + " `SINGKATAN` char(100) DEFAULT NULL,"
            sql = sql + " `DESC2` char(5)  DEFAULT NULL,"
            sql = sql + " `BKP` char(5)  DEFAULT NULL,"
            sql = sql + " `SUB_BKP` char(5)  DEFAULT NULL,"
            sql = sql + " `FRAC` char(5) DEFAULT NULL,"
            sql = sql + " `UNIT` char(3)  DEFAULT NULL,"
            sql = sql + " `ACOST` char(10) DEFAULT NULL,"
            sql = sql + " `LCOST` char(10) DEFAULT NULL,"
            sql = sql + " `PRICE` char(10)  DEFAULT NULL,"
            sql = sql + " `CTGR` char(5)  DEFAULT NULL,"
            sql = sql + " `KONS` char(5)  DEFAULT NULL,"
            sql = sql + " `PTAG` char(2) DEFAULT NULL,"
            sql = sql + " `REORDER`char(5) DEFAULT NULL,"
            sql = sql + " `LENGTH`char(5) DEFAULT NULL,"
            sql = sql + " `WIDTH`char(5) DEFAULT NULL,"
            sql = sql + " `HEIGHT`char(5) DEFAULT NULL,"
            sql = sql + " `NONSO` char(5) DEFAULT NULL,"
            sql = sql + " `NONRET` char(5) DEFAULT NULL,"
            sql = sql + " `TIPE_GDG` char(5) DEFAULT NULL,"
            sql = sql + " `BRG_IKIOSK` char(5) DEFAULT NULL,"
            sql = sql + " `PSNDULU` char(5) DEFAULT NULL,"
            sql = sql + " `NPLUS` char(5) DEFAULT NULL,"
            sql = sql + " `PKM_NEW` char(5) DEFAULT NULL,"
            sql = sql + " `PLAGPROD` char(30) DEFAULT NULL,"
            sql = sql + " `FT` char(5) DEFAULT NULL,"
            sql = sql + " `SS` char(5) DEFAULT NULL,"
            sql = sql + " `HIT_SPD` char(30) DEFAULT NULL,"
            sql = sql + " `HIT_PKM` char(30) DEFAULT NULL,"
            sql = sql + " `HIT_LEAD` char(5) DEFAULT NULL,"
            sql = sql + " `HIT_RASIO` char(5) DEFAULT NULL,"
            sql = sql + " `HIT_PKM_AKHIR` char(5) DEFAULT NULL,"
            sql = sql + " `HIT_MIN_DISP` char(5) DEFAULT NULL,"
            sql = sql + " `HIT_FIXED_TB` char(5) DEFAULT NULL,"
            sql = sql + " `HIT_SS_DEV` char(5) DEFAULT NULL,"
            sql = sql + " `TOKO_1` char(4) DEFAULT NULL,"
            sql = sql + " `FT_PROMO` char(8) DEFAULT NULL,"
            sql = sql + " `FT_DEV` char(8) DEFAULT NULL,"
            sql = sql + " `FT_SSN` char(8) DEFAULT NULL,"
            sql = sql + " `FT_SSN_DEV` char(8) DEFAULT NULL,"
            sql = sql + " `FT_HO` char(8) DEFAULT NULL,"
            sql = sql + " `TOKO` char(4) DEFAULT NULL,"
            sql = sql + " `TANGGAL` char(10) DEFAULT NULL,"
            sql = sql + "   PRIMARY KEY (`TOKO`,`TANGGAL`,`PRDCD`,`CATCODE`)"
            sql = sql + " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;"
            jlnSql(sql)
        End If
    End Sub
    Public Sub tablest()
        konek()
        str = "select table_name from information_schema.tables where table_name='" & st & "';"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
        Else
            Dim table_st = "st" & Format(DateTimePicker1.Value, "yyyyMMdd")
            Me.sql = "CREATE TABLE IF NOT EXISTS `" & table_st & "` ("
            sql = sql + " `RECID` varchar(1) NOT NULL DEFAULT '',"
            sql = sql + " `PRDCD` int(8) DEFAULT NULL,"
            sql = sql + " `CAT_CODE` int(10) DEFAULT NULL,"
            sql = sql + " `BEGBAL` char(8) DEFAULT NULL,"
            sql = sql + " `QTY` char(8) DEFAULT NULL,"
            sql = sql + " `MAX` char(8) DEFAULT NULL,"
            sql = sql + " `PKM_G` char(8) DEFAULT NULL,"
            sql = sql + " `PKM_N` char(4) DEFAULT NULL,"
            sql = sql + " `PKM_P` char(4) DEFAULT NULL,"
            sql = sql + " `PKM_K` char(4) DEFAULT NULL,"
            sql = sql + " `PKM_J` char(4) DEFAULT NULL,"
            sql = sql + " `PRICE` char(12) DEFAULT NULL,"
            sql = sql + " `MIN_DISP` char(10) DEFAULT NULL,"
            sql = sql + " `KAP_DISP` char(10) DEFAULT NULL,"
            sql = sql + " `AQTY` char(3) DEFAULT NULL,"
            sql = sql + " `BQTY` char(3) DEFAULT NULL,"
            sql = sql + " `CQTY` char(3) DEFAULT NULL,"
            sql = sql + " `DQTY` char(3) DEFAULT NULL,"
            sql = sql + " `EQTY` char(4) DEFAULT NULL,"
            sql = sql + " `FQTY` char(3) DEFAULT NULL,"
            sql = sql + " `STO1` char(2) DEFAULT NULL,"
            sql = sql + " `STO2` char(4) DEFAULT NULL,"
            sql = sql + " `STO3` char(2) DEFAULT NULL,"
            sql = sql + " `STO4` char(2) DEFAULT NULL,"
            sql = sql + " `STO5` char(2) DEFAULT NULL,"
            sql = sql + " `STO6` char(2) DEFAULT NULL,"
            sql = sql + " `AHJ` char(8) DEFAULT NULL,"
            sql = sql + " `BHJ` char(2) DEFAULT NULL,"
            sql = sql + " `CHJ` char(2) DEFAULT NULL,"
            sql = sql + " `DHJ` char(8) DEFAULT NULL,"
            sql = sql + " `EHJ` char(2) DEFAULT NULL,"
            sql = sql + " `FHJ` char(2) DEFAULT NULL,"
            sql = sql + " `ARP` char(10) DEFAULT NULL,"
            sql = sql + " `BRP` char(10) DEFAULT NULL,"
            sql = sql + " `CRP` char(10) DEFAULT NULL,"
            sql = sql + " `DRP` char(10) DEFAULT NULL,"
            sql = sql + " `ERP` char(10) DEFAULT NULL,"
            sql = sql + " `FRP` char(10) DEFAULT NULL,"
            sql = sql + " `SPD` char(10) DEFAULT NULL,"
            sql = sql + " `ACOST` char(10) DEFAULT NULL,"
            sql = sql + " `LCOST` char(10) DEFAULT NULL,"
            sql = sql + " `PLUMD` char(8) DEFAULT NULL,"
            sql = sql + " `PRCOST` char(10) DEFAULT NULL,"
            sql = sql + " `PLCOST` char(10) DEFAULT NULL,"
            sql = sql + " `TP_GDG` char(1) DEFAULT NULL,"
            sql = sql + " `STAUT` char(5) DEFAULT NULL,"
            sql = sql + " `RP_ADJ_K` char(2) DEFAULT NULL,"
            sql = sql + " `RP_ADJ_L` char(2) DEFAULT NULL,"
            sql = sql + " `BA` char(2) DEFAULT NULL,"
            sql = sql + " `BS` char(2) DEFAULT NULL,"
            sql = sql + " `TOKO` char(4) DEFAULT NULL,"
            sql = sql + " `TANGGAL` char(10) DEFAULT NULL,"
            sql = sql + "  PRIMARY KEY (`TOKO`,`TANGGAL`,`PRDCD`,`CAT_CODE`)"
            sql = sql + " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;"
            jlnSql(sql)
        End If
    End Sub
    Sub Tabledt()
        konek()
        str = "select table_name from information_schema.tables where table_name='" & st & "';"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
        Else
            Dim table_dt = "dt" & Format(DateTimePicker1.Value, "yyyyMMdd")
            Me.sql = "CREATE TABLE IF NOT EXISTS `" & table_dt & "` ("
            sql = sql + " `RECID` varchar(2) NOT NULL DEFAULT '',"
            sql = sql + " `STATION` char(2)  DEFAULT NULL,"
            sql = sql + " `SHIFT` char(2)  DEFAULT NULL,"
            sql = sql + " `RTYPE` char(2) DEFAULT NULL,"
            sql = sql + " `DOCNO` char(8)  DEFAULT NULL,"
            sql = sql + " `SEQNO` char(3)  DEFAULT NULL,"
            sql = sql + " `DIV` char(5)  DEFAULT NULL,"
            sql = sql + " `PRDCD` char(8) DEFAULT NULL,"
            sql = sql + " `QTY` char(10)  DEFAULT NULL,"
            sql = sql + " `PRICE` char(2) DEFAULT NULL,"
            sql = sql + " `GROSS` char(15) DEFAULT NULL,"
            sql = sql + " `DISCOUNT` char(2)  DEFAULT NULL,"
            sql = sql + " `SHOP` char(4)  DEFAULT NULL,"
            sql = sql + " `TANGGAL` date DEFAULT NULL,"
            sql = sql + " `JAM` time DEFAULT NULL,"
            sql = sql + " `KONS` char(2) DEFAULT NULL,"
            sql = sql + " `TTYPE` char(2) DEFAULT NULL,"
            sql = sql + " `HPP` char(20) DEFAULT NULL,"
            sql = sql + " `PROMISI` char(5) DEFAULT NULL,"
            sql = sql + " `PPN` char(25) DEFAULT NULL,"
            sql = sql + " `PTAG` char(2) DEFAULT NULL,"
            sql = sql + " `CAT_COD` char(7) DEFAULT NULL,"
            sql = sql + " `NM_VCR` char(3) DEFAULT NULL,"
            sql = sql + " `NO_VCR` char(3) DEFAULT NULL,"
            sql = sql + " `BKP` char(3) DEFAULT NULL,"
            sql = sql + " `SUB_BKP` char(3) DEFAULT NULL,"
            sql = sql + " `PLUMD` char(8) DEFAULT NULL,"
            sql = sql + " `NOPESANAN` char(2) DEFAULT NULL,"
            sql = sql + " `BERBAYAR` char(2) DEFAULT NULL,"
            sql = sql + " `NOACC` char(30) DEFAULT NULL,"
            sql = sql + " `TOKO` char(4) DEFAULT NULL,"
            sql = sql + " `TANGGAL2` date,"
            sql = sql + "  PRIMARY KEY (`TOKO`,`TANGGAL`,`PRDCD`,`SHOP`,`CAT_COD`,`DOCNO`,`RTYPE`,`DIV`,`TANGGAL2`)"
            sql = sql + " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;"
            jlnSql(sql)
        End If
    End Sub
    Sub tmpsttoko()
        konek()
        str = "select table_name from information_schema.tables where table_name='" & tmpst & "';"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
        Else
            Me.sql = "CREATE TABLE IF NOT EXISTS `" & tmpst & "` ("
            sql = sql + " `toko` varchar(4) NOT NULL DEFAULT '',"
            sql = sql + " `tanggal` date,"
            sql = sql + " `prdcd` char(8) DEFAULT NULL,"
            sql = sql + " `qty` char(10)  DEFAULT NULL,"
            sql = sql + " `max` char(10) DEFAULT NULL,"
            sql = sql + " `ket` char(15) DEFAULT NULL,"
            sql = sql + " `qty_ket` char(10)  DEFAULT NULL,"
            sql = sql + " `cat_code` char(20)  DEFAULT NULL,"
            sql = sql + "  PRIMARY KEY (`toko`,`tanggal`,`prdcd`,`cat_code`)"
            sql = sql + " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;"
            jlnSql(sql)
        End If
    End Sub
    Sub stokoutokotable()
        konek()
        str = "select table_name from information_schema.tables where table_name='tmp_intoko';"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
        Else
            Me.sql = "CREATE TABLE IF NOT EXISTS `tmp_intoko` ("
            sql = sql + " `prdcd` varchar(8) NOT NULL DEFAULT '',"
            sql = sql + " `cat_code` char(20),"
            sql = sql + " `tanggal` date DEFAULT NULL,"
            sql = sql + " `staut` char(10)  DEFAULT NULL,"
            sql = sql + "  PRIMARY KEY (`tanggal`,`prdcd`,`cat_code`)"
            sql = sql + " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;"
            jlnSql(sql)
        End If
    End Sub
    Sub tampil()
        Dim file As String
        lv.Items.Clear()
        max = 0
        d = Format(DateTimePicker1.Value, "yyMMdd")
        bt = Format(DateTimePicker1.Value, "MMdd")

        'Label2.Text = d
        If Mid(d, 3, 4) = "0100" Then
            Dim x As Integer
            x = Format(DateTimePicker1.Value, "yy")
            x = x - 1
            d = x.ToString + "1231"
        ElseIf Mid(d, 3, 4) = "0200" Then
            d = Format(Now, "yy") + "0131"
        ElseIf Mid(d, 3, 4) = "0300" Then
            d = Format(Now, "yy") + "0228"
        ElseIf Mid(d, 3, 4) = "0400" Then
            d = Format(Now, "yy") + "0331"
        ElseIf Mid(d, 3, 4) = "0500" Then
            d = Format(Now, "yy") + "0430"
        ElseIf Mid(d, 3, 4) = "0600" Then
            d = Format(Now, "yy") + "0531"
        ElseIf Mid(d, 3, 4) = "0700" Then
            d = Format(Now, "yy") + "0630"
        ElseIf Mid(d, 3, 4) = "0800" Then
            d = Format(Now, "yy") + "0731"
        ElseIf Mid(d, 3, 4) = "0900" Then
            d = Format(Now, "yy") + "0831"
        ElseIf Mid(d, 3, 4) = "1000" Then
            d = Format(Now, "yy") + "0930"
        ElseIf Mid(d, 3, 4) = "1100" Then
            d = Format(Now, "yy") + "1031"
        ElseIf Mid(d, 3, 4) = "1200" Then
            d = Format(Now, "yy") + "1130"
        End If
        file = Dir(txtasal.Text & "?r" & d & "*.???")
        'MsgBox(txtasal.Text & "?r" & d & "*.???")
        Do While file <> ""
            max = max + 1
            Dim lview As New ListViewItem
            lview = lv.Items.Add(file)
            file = Dir()
        Loop
        Label2.Text = max
        'Label7.Text = "792" - max
    End Sub
    Sub copy()
        On Error Resume Next
        If Not lv.Items.Count = 0 Then
            ProgressBar1.Value = 0
            If Not System.IO.Directory.Exists(txttuj.Text) Then
                Directory.CreateDirectory(txttuj.Text)
            End If
            Dim x As Integer
            Dim path As String
            path = "D:\idm\data\"
            For x = 0 To lv.Items.Count - 1
                If Not System.IO.File.Exists(txttuj.Text & lv.Items(x).Text) Then
                    UpdateLabel(Label4, "Copy file " & lv.Items(x).Text & " - " & FormatPercent(x / lv.Items.Count, 2))
                    System.Windows.Forms.Application.DoEvents()
                    FileCopy(txtasal.Text & lv.Items(x).Text, txttuj.Text & lv.Items(x).Text)
                End If
                BackgroundWorker1.ReportProgress(CInt(((x + 1) / lv.Items.Count) * 100))
            Next
            Label2.Text = max
            ' Label7.Text = "792" - max
            'Telegram.bot.sendMessage.send(-1001156169632, "Data Harian Yang belum Masuk Sisa  : " & Label7.Text & " Toko" & " - Tanggal : " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & " Jam : " & Format(Now, "hh:mm tt"))
        End If
    End Sub
    Sub bukafile()
        Dim x As Integer
        Dim path As String
        path = "D:\idm\data"
        If Not lv.Items.Count = 0 Then
            ProgressBar1.Value = 0
            If Not System.IO.Directory.Exists(txttuj.Text) Then
                Directory.CreateDirectory(txttuj.Text)
            End If
            For x = 0 To lv.Items.Count - 1
                If System.IO.File.Exists(txttuj.Text & lv.Items(x).Text) Then
                    UpdateLabel(Label4, "Buka file " & lv.Items(x).Text & " - " & FormatPercent(x / lv.Items.Count, 2))
                    System.Windows.Forms.Application.DoEvents()
                    'MsgBox("unzip -o " & txttuj.Text & lv.Items(x).Text & " DT" & bt & "*.* -d " & path)
                    Shell("unzip -o " & txttuj.Text & lv.Items(x).Text & " DT" & bt & "*.* -d " & path, AppWinStyle.Hide, True)
                    ' MsgBox("copy DT" & bt & "*.* ALL DT" & bt & ".csv")
                    Shell("unzip -o " & txttuj.Text & lv.Items(x).Text & " WT" & bt & "*.* -d " & path, AppWinStyle.Hide, True)
                    Shell("unzip -o " & txttuj.Text & lv.Items(x).Text & " ST" & bt & "*.* -d " & path, AppWinStyle.Hide, True)
                    ' Shell("unzip -o " & txttuj.Text & lv.Items(x).Text & " SLP" & bt & "*.* -d " & path, AppWinStyle.Hide, True)
                    Shell("unzip -o " & txttuj.Text & lv.Items(x).Text & " PR" & bt & "*.* -d " & path, AppWinStyle.Hide, True)
                    ' Shell("unzip -o " & txttuj.Text & lv.Items(x).Text & " RET*.CSV -d " & path, AppWinStyle.Hide, True)
                End If
                BackgroundWorker1.ReportProgress(CInt(((x + 1) / lv.Items.Count) * 100))
            Next
        End If
    End Sub
    Sub exportdt()
        Dim tgl As String
        tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")

        Dim file As String
        lv2.Items.Clear()
        file = Dir("D:\idm\data\DT*.*???")
        Do While file <> ""
            Dim lview As New ListViewItem
            lview = lv2.Items.Add(file)
            file = Dir()
        Loop
        konek()
        Dim x As Integer
        For x = 0 To lv2.Items.Count - 1
            Label2.Text = lv2.Items(x).Text.Replace(".", "")
            Label2.Text = Microsoft.VisualBasic.Right(Label2.Text, 4)

            If Not System.IO.File.Exists(txttuj.Text & lv2.Items(x).Text) Then
                UpdateLabel(Label4, "Proses Upload " & lv2.Items(x).Text & " - " & FormatPercent(x / lv2.Items.Count, 2))
                System.Windows.Forms.Application.DoEvents()
                cmd = New MySqlCommand("load data local infile 'D:/idm/data/" & lv2.Items(x).Text & "' into table " & dt & " FIELDS TERMINATED BY '|' LINES TERMINATED BY '\r\n' IGNORE 1 LINES set TOKO ='" & Label2.Text & "', TANGGAL2= '" & tgl & "'", conn)
                dr = cmd.ExecuteReader
                cmd.Dispose()
                dr.Close()
            End If
            BackgroundWorker1.ReportProgress(CInt(((x + 1) / lv2.Items.Count) * 100))
        Next
        conn.Close()
    End Sub
    Sub exportwt()
        Dim tgl As String
        tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")

        Dim file As String
        lv2.Items.Clear()
        file = Dir("D:\idm\data\WT*.*???")
        Do While file <> ""
            Dim lview As New ListViewItem
            lview = lv2.Items.Add(file)
            file = Dir()
        Loop

        konek()
        Dim x As Integer
        For x = 0 To lv2.Items.Count - 1
            Label2.Text = lv2.Items(x).Text.Replace(".", "")
            Label2.Text = Microsoft.VisualBasic.Right(Label2.Text, 4)

            If Not System.IO.File.Exists(txttuj.Text & lv2.Items(x).Text) Then
                UpdateLabel(Label4, "Proses Upload " & lv2.Items(x).Text & " - " & FormatPercent(x / lv2.Items.Count, 2))
                System.Windows.Forms.Application.DoEvents()
                cmd = New MySqlCommand("load data local infile 'D:/idm/data/" & lv2.Items(x).Text & "' into table " & wt & " FIELDS TERMINATED BY '|' LINES TERMINATED BY '\r\n' IGNORE 1 LINES set TOKO ='" & Label2.Text & "', TANGGAL= '" & tgl & "'", conn)
                dr = cmd.ExecuteReader
                cmd.Dispose()
                dr.Close()
            End If
            BackgroundWorker1.ReportProgress(CInt(((x + 1) / lv2.Items.Count) * 100))
        Next
        conn.Close()
    End Sub
    Sub exportst()
        Dim tgl As String
        tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")

        Dim file As String
        lv2.Items.Clear()
        file = Dir("D:\idm\data\ST*.*???")
        Do While file <> ""
            Dim lview As New ListViewItem
            lview = lv2.Items.Add(file)
            file = Dir()
        Loop

        konek()
        Dim x As Integer
        For x = 0 To lv2.Items.Count - 1
            Label2.Text = lv2.Items(x).Text.Replace(".", "")
            Label2.Text = Microsoft.VisualBasic.Right(Label2.Text, 4)
            If Not System.IO.File.Exists(txttuj.Text & lv2.Items(x).Text) Then
                UpdateLabel(Label4, "Proses Upload " & lv2.Items(x).Text & " - " & FormatPercent(x / lv2.Items.Count, 2))
                System.Windows.Forms.Application.DoEvents()
                'Import file ST to MYSQL
                cmd = New MySqlCommand("load data local infile 'D:/idm/data/" & lv2.Items(x).Text & "' into table " & st & " FIELDS TERMINATED BY '|' LINES TERMINATED BY '\r\n' IGNORE 1 LINES set TOKO ='" & Label2.Text & "', TANGGAL= '" & tgl & "'", conn)
                dr = cmd.ExecuteReader
                cmd.Dispose()
                dr.Close()
            End If
            BackgroundWorker1.ReportProgress(CInt(((x + 1) / lv2.Items.Count) * 100))
        Next
        conn.Close()
    End Sub
    Sub exportpr()
        Dim tgl As String
        tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")

        Dim file As String
        lv2.Items.Clear()
        file = Dir("D:\idm\data\PR*.*???")
        Do While file <> ""
            Dim lview As New ListViewItem
            lview = lv2.Items.Add(file)
            file = Dir()
        Loop

        konek()
        Dim x As Integer
        For x = 0 To lv2.Items.Count - 1
            Label2.Text = lv2.Items(x).Text.Replace(".", "")
            Label2.Text = Microsoft.VisualBasic.Right(Label2.Text, 4)
            If Not System.IO.File.Exists(txttuj.Text & lv2.Items(x).Text) Then
                UpdateLabel(Label4, "Proses Upload " & lv2.Items(x).Text & " - " & FormatPercent(x / lv2.Items.Count, 2))
                System.Windows.Forms.Application.DoEvents()
                cmd = New MySqlCommand("load data local infile 'D:/idm/data/" & lv2.Items(x).Text & "' into table " & pr & " FIELDS TERMINATED BY '|' LINES TERMINATED BY '\r\n' IGNORE 1 LINES set TOKO ='" & Label2.Text & "', TANGGAL= '" & tgl & "'", conn)
                dr = cmd.ExecuteReader
                cmd.Dispose()
                dr.Close()
            End If
            BackgroundWorker1.ReportProgress(CInt(((x + 1) / lv2.Items.Count) * 100))
        Next
        conn.Close()
    End Sub
    Sub stokouttoko()
        Dim tgl As String
        tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        str = "SELECT PRDCD,CAT_CODE,TANGGAL,SUM(STAUT) FROM " & st & " where tanggal='" & tgl & "' group by prdcd;"
        Try
            konek()
            cmd = New MySqlCommand(str, conn)
            Dim myAdapter As New MySqlDataAdapter(cmd)
            Dim myTabel As New DataTable
            myAdapter.Fill(myTabel)

            Dim i As Integer = 0
            Dim j As Integer = myTabel.Rows.Count - 1
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = j
            For i = 0 To j
                Application.DoEvents()
                ProgressBar1.Value = i
                Dim PRDCD As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(0)), "", myTabel.Rows.Item(i).Item(0))
                Dim CAT_CODE As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(1)), "", myTabel.Rows.Item(i).Item(1))
                Dim TANGGAL As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(2)), "", myTabel.Rows.Item(i).Item(2))
                Dim staut As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(3)), "", myTabel.Rows.Item(i).Item(3))
                Label4.Text = "Sum Stok Out - " & Math.Round((i / j) * 100, 2) & "%"
                ' Label4.Text = "Proses PLU - " & PRDCD
                Label4.Refresh()

                Dim simpan As String
                simpan = " Insert ignore tmp_intoko values('" & PRDCD & "','" & CAT_CODE & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & staut & "')"
                cmd = New MySqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub kebutuhantokodc()
        konek()
        Dim tk As String = vbEmpty
        Me.str = "select toko as p_toko from toko where not exists (select toko from " & tmpst & " where toko.toko=" & tmpst & ".toko and tanggal='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
        cmd = New MySqlCommand(str, conn)
        Dim myAdapter1 As New MySqlDataAdapter(cmd)
        Dim myTabel1 As New DataTable
        myAdapter1.Fill(myTabel1)
        Dim e As Integer = 0
        Dim f As Integer = myTabel1.Rows.Count - 1
        For e = 0 To f
            tk = (myTabel1.Rows.Item(e).Item(0))
            Try
                str = "select toko,tanggal,prdcd,qty,`max`,if(`max`-qty>0,'under','over') as ket,(`max`-qty) as qty_ket,cat_code from " & st & " where  toko='" & tk & "'  and tanggal='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
                cmd = New MySqlCommand(str, conn)
                Dim myAdapter As New MySqlDataAdapter(cmd)
                Dim myTabel As New DataTable
                myAdapter.Fill(myTabel)

                Dim i As Integer = 0
                Dim j As Integer = myTabel.Rows.Count - 1
                For i = 0 To j
                    Application.DoEvents()
                    Dim TOKO As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(0)), "", myTabel.Rows.Item(i).Item(0))
                    Dim TANGGAL As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(1)), "", myTabel.Rows.Item(i).Item(1))
                    Dim PRDCD As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(2)), "", myTabel.Rows.Item(i).Item(2))
                    Dim QTY As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(3)), "", myTabel.Rows.Item(i).Item(3))
                    Dim MAX As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(4)), "", myTabel.Rows.Item(i).Item(4))
                    Dim KET As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(5)), "", myTabel.Rows.Item(i).Item(5))
                    Dim QTY_KET As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(6)), "", myTabel.Rows.Item(i).Item(6))
                    Dim CAT_CODE As String = IIf(IsDBNull(myTabel.Rows.Item(i).Item(7)), "", myTabel.Rows.Item(i).Item(7))
                    Me.Text = TOKO & " - " & PRDCD & " - " & Math.Round((i / j) * 100, 2) & "%"
                    Me.Refresh()

                    Me.str = " Insert Ignore " & tmpst & " values('" & TOKO & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & PRDCD & "','" & QTY & "','" & MAX & "','" & KET & "','" & QTY_KET & "','" & CAT_CODE & "')"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub
    Sub deletfile()
        On Error Resume Next
        Dim idm As String = "D:\data\idm\"
        Dim datacsv As String = "D:\ADMIN\DATACSV\"
        Dim st As String = "D:\idm\data\"
        Dim pr As String = "D:\ADMIN\DATACSV\"
        For Each deleteFile In Directory.GetFiles(idm, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        For Each deleteFile In Directory.GetFiles(datacsv, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        For Each deleteFile In Directory.GetFiles(st, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        For Each deleteFile In Directory.GetFiles(pr, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lv.Items.Count = 0 Then
            MsgBox("Data Harian Tidak Ada!", vbInformation, "Sing baleg")
        Else
            If Not BackgroundWorker1.IsBusy = True Then
                BackgroundWorker1.RunWorkerAsync()
                Me.DateTimePicker1.Enabled = False
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.buatfolder()
        Me.copy()
        Me.bukafile()
        Me.tablewt()
        Me.tablepr()
        Me.tablest()
        Me.Tabledt()
        Me.tmpsttoko()
        Me.stokoutokotable()
        Me.exportwt()
        Me.exportst()
        Me.exportpr()
        Me.deletfile()
        Me.stokouttoko()
        Me.kebutuhantokodc()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
        Else
            Me.ProgressBar1.Value = 0
            Label4.Text = ""
            Label2.Text = ""
            MsgBox("Rengse.", vbInformation, "Info")
            Me.Close()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        tampil()
    End Sub
End Class