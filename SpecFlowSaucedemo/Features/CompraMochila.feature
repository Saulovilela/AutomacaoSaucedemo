Feature: Comprando Mochila
@login
Scenario: Compra Mochila
Given que eu clique na imagem da mochila
When clicar em add ao carrinho
And clicar no carrinho
And clicar em checkout
And coloco os dados de nome sobrenome e cep
And clico em finalizar
Then terei feito com sucesso a compra