# 📘 Planejamento do Projeto – Mini ERP Web

Este documento descreve o planejamento inicial do desenvolvimento de um sistema ERP para varejo, seguindo boas práticas de **Gerência de Projetos** e **Engenharia de Software**.

---

## 🧠 1. Visão Geral do Projeto

Objetivo: construir um sistema web para gestão de loja de varejo com as seguintes funcionalidades:

✅ Cadastro de clientes  
✅ Cadastro de fornecedores  
✅ Controle de estoque e itens  
✅ Contas a pagar e a receber  
✅ Relatórios gerenciais  
✅ Emissão de cupom fiscal (evolução futura para NF-e)

Tecnologias definidas:

- Backend: C# .NET Web API  
- Frontend: React + TypeScript  
- Banco de dados: MySQL  
- Arquitetura preparada para SaaS multi-loja

---

## 🟦 2. Gerência de Projeto

### 2.1 Escopo do MVP

O MVP deverá contemplar:

- Gestão de produtos e estoque  
- Registro de vendas  
- Contas a receber  
- Relatórios básicos  
- Autenticação de usuários

Ficam fora da versão inicial:

❌ NF-e completa  
❌ Integração contábil  
❌ Aplicativo mobile

### 2.2 Requisitos

#### Funcionais

- Cadastrar clientes e fornecedores  
- Registrar vendas com baixa automática de estoque  
- Gerar contas a receber  
- Emitir cupom simples  
- Consultar relatórios por período

#### Não funcionais

- Sistema web responsivo  
- Uso local inicialmente  
- Arquitetura preparada para nuvem  
- Backup periódico

### 2.3 Metodologia

Será adotado um modelo inspirado no SCRUM:

- Sprints semanais  
- Lista de tarefas priorizadas  
- Testes a cada entrega

---

## 🟩 3. Engenharia de Software

### 3.1 Domínio

Principais módulos:

- Comercial  
- Estoque  
- Financeiro  
- Fiscal

### 3.2 Entidades Principais

- Cliente  
- Fornecedor  
- Produto  
- Venda  
- ItemVenda  
- ContaReceber  
- ContaPagar  
- Usuário  
- Tenant

### 3.3 Regras de Negócio

- Não permitir venda sem estoque  
- Baixa automática ao vender  
- Contas a receber vinculadas à venda

---

## 🟧 4. Arquitetura do Sistema

### 4.1 Visão Geral

[React + TypeScript] → [API .NET] → [Banco de Dados]

### 4.2 Estrutura da Solução

MeuERP.sln
- Domain  
- Application  
- Infrastructure  
- API

### 4.3 Frontend

- Pages  
- Components  
- Services  
- Models  
- Contexts

---

## 🟪 5. Plano de Implementação

### Sprint 1 – Fundação

- Estrutura do projeto  
- Autenticação  
- Configuração do banco

### Sprint 2 – Cadastros

- Cliente  
- Produto  
- Fornecedor

### Sprint 3 – Estoque

- Entrada e saída  
- Consulta

### Sprint 4 – Vendas

- PDV simples  
- Baixa de estoque  
- Contas a receber

### Sprint 5 – Relatórios

- Vendas por período  
- Estoque  
- Financeiro

---

📌 Documento base para início do projeto Mini ERP.

