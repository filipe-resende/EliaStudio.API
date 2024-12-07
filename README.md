# API de Arquitetura - C# .NET 6

Este projeto é uma **API** desenvolvida para um escritório de arquitetura, com o objetivo de gerenciar e fornecer informações sobre os serviços, portfólio e contato de forma estruturada. A API fornece endpoints para acesso aos dados do escritório, permitindo que outras aplicações consumam e apresentem essas informações de forma flexível.

---

## 📖 Sobre o Projeto

A **API de Arquitetura** foi criada para o gerenciamento das informações e dados essenciais de um escritório de arquitetura. Com ela, é possível acessar os serviços oferecidos, visualizar projetos realizados, obter informações sobre o escritório e enviar contatos. A API está construída com **C#** e utiliza o **.NET 6** como framework para garantir alto desempenho e escalabilidade.

### Funcionalidades principais:
- **Serviços**: Endpoint para obter os serviços oferecidos pelo escritório, como design arquitetônico, consultoria e gerenciamento de projetos.
- **Portfólio**: Endpoint para listar os projetos realizados, com descrição e imagens.
- **Informações do Escritório**: Endpoint que fornece informações sobre a história do escritório, missão, visão e valores.
- **Formulário de Contato**: Endpoint para o envio de mensagens ou solicitações de contato para o escritório.

---

## 🔧 Funcionalidades

- **Obtenção de Serviços**: A API permite consultar os serviços oferecidos pelo escritório de forma estruturada.
- **Exibição de Portfólio**: Possibilidade de acessar os projetos realizados, com imagens e descrições detalhadas.
- **Informações Institucionais**: Endpoint para obter informações sobre a missão, visão e história do escritório.
- **Formulário de Contato**: Permite o envio de mensagens através de um endpoint dedicado para o envio de informações de contato.

---

## 🛠 Tecnologias Utilizadas

- **C# .NET 6**: Framework principal para desenvolvimento da API.
- **Entity Framework Core**: Para acesso e manipulação do banco de dados.
- **Swagger**: Para documentação interativa da API.
- **SQL Server** (ou outro banco de dados relacional): Para persistência dos dados.
- **AutoMapper**: Para mapeamento entre DTOs e modelos de dados.
- **ASP.NET Core**: Framework para criação da API RESTful.

---

## 🔧 Como Rodar o Projeto

### Pré-requisitos

Certifique-se de ter o **.NET 6 SDK** instalado no seu sistema. Caso não tenha, você pode baixar a versão mais recente do **.NET** [aqui](https://dotnet.microsoft.com/download).

### Instalação

1. **Clone o repositório:**
    ```bash
    git clone https://github.com/seu-usuario/arquitetura-api.git
    cd arquitetura-api
    ```

2. **Instale as dependências e pacotes do projeto:**
    - No terminal, na raiz do projeto, execute:
    ```bash
    dotnet restore
    ```

3. **Compile e execute a API:**
    - Para compilar o projeto, execute:
    ```bash
    dotnet build
    ```

    - Para rodar a API, execute:
    ```bash
    dotnet run
    ```

4. **Acesse a API:**
    - A API estará disponível em [http://localhost:5000](http://localhost:5000).

5. **Documentação da API:**
    - A documentação interativa da API estará disponível em [http://localhost:5000/swagger](http://localhost:5000/swagger).

---

## 📂 Estrutura do Projeto

- **/Controllers**: Contém os controladores da API, responsáveis por lidar com as requisições HTTP e fornecer as respostas.
- **/Models**: Contém as classes de modelo que representam os dados que serão manipulados.
- **/DTOs**: Data Transfer Objects (DTOs) usados para transferir dados entre o cliente e o servidor.
- **/Services**: Contém a lógica de negócio da aplicação.
- **/Data**: Configurações de banco de dados, como o contexto do Entity Framework e as migrações.
- **/Config**: Arquivos de configuração, como o setup do Swagger e outras configurações globais.
- **/wwwroot**: Arquivos estáticos (se houver), como imagens e documentos.

---

## 🤝 Contribuição

Se você deseja contribuir para este projeto, siga as etapas abaixo:

1. Faça um fork do repositório.
2. Crie uma branch para sua feature (`git checkout -b feature/nome-da-feature`).
3. Faça suas alterações e commit (`git commit -am 'Adiciona nova feature'`).
4. Envie sua branch (`git push origin feature/nome-da-feature`).
5. Crie um pull request.

---

## 📝 Licença

Este projeto está licenciado sob os termos da MIT License - veja o arquivo [LICENSE](./LICENSE) para mais detalhes.
