#include <iostream>
#include <cstdlib>
#include <conio.h>

int main()
{
    std::cout << "make sure you have run this program as admin\n";
    std::cout << "press any key remove GetThatOS from your system\n";
    char ch = _getch();

    std::string fPath = "C:\\Program Files (x86)\\GetThatOS";
    std::string command = "rmdir /s /q \"" + fPath + "\"";
    int result = std::system(command.c_str());

    if (result == 0) {
        std::cout<< "GetThatOS removed\n";
    }
    else {
        std::cout<< "GetThatOS removal failed\n";
        }

        std::cout<< "press any key to exit";
        char ch1 = _getch();
        return 0;   
}
