A) INFO MAS IMPORTANTE DEL PACIENTE(NOMBRE_COMPLETO, TIPO DE PACIENTE, CI, FECHA DE INGRESO)
B) Se debe almacenar el registro de pacientes en estructuras tipo hash de tamaño 23.
C) Existiran 2 Estructuras HASH la primera en su funcion hash, el numero de carnet de identidad como llave
para generar el indice de registro del paciente. La segunda estructura utilizara como llave de generacion
el nombre completo del paciente.
D) Para las colisiones se usara el metodo de encadenamiento mediante listas enlazadas creadas manualmente
cada elemento contendra a un paciente y una llave que permita encontrarlo.
E) Las listas generadas con llave CI deberan utilizar una busqueda binaria. Las listas generadas
con llave NOMBRE_COMPLETO deberan implementar una busqueda secuencial.
F) Sobre el menu:
	1. Añadir Paciente (1 PACIENTE O VARIOS)
	2. Buscar Paciente (CI O NOMBRE_COMPLETO)
	3. Eliminar Paciente (SE ELIMINA DE LAS 2 ESTRUCTURAS HASH)
	4. Imprimir Tabla HASH (BUSQUEDA SEQ, BUSQUEDA BINARIA)
	5. Salir
G) La opción de “Imprimir Tabla Hash” imprimirá todos los registros de la tabla (incluidos los que no
tengan elementos almacenados) y cuando se tenga mas de un elemento en alguna celda, se deberá
mostrar todos los elementos de la lista enlazada de este modo [indice] { llave -> llave2 }
H) Se medira los ticks en el momento de las busquedas en ambas tablas hash y se verificara si inlfuye
en la eficienca cuando las listas enlazadas vayan creciendo.
	

-Encontrar de forma imediata la info de cualquier paciente.
-TIEMPO DE BUSQUEDA CORTO.
	-Se puede encontrar el paciente mediante el CI o su Nombre Completo	
	-Un paciente puede ser dado de alta o detectarlo como un fallecido.
		-Si se le da de alta o fallece entonces este es eliminado de la base de datos


