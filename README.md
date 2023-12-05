# Conjunto de proyectos

En este repositorio, se encuentran diversas secciones de una prueba. A continuación, se presentarán detalladamente las distintas partes de dicho examen, proporcionando un conjunto completo de recursos para su análisis y comprensión.


## Tecnologías Utilizadas:

**ASP.NET MVC:** La aplicación se basa en ASP.NET MVC, un marco de desarrollo web que facilita la creación de aplicaciones web escalables y mantenibles. Utiliza el patrón Modelo-Vista-Controlador (MVC) para organizar la lógica de la aplicación.

**C#:** El lenguaje de programación C# se utiliza en el lado del servidor para implementar la lógica de la aplicación. Esto incluye la gestión de solicitudes web, la interacción con la base de datos y la validación de datos.

**SQL Server:** La base de datos subyacente utiliza SQL Server para almacenar y gestionar la información de libros y autores. Entity Framework se utiliza para interactuar con la base de datos.

**Entity Framework:** Se utiliza Entity Framework, un ORM (Object-Relational Mapping), para mapear objetos de la aplicación a tablas de la base de datos y simplificar las operaciones de base de datos. Se emplea Fluent API para configurar el modelo de datos, establecer relaciones avanzadas entre tablas y proporcionar datos iniciales.

**Bootstrap:** La capa de diseño de la aplicación se mejora con el uso de Bootstrap, un framework CSS que proporciona un diseño receptivo y atractivo. Esto garantiza una experiencia de usuario agradable.

**Inyección de Dependencias:** La inyección de dependencias se utiliza para administrar las dependencias de los componentes de la aplicación y promover un diseño modular y mantenible.

**Swagger:** Se implementa el middleware Swagger para documentar la API de la aplicación de manera clara y accesible. Esto facilita la comprensión y el consumo de la API (La implementacion de la API y el consumo se encuentran dentro de la misma solucion).

  




## Observaciones

La base de datos no requiere la ejecución de consultas directas, ya que EF Core se encarga de crear la base de datos 'MidleDb' y Fluent API se encarga de la definición de tablas y la inserción de datos iniciales de manera automática.

Para la seccion numero 5 se implemento como patron de diseño mvc, debido a la operabilidad de la seccion 3 - 4.

No se realizó la sección de pruebas, pero originalmente se tenía la intención de utilizar xUnit para llevar a cabo cinco pruebas unitarias. Estas pruebas se habrían centrado en validar diferentes aspectos del código, como la funcionalidad de módulos clave, la manipulación correcta de datos de entrada, la gestión adecuada de excepciones y la verificación de la integridad de los resultados.



## Funcionalidades

### Seccion 1

#### Ejercicio 1
![Ejercicio 1 ](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura1.png) 

#### Ejercicio 2

![Ejercicio 2](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura2.png)


### Seccion 2

![API](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura3.png)

### Seccion 3

#### Consulta de datos en sql server

![Base de datos ](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura4.png)

#### Nueva Consulta con Usuario

![Base de datos ](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura5.png)

#### Tabla de la base de datos en Azure SQL

![Base de datos ](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura6.png)

### Seccion 4

##### Pagina Principal del UI 
![Base de datos ](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura7.png)

#### Nueva Consulta 
![Base de datos ](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura8.png)

#### Resultado
![Base de datos ](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura9.png)

#### Pagina Prncipal con nueva Consulta
![Base de datos ](https://raw.githubusercontent.com/AlwayzCesta/Prueba/main/Imagenes/Captura10.png)


