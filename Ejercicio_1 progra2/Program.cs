// See https://aka.ms/new-console-template for more information
using Ejercicio_1_progra2;



Pila pila = new Pila();


Object obj1 = "hola 1";

Object obj2 = "hola 2";

Object obj3 = "hola 3";

Object obj4 = "hola 4";

Object obj5 = "hola 5";

pila.aniadir(obj1);


Cola cola = new Cola();

cola.aniadir(obj1);
cola.aniadir(obj2);
cola.aniadir(obj3);
cola.aniadir(obj4);
cola.aniadir(obj5);

if (!cola.estaVacia())
Console.WriteLine(cola.primero().ToString());

if (!cola.estaVacia())
{ Console.WriteLine(cola.extraer().ToString()); }

if (!cola.estaVacia())
{ Console.WriteLine(cola.extraer().ToString()); }

if (!cola.estaVacia())
{ Console.WriteLine(cola.extraer().ToString()); }

if (!cola.estaVacia())
{ Console.WriteLine(cola.extraer().ToString()); }

if (!cola.estaVacia())
{ Console.WriteLine(cola.extraer().ToString()); }

if (!cola.estaVacia())
{ Console.WriteLine(cola.extraer().ToString()); }



//Console.WriteLine(pila.extraer().ToString());