Feature: Calculator

@CalculadoraSuma
Scenario: Operar dos numeros
	Given entro a la pagina de la calculadora
	Then la operacion es suma
	Then el primer numero es 30
	Then el segundo numero 25
	Then el resultado debe ser 55
	Then la operacion es multiplicacion
	Then el resultado es 750
	Then la operacion es division
	Then el resultado debe dar 1.2
	Then la operacion es resta
	Then la operacion resulta 5