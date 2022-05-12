# Entendendo o que são Value Type e Reference Type
## Demo 1
O objetivo dessa demo e criar um metodo que receba um valor e altere esse valor para qualquer outro.
* Teste 1
    O primeiro teste deu um bug porque o metodo recebe uma copia do valor de a (declarado no main) e esta copia so e alterada no escopo do metodo. Sendo assim, quando a chamada morre na stack, o valor alterado e perdido, e o valor que é printado no console e da variavel a declarada o escopo do main.

* Teste 2
    Para retornar corretamente o valor modificado, alterou o metodo para que retornace um dado, ou seja, modificou de void(metodo sem retorno) para int(tipo do retorno desejado) 

## Demo 2
O objetivo desta demo e criar uma classe Pessoa com os seguintes atributos “Nome”, “Idade” e “Documento” e criar um metodo para alterar o nome de Pessoa e exibir o nome alterado.

* Teste 1
    Tendo em mente que uma classe e um reference type, sabemos que não será criado uma copia e sim uma referencia para a instância que esta na heap. Portando o primeiro teste será execultado com sucesso ja que no metodo existe uma referencia para a instância pessoa. Quando o nome for alterado, refletirar tambem na referencia criada no main.

* Teste 2 
    Criamos uma variavel do tipo Pessoa para quardar os valores de p1 e exibir o valor de p1 alterado e as antigas informações que foram atribuidas para p2. Porem p2 tambem sofre alteração ja que ao inves de receber os dados, p2 recebe a mesma referencia de p1 para os valores guardados na heap.

* Teste 3
    Criamos um novo objeto p2, com uma nova referencia para uma outra instância. Agora, p2 guarda as informações em uma nova instancia da heap.

* Teste 4
