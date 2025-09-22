# 🏗️ Sistema de Orçamento de Obra - Backend (.NET)

Este projeto é um **backend em .NET** para gerenciamento de **orçamentos de obras**, permitindo cadastrar e organizar custos em diferentes categorias, como **materiais, mão de obra, transporte, equipamentos**, entre outros.  

Conta com suporte a **Swagger** para documentação e **migrations** para gerenciamento do banco de dados.

---

## 🚀 Tecnologias Utilizadas
- **.NET 9**
- **Entity Framework Core**
- **Swagger / Swashbuckle**
- **SQL Server** 
- **AutoMapper** 
- **DTOs + Validations**

---

## 📂 Estrutura do Projeto
OrçamentoObra/
├── Controllers/ # Controladores da API
├── Data/ # Contexto do banco de dados
├── Dto/ # Objetos de transferência de dados
├── Enum/ # Enums usados no sistema
├── Migrations/ # Migrações do Entity Framework
├── Models/ # Modelos de domínio
├── Profiles/ # Perfis do AutoMapper
├── Properties/ # Configurações do projeto
├── Services/ # Serviços com lógica de negócio
├── FileUploadOperationFilter.cs # Filtro para upload no Swagger
├── OrçamentoObra.csproj
├── Program.cs # Configuração inicial do projeto
├── appsettings.json # Configurações da aplicação
└── appsettings.Development.json # Configurações de dev

yaml
Copy code

---

## ⚙️ Como Rodar o Projeto

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) (6 ou 7, conforme seu projeto)  
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou outro banco configurado  

### Passos
```bash
# Clonar o repositório
git clone https://github.com/GustavoFhz/SistemaOrcamentoObra.git

# Entrar na pasta do backend
cd SistemaOrcamentoObra/backend/OrçamentoObra/OrçamentoObra

# Restaurar pacotes
dotnet restore

# Aplicar as migrations
dotnet ef database update

# Rodar a aplicação
dotnet run
A aplicação ficará disponível em:
👉 https://localhost:5001 (HTTPS)
👉 http://localhost:5000 (HTTP)

📖 Documentação da API
Swagger está configurado e disponível em:
👉 https://localhost:5001/swagger

📌 Funcionalidades (em desenvolvimento)
CRUD de categorias e itens de orçamento

Upload de arquivos via API

Cálculo de totalizadores

Versionamento de banco com migrations

Documentação automática com Swagger

🛠️ Próximos Passos
 Implementar autenticação (JWT)

 Adicionar testes unitários

 Criar integração com frontend

 Publicar API em ambiente de produção

👨‍💻 Autor
Desenvolvido por Gustavo Silva
💡 Projeto criado para fins de aprendizado e prática em .NET + EF Core + Swagger.
