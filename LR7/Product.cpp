//---------------------------------------------------------------------------

#pragma hdrstop

#include "Product.h"
//---------------------------------------------------------------------------
	Product::Product(void)
	{
	}

	Product::Product (string name,string cost,  string country, string category, string guarant){
		Name = name;
		Cost = cost;
		Category = category;
		Country = country;
		Guarant = guarant;
	}

	Product::Product(string category = "", string name = "",  string country= "")
	{

		Category = category;
		Name = name;
		Country = country;

	}

	Product::Product(string name)
	{
		Name = name;
	}

	Product::~Product(void)
	{
	}

	void Product::setCost(string cost)
	{
		Cost = cost;
	}

	string Product::getCost()
	{
		return Cost;
	}

	void Product::setCategory(string category)
	{
		Category = category;
	}

	string Product::getCategory()
	{
		return Category;
	}

	void Product::setName(string name)
	{
		Name = name;
	}

	string Product::getName()
	{
		return Name;
	}


	void Product::setCountry(string country)
	{
		Country = country;
	}

	string Product::getCountry()
	{
		return Country;
	}

	void Product::setGuarant(string guarant)
	{
		Guarant = guarant;
	}

	string Product::getGuarant()
	{
		return Guarant;
	}

#pragma package(smart_init)
