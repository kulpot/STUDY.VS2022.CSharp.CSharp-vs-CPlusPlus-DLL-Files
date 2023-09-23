//#include "MyCPlusPlus.h"	//<--------how class is link/created

class __declspec(dllexport) Cow
{
public:
	void Moo();
	void EatGrass();
};

void main()
{
	Cow c;
	c.Moo();
	c.EatGrass();
}