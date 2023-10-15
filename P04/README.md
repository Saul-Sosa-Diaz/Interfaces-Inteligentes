# Delegados, Eventos: 
* author: Saúl Sosa Díaz
* email: _alu0101404141@ull.edu.es_

# Ejercicio 1:
A partir de la escena que has estado utilizando en las últimas prácticas, crea la siguiente mecánica. Cuando el cubo colisiona con el cilindro, las esferas de tipo 1 cambian su color y las esferas de tipo 2 se desplazan hacia el cilindro.
  
![Ejer1](ejer1.gif)

# Ejercicio 2:
Cuando el cubo colisiona con cualquier objeto que no sean esferas del grupo 1, las esferas en el grupo 1 se acercan al cilindro. Cuando el cubo toca cualquier esfera del grupo 1, las esferas del grupo 2 aumentan de tamaño.

![Ejer2](ejer2.gif)

# Ejercicio 3:
Cuando el cubo se aproxima al cilindro, las esferas del grupo 1 cambian su color y saltan y las esferas del grupo 2 se orientan hacia un objeto ubicado en la escena con ese propósito. 

![Ejer3](ejer3.gif)

# Ejercicio 4 y 5:
Implementar la mecánica de recoger esferas en la escena que actualicen la puntuación del jugador. Las esferas de tipo 1 suman 5 puntos y las esferas de tipo 2 suman 10. 
Partiendo del script anterior crea una interfaz que muestre la puntuación que va obteniendo el cubo. 

![Ejer4_5](ejer4_5.gif)

# Ejercicio 6:
Genera una escena que incluya elementos que se ajusten a la escena del prototipo y alguna de las mecánicas anteriores.

![Ejer6](ejer6.gif)

Lo que he implementado es lo siguiente:
* Movimiento de jugador.
    * Aquí tuve varios problemas. Al ser una cápsula, cuando tocaba con la parte esférica inferior perdía el equilibrio y caía.
    * Cuando el jugador muere pierde el control del movimiento, lo hago con un evento.
* Movimiento de cámara.
   * Cuando el jugado muere la cámara se aleja, esto lo hago con un evento.
* Movimiento de plataformas.
  * Utilicé la función seno para simular el movimiento de estas.
* Movimiento de la moneda.
  * Igual que las plataformas pero añadida una rotación.
* Gestión de muerte.
  * Cuando se toca el agua se lanza el mensaje. 
* Texto de muerte.
  * Información de la muerte.

