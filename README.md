#Instalação de pacotes do nuget

#DotNetSeleniumExtras.WaitHelpers

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/e97fa4db-24e4-4fc2-bacd-9074cd4f6ad9) 

#FluentAssertions

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/ff48aecb-4969-4ebe-a6eb-e3f04676eba4)

#Microsoft.Net.Test.Sdk

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/378d0ce0-3dbf-49a7-8370-198666db73b4)

#NUnit

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/ed99670d-2ba8-47ae-8105-f898f3e2a8a8)

#NUnit3TestAdapter

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/125fbd5b-a1b1-4bd7-a575-279cde6d2ecd)

#Selenium.WebDriver

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/73c5626d-3b17-4b01-8d2c-b9e6b753a75f)

#Selenium.Webdriver.ChromeDriver

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/b908542b-03f5-4fbe-b0c9-17f51e0e452c)

#Specflow

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/a6b56f25-f39b-48e6-9d9b-4767fb70ff9a)

#Specflow.NUnit

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/d67fd7ed-dd0e-47cd-9cc8-852cd58f79f9)

#Specflow.Plus.LivingDocPlugin

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/66ca18a9-9186-427e-b940-9dad8578633c)

#Specflow.Tools.MsBuild

![image](https://github.com/Saulovilela/PraticaSeleniumCsharp/assets/87072804/ac89fc86-fec0-4409-ab0c-7f2a8cb97aaa)


# Dicas de git e github

criação de nova branch
Dentro da pasta do seu projeto dentro do terminal:
1. Certifique-se de estar na branch master: Primeiro, você precisa garantir que está na branch master. Você pode verificar isso executando git status no terminal.

2. digite git checkout -b nome-da-sua-nova-branch-exemplo

3. Faça suas alterações: Agora que você está na nova branch, você pode fazer suas alterações, adicionar, e fazer commit como de costume.

4. Faça push da nova branch para o repositório remoto (opcional): Se você quiser compartilhar sua nova branch com outros colaboradores ou com o repositório remoto, você pode fazer push usando:
git push origin nome-da-sua-nova-branch-exemplo

# Dicas para subir um projeto
depois de criada a branch e feitas as alterações faça:
git add . 
git commit -m'mensagem aqui'
git push origin develop: subir alterações 

para pegar alterações
git pull origin develop: pegar as alterações feitas

#para baixar o projeto
Para baixar um projeto do GitHub, você pode seguir estes passos básicos usando o Git:

1. **Clone o repositório:** Use o comando `git clone` seguido pelo URL do repositório GitHub. Por exemplo:

```bash
git clone https://github.com/usuario/nome-do-repositorio.git
```

Isso criará uma cópia do repositório no seu computador.

2. **Mude para o diretório do repositório:** Use o comando `cd` para entrar no diretório do repositório que você acabou de clonar. Por exemplo:

```bash
cd nome-do-repositorio
```

Agora você está dentro do diretório do projeto.

3. **Verifique as branches disponíveis (opcional):** Você pode verificar todas as branches disponíveis no repositório usando:

```bash
git branch -a
```

Isso listará todas as branches locais e remotas.

4. **Selecione a branch desejada (opcional):** Se você quiser mudar para uma branch específica, use o comando `git checkout` seguido pelo nome da branch. Por exemplo:

```bash
git checkout nome-da-branch
```

Isso mudará para a branch desejada.

Depois de seguir esses passos, você terá baixado o projeto do GitHub para o seu computador e estará pronto para começar a trabalhar nele localmente.
