#include <iostream>
#include <sstream>
#include <string>

using namespace std;


bool check_N(string x, string& data_type, string& data_sign) {
	data_sign = "positive";
	data_type = "int";
	int count_sign = 0, count_type = 0;
	for (int i = 0; i < x.size(); i++) {
		if (((x[i] < '0' || x[i] > '9') && x[i] != '.' && x[i] != ',' && x[i] != '-') || count_sign > 1 || count_type > 1 || (x[i] == '-' && i != 0) || ((x[i] == '.' || x[i] == ',') && i == 0)) return false;
		if (x[i] == '-') {
			data_sign = "negative";
			count_sign++;
		}
		else if (x[i] == '.' || x[i] == ',') {
			data_type = "float";
			count_type++;
		}
	}
	return true;
}
int main() {
	setlocale(LC_ALL, "Russian");
	string data_type, data_sign;
	
	string N_s;
	cout << "Введите число длину массива N^ ";
	cin >> N_s;
	while (!check_N(N_s, data_type, data_sign) || stof(N_s) > 5 || stof(N_s) < 1 || data_type == "float") {
		if (!check_N(N_s, data_type, data_sign)) cout << "Неверный формат ввода числа!" << endl;
		else {
			if (stof(N_s) > 5 || stof(N_s) < 1) cout << "Ваше значение не входит в диапазон [1,5]." << endl;
			if (data_type == "float") cout << "Ваше значение нецелого типа. Размер массива может иметь только целочисленное значение." << endl;
		}
		
		cout << "Введите число длину массива N ";
		cin >> N_s;
	}
	int N = stoi(N_s);
	int* data = new int[N];


	return 0;
}