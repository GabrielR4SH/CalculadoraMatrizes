# Calculadora de Matrizes

## Introdução
A calculadora de matrizes é uma aplicação em C# que permite realizar operações básicas com matrizes, como adição e multiplicação. Este README fornecerá uma explicação sobre como as operações são realizadas e como usar o programa.

## Operações Suportadas

### Adição de Matrizes
A adição de duas matrizes A e B é feita somando os elementos correspondentes de cada matriz para obter uma nova matriz C. Por exemplo, se A e B são duas matrizes 2x2, a soma de A + B resultará em uma matriz 2x2 C, onde cada elemento C[i, j] é a soma dos elementos A[i, j] e B[i, j].

### Multiplicação de Matrizes
A multiplicação de duas matrizes A e B é feita multiplicando cada elemento da linha de A pelos elementos correspondentes da coluna de B e somando os resultados para obter um novo elemento da matriz resultante C. Por exemplo, se A é uma matriz 2x3 e B é uma matriz 3x2, a multiplicação de A por B resultará em uma matriz 2x2 C, onde cada elemento C[i, j] é calculado como a soma dos produtos dos elementos da linha i de A pelos elementos da coluna j de B.

## Como Usar o Programa

1. **Entrada de Dados**: Ao iniciar o programa, o usuário será solicitado a inserir o número de linhas e colunas da primeira e segunda matriz. Em seguida, o usuário deve inserir os elementos de cada matriz um por um, seguindo as instruções fornecidas no console.

2. **Operações Disponíveis**: Após inserir os elementos das duas matrizes, o programa calculará a soma e o produto das matrizes inseridas. Se as dimensões das matrizes não permitirem realizar essas operações, o programa exibirá uma mensagem de erro.

3. **Exibição do Resultado**: O programa exibirá o resultado da soma e do produto das matrizes no console.

## Exemplo de Uso
Suponha que queremos somar duas matrizes A e B:
<br>
A = | 1 2 |   B = | 3 4 |
    | 5 6 |       | 7 8 |

<p>A saída esperada seria:</p>
## Soma das matrizes:
4 6
12 14

## Produto das matrizes:
17 20
39 46


## Conclusão
A calculadora de matrizes em C# é uma ferramenta útil para realizar operações básicas com matrizes. Ela pode ser usada para adicionar e multiplicar matrizes de tamanhos diferentes, desde que as dimensões permitam as operações desejadas. Esperamos que este README tenha sido útil para entender como a calculadora de matrizes funciona e como usá-la.
