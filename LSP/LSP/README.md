Liskov substitution Principle (LSP)

Este principio de SOLID se basa en el principio de Liskov que viene a decir que cada clase que hereda de otra puede usarse 
como su padre sin necesidad de conocer las diferencias entre ellas. En otras palabras, podemos crear clases hijas de la clase padre
que puedan sobreescrivir métodos de esta. Esto es muy cómodo para agregar nuevas clases aun sin tener pensado desde el primer momento
que se hizo el programa que se ibana a añadir más casuísticas.

En el ejemplo podemos ver un archivo: programador.cs

Este archivo contiene 3 clases:

*ProgramadorJunior: es la clase padre y la que inicialmente ha existido. Hay una fuinción quye devuelve el el sueldo mensual. Ha habido 
un cambio en la política de empresa y quieren incitar a los júnior a dar más de sí así que los más mediocres tendrán un sueldo algo inferior
y los mejores tendrán un sueldo superior.

*Brillante y Mediocre: Son hijos de ProgramadorJunior y implementan el método de obtención de sueldo añadiéndole la opción de override
lo cual permitirá que se pueda sobreescribir las función del padre para así usar la suya.

La ventaja de aplicar este principio es que se hace muy fácil ampliar las clases de nuestro programa sin tener que modificar nada del código ya
existente y así respetando el principio de OPS.
