using System;
using System.Diagnostics;
using System.Net;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GetThatOS.Settings;


// This code was horrible and now its sort of not!!
// I couldn't understand my own code half the time so this should make future updates easier :sob:
// Maybe its just because im shit at this
namespace GetThatOS.Main
{
    public partial class MainWindowMenu : Form
    {
        private enum SelectedOS
        {
            None,
            Windows11, Windows10, Windows81, Windows8, Windows7, WindowsVista,
            WindowsXP, WindowsME, Windows2000, Windows98, Windows95,
            Windows31, Windows3, Windows2, Windows,
            MacOS26, MacOS15, MacOS14, MacOS13, MacOS12, MacOS11,
            MacOS10_15, MacOS10_14, MacOS10_13, MacOS10_12, MacOS10_11,
            MacOS10_10, MacOS10_9, MacOS10_8, MacOS10_7, MacOS10_6,
            MacOS10_5, MacOS10_4, MacOS10_3, MacOS10_2, MacOS10_1, MacOS10_0,
            MacOS9, MacOS8, MacOS7, MacOS6, MacOS5, MacOS4, MacOS3, MacOS2, MacOS
        }

        private SelectedOS _selectedOS = SelectedOS.None;

        private string LogoPath(string filename)
        {
            string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            return Path.Combine(programFiles, "GetThatOS", "LogosAndImages", filename);
        }

        public MainWindowMenu()
        {
            Console.WriteLine("GetThatOS");
            Console.WriteLine("0.3.5");
            InitializeComponent();
        }

        public void MainWindowMenu_Load(object sender, EventArgs e)
        {
            InitiallyUpdateLogo();
            DisableUnwantedText();
            DisableUnwantedButtons();
            GetDocs();
            this.Text = $"GetThatOS 0.3.5 | {Environment.OSVersion}";
            flowLayoutPanel3.Controls.SetChildIndex(button4, 0);
        }

        public void GetDocs()
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullDocs = Path.Combine(docs, "GetThatOSImages");
            Directory.CreateDirectory(fullDocs);
            textBox1.Text = fullDocs;
        }

        public void InitiallyUpdateLogo()
        {
            try
            {
                pictureBox1.Image = Image.FromFile(LogoPath("GetThatOS_logo.ico"));
            }
            catch
            {
                MessageBox.Show("Something bad happened! :(");
                Environment.Exit(1);
            }
        }

