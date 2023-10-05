# la-bodeguita-app

Datos a considerar para el uso del programa:
1. Tener la instancia por default de SQL Server "SQLEXPRESS" o tener identificado el nombre de la instancia local
2. Crear la base de datos local con el script bodeguitaBD.sql que se encuentra en el directorio "capa_datos"
3. En Visual studio, seleccionar el proyecto capa_datos en el explorador de archivos
4. Conectar la BD añadiendola desde "origen de datos" (teniendo previamente seleccionado el proyecto capa_datos)
5. Si seleccionó la instancia de SQL Server por default, el programa esta listo para conectarse con la BD. Si eligio otro, debe modificar el string de conexion en la clase datos_cliente con su instancia elegida
6. Por ultimo, para acceder a cada menu del sistema debe usar los siguientes usuarios en el login: 1 - Administrador; 2 - Supervisor; 3 - Vendedor

ERS: https://docs.google.com/document/d/1EYbKJGRKlkF2NouZH-YFr9591NWEvCgQw5QeAyjQ93M/edit?usp=sharing

DER: https://lucid.app/lucidchart/e56c03bc-cb52-4396-95c3-b49718c92112/edit?viewport_loc=-11%2C-11%2C1073%2C652%2C0_0&invitationId=inv_d299fc58-4e52-46e6-a3c7-598d968ba7cb
