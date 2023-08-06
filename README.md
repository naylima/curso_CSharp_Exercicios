# Lista 1 - Nivelamento C#

Este repositório contém soluções para uma lista de exercícios de nivelamento em C#.

## Exercícios

### Exercício 1
Um imposto é calculado com base nas seguintes condições: 
- Até 1.200,00 isento 
- De 1.201,00 a 2.500,00 10% 
- De 2.501,00 a 5.000,00 15% 
- Acima de 5.000,00 20%. 

O programa lê o valor base e calcula o imposto a pagar.

### Exercício 2
A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. 

O algoritmo lê o número de horas trabalhadas em um mês, o salário por hora e escreve o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considera-se que o mês possua 4 semanas exatas). 

### Exercício 3
O algoritmo lê a quantidade atual em estoque, quantidade máxima em estoque e quantidade mínima em estoque de um produto. Calcula e escreve a quantidade média ((quantidade média = quantidade máxima + quantidade mínima)/2). 

Se a quantidade em estoque for maior ou igual a quantidade média escreve a mensagem 'Não efetuar compra', senão escreve a mensagem 'Efetuar compra'. 

### Exercício 4
O programa preenche um vetor de 100 elementos com valores inteiros aleatórios, e identifica o maior e o menor número gerados, e suas respectivas posições. 

### Exercício 5
Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.

O algoritmo lê o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) é solicitado um novo código (até que seja válido). 

O programa é encerrado quando o código informado for o número 4. A mensagem "MUITO OBRIGADO" é exibida e a quantidade de clientes que abasteceram cada tipo de combustível. 

### Exercício 6
O programa lê um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostra quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 

## Como usar

Cada exercício está em sua própria classe na pasta "Exercicios". Para executar um exercício específico, vá ao método `Main` na classe `Program` e chame o método `Executar` na classe do exercício que você deseja executar.

Exemplo:
```csharp
Exercicio1.Executar();
```
