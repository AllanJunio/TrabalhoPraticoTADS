# 🚗 Locadora de Veículos

Projeto desenvolvido para a disciplina de **Banco de Dados** utilizando **C#**, **SQL Server Express** e **Entity Framework Core**.

---

## 📋 Descrição
Sistema básico para gerenciamento de uma locadora de veículos, incluindo:

- Modelagem do banco de dados  
- Criação de registros  
- Execução de consultas  
- Implementação do backend

---

## 🏗️ Tecnologias
- **Linguagem:** C#  
- **Banco de Dados:** SQL Server Express  
- **ORM:** Entity Framework Core  

---

## 🗂️ Estrutura do Projeto

### Modelagem do Banco de Dados
- **Entidades principais:** `Veiculo`, `Fabricante`, `Cliente`, `Aluguel` e `Pagamento` (ou outra entidade extra criada).  
- **Relacionamentos:** Uso de chaves primárias e estrangeiras para garantir integridade dos dados.

### Regras Implementadas
- Cada **veículo** pertence a um **fabricante**.  
- **Cliente** possui **nome**, **CPF** e **e-mail** obrigatórios.  
- **Aluguel** vincula um cliente a um veículo com:
  - Data de início e data de devolução  
  - Quilometragem inicial e final  
  - Valor da diária e valor total da locação  

### Backend
- Classes de entidades em **C#** representando as tabelas do banco.  
- Mapeamento e migrações com **Entity Framework**.

---

## 🚀 Como Executar
dotnet build
dotnet run

1. **Clone este repositório:**
   ```bash
   git clone https://github.com/seu-usuario/locadora-veiculos.git
