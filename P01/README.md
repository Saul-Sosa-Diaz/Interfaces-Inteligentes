# Introducción a Unity: 
* author: Saúl Sosa Díaz
* email: _alu0101404141@ull.edu.es_

## Resumen
En este repositorio se implementa un script, escrito sn C#, que muestra un mensaje por la consola del debug.
Además, se incluye un gif que muestra la ejecución del entorno en unity.

## Tareas
* _Incluir objetos 3D básicos._
Se ha añadido un cubo a la escena que se utilizará como personaje.
<br>
* _Incluir en el proyecto el paquete Starter Assets_.
Se han incluido [The Starter Assets - First Person Controller package](https://assetstore.unity.com/packages/essentials/starter-assets-first-person-character-controller-urp-196525) y [Starter Assets - Third Person Character Controller](https://assetstore.unity.com/packages/essentials/starter-assets-third-person-character-controller-urp-196526), los cuales no son compatibles con la versión 2022.3.8, resultando en muchos errores por incompatibilidad.
<br>
* _Utilizar prefabs de Starter Asset FPS o Third Person_.
Se ha utilizado el prefabs *PlayerFollowCamera* de _Starter Asset FPS_.  
Además, también se han importado algunos scripts incluidos en el paquete para manejar el control del personaje.
<br>
* _Incluir un objeto libre de la Asset Store que no sea de los Starter Assets_.
Se ha incluido el siguiente asset libre: [Palmera](https://assetstore.unity.com/packages/3d/vegetation/trees/palm-tree-123890).
<br>
* _Crear un terreno_.
Se ha creado un terreno y se le han aplicado diferentes materiales.
<br>
* _Cada objeto debe tener una etiqueta que lo identifique_.
Todos los objetos en la escena tienen su respectiva etiquieta, para ello se han creado tres etiquetas: Palm, Cube, Terrain
<br>
* _Cada objeto debe tener una etiqueta que lo identifique_.
Todos los objetos en la escena tienen su respectiva etiquieta, para ello se han creado tres etiquetas: Palm, Cube, Terrain.
<br>
* _Script que escriba en la consola los objetos que se han utilizado_.
Se ha utilizado una variable pública de tipo string, para controlar desde el entorno de unity, el tipo objeto que está ejecutando el script.

## Ejecución
![Ejecución](videogif.gif)
