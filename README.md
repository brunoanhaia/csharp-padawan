# Calculadora

Hirosberto, que está participando do Padawan, só sabe pensar em
problemas matemáticos, por isso, para fixar seus conhecimentos na
linguagem C\# e orientação a objetos decidiu criar uma calculadora com
os seguintes requisitos:

- O software deverá aceitar como entrada uma **única** string contendo
  dois números e um caractere utilizado como operador, separados por
  um único espaço entre eles, ou seja, no seguinte formato:

  numero operador numero;

  Exemplo: 1 + 2

- Deverá suportar as seguintes operações:

  | **Operação**  | **Símbolo** |
  | ------------- | ----------- |
  | Adição        | +           |
  | Subtração     | -           |
  | Multiplicação | \*          |
  | Divisão       | /           |

- Ao receber uma entrada inválida o program deverá exibir a seguinte
  mensagem “Entrada inválida, por favor insira uma entrada válida”.

- O programa deverá ser executado até que seja inserida a string
  “SAIR”.

- As exceções deverão ser tratadas.

- Os resultados deverão ser exibidos com 3 casas decimais de precisão.

Faça como Hirosberto, crie um programa com as mesmas funcionalidades.
Veja abaixo alguns exemplos de entradas e saídas esperadas:

| **Entrada**      | **Saída**                                    |
| ---------------- | -------------------------------------------- |
| 7.99 + 8.21      | 16.200                                       |
| 1 - 100.4        | -99.400                                      |
| 45.091 \* 20.754 | 935.819                                      |
| 1 / 3            | 0.333                                        |
| 30.0 / 0         | “Não é possível realizar a divisão por zero” |
| Entrada vazia    | “Entrada inválida, tente novamente”          |
| 1.00+100         | “Entrada inválida, tente novamente”          |