        public void DisableUnwantedText()
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
        }

        public void DisableUnwantedPanels()
        {
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel2.Enabled = false;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel3.Enabled = false;
        }

        public void DisableUnwantedButtons()
        {
            button11.Enabled = true;
            button11.Visible = true;
            button12.Enabled = false;
            button12.Visible = false;
        }

        private void SelectWindows(string logoFile, string labelText, SelectedOS os, bool InfoButton = false)
        {
            pictureBox1.Image = Image.FromFile(LogoPath(logoFile));
            label3.Visible = true;
            label3.Text = labelText;
            label8.Visible = InfoButton;
            button11.Enabled = InfoButton;
            button11.Visible = InfoButton;
            button12.Enabled = true;
            button12.Visible = true;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
            _selectedOS = os;
        }

        private void SelectMacOS(string logoFile, string labelText, SelectedOS os)
        {
            pictureBox1.Image = Image.FromFile(LogoPath(logoFile));
            label5.Visible = true;
            label5.Text = labelText;
            label2.Visible = false;
            _selectedOS = os;
        }

        // Windows tab stuff
        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(LogoPath("Windows11_logo.ico"));
            label3.Visible = true;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.Enabled = true;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel3.Enabled = false;
            _selectedOS = SelectedOS.None;
        }

        // macOS tab shit
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(LogoPath("MacGlass_logo.ico"));
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            button11.Enabled = false;
            button11.Visible = false;
            button12.Visible = true;
            button12.Enabled = true;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel2.Enabled = false;
            flowLayoutPanel3.Visible = true;
            flowLayoutPanel3.Enabled = true;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
            _selectedOS = SelectedOS.None;
        }


        // Windows version selection
        private void button5_Click(object sender, EventArgs e) => SelectWindows("Windows11_logo.ico", "Windows\n      11", SelectedOS.Windows11, InfoButton: true);
        private void button6_Click(object sender, EventArgs e) => SelectWindows("Windows10_logo.ico", "Windows\n      10", SelectedOS.Windows10, InfoButton: true);
        private void button7_Click(object sender, EventArgs e) => SelectWindows("Windows8_logo.ico", "Windows\n      8.1", SelectedOS.Windows81);
        private void button8_Click(object sender, EventArgs e) => SelectWindows("Windows8_logo.ico", "Windows\n       8", SelectedOS.Windows8);
        private void button9_Click(object sender, EventArgs e) => SelectWindows("Windows7_logo.ico", "Windows\n       7", SelectedOS.Windows7);
        private void button13_Click(object sender, EventArgs e) => SelectWindows("WindowsVista_logo.ico", "Windows\n    Vista", SelectedOS.WindowsVista);
        private void button14_Click(object sender, EventArgs e) => SelectWindows("WindowsXP_logo.ico", "Windows\n      XP", SelectedOS.WindowsXP);
        private void button15_Click(object sender, EventArgs e) => SelectWindows("WindowsME_logo.ico", "Windows\n      ME", SelectedOS.WindowsME);
        private void button16_Click(object sender, EventArgs e) => SelectWindows("Windows2000_logo.ico", "Windows\n    2000", SelectedOS.Windows2000);
        private void button17_Click(object sender, EventArgs e) => SelectWindows("Windows98953_logo.ico", "Windows\n      98", SelectedOS.Windows98);
        private void button18_Click(object sender, EventArgs e) => SelectWindows("Windows98953_logo.ico", "Windows\n      95", SelectedOS.Windows95);
        private void button19_Click(object sender, EventArgs e) => SelectWindows("Windows98953_logo.ico", "Windows\n      3.1", SelectedOS.Windows31);
        private void button20_Click(object sender, EventArgs e) => SelectWindows("Windows98953_logo.ico", "Windows\n       3", SelectedOS.Windows3);
        private void button21_Click(object sender, EventArgs e) => SelectWindows("Windows_logo.ico", "Windows\n       2", SelectedOS.Windows2);
        private void button22_Click(object sender, EventArgs e) => SelectWindows("Windows_logo.ico", "Windows", SelectedOS.Windows);

        // macOS version selectiobn
        private void button4_Click_1(object sender, EventArgs e) => SelectMacOS("MacGlass_logo.ico", "macOS 26", SelectedOS.MacOS26);
        private void button24_Click(object sender, EventArgs e) => SelectMacOS("MacModern_logo.ico", "macOS 15", SelectedOS.MacOS15);
        private void button25_Click(object sender, EventArgs e) => SelectMacOS("MacModern_logo.ico", "macOS 14", SelectedOS.MacOS14);
        private void button26_Click(object sender, EventArgs e) => SelectMacOS("MacModern_logo.ico", "macOS 13", SelectedOS.MacOS13);
        private void button27_Click(object sender, EventArgs e) => SelectMacOS("MacModern_logo.ico", "macOS 12", SelectedOS.MacOS12);
        private void button28_Click(object sender, EventArgs e) => SelectMacOS("MacModern_logo.ico", "macOS 11", SelectedOS.MacOS11);
        private void button29_Click(object sender, EventArgs e) => SelectMacOS("MacFlat_logo.ico", "macOS\n 10.15", SelectedOS.MacOS10_15);
        private void button30_Click(object sender, EventArgs e) => SelectMacOS("MacFlat_logo.ico", "macOS\n 10.14", SelectedOS.MacOS10_14);
        private void button31_Click(object sender, EventArgs e) => SelectMacOS("MacFlat_logo.ico", "macOS\n 10.13", SelectedOS.MacOS10_13);
        private void button32_Click(object sender, EventArgs e) => SelectMacOS("MacFlat_logo.ico", "macOS\n 10.12", SelectedOS.MacOS10_12);
        private void button33_Click(object sender, EventArgs e) => SelectMacOS("MacFlat_logo.ico", "macOS\n 10.11", SelectedOS.MacOS10_11);
        private void button34_Click(object sender, EventArgs e) => SelectMacOS("MacFlat_logo.ico", "macOS\n 10.10", SelectedOS.MacOS10_10);
        private void button35_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.9", SelectedOS.MacOS10_9);
        private void button36_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.8", SelectedOS.MacOS10_8);
        private void button37_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.7", SelectedOS.MacOS10_7);
        private void button38_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.6", SelectedOS.MacOS10_6);
        private void button39_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.5", SelectedOS.MacOS10_5);
        private void button40_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.4", SelectedOS.MacOS10_4);
        private void button41_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.3", SelectedOS.MacOS10_3);
        private void button42_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.2", SelectedOS.MacOS10_2);
        private void button43_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.1", SelectedOS.MacOS10_1);
        private void button44_Click(object sender, EventArgs e) => SelectMacOS("MacOSX_logo.ico", "macOS\n  10.0", SelectedOS.MacOS10_0);
        private void button45_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "MacOS\n     9", SelectedOS.MacOS9);
        private void button46_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "MacOS\n     8", SelectedOS.MacOS8);
        private void button47_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "MacOS\n     7", SelectedOS.MacOS7);
        private void button48_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "System\n     6", SelectedOS.MacOS6);
        private void button49_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "System\n     5", SelectedOS.MacOS5);
        private void button50_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "System\n     4", SelectedOS.MacOS4);
        private void button51_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "System\n     3", SelectedOS.MacOS3);
        private void button52_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "System\n     2", SelectedOS.MacOS2);
        private void button53_Click(object sender, EventArgs e) => SelectMacOS("MacPreOSX_logo.ico", "System\n     1", SelectedOS.MacOS);

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Windows 11 - XP and OSX 10.4 - 10.7 & 10.9 will be downloaded from Archive.org");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string directory = textBox1.Text;

            var singleDownloads = new Dictionary<SelectedOS, (string url, string filename)>
            {
                [SelectedOS.Windows11] = ("https://archive.org/download/windows-11-24h2-iso_202501/Win11_24H2_English_x64.iso", "Windows11.iso"),
                [SelectedOS.Windows10] = ("https://archive.org/download/windows-10-22h2-englishus/Win10_22H2_English_x64.iso", "Windows10.iso"),
                [SelectedOS.Windows81] = ("https://archive.org/download/win-8.1-english-x-64-x-86/Win8.1_English_x64.iso", "Windows8-1.iso"),
                [SelectedOS.Windows8] = ("https://archive.org/download/windows-8-x-64/Windows%208%20x64.iso", "Windows8.iso"),
                [SelectedOS.Windows7] = ("https://archive.org/download/Windows7-iso/win7_64_bit.iso", "Windows7.iso"),
                [SelectedOS.WindowsVista] = ("https://archive.org/download/windows-vista-64bit_202303/Windows_Vista_64bit.iso", "WindowsVista.iso"),
                [SelectedOS.WindowsXP] = ("https://archive.org/download/WinXPProSP3x86/en_windows_xp_professional_with_service_pack_3_x86_cd_vl_x14-73974.iso", "WindowsXP.iso"),
                [SelectedOS.WindowsME] = ("https://github.com/miniusbhater/diskimages/releases/download/me/Windows.Me.115.-.OEM.Full.iso", "WindowsME.iso"),
                [SelectedOS.Windows2000] = ("https://github.com/miniusbhater/diskimages/releases/download/2k/5.00.2195.1_x86fre_Professional_en-us-W2PFPP_EN.iso", "Win2k.iso"),
                [SelectedOS.Windows98] = ("https://github.com/miniusbhater/diskimages/releases/download/98/Windows.98.Second.Edition.iso", "Windows.98.Second.Edition.iso"),
                [SelectedOS.Windows95] = ("https://github.com/miniusbhater/diskimages/releases/download/95/windows95b.iso", "windows95.iso"),
                [SelectedOS.MacOS26] = ("https://swcdn.apple.com/content/downloads/40/56/122-28067-A_9B4FJ1TL06/zchwyidn8ubxkpelhytzb05o418bchr2se/InstallAssistant.pkg", "InstallAssistant26.pkg"),
                [SelectedOS.MacOS15] = ("https://swcdn.apple.com/content/downloads/22/06/047-96175-A_196UW6QK9G/dx1bmt6mb0q3llh0iyingau9ld5liod96r/InstallAssistant.pkg", "InstallAssistant15.pkg"),
                [SelectedOS.MacOS14] = ("https://swcdn.apple.com/content/downloads/23/16/047-96015-A_F2ZJ8P7940/aknn1yshpkeeg1l3hgz7saai1d0zguw31y/InstallAssistant.pkg", "InstallAssistant14.pkg"),
                [SelectedOS.MacOS13] = ("https://swcdn.apple.com/content/downloads/09/46/093-22004-A_QNZEDC334I/phigx2zvoggml6sh79my4y51fnvgy8hix4/InstallAssistant.pkg", "InstallAssistant13.pkg"),
                [SelectedOS.MacOS12] = ("https://swcdn.apple.com/content/downloads/46/57/052-60131-A_KM2RH04C2D/9yzvba1uvpem2wuo95r459qno57qaizwf2/InstallAssistant.pkg", "InstallAssistant12.pkg"),
                [SelectedOS.MacOS11] = ("http://swcdn.apple.com/content/downloads/14/38/042-45246-A_NLFOFLCJFZ/jk992zbv98sdzz3rgc7mrccjl3l22ruk1c/InstallAssistant.pkg", "InstallAssistant11.pkg"),
                [SelectedOS.MacOS10_12] = ("http://updates-http.cdn-apple.com/2019/cert/061-39476-20191023-48f365f4-0015-4c41-9f44-39d3d2aca067/InstallOS.dmg", "InstallMacOSX10.12.dmg"),
                [SelectedOS.MacOS10_11] = ("http://updates-http.cdn-apple.com/2019/cert/061-41424-20191024-218af9ec-cf50-4516-9011-228c78eda3d2/InstallMacOSX.dmg", "InstallMacOSX10.11.dmg"),
                [SelectedOS.MacOS10_10] = ("http://updates-http.cdn-apple.com/2019/cert/061-41343-20191023-02465f92-3ab5-4c92-bfe2-b725447a070d/InstallMacOSX.dmg", "InstallMacOSX10.10.dmg"),
                [SelectedOS.MacOS10_9] = ("https://archive.org/download/os-x-mavericks-10.9.5/OS%20X%20Mavericks%2010.9.5.iso", "OSXMavericks.iso"),
                [SelectedOS.MacOS10_8] = ("https://updates.cdn-apple.com/2021/macos/031-0627-20210614-90D11F33-1A65-42DD-BBEA-E1D9F43A6B3F/InstallMacOSX.dmg", "InstallMacOSX10.8.dmg"),
                [SelectedOS.MacOS10_7] = ("https://updates.cdn-apple.com/2021/macos/041-7683-20210614-E610947E-C7CE-46EB-8860-D26D71F0D3EA/InstallMacOSX.dmg", "InstallMacOSX10.7.dmg"),
                [SelectedOS.MacOS10_6] = ("https://archive.org/download/mac-os-x-10.6-snow-leopard-retail/Mac_OS_X_10.6_Snow_Leopard_Retail.iso", "OSXSnowLeopard.iso"),
                [SelectedOS.MacOS10_5] = ("https://archive.org/download/OsxLeopardInstall/osx%20leopard%20install.iso", "OSXLeopard.iso"),
                [SelectedOS.MacOS10_4] = ("https://archive.org/download/mac-os-x-tiger-intelppc/Mac%20OS%20X%20Tiger%2010.4.5%20%28Intel%29.iso", "OSXSnowTiger.iso"),
                [SelectedOS.MacOS9] = ("https://github.com/miniusbhater/diskimages/releases/download/9.2/macos_921_ppc.iso", "macos_921_ppc.iso"),
                [SelectedOS.MacOS8] = ("https://github.com/miniusbhater/diskimages/releases/download/8.0/Apple.MacOS.8.0.m68k.iso", "Apple.MacOS.8.0.m68k.iso"),
                [SelectedOS.MacOS7] = ("https://github.com/miniusbhater/diskimages/releases/download/7/System.7.1.CD.iso", "System.7.1.CD.iso"),
                [SelectedOS.MacOS10_1] = ("https://github.com/miniusbhater/diskimages/releases/download/10.1/osx_101_5g64_install.iso", "osx-10.1.iso"),
                [SelectedOS.MacOS10_0] = ("https://github.com/miniusbhater/diskimages/releases/download/osx10.0/osx-10.0.iso", "osx-10.0.iso"),
                [SelectedOS.MacOS2] = ("https://github.com/miniusbhater/diskimages/releases/download/sys2/System.Disk.img", "System.Disk.System.Software.2.img"),
                [SelectedOS.MacOS] = ("https://github.com/miniusbhater/diskimages/releases/download/sys1/System.Disk.img", "System.Disk.img"),
            };

            var appStore = new Dictionary<SelectedOS, string>
            {
                [SelectedOS.MacOS10_15] = "https://apps.apple.com/us/app/macos-catalina/id1466841314?mt=12",
                [SelectedOS.MacOS10_14] = "https://apps.apple.com/us/app/macos-mojave/id1398502828?mt=12",
                [SelectedOS.MacOS10_13] = "https://itunes.apple.com/us/app/macos-high-sierra/id1246284741",
            };

            var multiDownloads = new Dictionary<SelectedOS, (string label, (string url, string file)[] files)>
            {
                [SelectedOS.Windows31] = ("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk01-06.img", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk01.img", "disk01.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk02.img", "disk02.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk03.img", "disk03.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk04.img", "disk04.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk05.img", "disk05.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk06.img", "disk06.img"),
                }),
                [SelectedOS.Windows3] = ("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK01-05.IMG", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK01.IMG", "disk01.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK02.IMG", "disk02.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK03.IMG", "disk03.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK04.IMG", "disk04.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK05.IMG", "disk05.img"),
                }),
                [SelectedOS.Windows2] = ("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk1-5.img", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk1.img", "disk1.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk2.img", "disk2.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk3.img", "disk3.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk4.img", "disk4.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk5.img", "disk5.img"),
                }),
                [SelectedOS.Windows] = ("https://github.com/miniusbhater/diskimages/releases/download/1.03/D1_Setup-D6_Write.img", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/1.03/D1_Setup.img", "D1_Setup.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/1.03/D2_Build.img", "D2_Build.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/1.03/D3_Utils.img", "D3_Utils.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/1.03/D4_Font.img",  "D4_Font.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/1.03/D5_Apps.img",  "D5_Apps.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/1.03/D6_Write.img", "D6_Write.img"),
                }),
                [SelectedOS.MacOS10_3] = ("https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.1-3.iso", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.1.iso", "osx-10.3.disk1.iso"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.2.iso", "osx-10.3.disk2.iso"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.3.iso", "osx-10.3.disk3.iso"),
                }),
                [SelectedOS.MacOS10_2] = ("https://github.com/miniusbhater/diskimages/releases/download/10.2/disk1-2.iso", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/10.2/disk1.iso", "osx-10.2.disk1.iso"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/10.2/disk2.iso", "osx-10.2.disk2.iso"),
                }),
                [SelectedOS.MacOS6] = ("https://github.com/miniusbhater/diskimages/releases/download/6/Printing.Tools|System.Tools|Utilities.1-2.img", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/6/Printing.Tools.img", "Printing.Tools.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/6/System.Tools.img",   "System.Tools.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/6/Utilities.1.img",    "Utilities.1.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/6/Utilities.2.img",    "Utilities.2.img"),
                }),
                [SelectedOS.MacOS5] = ("https://github.com/miniusbhater/diskimages/releases/download/5.0/System.Tools.1-2|Utilities.1-2.img", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/5.0/System.Tools.1.img", "System.Tools.1.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/5.0/System.Tools.2.img", "System.Tools.2.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/5.0/Utilities.1.img",    "Utilities.1.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/5.0/Utilities.2.img",    "Utilities.2.img"),
                }),
                [SelectedOS.MacOS4] = ("https://github.com/miniusbhater/diskimages/releases/download/4/System.Tools.2.0.1.img|Utilities.2.1.Disk.1.img|Utilities.2.1.Disk.2.img", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/4/System.Tools.2.0.1.img",   "System.Tools.2.0.1.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/4/Utilities.2.1.Disk.1.img", "Utilities.2.1.Disk.1.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/4/Utilities.2.1.Disk.2.img", "Utilities.2.1.Disk.2.img"),
                }),
                [SelectedOS.MacOS3] = ("https://github.com/miniusbhater/diskimages/releases/download/3/System.Tools.512ke.v1.0.img|Utilities.1.0.img", new[]
                {
                    ("https://github.com/miniusbhater/diskimages/releases/download/3/System.Tools.512ke.v1.0.img", "System.Tools.512ke.v1.0.img"),
                    ("https://github.com/miniusbhater/diskimages/releases/download/3/Utilities.1.0.img",           "Utilities.1.0.img"),
                }),
            };

            if (appStore.TryGetValue(_selectedOS, out string storeUrl))
            {
                MessageBox.Show("This will open a link to App Store\nPress Ok to continue");
                Process.Start(new ProcessStartInfo { FileName = storeUrl, UseShellExecute = true });
                return;
            }

            if (singleDownloads.TryGetValue(_selectedOS, out var single))
            {
                label10.Visible = true;
                label10.Text = $"Downloading: {single.url}";
                label10.Refresh();
                Task.Run(() => MessageBox.Show("The download has started\ndepending on the size of the installer\nit may take a while for the progress to move"));
                DownloadFileWithProgress(single.url, Path.Combine(directory, single.filename), () =>
                {
                    MessageBox.Show("Download complete");
                    label10.Visible = false;
                });
                return;
            }

            if (multiDownloads.TryGetValue(_selectedOS, out var multi))
            {
                label10.Visible = true;
                label10.Text = $"Downloading: {multi.label}";
                label10.Refresh();
                Task.Run(() => MessageBox.Show("The download has started\ndepending on the size of the installer\nit may take a while for the progress to move"));
                DownloadFilesTogether(multi.files, directory, 0, () =>
                {
                    MessageBox.Show("Download complete");
                    label10.Visible = false;
                });
            }
        }

        private void DownloadFilesTogether((string url, string file)[] files, string directory, int index, Action completed)
        {
            if (index >= files.Length)
            {
                completed?.Invoke();
                return;
            }
            var (url, file) = files[index];
            DownloadFileWithProgress(url, Path.Combine(directory, file), () =>
                DownloadFilesTogether(files, directory, index + 1, completed));
        }

        private void DownloadFileWithProgress(string url, string path, Action completed)
        {
            WebClient client = new WebClient();
            long lastBytes = 0;
            DateTime lastTime = DateTime.UtcNow;
            label11.Visible = true;
            label12.Visible = true;

            client.DownloadProgressChanged += (s, e) =>
            {
                progressBar1.Value = e.ProgressPercentage;

                var now = DateTime.UtcNow;
                double seconds = (now - lastTime).TotalSeconds;
                double percent = (double)e.BytesReceived / e.TotalBytesToReceive * 100;
                label12.Text = $"{percent:F2}%";
                if (seconds >= 1.0)
                {
                    long delta = e.BytesReceived - lastBytes;
                    double mbps = (delta / 1024.0 / 1024.0) / seconds;
                    label11.Text = $"{mbps:F2} MB/s";

                    lastBytes = e.BytesReceived;
                    lastTime = now;
                }
            };

            client.DownloadFileCompleted += (s, e) =>
            {
                label11.Text = "";
                label12.Text = "";
                label11.Visible = false;
                label12.Visible = false;
                progressBar1.Value = 0;
                client.Dispose();
                completed?.Invoke();
            };

            client.DownloadFileAsync(new Uri(url), path);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.Text = dialog.SelectedPath;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.Show();
        }


        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}