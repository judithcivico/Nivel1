using System;

public class Persona(){
	public string nombre = "Paula";
    public int edad = 24;
    public string DNI = "12345678JN";
	
public Constructor(String nombre, int edad, int DNI){
	this.nombre = nombre;
	this.edad = edad;
	this.DNI = DNI;
	esMayorDeEdad();
	
	private String nombre {
		get { return nombre; }
		set { nombre = value; }
	}
	
	private int edad {
		get { return edad; }
		set { edad = value; }
	}
	
	private int DNI {
		get { return DNI; }
		set { DNI = value }
	}
}
public mostrar() {
	Console.WriteLine(get.nombre + get.edad; + get.DNI);
	get.nombre;
	get.edad;
	get.DNI;
	}
public esMayorDeEdad() {
	boolean mayor = false;
	if(edad=> 18) {
		mayor = true;
	}
	return mayor;
}
}