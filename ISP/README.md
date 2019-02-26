Interface Segregation Principle (ISP)

Este principio SOLID busca la ceración de interficies para definir comportamientos y así poder desacoplar de manera fácil.

En el ejemplo podemos ver dos archivos: ISPNoAplicado.cs y ISPAplicado.cs

*ISPNoAplicado: Cada clase de tipos de usuario: Admin, Prenuim y Normal y tal y como está organizado cada clase implementa todas las
funcionalidades pese a que dicha clase no sea capaz de ejercer esa funcionalidad.

*ISPAplicado: Cada clase de tipo de usuario tiene tantas interfaces com funciones puede realizar.

Al aplicar ISP el código queda mucho mejor organizado y limpio y cada clase tiene sus funcionalidades no las funcionalidades de otras clases
pese a no poder jercerlas.
