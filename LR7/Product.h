//---------------------------------------------------------------------------

#ifndef ProductH
#define ProductH
//---------------------------------------------------------------------------
#include<string>

using namespace std;

class Product
{
		string Guarant;
		string Country;
		string Name;
		string Cost;
		string Category;


	public:
		Product *Next;
		Product(void);
		Product (string);
		Product (string,string, string, string, string);
		Product (string category, string name, string country);
		void	setCost(string);
		string	getCost();
		void	setCategory(string);
		string	getCategory();
		void	setName(string);
		string	getName();
		void	setCountry(string);
		string	getCountry();
		void	setGuarant(string);
		string	getGuarant();
		void    setAvail(bool);
		bool    getAvail();


	~Product(void);
};
#endif
