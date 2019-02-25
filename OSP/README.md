Open/Closed Principle (OSP)

Este Principio de SOLID obliga a que los programas sean Abiertos a la Extensión (Open) y cerrados a la Modificacón (Close). Pretende 
que el código de nuestros programas permite la inclusión de nuevas funciones, tipos o clases sin necesidad de cambiar código. Esto ayuda
a que los programas puedan ampliarse con facilidad, y a que el código sea más entendible.

En el ejemplo podemos ver dos archivos: OSPNoAplicado y OSPAplicado.cs.

*OSPNoAplicado: Tenemos dos clases hijas de Usuario (Admin y Común) y una clase con las carácterísticas de estos. Hay dos funciones que 
comprueban si dicho usuario puede Banear a otro, una para cada tipo de usuario.

*OSPAplicado: Tenemos las mismas clases que en el archivo anterior con la diferencia de que hay una única función que se adapta al tipo de 
usuario que reciba como entrada. De esta manera podemos añadir nuevas clases de manera limpia, sin tener que retocar el código de otras
clases.
