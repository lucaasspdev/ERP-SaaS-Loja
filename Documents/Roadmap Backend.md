# 📘 Roadmap Técnico – ERP SaaS Loja

## 📌 1. Objetivo

Este documento define o padrão arquitetural, organização de pastas e roadmap técnico para o desenvolvimento do ERP SaaS Loja.

Stack definida:

- Backend: .NET Web API
- Frontend: React + TypeScript
- Banco de Dados: MySQL
- Arquitetura: Clean Architecture
- Preparado para SaaS Multi-Tenant

---

# 🏗 2. Arquitetura do Sistema

O projeto deverá seguir o padrão **Clean Architecture**, com separação clara de responsabilidades.

## 🔷 Camadas

- **Domain** → Regras de negócio e entidades
- **Application** → Casos de uso
- **Infrastructure** → Persistência e integrações externas
- **API** → Camada HTTP (entrada da aplicação)

Regra obrigatória:

- Domain não depende de nenhuma camada
- Application depende apenas de Domain
- Infrastructure depende de Domain e Application
- API depende de Application e Infrastructure

---

# 📂 3. Estrutura Oficial de Pastas

## 📁 Estrutura Raiz
