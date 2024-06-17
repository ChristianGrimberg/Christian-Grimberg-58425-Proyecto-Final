[![Markdown Validation](https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Proyecto-Final/actions/workflows/markdown-validation.yml/badge.svg?branch=main)](https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Proyecto-Final/actions/workflows/markdown-validation.yml)
[![.NET Validation](https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Proyecto-Final/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Proyecto-Final/actions/workflows/dotnet.yml)

# Entrega del Proyecto Final

> Entrega definitiva de tu proyecto de fin de cursada.

## Entrega Final

### Objetivos generales

* Entregar el proyecto funcionando con los Endpoint con los métodos especificados en las clases 14 y 15.

### Objetivos específicos

* Se evaluará al alumno y se le dará una devolución de su desempeño en la cursada tanto como así en el proyecto.

### Formato

* Link del repositorio del proyecto en Github. (Subir la versión entregable del código a una rama llamada “master”)

### Sugerencias

* Se debe comprobar que todos los puntos a resolver estén completados

### Se debe entregar una API que siga las siguientes instrucciones

* Traer Nombre
* ~~Inicio de sesión~~
* Crear usuario
* Modificar Usuario
* Traer usuario
* Eliminar usuario
* Crear producto
* Modificar producto
* Eliminar producto
* Cargar Venta
* Eliminar venta
* Traer productos
* Traer Productos Vendidos
* Traer ventas

# Primera entrega de tu Proyecto final

> Debes entregar la primera pre-entrega de tu proyecto final.

## Primera entrega

> Entrega realizada: <https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Proyecto-Final/releases/tag/v1.0.0>

### Objetivos generales

* Armar la primera estructura en Capas conteniendo las capas de Entidades, Negocio y Acceso a Datos. Opcionalmente una interfaz ya sea de consola o de escritorio (capa de presentación).

### Objetivos específicos

* Se debe mostrar la ejecución, los distintos métodos creados aplicando arquitectura en capas.

### Formato

* Link del repositorio del proyecto en Github. (Subir la versión entregable del código a una rama llamada “master”)

### Sugerencias

* Se debe comprobar que todos los datos pedidos y traídos deben ser los solicitados en la entrega.
* Verificar dependencias de las capas como corresponde al modelo de Capas trabajado.
* El proyecto de Consola o Escritorio es opcional, se recomienda el proyecto en sí para que puedan probar la comunicación entre las capas pero no todo el diseño.

### Se debe entregar

* Solución desarrollada en Capas
* Una solución que se llame SistemaGestion que contenga
  * Una Librería de Clases llamada SistemaGestionEntities
  * Una Librería de Clases llamada SistemaGestionData
  * Una Librería de Clases llamada SistemaGestionBussiness
  * Un proyecto de Escritorio o Consola llamado SistemaGestionUI __(Código OPCIONAL)__
  * Un proyecto de Libreria de clases llamado SistemaGestionEntities
    * Aquí debe agregar las clases creadas en la entrega de clase 6
  * Un proyecto de Libreria de Clases llamado SistemaGestionData
    * Aquí debe agregar todas las clases creadas en la entrega de la clase 11
  * Un proyecto de Librería de clases llamado SistemaGestionBussines
    * Crear las siguientes clases staticas con sus respectivos métodos, __cada método invocará al método correspondiente de su clase asociada en la capa de Datos__.
      * ProductoBussiness
      * UsuarioBussiness
      * VentaBussiness
      * ProductoVendidoBussiness
  * Un proyecto de Escritorio o Consola llamado SistemaGestionUI
    * Interface para Listar Usuarios, dar de alta, baja y modificación
    * Interface para Listar Productos, dar de alta, baja y modificación
    * Interface para Listar Ventas, dar de alta, baja y modificación
    * Interface para Listar productos de una venta, agregar artículos a una venta, quitarlos o modificarlos

> NOTA: No es obligatorio en la entrega, pero el que desee sumarlo aportaría un gran valor
