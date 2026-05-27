# Gomez Corbalan,Juan Cruz
# 45059711
## ¿String es una tipo por valor o un tipo por referencia?
String es un tipo por referencia en C#.

## ¿Qué secuencias de escape tiene el tipo string?
Algunas de las secuencia de escape que tiene el tipo de string son:
#### \" (Comilla doble)
#### \\ (Barra invertida)
#### \n (Nueva linea)
#### \r (Retorno de carro)

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto? 
Cuando se utiliza el simbolo $ antes de una apertura de comillas dobles (para la string), si queremos concatenar el texto con una variable
basta con usar corchetes {}, ahorrandonos usar el + para concatenar variables y texto literal.
El simbolo @ por otra parte permite strings de multiples lineas y ademas literaliza el texto escrito, esto basicamente significa que en una cadena
se ignoran las reglas especiales de C# referidos a las secuencias de escape.
