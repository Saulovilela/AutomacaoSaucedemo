Feature: Deixando de inserir valor no campo de Cep
@login
Scenario: Não inserir valor no campo Cep

Given Dado que estou na tela inicial
When Quando Clico em Add to cart
And E Clico no botao de carrinho no canto superior direito
Then Entao Serei levado a tela para fazer Checkout

Given  Dado que Estou na tela de checkout
When Quando clico no botao de checkout
Then Entao serei levado para a tela de inserir dados para finalizar a compra

Given Estou na tela de Preencher os dados da compra
When Insiro first name e last name e deixo de inserir o campo Zip/Postal code
And E clico no botao continue
Then Deve aparecer uma mensagem de erro em vermelho Error: Postal Code is required