// Making this just because i can atp
#include <iostream>
#include <cstdlib>
#include<conio.h>

int main()
{
   std::cout << "Pinging GitHub\n ";
   int result = system("ping -n 3 github.com");
   
   if (result == 0) {
	   std::cout<< "\nResponse\n";
   }
   else {
	   std::cout<< "\nNo response\n";
   }

   std::cout << "Pinging Internet Archive\n ";
   int result1 = system("ping -n 3 archive.org");

   if (result1 == 0) {
	   std::cout << "\nResponse\n";
   }
   else {
	   std::cout << "\nNo response\n";
   }

   std::cout<<"\nChances are that if you ran this because a download was not working\nand both checks were successful then the Github repo\nor Archive.org link was taken down\n";
   std::cout << "\nPress any key to exit...";
   char ch = _getch();
   exit(1);

   return 0;
}


