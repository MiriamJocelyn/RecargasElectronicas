// millas a kilometros.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include<stdio.h>
int main()
{
	int condicion = 0;
	double numero = 0;
	double resultado = 0;
	double milla = 1.6093; //milla-kilometro
	double kilometro = 0.631388;//kilometro-milla
	printf("Ingrese la condición:\n");
	scanf("%d", &condicion);
	printf("Ingrese el valor a convertir: \n");
	scanf("%d", &numero);


	if (condicion == 0)
	{
		resultado = numero * kilometro;

	}
	else
	{
		resultado = numero * milla;
	}
	std::cout << resultado;
}

