<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovableDisksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecifyFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VirusVaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuarantineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThreatDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.GenerateListOfInfectedFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Threats:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 345)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(500, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(615, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 56)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Scan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Items.AddRange(New Object() {"OSX.Keylogger ", "Spyware.OnlineRecorder", "Spyware.AoboKeyLogger ", "Spyware.WinSupervisor", "Spyware.KeyProwler", "Spyware.MLog360", "Spyware.NetScreenWatch ", "Spyware.CompuSpy", "Spyware.XPCMonitor", "Spyware.RemoteSpy", "Spyware.KeyPlusPlus", "Spyware.CheatMonitor", "Spyware.Mod", "Spyware.KeyStalker", "Spyware.PCSurveilPro", "Spyware.HidetoolsSpy", "Spyware.SpyMonitor", "Spyware.HBScreenSpy", "Spyware.LightLogger", "Spyware.SilentMonitor", "Spyware.UltimateKeylog", "Spyware.NokKernel", "Spyware.TupInsight", "Spyware.SpyBossPro", "Spyware.ExpressKeylog", "Spyware.Borzoi", "Spyware.SpyMan", "Spyware.SpyMail", "Spyware.PornCleanser", "Spyware.RelyAllInOne", "Spyware.OsMonitor", "Spyware.PCAgent", "Spyware.PCGhost", "Spyware.ChilyEMon", "Spyware.MySuperSpy", "Spyware.FreeKeyLog", "Spyware.MySpaceIMSnif", "Spyware.AcePasswdSnif", "Spyware.AIMSniffer", "Spyware.SmartPCKeylog", "Spyware.RedPill", "Spyware.NeoSpy", "Spyware.AllMonitor", "Spyware.IMonitorPCPro", "Spyware.RevealerKeylog", "SecurityRisk.Cmdow", "Spyware.KeySnitch", "Spyware.MomKnowsBest", "Spyware.EmailSpyMon", "Spyware.ScreenSpyMon", "Spyware.MSNTrackMon", "Spyware.IMFMonitor", "Spyware.DDominator", "Spyware.IMMonitor", "Spyware.Ming", "Spyware.123Keylogger", "Spyware.MGShadow", "Spyware.IncredibleKey", "Spyware.LocalKeylog", "Spyware.InfineKeylog", "Spyware.StarLogger", "Spyware.SpyKy", "Spyware.SpySure", "Spyware.CheaterChecker", "Spyware.PCPandora", "Spyware.StealthWatcher", "Spyware.MSNSpyMonitor", "Spyware.SysDetective", "Spyware.IESecurityPro", "Spyware.StealthChatMon", "Spyware.TypeTeller", "Spyware.SpyPal", "YahooSpyMon", "Spyware.KeyloggerLite", "InsideChatSpy", "Spyware.DataDoctorKey", "Spyware.ISnake", "Spyware.MobileSpy", "Spyware.FreeKeylogger", "Spyware.IKL", "Spyware.SnoopStick", "Spyware.ScreenView", "Spyware.MDetect", "Spyware.CyberPredator", "Spyware.PrintMonitor", "Spyware.Ezurl", "Spyware.NetMama", "Spyware.WebSnitch", "Spyware.SniperSpy", "Spyware.SysKeylog", "Spyware.Canary", "Spyware.MSNPAnalyzer", "Spyware.TotalSpy", "Spyware.EMailObserver", "Spyware.iCam", "Spyware.Netrat", "Spyware.ABSystemSpy", "Spyware.BlackLog", "Spyware.Fingerprints", "Spyware.FlexiSpy", "Spyware.TypeRecorder", "Spyware.ESP", "Spyware.Intruder", "Spyware.KeySpyware", "Spyware.EarSpy", "Spyware.Ghostlog", "Spyware.PCProwler", "Spyware.MailRedirector", "Spyware.Spectre", "Spyware.SuperKeylogger", "Spyware.StaffCop", "Spyware.MsnSniffer", "Spyware.SpyClock", "Spyware.Ultraview", "Spyware.MagPlayer", "Spyware.KBMonitor", "Spyware.SolidKeyLogger", "Spyware.TrafficAccProc", "Spyware.BossEye", "Spyware.MSNChatSniffer", "Spyware.MateWatcher", "Spyware.Redhanded", "Spyware.PCSpyKeyLogger", "Spyware.ESurveiller", "Spyware.SecondSight", "Spyware.SentinelX", "Spyware.EZKeylogger", "Spyware.Mom", "Spyware.Spy-Guard", "Spyware.XPKey", "Spyware.CUseReporter", "Spyware.SmartKeylogger", "Spyware.UltraKeylogger", "Spyware.AIOLogger", "Spyware.SmokingGun", "Spyware.OverSpy", "Spyware.Watchdog", "Spyware.Systemsurv", "Spyware.SaveMyWork", "Spyware.KidLogger", "Spyware.ASObserver", "Spyware.StatWin", "Spyware.HiddenCamera", "Spyware.SpyPc", "Spyware.Deskadv", "Spyware.DesktopSnooper", "Spyware.Espion", "Spyware.StealthLogger", "Spyware.PCDetective", "Spyware.PcController", "Spyware.EyeSpyPro", "Spyware.YKPMD", "Spyware.EyeCandyMon", "Spyware.GiveMeToo", "Spyware.IEWatcher", "Spyware.PowerSpy", "Spyware.WatchRight", "Spyware.Spie", "Spyware.Intelliflag", "Spyware.Busted", "Spyware.NetMonitor", "Spyware.Supremespy", "Spyware.Elgolf", "Spyware.Watcher", "Spyware.SpyAll", "Spyware.XPSpy", "Spyware.Sesui", "Spyware.WSLogger", "Spyware.Apropos.C", "Spyware.Spagent", "Spyware.Teensearch", "Spyware.ElpowKey!grp0", "Spyware.ElpowKeylogger", "Spyware.ComSpySysSvr", "Spyware.ComKeylogger", "Spyware.SpyArsenalLog", "Spyware.SpymodePCSpy", "Spyware.StealthWeblog", "Spyware.StealthKeylog", "Spyware.BeyondKeylog", "Spyware.eSpyNow", "Spyware.EliteKeylogger", "Spyware.Surfcomp", "Spyware.ActMon", "Spyware.PersonInspect", "Spyware.ParentTools", "Spyware.Snoop", "Spyware.KeyCaptor", "Spyware.SpyGator", "Spyware.Track4Win", "Spyware.StealthWebPage", "Spyware.PCTattletale", "Spyware.SnapKey", "Spyware.QuickLaunch", "Spyware.PrivateEye", "Spyware.PCPolice", "Spyware.WinRecon", "Spyware.WebPI", "Spyware.HiddenRecorder", "Spyware.WALogger", "Spyware.SpyKeySpy", "Spyware.Visage", "Spyware.UltraKeyboard", "Spyware.UserLogger", "Spyware.SpyloPCMonitor", "Spyware.QuickKeylogger", "Spyware.PaqKeylog", "Spyware.Spytector", "Spyware.PCWatch", "Spyware.Screenspy", "Spyware.KeyboardLogger", "Spyware.InlookExpress", "Spyware.KeyLover", "Spyware.LympexPcSpy", "Spyware.IMSurfSentinel", "Spyware.KeyTrap", "Spyware.ISpy", "Spyware.Spy4PC", "Spyware.Wiretap", "Spyware.HandyKeylogger", "Spyware.SpyOutside", "Spyware.GuardMon", "Spyware.KGBSpy", "Spyware.HSLABLogger", "Spyware.ExploitChildWD", "Spyware.WebSurfWatch", "Spyware.SpyLantern", "Spyware.Wintective", "Spyware.Blackbox", "Spyware.TrustyHound", "Spyware.SpyKeylogger", "Spyware.SherlockKeylog", "Spyware.ComSurveilSys", "Spyware.SafeSurfing", "Spyware.NiceSpy", "Spyware.NSKeyLogger", "Spyware.Vipsearcher", "Spyware.MessageSpy", "Spyware.KeyLoggerExp", "Spyware.StingKeyLogger", "Spyware.CMK", "Spyware.PCSuperSpy", "Spyware.Perez", "Spyware.EmployeeWatch", "Spyware.EmailSpy", "Spyware.ChatBlocker", "Spyware.EasyKeyLogger", "Spyware.ElfSpy", "Spyware.CMKeyLogger", "Spyware.ACM", "Spyware.AllInOne", "Spyware.CWSMil", "Spyware.GoldenKeylog", "Spyware.AppsTraka", "Spyware.ActivityKey", "Spyware.SearchPounder", "Spyware.Probotse", "Spyware.2Spy", "Spyware.TinyKeylogger", "Spyware.Screenlogger", "Spyware.Intraspy", "Spyware.Relevancy", "Spyware.CyberSpy", "Spyware.Salus", "Spyware.CWSAddClass.B", "Spyware.StealthKeySpy", "Spyware.AceScreenSpy", "Spyware.SurfingSpy", "Spyware.InvisibleASpy", "Spyware.Realspy", "Spyware.SmartBrowse", "Spyware.PowerSearch", "Spyware.InvisibleKey.C", "Spyware.TAFbar", "Packed.Spyware", "Spyware.Starr", "Spyware.RemoteKey", "Spyware.InvisibleKey.B", "Spyware.WindowsKey", "Spyware.Supaseek", "Spyware.e2give", "Spyware.QuickSearch", "Spyware.zSearch", "Spyware.Digitals", "Spyware.Ashlt", "Spyware.ABCKeylogger", "Spyware.CWSAddClass", "Spyware.DsktopSurveil", "Spyware.TinySpyAgent", "Spyware.KBGuardian", "Spyware.CometCursor", "Spyware.SystemSpy", "Spyware.TrueActive", "Spyware.Probot", "Spyware.IEToolbar", "Spyware.ISearch", "Spyware.Sa_PCSpy.b", "Spyware.Sa_PCSpy", "Spyware.PCSpy", "Spyware.Actuals", "Spyware.SpyMyPC", "Spyware.007Spy", "Spyware.2020search", "Spyware.PCMonitor", "Spyware.ActualSpy", "Spyware.Arau", "Spyware.Seekseek", "Spyware.Goidr", "Spyware.BrowserSpy", "Spyware.AtWinspy", "Spyware.WinGuardian", "Spyware.RemPSteal", "Spyware.SaveKeys", "Spyware.DesktopD", "Spyware.FamilyCam", "Spyware.NetSpy", "Spyware.MyLittleSpy", "Spyware.SpyAssault", "Spyware.NetVizor", "Spyware.IkitecKL", "Spyware.KeyCollect", "Spyware.GhostKeyLog", "Spyware.HackerWacker", "Spyware.SpyAOL", "Spyware.KeyThief", "Spyware.ActivityLog", "Spyware.ActivMonAgent", "Spyware.AceSpy", "Spyware.Farsighter", "Spyware.ChatWatch", "Spyware.ModemSpy", "Spyware.WinKeyG", "Spyware.IamBigBrother", "Spyware.iiPwrKeySpy", "Spyware.AdvancedKey", "Spyware.SpyGraphica", "Spyware.SKIn", "Spyware.XpcSpy", "Spyware.DSpy", "Spyware.InvisibleKey", "Spyware.KeyKey", "Spyware.SurfSpy", "Spyware.GURLWatcher", "Spyware.PCAcme.B", "Spyware.WebMailSpy", "Spyware.SpyCapture", "Spyware.Winvest", "Spyware.Netobserve", "Spyware.Spytech.B", "Spyware.WinWhatWhere", "Spyware.KsLogger", "Spyware.PCParent", "Spyware.GoldenEye", "Spyware.DesktopScout", "Spyware.AbsoluteKey", "Spyware.InTheKnow", "Spyware.SilentSpy", "Spyware.NTLogonCapture", "Spyware.Ssppyy", "Spyware.FamilyKeylog", "Spyware.HomeKeyLogger", "Spyware.InternetSpy", "Spyware.DesktopSpy", "Spyware.BEverywhere", "Spyware.Marketscore", "Spyware.Keylogger", "Spyware.STAR", "Spyware.SpyBuddy", "Spyware.Apropos", "Spyware.Ardakey", "Spyware.Keyspy", "Spyware.Acext", "Spyware.KeyLoggerPro", "Spyware.MiniKeylogger", "Spyware.Hotra", "Spyware.PCAcme", "Spyware.BCWinSpy", "Spyware.Spytech", "Spyware.Manan", "Spyware.Dotcomtoolbar", "Spyware.ActiveKeylog", "Spyware.Perfect", "Spyware.LoverSpy", "Spyware.Pcaudit", "Spyware.ClientMan", "Spyware.ISpynow", "Spyware.Shopnav", "Spyware.Eblaster", "Spyware.Dlder", "Spyware.SCKeyLogger", "Spyware.Spector", "Spyware.Boolospy", "Adware.Owlforce", "Adware.Zwunzi ", "Adware.TrueAds", "Adware.DoubleD", "Adware.MyCentria", "Adware.OneStep", "Adware.Webwise", "Adware.Peppi", "Adware.Okcashbackmall", "Adware.Rabio", "Adware.Superiorads", "Adware.FindNavi", "Adware.DiscoveryLive", "Adware.AntiSpamBoy", "Adware.Mycashbag", "Adware.InstallProvider", "Adware.Webbuy", "Adware.DreamAd", "Adware.DisableKey", "Adware.Rugo", "Adware.Memini", "Adware.Kiswin", "Adware.Vomba", "Adware.NewAds", "Adware.Uplink", "Adware.CPush", "Adware.Searchtool", "Adware.BarACE", "AdwareRemover", "Adware.Optserve", "Adware.Elodu", "Adware.Oemji", "Adware.AdSupport", "Spyware.Jgidol", "Adware.RaxSearch", "Adware.PPRich", "Adware.NetMedia", "Adware.RegiFast", "Adware.Kuaiso", "Adware.TargetAd", "Adware.SearchNet", "Adware.ContextualToolbar", "Adware.Fresh", "Adware.TrustInPopups", "Adware.Roogoo", "Adware.Caishow", "Adware.LoadEWXD", "Adware.SecureServicePk", "Adware.LoveFreeGames", "Adware.BMCentral", "Adware.Netword", "Adware.Emusic", "Adware.BBSee", "Adware.TrustInBar", "Adware.AllSum", "Adware.Spedia", "Adware.NewWeb", "Adware.FreeAccessBar", "Adware.SmartDove", "Adware.BestIdol", "Adware.IESearch", "Adware.Adhelper", "Adware.Egyrank", "Adware.DesktopMedia", "Adware.Kidda", "Adware.Superlogy", "Adware.VCatch", "Adware.Webprefix", "Adware.FCHelp", "Adware.Tbon", "Adware.ZipClix", "Adware.Clearx", "Adware.DailyWinner", "Adware.Webentrance", "Adware.Wnad", "Adware.Whazit", "Adware.123Search", "Adware.Thumbsnatcher", "Adware.Director", "Adware.Redir", "Adware.Links", "Adware.MoneyGainer", "Adware.IEhlpr", "Adware.Meplex", "Adware.Borlan", "Adware.Webmisc", "Adware.Littlehelper", "Adware.Atlcontrol", "Adware.CoolSavings", "Adware.WebDir", "Adware.BocaiToolbar", "Adware.Hmtoolbar", "Adware.SweetBar", "Adware.DollarRevenue", "Adware.PLook", "Adware.Webext", "Adware.AlibabaTB", "Adware.ZenoSearch", "Adware.SmartBrowser", "Adware.Weblookup", "Adware.CramToolbar", "Adware.NaviSearch", "Adware.CashBackBuddy", "Adware.Bullseye", "Adware.Eziin", "Adware.SideFind", "Adware.YourSiteBar", "Adware.180Solutions", "Adware.SystemProcess", "Adware.BlockChecker", "Adware.ScreenScenes", "Adware.GatorEWallet", "Adware.GotSmiley", "Adware.DashBar", "Adware.WebSecureAlert", "Adware.DateManager", "Adware.PrecisionTime", "Adware.WeatherScope", "Adware.ZQuest", "Adware.BrowserVillage", "Adware.SP2Update", "Adware.Expand", "Adware.2Search", "Adware.Aurora", "Adware.Ztoolbar", "Adware.SearchCentrix", "Adware.FFToolBar", "Adware.SideBySide", "Adware.Idocha", "Adware.Movittone", "Adware.AdChannel19", "Adware.MBKWbar", "Adware.WinBo", "Adware.FriendsBlog", "Adware.SearchWords", "Adware.SurfAccuracy", "Adware.PigSearch", "Adware.EnhanceMSearch", "Adware.AUNPS", "Adware.GoGoTools", "Adware.CasinoClient", "Adware.Cashfiesta", "Adware.CashFiesta", "Adware.AFAEnhance", "Adware.MetaSearch", "Adware.STIEBar", "Adware.MaxSearch", "Adware.SavingsHound", "Adware.HalfLemon", "Adware.Iebar", "Adware.ESDIexplorr", "Adware.WeirdOnTheWeb", "Adware.NaughtyPops", "Adware.SearchNugget", "Adware.Adstation", "Adware.X10", "Adware.CtxPopup", "Adware.BeSys", "Adware.OfferAgent", "Adware.SeeqBar", "Adware.BigTrafficNet", "Adware.SmartAdware", "Adware.AdBlaster", "Adware.IEHost", "Adware.Trinity", "Adware.ZangoSearch", "Adware.Starware", "Adware.BestSearch", "Adware.TopAV", "Adware.FastLook", "Adware.Windupdates", "Adware.MediaPass", "Adware.WhileUSurf", "Adware.EZToolbar", "Adware.eSyndicate", "Adware.UniversalTB", "Adware.UpSpiralBar", "Adware.CSearch", "Adware.Qidion", "Adware.MDSSearchboost", "Adware.Daosearch", "Adware.GonnaSearch", "Adware.Ulubione", "Adware.SearchMaid", "Adware.7000n", "Adware.MediaPlaceTV", "Adware.HyperBar", "Adware.RXToolbar", "Adware.AdBlock", "Adware.InstaFinder", "Adware.AdBars", "Adware.NowFind", "Adware.WinProtect", "Adware.Topantispyware", "Adware.FindSpyware", "Adware.MatrixSearch", "Adware.UCMore", "Adware.ABXToolbar", "Adware.PowerScan", "Adware.Popuppers", "Adware.MWSearch", "Adware.LinkMaker", "Adware.StartPage.C", "Adware.Mainpean", "Adware.Diginum", "Adware.Appztoolbar", "Adware.Sheldor", "Adware.Getup.B", "Adware.AdServerNow", "Adware.Shazaa", "Adware.AdsInContext", "Adware.SeekSeek.B", "Adware.Nafaoz", "Adware.SeekSeek", "Adware.Appoli", "Adware.Yuupsearch", "Adware.Findwhatever", "Adware.ZioCom.C", "Adware.OrbitExplorer", "Adware.ClipGenie", "Adware.Riversoft", "Adware.TopSearch.B", "Adware.Henbang", "Adware.Purityscan.D", "Adware.Fastsearchweb", "Adware.TargetSaver", "Adware.Ventures", "Adware.ActiveSearch", "Adware.CWSConyc", "Adware.ClickDLoader.B", "Adware.ZioCom.B", "Adware.Blowsearch", "Adware.CWSIEFeats", "Adware.Ro2cn", "Adware.Affilred", "Adware.Medload", "Adware.MediaTicket", "Adware.Drusearch", "Adware.CWSAlfaSearch", "Adware.Vtlbar", "Adware.Navihelper", "Adware.CashSaver", "Adware.CWSMSConfd.B", "Adware.CWSMSConfd", "Adware.WinLog", "Adware.Delta", "Adware.WebBar", "Adware.WinTaskAd", "Adware.Sa", "Adware.SearchSeekFind", "Adware.Locator", "Adware.SQuery", "Adware.SurfSideKick", "Adware.MyCustomIE", "Adware.HighTraffic", "Adware.EBoard", "Adware.Instdollars", "Adware.Livechat", "Packed.Adware", "Adware.Searchforit", "Adware.Adultbox", "Adware.SearchScout", "Adware.BrowserPal", "Adware.EZSearch.B", "Adware.Surebar", "Adware.MXTarget.B", "Adware.MXTarget", "Adware.Twaintec", "Adware.Umaxsearch", "Adware.Fastfind.B", "Adware.IntDel", "Adware.ShowBehind", "Adware.PSN", "Adware.WhenUSearchBar", "Adware.YinStart", "Adware.Linkgrabber", "Adware.SyncroAd", "Adware.P2PNetworking", "Adware.QuickBrowser", "Adware.SmartPops.B", "Adware.Begin2search", "Adware.JustFindIt", "Adware.Aureate", "Adware.ZeroPopUp", "Adware.Mirar", "Adware.Iwantsearch", "Adware.ZioCom", "Adware.Horoscope", "Adware.WebRebates", "Adware.FreeScratchWin", "Adware.StartPage.B", "Adware.NeededWare", "Adware.DailyToolbar", "Adware.FlashEnhancer", "Adware.CoolWebSearch", "Adware.Toolband", "Adware.InetAntispy", "Adware.GreenIO", "Adware.EasySearch", "Adware.WWWBar", "Adware.MSView", "Adware.PurityScan.C", "Adware.CDT", "Adware.Multidropper", "Adware.FavBarCash", "Adware.ClickDLoader", "Adware.FakeMessage", "Adware.SearchBarCash", "Adware.Fastfind", "Adware.MediaInject", "Adware.OverPro", "Adware.Adlogix", "Adware.Hithopper", "Adware.Topicks", "Adware.SmartPops", "Adware.MediaLoad", "Adware.DealHelper", "Adware.Inetex", "Adware.GatorClone", "Adware.WinAd", "Adware.QoolAid", "Adware.Admass", "Adware.Lamhok", "Adware.180Search", "Adware.EnergyPlugin", "Adware.LizardBar", "Adware.Fizzle", "Adware.Surfairy", "Adware.BrowserAid", "Adware.AdDestroyer", "Adware.SearchNew", "Adware.WinFetch", "Adware.Syslibie", "Adware.WinFavorites.B", "Adware.Margoc", "Adware.LookNSearch", "Adware.StartPage", "Adware.WorldSearch", "Adware.Look2Me", "Adware.Searchdot", "Adware.HungryHands", "Adware.DelFin", "Adware.MessStopper", "Adware.Incredifind", "Adware.FavoriteMan", "Adware.ClickAlchemy", "Adware.BlazeFind", "Adware.IEPageHelper", "Adware.Onban", "Download.Adware", "Adware.Roimoi", "Adware.Annoyance", "Adware.Slagent", "Adware.LSPP", "Adware.Iefeats", "Adware.FindemNow", "Adware.TickerBar", "Adware.Raxums", "Adware.Replace", "Adware.SideSearch", "Adware.PrecisionPop", "Adware.AdGoblin", "Adware.Conspy", "Adware.Buddylinks", "Adware.NDotNet", "Adware.EZSearch", "Adware.FastSeek", "Adware.Cax", "Adware.IEDriver", "Adware.WinFavorites", "Adware.Jraun", "Adware.Searchsquire", "Adware.Smartsearch", "Adware.FreeComm", "Adware.SideBar", "Adware.Mpgcom", "Adware.YellowPages", "Adware.Ntsearch", "Adware.AdShooter", "Adware.Sqwire", "Adware.DownloadPlus", "Adware.TopMoxie", "Adware.IAGold", "Adware.FOne", "Adware.Netpal", "Adware.SearchSpace", "Adware.EasyWWW", "Adware.EvidenceScan", "Adware.VirtuMonde", "Adware.PopAdStop", "Adware.OMI", "Adware.Advision", "Adware.AdRoar", "Adware.Getup", "Adware.SearchCounter", "Adware.HelpExpress", "Adware.DynamicUpdater", "Adware.AdultLinks", "Adware.Superbar", "Adware.SafeSearch", "Adware.RCPrograms", "Adware.SecondThought", "Adware.Dynamic", "Adware.Fastwebfinder", "Adware.InstantAccess", "Adware.StatBlaster", "Adware.BetterInternet", "Adware.ILookup", "Adware.PortalScan", "Adware.TMKSoft.XPlugin", "Adware.PStrip", "Adware.OpenSite", "Adware.iPend", "Adware.Adpopup", "Adware.Ddpop", "Adware.Vanish", "Adware.Websearch", "Adware.Bookedspace", "Adware.Fapi", "Adware.Ting", "Adware.StopPopupAdsNow", "Adware.Satbo", "Adware.Searchq", "Adware.Magicads", "Adware.Wengs", "Adware.Winshow", "Adware.CrushSearch", "Adware.Quadro", "Adware.Lop", "Adware.ReferAd", "Adware.VirtualBouncer", "Adware.TSAdbot", "Adware.Winpup", "Adware.Massfav", "Adware.MainSearch", "Adware.ClearSearch", "Adware.Keenval", "Adware.Adtomi", "Adware.Istbar", "Adware.Adtest", "Adware.NetOptimizer", "Adware.SpywareNuker", "Adware.MemoryMeter", "Adware.PurityScan", "Adware.Wurldmedia", "Adware.Savenow", "Adware.MoeMoney", "Adware.Ipinsight", "Adware.IGetNet", "Adware.GAIN", "Adware.Flyswat", "Adware.Ezula", "Adware.Exactbar", "Adware.Dware", "Adware.Downreceive", "Adware.Cydoor", "Adware.Common", "Adware.Broadcastpc", "Adware.Bonzi", "Adware.BDE", "Adware.Hotbar", "Adware.BargainBuddy", "Adware.Topsearch", "Adware.Searchexplorer", "Adware.IEPlugin", "Adware.Aornum", "Adware.Advertbar", "Trackware.WebExplorer", "Trackware.ProSearch", "Trackware.CasinoBar", "Trackware.Icarus", "Trackware.Gemius", "Trackware.Spynova", "Trackware.Baigoo", "Trackware.SearchTerms", "Trackware.WebGuardian", "Trackware.Rewardnet", "Trackware.WUPControl", "Trackware.Energyplus", "Trackware.SafeScreen", "Trackware.SmartShopper", "Trackware.ActivShopper", "Trackware.Anquiro", "Trackware.MegaSearch", "Trackware.IEMenuExt", "Trackware.Bazookabar", "Trackware.Marketdart", "Packed.Trackware", "Trackware.BrowserAccel", "Trackware.Alexa", "Trackware.Dogpile", "Trackware.SAHAgent", "Trackware.Webhancer", "Trackware.7FaSStSearch", "AntiVirusDemoFraud", "VirusProtector", "PCDefender", "AntivirusFraud", "AntiToolbar", "SysDefence", "SafetyAntiSpyware", "AntivirusSystemPro", "SecurityToolFraud", "AntiVirus2010", "PersonalAntivirus", "WindowsAntivirusPro", "NortelAntivirus", "TotalSecurity", "LiveAntispy", "WindoFix", "007AntiSpyware ", "AVCare", "SpySniper", "VirusBye ", "AntivirusAgentPro", "Unvirex", "AntivirusDoktor2009", "SpywareCease", "PrivacyCenter", "PerfectDefender2009", "CoreGuardAntivirus2009", "MalwareCleaner", "FixTool", "ErrorRepair", "Antivirus360", "MalwareDefender2009", "FileFixProfessional", "SystemGuard2009", "VirusMelt ", "ThreatNuker", "MalwareDoctor", "AntispywareProtector", "VirusDoctor", "SpywareProtect2009", "WiniGuard", "TotalProtect2009", "ExpressAntiVirus2009", "PrivacyCommander", "AntiSpywareGuard", "AntivirusPlasma", "EKerberos", "SpywareGuard2008", "PersonalAntispy", "VirusResponseLab", "AntispywareProXP", "Cleaner2009", "SpyDevastator", "TotalSecure2009", "TheRegistrySentinel", "AndromedaAV", "SpywarePreventer", "MaxAntispy", "PCPrivacyCleaner", "InternetAntivirus", "PyroAntiSpy", "RegistryDoctor2008", "SecureExpertCleaner", "XLGuarder", "VirusRemover2008", "AntiVirusXP2008", "AntiVirus2009", "SpywareScanner2008", "RegistryDefender", "WinDefender", "WistaAntivirus", "PestSweeper", "MalwareProtector2008", "Zinaps", "SpyGuarder", "DisableSpyware", "AdvancedXPFixer", "KvmSecure", "XPSecurityCenter", "XPShield", "MalwareScanner", "AntiVirus2008", "RegistryGreat", "AntiSpywareMaster", "IEAntivirus", "PrivacyWatcher", "WinSpywareProtect", "MalwareBell", "VirusIsolator", "AntiSpywareExpert", "AntiVirProtect", "VipAntiSpyware", "PrivacyRedeemer", "WinXProtector", "PCClean", "PCAntiSpyware", "AntispyDeluxe", "MalwareWar", "AntispySpider", "SpywarePro", "SpywareSweeperPro", "MalwareCore", "RealAV", "SearchAndDestroy", "TheLastDefender", "Unigray", "SpyWatchE", "WinIFixer", "TheSpyBot", "SpyKillerPro", "InfeStop", "EasySpywareCleaner", "RaptorDefence", "SwiftCleaner", "LiveKill", "XPCleaner", "SpyBurner", "XPdefender", "WinPerformance", "AntiSpyKit", "WinReanimator", "WinSpyKiller", "VirusHeat", "SysCleaner", "EliteProtector", "SpywareIsolator", "MalwarePro", "SpyRid", "AntiSpyBoss", "Macsweeper", "Cleanator", "AntiSpyCheck", "AdwarePro2Sqr", "FilesSecure", "PcTurboPro", "RegSort", "AdwareRemover2007", "SpySnipe", "SuperSpywareKiller", "AntiSpyPro", "GuardCenter", "AdwarePro", "OnlineGuard", "PcRaiser", "DrProtection ", "DeusCleaner", "ErrorDigger", "ErrorInspector", "MySpyProtector", "AntiSpyGuard", "RegistryCleanFix", "VirusRay", "SunshineSpy ", "SpyOnThis", "WebSpyShield", "MessengerBlocker", "PerformanceOptimizer", "XPAntivirus", "MalwareMonitor", "MalWarrior", "SmartFixer", "Awola", "SystemDefender", "SpywareLocker", "SpywareSecure", "ContrWare", "AntiVirGear", "AntiSpywareShield", "SafeStrip", "ErrClean", "CryptDrive", "MalwareDestructor", "OSBodyGuard", "ErrorProtector", "PrivacyGuarantor", "SpyDefenderPro", "WinSpy", "ErrorDoctor", "SpywareSweeper", "CrisysTecSentry", "PrivacyKit", "WinXDefender", "AdvancedCleaner", "PCCleaner", "Spyinator", "PCPrivacyTool", "AntiVirusAndTrojan", "AntiVirusAndSpyware", "SpywareScrapper", "UltimateCleaner", "UltimateFixer", "UltimateDefender", "SecureMyPcPCScanner", "SpyShield", "SpyReaper", "MagicAntiSpy", "SpyShredder", "VirusProtectPro", "VirusLocker", "MyBugFreePc", "SpywareAnnihilatorPro", "RegistryCleanerXP", "WinFixer", "DrAntiSpy", "AVSystemCare", "SpyLocked", "SpyDawn", "SpyCrush", "AntiSpyZone", "Antivermins", "MyCleanerPC", "SpywareBomb", "ExpertAntiVirus", "FreeSpyScanRemove", "UltimateSpyware", "TrackZapper", "SpyKill", "BPSpyware", "SpySpeed", "NeospacelabSecurity", "RegistryPowerCleaner", "CodeClean", "SpyLax", "CurePCSolution", "Spyaxe", "Kazaap", "Virus-Kill", "2AntiSpyware", "AntispywareSoldier", "VirusRescue", "SpywareRemovalWizard", "VirusBlast", "DoctorAdwarePro", "TrojanGuarder", "TrueSword", "DriveCleaner", "SystemDoctor", "TrustCleaner", "AdwareSheriff", "SpySpotter", "TitanShield", "SpyBlocs", "MalwareWipe", "TheSpywareDetective", "Softstop", "AgentSpyware", "AdwareSpy", "AdsAlert", "SpyFighter", "SpywareHound", "WorldAntiSpy", "Spyviper", "ScanandRepair", "PSGuard", "PCHealthPlan", "SafeandClean", "AntiVirusPro", "ETDScanner", "EasySpywareKiller", "RegistryCare", "SpywareQuake", "RegistrySweeper", "SpyBouncer", "AntiVirusGold", "1stAntiVirus", "SpyDestroy", "WinAntiSpyware", "AlfaCleaner", "SpywareBomber", "SpyFalcon", "SaferScan", "RazeSpyware", "ErrorSafe", "SpywareStormer", "SpywareStrike", "WinHound", "UnSpyPC", "SpySheriff", "Trackware.Freesave ", "DefenceLabRemovalTools", "AdShortcuts", "AsteriskLogger", "Favorit", "RegistryEasy", "MalwareBot ", "USBcillin", "Hacktool.WFPOff", "LivePlayer", "PUA.SpywareSecure", "TraceSweeper", "DiskKnight", "MessengerSkinner", "SudoPlanet", "GoRecord", "WebMediaPlayer", "HotTv", "InternetGameBox", "PasswordInspector", "DioCleaner", "DivoPlayer", "DomPlayer", "IEDefender", "Craagle", "MicroBillSys", "AntiSpyStorm", "TrojanSimulator", "MalwareBurn", "NetPumper", "WinZix", "PrivacyProtector", "3wPlayer", "Torrent101", "VirusHeal", "LiveProtect", "SecurityRisk.Cashmoa", "SpyHeal", "888bar", "Movieland", "VirusBurst", "SecurityRisk.Malconfig", "Remacc.MultiWebSurv", "SecurityRisk.ProxyDns ", "SecurityRisk.URLRedir", "Tracking Cookie", "SecurityRisk.Settec", "SecurityRisk.DirectIP", "Securityrisk.Proxybar", "SecurityRisk.Pacer", "SecurityRisk.First4DRM", "SecurityRisk.HubSafe", "SecurityRisk.Dropper", "SecurityRisk.LanHelper", "SecurityRisk.MatrixSS", "SecurityRisk.LowZones", "SecurityRisk.IdleUI", "SecurityRisk.QD2", "Packed.SecurityRiskOff", "Packed.SecurityRiskOn", "JohntheRipper", "SecurityRisk.BrosExt", "SecurityRisk.eGatherer", "SecurityRisk.IISPriv", "SecurityRisk.Downldr", "SecurityRisk.ScanToy", "SecurityRisk.NavHelper", "SecurityRisk.ClubPoker", "SecurityRisk.Aports.dr", "KidControl", "CyberAlert", "Parentis", "CyberSitter", "iProtectYou", "Joke.Blusod", "Joke.IconInfest", "Joke.Poltergeist", "Joke.Year2k", "Joke.WindowCloser", "Joke.Owned", "Joke.EmailFun", "Joke.TimeTraveler", "Joke.ScreenFlasher", "Joke.Restart", "Joke.Meltscreen", "Joke.AnnoyGreet", "Joke.FakeStart", "Joke.Remove", "Joke.Bonus", "Packed.Joke", "Joke.WindowsMin", "Joke.ClickMe", "Joke.Bounce", "Joke.Playball", "Joke.Norantiv", "Joke.Aprool", "Joke.Apeldorn", "Joke.Flash", "Joke.MoveMouse", "Joke.Removal", "Joke.Geschenk", "Joke.Hikaru", "Joke.ErrorMsg", "Joke.Stupid", "Joke.Noise", "Joke.PS2Emulator", "Joke.Sojfuse", "Joke.AnnoyPal", "Joke.Trembler", "Joke.JepRuss", "Joke.Idiot", "Joke.HaltWin", "Joke.FakeDel", "Joke.Train", "Joke.Stupid.D", "Joke.Stupid.C", "Joke.Stript", "Joke.Madcow", "Joke.Knijpme", "Joke.Irritan", "Joke.FakeFormat.A", "Joke.CrazyMessage", "Joke.Bros", "Joke.BrokenDisk", "Joke.Boredom", "Joke.Amigo", "Hacktool.PStorRevealer", "Hacktool.Dahij", "Hacktool.PTHToolkit", "Hacktool.Squeeza", "Hacktool.Purpload", "Hacktool.DeepUnfreeze", "Hacktool.WCI", "Hacktool.Lisentkey", "Hacktool.Ghostmail", "Hacktool.YMDSearch", "Hacktool.SPHPBlog", "Hacktool.7thPortScan", "Hacktool.Hideout", "Hacktool.Ssiwg", "Hacktool.Webdav", "Hacktool.Spytector", "Hacktool.Phantom2", "Hacktool.AnyWeb", "Hacktool.AceSniffer", "Hacktool.ABFPRecovery", "Hacktool.Vanquish", "Hacktool.DFind", "Hacktool.ADSLpass", "Hacktool.Screenlogger", "Hacktool.THCScan", "Packed.Hacktool", "Hacktool.Clearlogs", "Hacktool.Nibor", "Hacktool.Rxhide", "Hacktool.CHMBuilder", "Hacktool.Shanluprober", "Hacktool.IPCscan", "Hacktool.RunService", "Hacktool.IGMPnuker", "Hacktool.ShadowAdmin", "Hacktool.Lemir.Kit", "Hacktool.FKWPkeylog", "Hacktool.KeyLoggPro.B", "Hacktool.Exe2Bmp", "Hacktool.Ace", "Hacktool.Exebind", "Hacktool.Brutex", "Hacktool.Asni", "Hacktool.SQLck", "Hacktool.Misoska.B", "Hacktool.Misoska", "Hacktool.DBomb", "Hacktool.UdpFlood", "Hacktool.PassReminder", "Hacktool.Sfind", "Hacktool.HideWindow", "Hacktool.FxScanner", "Hacktool.PasswordSpy", "Hacktool.Keygen.151552", "Hacktool.Xdos", "Hacktool.HTTPRat", "Hacktool.BattlePong", "Hacktool.SkSocket", "Hacktool.WPE", "Hacktool.Keylogger", "Hacktool.PassUnleash", "Hacktool.KeyLoggPro", "Dialer.MoldConecta", "Dialer.Trafficjam", "Dialer.AxFreeAccess", "Dialer.Diver", "Dialer.RasPro", "Adware.Adhelper", "Dialer.BaciamiStupido", "Dialer.MasterDialer", "Dialer.SPlanet", "Dialer.Pagomaster", "Dialer.MicroDialer", "Dialer.RatedXXX", "Dialer.SouthBeachTel", "Dialer.Webcont", "Dialer.ICcontrol", "Dialer.Nunci", "Dialer.PlayGames", "Dialer.Tronyx", "Dialer.Sfonditalia", "Dialer.Volta", "Dialer.Palazzo", "Dialer.Ulubione", "Dialer.Asdplug", "Dialer.PremiumHTML", "Dialer.StripPlayer", "Dialer.IEDisco.B", "Dialer.Inproc.B", "Dialer.Eroskop", "Dialer.Saristar", "Dialer.Trafficadvance", "Dialer.Dapsol", "Dialer.Postbas", "Dialer.Mostrar", "Dialer.NewDial.B", "Dialer.XLite", "Hacktool.THCScan", "Dialer.Gxbill", "Dialer.Sexprovider", "Dialer.Sexcyberkey", "Dialer.Superzugang", "Packed.Dialer", "Dialer.Antispy", "Dialer.XAccess", "Dialer.GBDial", "Dialer.Xpehbam", "Dialer.iDialer", "Dialer.XDialer", "Dialer.Hq", "Dialer.SexPornoAdult", "Dialer.Connect", "Dialer.HotPleasure.B", "Dialer.LiveCams", "Dialer.7AdPower", "Dialer.Coder", "Dialer.Inproc", "Dialer.LetToPhone", "Dialer.Vesta", "Dialer.Hoterotik", "Dialer.Wingoon", "Dialer.Goin", "Dialer.DialPlatform", "Dialer.QuestNet", "Dialer.Intexus", "Dialer.Mejorbus", "Dialer.IEDisco", "Dialer.Kotu", "Dialer.Uyelik", "Dialer.WSV", "Dialer.WildJP", "Dialer.EuroInfoMedia", "Dialer.Greencard", "Dialer.Switchdialer.B", "Dialer.Juicyteen", "Dialer.PornPaq.B", "Dialer.UDIS", "Dialer.HeissSex", "Dialer.SexFiles", "Dialer.Edipole", "Dialer.InstantAccess", "Dialer.CarpeDiem", "Dialer.ExDialer", "Dialer.Freeload", "Dialer.Sexitaly", "Dialer.SwitchDialer", "Dialer.DateMake", "Dialer.Erostars", "Dialer.Pornosex", "Dialer.RASDialer", "Dialer.GizliGercekler", "Dialer.Cyberbill", "Dialer.HotPleasure", "Dialer.DialXS", "Dialer.DialNet", "Dialer.Myworld", "Dialer.Lusval", "Dialer.Teens", "Dialer.OneOnOne", "Dialer.Dcon", "Dialer.Montil", "Dialer.AGB", "Dialer.HackerCD", "Dialer.Beweb", "Dialer.Marcado", "Dialer.Tibs", "Dialer.MovieFile", "Dialer.AdultBrowser", "Dialer.Telebizz", "Dialer.CAPI-Anruf", "Dialer.NewDial", "Dialer.UKAmPorn", "Dialer.Megateens", "Dialer.Heysan", "Dialer.WebDialler", "Dialer.Paydial", "Dialer.Desire", "Dialer.GlobalDialer", "Dialer.HotVideo", "Dialer.Adultchat", "Dialer.Stardial", "Dialer.Pornpaq", "Dialer.LiveVideo_fi", "Dialer.Pornostar", "Dialer.Gola", "Dialer.Rampage", "Dialer.Global", "Dialer.Paycenter", "Dialer.Target", "Dialer.Girlshost", "Dialer.Winmuschi", "Dialer.ConsulInfo", "Dialer.SweetGirls_gb", "Dialer.DirectDialler", "Dialer.VividGal", "Dialer.Rapidspark", "Dialer.XXXAction", "Dialer.LoveX", "Dialer.Prive", "Dialer.Indiax", "Dialer.Crosskirk", "Dialer.Holistyc", "Dialer.Haldex", "Dialer.LiquidInc", "Dialer.Lohan", "Dialer.Flatfive", "Dialer.ConnectParty", "Dialer.Webview", "Dialer.Moneytree", "Dialer.Lovemenow", "Dialer.Rapidblaster", "Dialer.Powerdial", "Dialer.Pecdialer", "Dialer.Fite", "Dialer.Dilos", "Dialer.Dialpass", "Dialer.Aconti", "Dialer.Hotstuff", "OSX.Remoteaccess ", "IACommand", "Remacc.RCPro", "Remacc.ABSystemSpy", "Remacc.MyShell", "Packed.RemoteAccess", "Remacc.SpyAnywhere", "Remacc.Rics", "Remacc.SAdoor", "Remacc.Radmin", "Remacc.RAServer", "Remacc.Surveil", "Word2000PasswdRecovery", "HackTool.SniffPass", "PasswordRevealer", "FileExec", "MailPassView", "JailBreak", "Firepass", "Incognito", "WLMPass", "CpuSpike", "IEPassView", "DCOMAssess", "Snipher", "MultiTool", "LophtCrack", "SamInside", "MultiPassRecover", "SecurityRisk.Atsiv", "LCRemover", "EasyPass", "SRunner", "BBproxy", "BosonGetPass", "HTTPBruteForcer", "PasswordSpectator", "Switchsniff", "DialupPwd", "RainbowCrack", "DSNS Network Scanner", "Kerbcrack", "PPAuditor", "CainAbel", "Amac", "LSADump", "NetCat", "Pwdump", "WinSniffer", "SpySharp", "Webcracker", "SuperScan", "Ariskkey", "PRecovery", "XScan", "AngryIPscanner", "SecurityRisk.Aports", "EICAR Test String"})
        Me.ListBox2.Location = New System.Drawing.Point(803, 67)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(238, 364)
        Me.ListBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Not yet scanned."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(800, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Threat database"
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0% Complete"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanToolStripMenuItem, Me.VirusVaultToolStripMenuItem, Me.TodoToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ThreatDatabaseToolStripMenuItem, Me.GenerateListOfInfectedFilesToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'ScanToolStripMenuItem
        '
        Me.ScanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuickToolStripMenuItem, Me.FullToolStripMenuItem, Me.CustomToolStripMenuItem, Me.StopScanToolStripMenuItem, Me.PauseToolStripMenuItem, Me.RemoteScanToolStripMenuItem})
        Me.ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        Me.ScanToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ScanToolStripMenuItem.Text = "Scan"
        '
        'QuickToolStripMenuItem
        '
        Me.QuickToolStripMenuItem.Name = "QuickToolStripMenuItem"
        Me.QuickToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuickToolStripMenuItem.Text = "Quick"
        '
        'FullToolStripMenuItem
        '
        Me.FullToolStripMenuItem.Name = "FullToolStripMenuItem"
        Me.FullToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FullToolStripMenuItem.Text = "Full"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemovableDisksToolStripMenuItem, Me.SpecifyFolderToolStripMenuItem})
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'RemovableDisksToolStripMenuItem
        '
        Me.RemovableDisksToolStripMenuItem.Name = "RemovableDisksToolStripMenuItem"
        Me.RemovableDisksToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RemovableDisksToolStripMenuItem.Text = "Removable Disks"
        '
        'SpecifyFolderToolStripMenuItem
        '
        Me.SpecifyFolderToolStripMenuItem.Name = "SpecifyFolderToolStripMenuItem"
        Me.SpecifyFolderToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SpecifyFolderToolStripMenuItem.Text = "Specify Folder..."
        '
        'StopScanToolStripMenuItem
        '
        Me.StopScanToolStripMenuItem.Name = "StopScanToolStripMenuItem"
        Me.StopScanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StopScanToolStripMenuItem.Text = "Stop Scan"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'RemoteScanToolStripMenuItem
        '
        Me.RemoteScanToolStripMenuItem.Name = "RemoteScanToolStripMenuItem"
        Me.RemoteScanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RemoteScanToolStripMenuItem.Text = "Remote Scan"
        '
        'VirusVaultToolStripMenuItem
        '
        Me.VirusVaultToolStripMenuItem.Name = "VirusVaultToolStripMenuItem"
        Me.VirusVaultToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.VirusVaultToolStripMenuItem.Text = "Virus Vault"
        '
        'TodoToolStripMenuItem
        '
        Me.TodoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.QuarantineToolStripMenuItem, Me.MoveToolStripMenuItem, Me.AbortToolStripMenuItem, Me.CancelToolStripMenuItem, Me.BlockToolStripMenuItem, Me.HealToolStripMenuItem})
        Me.TodoToolStripMenuItem.Name = "TodoToolStripMenuItem"
        Me.TodoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.TodoToolStripMenuItem.Text = "To-do"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'QuarantineToolStripMenuItem
        '
        Me.QuarantineToolStripMenuItem.Name = "QuarantineToolStripMenuItem"
        Me.QuarantineToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.QuarantineToolStripMenuItem.Text = "Quarantine"
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.MoveToolStripMenuItem.Text = "Move"
        '
        'AbortToolStripMenuItem
        '
        Me.AbortToolStripMenuItem.Name = "AbortToolStripMenuItem"
        Me.AbortToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AbortToolStripMenuItem.Text = "Abort connection"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'BlockToolStripMenuItem
        '
        Me.BlockToolStripMenuItem.Name = "BlockToolStripMenuItem"
        Me.BlockToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BlockToolStripMenuItem.Text = "Block"
        '
        'HealToolStripMenuItem
        '
        Me.HealToolStripMenuItem.Name = "HealToolStripMenuItem"
        Me.HealToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.HealToolStripMenuItem.Text = "Heal"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ThreatDatabaseToolStripMenuItem
        '
        Me.ThreatDatabaseToolStripMenuItem.Name = "ThreatDatabaseToolStripMenuItem"
        Me.ThreatDatabaseToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ThreatDatabaseToolStripMenuItem.Text = "Threat Database"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "Check for Updates"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AToolStripMenuItem.Text = "About"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ColumnWidth = 250
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(11, 48)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(500, 292)
        Me.CheckedListBox1.TabIndex = 9
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "None selected."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "0 scanned, 0 infected"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(702, 249)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "0"
        Me.TextBox1.Visible = False
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(615, 278)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(50, 23)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(671, 278)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(50, 23)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = "0"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(727, 278)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(50, 23)
        Me.TextBox4.TabIndex = 12
        Me.TextBox4.Text = "0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox4.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(783, 277)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(50, 23)
        Me.TextBox5.TabIndex = 12
        Me.TextBox5.Text = "0"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(779, 268)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(50, 23)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = "0"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Not available."
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(656, 307)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(50, 23)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.Text = "0"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox7.Visible = False
        '
        'Timer6
        '
        '
        'GenerateListOfInfectedFilesToolStripMenuItem
        '
        Me.GenerateListOfInfectedFilesToolStripMenuItem.Name = "GenerateListOfInfectedFilesToolStripMenuItem"
        Me.GenerateListOfInfectedFilesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.GenerateListOfInfectedFilesToolStripMenuItem.Text = "Generate list of infected files"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 483)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antivirus 7.7"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovableDisksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpecifyFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VirusVaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuarantineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopScanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThreatDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HealToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents RemoteScanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents GenerateListOfInfectedFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
