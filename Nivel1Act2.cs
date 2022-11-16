using System;

public class Cuenta(){
	public String titular = "Pepe";
	public double cantidad = 2300;
	
public Cuenta(String titular, double cantidad) {
	this.titular = titular;
	this.cantidad =  cantidad;
	
	private String titular {
		get { return titular; }
		set { titular = value; }
	}
	
	private double cantidad {
		get { return cantidad; }
		set { cantidad = value; }
	}
}
public mostrar() {
	Console.WriteLine(get.titular " tu saldo es de: "+ get.cantidad);
	}
	
public ingresar() {
	Console.WriteLine("Tu saldo: "+ get.cantidad);
	Console.WriteLine("¿Cuanto dinero quieres ingresar?: ");
	double cantidadIngresar = double.Parse(Console.ReadLine());
	
	if (cantidadIngresar = 0) {
		Console.WriteLine("El numero introducido es invalido ");
	} else {
		cantidadIngresar = cantidad + cantidadIngresar;
	} while (cantidad != 0);
	Console.WriteLine("Tu saldo: " + cantidad);
	Console.Read();
}

public retirar() {
	Console.WriteLine("Tu saldo: "+ get.cantidad);
	Console.WriteLine("¿Cuanto dinero quieres retirar?: ");
	double cantidadRetirar = double.Parse(Console.ReadLine());
	
	if (cantidadRetirar > get.cantidad || cantidadRetirar < 0) {
		Console.WriteLine("El numero introducido es invalido ");
	} else {
		cantidadRetirar = cantidad - cantidadRetirar;
	} while (cantidad != 0);
	Console.WriteLine("Tu saldo: " + cantidad);
	Console.Read();
}