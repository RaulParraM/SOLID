Single Responsibility Principle (SRP)

Este Principio de SOLID busca la división del programa en pequeñas funciones que serán reutilizables en otra funcionalidad de nuestro
programa para así tener el codigo más ordenado y evitar copiar el mismo código en varias funciones.

En el ejemplo podemos ver dos archivos: SRPNoAplicado.cs y SRPAplicado.cs.

  *SRPNoAplicado.cs: La función CrearUsuario busca si el usuario existe y en caso de que no exista, lo crea y lo añade a la lista de
  usuarios.
  
  *SRPAplicado.cs: La función CrearUsuario llama a la función UsuarioCumpleCondiciones que a su vez llama a NoExisteUsuario.
  
La ventaja de aplicar SRP es que el código nos queda mucho más entendible y documentado y sobretodo que la función UsuarioCumplecondiciones
podría usarse también para el caso de Update usuario, por ejemplo. Si siguieramos el ejemplo de no aplicar SRP para la función
UPdateUsuario tendríamos que volver a picar la parte del código que comprueba que el nombre de usuario que queremso poner no exista en la
lista de los usuarios.
