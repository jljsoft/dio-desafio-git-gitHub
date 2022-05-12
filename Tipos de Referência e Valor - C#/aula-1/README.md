# Entendendo o que são Value Type e Reference Type
## Demo 1
O objetivo dessa demo e criar um metodo que receba um valor e altere esse valor para qualquer outro.
* Teste 1
    O primeiro teste deu um bug porque o metodo recebe uma copia do valor de a (declarado no main) e esta copia so e alterada no escopo do metodo. Sendo assim, quando a chamada morre na stack, o valor alterado e perdido, e o valor que é printado no console e da variavel a declarada o escopo do main.

* Teste 2
    Para retornar corretamente o valor modificado, alterou o metodo para que retornace um dado, ou seja, modificou de void(metodo sem retorno) para int(tipo do retorno desejado) 