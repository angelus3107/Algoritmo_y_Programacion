Algoritmo MayorMenor_de_edad
	
	// Miguel Angel Amador Blanco
	
	// Entrada
	escribir "Ingrese el año actual"
	leer añoActual
	
	escribir "Ingrese su año de nacimiento" 
	leer añoNacimiento
	
	// Proceso 
	edad=añoActual - añoNacimiento
	
	
	// Salida logica
	si edad>= 18 Entonces
		Escribir "Es mayor de edad. Edad: ", edad
		
	SiNo
		Escribir "Es menor de edad. Edad: ", edad
	FinSi
FinAlgoritmo
