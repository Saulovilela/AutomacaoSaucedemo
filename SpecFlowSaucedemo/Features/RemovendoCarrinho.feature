Feature: Removendo um Produto
@login
Scenario: Remove Produto

Given Estou na tela inicial
When  Clico em Add to cart
And Clico no botao de carrinho no canto superior direito
Then Serei levado a tela para fazer Checkout

Given Estou na tela de checkout
When Clico no botao Remove
Then O produto adicionado deve ser removido do carrinho

Given Apos o produto ser removido do carrinho
When Clico no botao continue shopping
Then Devo voltar a tela inicial com o botao add to cart disponivel para ser clicado novamente