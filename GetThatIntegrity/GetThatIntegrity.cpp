#include <iostream>
#include <fstream>
#include <conio.h>
#include <cstdlib>

int main()
{
    std::cout << "GetThatIntegrity 1.0.0\n";
    std::cout << "Beginning checks\n";
    std:: string rootDir = "C:\\Program Files (x86)\\GetThatOS\\";
    std:: string imgDir = "C:\\Program Files (x86)\\GetThatOS\\LogosAndImages\\";

    // GetThatOS
    std:: string chkFr = rootDir + "GetThatOS.exe";
    std:: cout << chkFr;
    std::ifstream file(chkFr);

    if (file.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch = _getch();
        exit(1);
    }

    // GetThatOS Logo
    std::string chkFr1 = imgDir + "GetThatOS_logo.ico";
    std::cout << chkFr1;
    std::ifstream file1(chkFr1);

    if (file1.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch1 = _getch();
        exit(1);
    }

    // GetThatOS Other
    std::string chkFr2 = imgDir + "GetThatOSOther_logo.ico";
    std::cout << chkFr2;
    std::ifstream file2(chkFr2);

    if (file2.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch2 = _getch();
        exit(1);
    }

    // Linux Tux
    std::string chkFr3 = imgDir + "LinuxTux_logo.ico";
    std::cout << chkFr3;
    std::ifstream file3(chkFr3);

    if (file3.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch3 = _getch();
        exit(1);
    }

    // MacFlat
    std::string chkFr4 = imgDir + "MacFlat_logo.ico";
    std::cout << chkFr4;
    std::ifstream file4(chkFr4);

    if (file4.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch4 = _getch();
        exit(1);
    }

    // MacModern
    std::string chkFr5 = imgDir + "MacModern_logo.ico";
    std::cout << chkFr5;
    std::ifstream file5(chkFr5);

    if (file5.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch5 = _getch();
        exit(1);
    }

    // MacOSX
    std::string chkFr6 = imgDir + "MacOSX_logo.ico";
    std::cout << chkFr6;
    std::ifstream file6(chkFr6);

    if (file6.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch6 = _getch();
        exit(1);
    }

    // MacOSXPre
    std::string chkFr7 = imgDir + "MacPreOSX_logo.ico";
    std::cout << chkFr7;
    std::ifstream file7(chkFr7);

    if (file7.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch7 = _getch();
        exit(1);
    }

    // Windows
    std::string chkFr8 = imgDir + "Windows_logo.ico";
    std::cout << chkFr8;
    std::ifstream file8(chkFr8);

    if (file8.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch8 = _getch();
        exit(1);
    }

    // Windows 2 
    std::string chkFr9 = imgDir + "Windows2_logo.ico";
    std::cout << chkFr9;
    std::ifstream file9(chkFr9);

    if (file9.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch9 = _getch();
        exit(1);
    }

    // Windows 3.1 
    std::string chkFr10 = imgDir + "Windows3.1_logo.ico";
    std::cout << chkFr10;
    std::ifstream file10(chkFr10);

    if (file10.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch10 = _getch();
        exit(1);
    }

    // Windows 95
    std::string chkFr11 = imgDir + "Windows95_logo.ico";
    std::cout << chkFr11;
    std::ifstream file11(chkFr11);

    if (file11.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch11 = _getch();
        exit(1);
    }

    // Windows 98
    std::string chkFr12 = imgDir + "Windows98_logo.ico";
    std::cout << chkFr12;
    std::ifstream file12(chkFr12);

    if (file12.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch12 = _getch();
        exit(1);
    }

    // Windows 2000
    std::string chkFr13 = imgDir + "Windows2000_logo.ico";
    std::cout << chkFr13;
    std::ifstream file13(chkFr13);

    if (file13.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch13 = _getch();
        exit(1);
    }

    // Windows ME
    std::string chkFr14 = imgDir + "WindowsME_logo.ico";
    std::cout << chkFr14;
    std::ifstream file14(chkFr14);

    if (file14.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch14 = _getch();
        exit(1);
    }

    // Windows XP
    std::string chkFr15 = imgDir + "WindowsXP_logo.ico";
    std::cout << chkFr15;
    std::ifstream file15(chkFr15);

    if (file15.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch15 = _getch();
        exit(1);
    }

    // Windows Vista
    std::string chkFr16 = imgDir + "WindowsVista_logo.ico";
    std::cout << chkFr16;
    std::ifstream file16(chkFr16);

    if (file16.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch16 = _getch();
        exit(1);
    }

    // Windows 7
    std::string chkFr17 = imgDir + "Windows7_logo.ico";
    std::cout << chkFr17;
    std::ifstream file17(chkFr17);

    if (file17.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch17 = _getch();
        exit(1);
    }

    // Windows 8
    std::string chkFr18 = imgDir + "Windows8_logo.ico";
    std::cout << chkFr18;
    std::ifstream file18(chkFr18);

    if (file18.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch18 = _getch();
        exit(1);
    }

    // Windows 10
    std::string chkFr19 = imgDir + "Windows10_logo.ico";
    std::cout << chkFr19;
    std::ifstream file19(chkFr19);

    if (file19.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch19 = _getch();
        exit(1);
    }

    // Windows 11
    std::string chkFr20 = imgDir + "Windows11_logo.ico";
    std::cout << chkFr20;
    std::ifstream file20(chkFr20);

    if (file20.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch20 = _getch();
        exit(1);
    }

    // TF2 coconut
    std::string chkFr21 = imgDir + "coconut.jpg";
    std::cout << chkFr21;
    std::ifstream file21(chkFr21);

    if (file21.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch21 = _getch();
        exit(1);
    }


    // GetThatIntegrity
    std::string chkFr22 = rootDir + "GetThatIntegrity.exe";
    std::cout << chkFr22;
    std::ifstream file22(chkFr22);

    if (file22.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch22 = _getch();
        exit(1);
    }

    // GetThatUptime
    std::string chkFr23 = rootDir + "GetThatUptime.exe";
    std::cout << chkFr23;
    std::ifstream file23(chkFr23);

    if (file23.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch23 = _getch();
        exit(1);
    }

    // GetThatUninstaller
    std::string chkFr24 = rootDir + "GetThatUninstaller.exe";
    std::cout << chkFr24;
    std::ifstream file24(chkFr24);

    if (file24.good()) {
        std::cout << "\nFile exists\n";
    }
    else {
        std::cout << "\nFile does not exist\n";
        std::cout << "\nPlease re install GetThatOS\n";
        char ch24 = _getch();
        exit(1);
    }


    std::cout << "\nAll files validated\nPress any key to exit";
    char ch25 = _getch();
    return 0;
}


