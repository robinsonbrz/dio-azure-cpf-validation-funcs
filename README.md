<div width="720" >
  <h1 align="left">Projeto DIO / MS Azure para o bootcamp Az204 </h1>
  <h2 align="left">Este repositório contém uma função Lambda do Azure desenvolvida por Robinson Enedino, que tem como objetivo validar CPFs. Com deploy Azure functions.</h2>
  <h2 align="left"></h2>
  <br>
  <div align="center">
    <table>
      </tr>
            <td>
                <a  href="https://www.linkedin.com/in/robinsonbrz/">
            </td>
        <td>
            <a  href="https://www.linkedin.com/in/robinsonbrz/">
            <img src="https://raw.githubusercontent.com/robinsonbrz/robinsonbrz/main/static/img/linkedin.png" width="30" height="auto">
        </td>
        <td>
            <a  href="https://www.linkedin.com/in/robinsonbrz/">
            <img  src="https://avatars.githubusercontent.com/u/18150643?s=96&amp;v=4" alt="@robinsonbrz" width="30" height="auto">
        </td>
        <td>
            <a href="mailto:robinsonbrz@gmail.com">
            <img src="https://raw.githubusercontent.com/robinsonbrz/robinsonbrz/main/static/img/gmail.png" width="30" height="auto" ></a>
        </td>
      </tr>
    </table>
  </div>


### Funcionalidade
A função realiza a verificação do formato e da validade do CPF informado, utilizando a formatação xxx.xxx.xxx-xx (apenas números, com pontos e hífen). Se o CPF não for válido, a função retorna um erro 400 com a mensagem correspondente. Caso o CPF seja válido, é retornada uma resposta 200 confirmando que o CPF é válido.

### Estrutura do Projeto
Este projeto é uma Função Azure escrita em C# e utiliza a biblioteca Azure Functions SDK. O código implementa a validação do CPF através de uma expressão regular para assegurar que o CPF esteja no formato correto e que os dígitos verificadores sejam válidos.

### Arquivos principais:

fnvalidacpf.cs: Contém a lógica responsável pela validação do CPF.


### Sinta-se à vontade para explorar o código e contribuir com melhorias!


func init --worker-runtime dotnet

  <h1 align="center"> Informações e contato </h1> 
  <div align="center">
    <table>
        </tr>
            <td>
                <a  href="https://www.linkedin.com/in/robinsonbrz/">
                <img src="https://raw.githubusercontent.com/robinsonbrz/robinsonbrz/main/static/img/linkedin.png" width="100" height="100">
            </td>
            <td>
                <a  href="https://www.linkedin.com/in/robinsonbrz/">
                <img  src="https://avatars.githubusercontent.com/u/18150643?s=96&amp;v=4" alt="@robinsonbrz" width="30" height="30">
            </td>
            <td>
                <a href="mailto:robinsonbrz@gmail.com">
                <img src="https://raw.githubusercontent.com/robinsonbrz/robinsonbrz/main/static/img/gmail.png" width="120" height="120" ></a>
            </td>
        </tr>
    </table> 
  </div>
  <br>

</div>