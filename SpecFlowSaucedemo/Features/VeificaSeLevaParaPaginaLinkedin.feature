Feature: P�ginas de rede social
@login
Scenario: Veriica se leva para a p�gina do Linkedin da empresa
Given Estou na pagina inicial
When Rolo a tela para baixo
And Clico no botao do Linkedin
Then Devo ser redirecionado para a URL do Linkedin da empresa
