# Desafio Backend Totvs 2020

**¡Felicidades!** <br>
Estamos muy contentos de que hayas llegado tan lejos, y ahora es el momento de poner tus manos en el código y mostrar tus habilidades.
En este paso, queremos ver cómo piensa y cómo estructura su código, así que esto es lo que vamos a desarrollar.


## El desafío

Nuestro desafío es resolver la siguiente situación en el día a día de los operadores de punto de venta (PDV):<br><br>
Estos profesionales tienen mucha responsabilidad en sus manos y la mayor parte de su tiempo lo dedican a conseguir dinero de los clientes y, en algunos casos, a dar cambio.<br><br>
Su desafío es crear una API que lea el monto total a pagar y el monto realmente pagado por el cliente, luego informe la menor cantidad de billetes y monedas que se deben proporcionar como cambio.

## Reglas
* Billetes disponibles: **R$ 10,00 - R$ 20,00 - R$ 50,00 - R$ 100,00**
* Monedas disponibles: **R$ 0,01 - R$ 0,05 - R$ 0,10 - R$ 0,50**
* Entregar la menor cantidad de billetes posibles.

Ejemplo:<br><br>
```Valor del cambio: R$ 30,00```<br>
```Resultado esperado: Entregar 1 billete de R$20,00 y 1 billete de R$10,00```<br><br>
```Valor del cambio: R$ 80,00```<br>
```Resultado esperado: Entregar 1 billete de R$50,00, 1 billete de R$20,00 y 1 billete de R$10,00```<br>
