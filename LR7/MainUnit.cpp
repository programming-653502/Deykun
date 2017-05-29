//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "MainUnit.h"
#include "Product.h"
#include "Unit1.h"
#include <fstream>
#include <string.h>
#include <sstream>
#include<stdlib.h>
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm3 *Form3;

ofstream fout ("d:\\report.txt", ios::app);
ifstream fin;
void main();
void addToBasket();

class List {
	Product *Head;

public:
	List() : Head(NULL) {};

	void 	Add(Product &product);
	void 	Show();
	void 	Search();
	bool 	tryFind(string);
	void 	basketShow();
	int  	Earning();
	string 	fileOutput();
	void 	Delete();
	void 	SearchAll();
};

List lst, basket;
//---------------------------------------------------------------------------
__fastcall TForm3::TForm3(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button6Click(TObject *Sender)
{
	Memo2->Clear();
	lst.Show();
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button1Click(TObject *Sender)
{
    Memo2->Clear();
	addToBasket();
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button2Click(TObject *Sender)
{
	Form1->Show();
	string list = basket.fileOutput();
	fout << list;
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button7Click(TObject *Sender)
{
	Memo2->Clear();
	Memo2->Lines->Add("Отчет о продажах за последний сеанс : ");
	basket.basketShow();
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button8Click(TObject *Sender)
{
	Memo2->Clear();
	basket.basketShow();
	int earnings = basket.Earning();
	stringstream cost;
	cost << earnings;
	string str = cost.str();
	Memo2->Lines->Add("Общая сумма выручки составляет : ");
	Memo2->Lines->Add(str.c_str());
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button9Click(TObject *Sender)
{
	 Memo2->Clear();
	 ifstream file ("d:\\report.txt");
	 string client, contact, product;
	 string str = "ФИО\tКонтакты\tТовар";

	 Memo2->Clear();
	 Memo2->Lines->Add(str.c_str());
	 while (file) {

		getline(file, product);
		getline(file, client);
		getline(file, contact);

		string report = client + "\t" + contact  + "\t\t"  + product;
		Memo2->Lines->Add(report.c_str());
   }
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button5Click(TObject *Sender)
{
	lst.Delete();
    basket.Delete();
	exit(0);
}
//---------------------------------------------------------------------------

void main() {
	fin.open("d:\\catalog.txt");
	if (!fin.is_open()) {
		ShowMessage( "Error! File is not found");
	}


	while (!fin.eof()){

		string Name, Category, Country, Guarant, Cost;
		getline(fin,Name);
		getline (fin,Cost);
		getline(fin, Country);
		getline(fin,Category);
		getline(fin, Guarant);
		Product product(Name, Cost, Country, Category, Guarant);
		lst.Add(product);

	}
	fin.close();
 }


void List::Add(Product &product)
{
	Product *temp = new Product;
	temp->Next = Head;

	string Name, Country, Category, Cost, Guarant;

	Name = product.getName();
	Category = product.getCategory();
	Country = product.getCountry();
	Cost = product.getCost();
	Guarant = product.getGuarant();

	temp->setName(Name);
	temp->setCountry(Country);
	temp->setCategory(Category);
	temp->setCost(Cost);
    temp->setGuarant(Guarant);

	Head = temp;
}

void List::Show()
{
   Form3->Memo2->Lines->Add("Продукт\tСтрана\t\tЦена\tГарантия");
	Product *temp = Head;
	while (temp != NULL)
	{

	   string str =  temp->getName() + "\t" + temp->getCountry() + "\t\t"
	   + temp->getCost() + "\t" + temp->getGuarant();
	   Form3->Memo2->Lines->Add(str.c_str());

		temp = temp->Next;
	}

}

void List::Search() {
	cout << "Введите наименование товара : ";
	string name;
	getline(cin, name);

	Product *temp = Head;
	while (temp != NULL)
	{
		if (temp->getName() == name) {
			cout << endl << temp->getCategory() << "\t";
			cout << temp->getName() << "\t";
			cout << temp->getCountry() << "\t" << endl;
		}

		temp = temp->Next;
	}

}

bool List::tryFind(string name) {
	bool result = false;
	Product *temp = Head;
	while (temp != NULL)
	{
		if (temp->getName() == name) {
			result = true;
		}

		temp = temp->Next;
	}
	return result;
}

string List::fileOutput() {
	Product *temp = Head;
	string list;
	while (temp != NULL)
	{
		list += temp->getName() + ", ";
		temp = temp->Next;
	}
	return list;
}

//---------------------------------------------------------------------------

 void addToBasket() {

	String  product = Form3->Edit1->Text;
	char* productC = AnsiString(product).c_str();
	string productS= string(productC);

	bool search = lst.tryFind(productS);
	if (search == false)
		ShowMessage("Такого товара не найдено! Попробуйте еще раз.");
	else
		{
			Product basketAdd(productS);
			basket.Add(basketAdd);
			ShowMessage("Товар добавлен в корзину.");
		}

}

void List::basketShow(){
	Product *temp = Head;
	while (temp != NULL)
	{
	   string str = temp->getName() + "\t" + temp->getCost();
	   Form3->Memo2->Lines->Add(str.c_str());

		temp = temp->Next;
	}
}

int List::Earning(){
	Product *temp = Head;
	int earning = 0;
	char* item;
	while (temp != NULL)
	{

	   strcpy( item, temp->getCost().c_str() );
	   Form3->Memo2->Lines->Add(item);
	   earning += atoi(item);
	   temp = temp->Next;
	}
	return earning;
}

void List::Delete(){
	while (Head!=NULL)
	{
		 Product *temp = Head->Next;
		 delete Head;
		 Head = temp;
	}

}

void List::SearchAll() {
    Product *temp = Head;
	while (temp != NULL)
	{
	   String info = Form3->Edit2->Text;
	   if (info == temp->getName().c_str()){
	   string str = temp->getName() + "\t" + temp->getCost() + "\t" + temp->getCountry() + "\t" + temp->getGuarant();
	   Form3->Memo2->Lines->Add(str.c_str());
	   }

	   else if (info == temp->getCost().c_str()){
	   string str = temp->getName() + "\t" + temp->getCost() + "\t" + temp->getCountry() + "\t" + temp->getGuarant();
	   Form3->Memo2->Lines->Add(str.c_str());
	   }

	   else if (info == temp->getCountry().c_str()){
	   string str = temp->getName() + "\t" + temp->getCost() + "\t" + temp->getCountry() + "\t" + temp->getGuarant();
	   Form3->Memo2->Lines->Add(str.c_str());
	   }

	   else if (info == temp->getCategory().c_str()){
	   string str = temp->getName() + "\t" + temp->getCost() + "\t" + temp->getCountry() + "\t" + temp->getGuarant();
	   Form3->Memo2->Lines->Add(str.c_str());
	   }


		temp = temp->Next;
	}
}

void __fastcall TForm3::FormCreate(TObject *Sender)
{
	Memo2->Clear();
	main();
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button3Click(TObject *Sender)
{
	Memo2->Clear();
	Memo2->Lines->Add("Товары в корзине : \n");
	string info = basket.fileOutput();
	Memo2->Lines->Add(info.c_str());
}
//---------------------------------------------------------------------------

void __fastcall TForm3::Button4Click(TObject *Sender)
{
	Memo2->Clear();
	basket.Delete();
	ShowMessage("Корзина очищена!");
}
//---------------------------------------------------------------------------

void __fastcall TForm3::Button10Click(TObject *Sender)
{
   Memo2->Clear();
   lst.SearchAll();
}
//---------------------------------------------------------------------------


