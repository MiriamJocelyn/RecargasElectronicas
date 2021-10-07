// ConsoleApplication1.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include <conio.h>

using namespace std;
//using namespace System; ctrl+k+c  descomentar es con ctrl+k+u
int main()
{
	char nombre[20];
	int i = 10;

	if (i > 10)   //10>10
		i++;  //i=i+1; i=11+1=12;
	i = i + 3; //i=10+3=13

	/*for (int i; i < 10; i++)
	{
	
	}*/
	int condicion=0;
	double numero=0;
	double resultado=0;
	double milla = 1.6093; //milla-kilometro
    double kilometro = 0.631388;//kilometro-milla
	printf("Ingrese la condición:\n");
	scanf("%f", &condicion);
	printf("Ingrese el valor a convertir: \n");
	scanf("%f", &numero);
	if(condicion==0)
	{
	resultado=numero*kilometro;	
		//cout<<"kilometro a milla"
	}
	else
	{
		//milla a kilometro
		resultado=numero*milla;
	}
	//cout<<

	cout << resultado;
	
	_getch();
	   
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
