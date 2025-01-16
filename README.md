# dio-azure-cpf-validation-funcs

Projeto Diao / MS Azure para o bootcamp Az204 

## Aluno Robinson Enedino

ValidaCPF

Este repositório contém uma função Lambda do Azure desenvolvida por Robinson Enedino, que tem como objetivo validar CPFs. 

### Funcionalidade
A função realiza a verificação do formato e da validade do CPF informado, utilizando a formatação xxx.xxx.xxx-xx (apenas números, com pontos e hífen). Se o CPF não for válido, a função retorna um erro 400 com a mensagem correspondente. Caso o CPF seja válido, é retornada uma resposta 200 confirmando que o CPF é válido.

### Estrutura do Projeto
Este projeto é uma Função Azure escrita em C# e utiliza a biblioteca Azure Functions SDK. O código implementa a validação do CPF através de uma expressão regular para assegurar que o CPF esteja no formato correto e que os dígitos verificadores sejam válidos.

### Arquivos principais:

fnvalidacpf.cs: Contém a lógica responsável pela validação do CPF.


### Sinta-se à vontade para explorar o código e contribuir com melhorias!


func init --worker-runtime dotnet

