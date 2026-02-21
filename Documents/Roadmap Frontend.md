
---

# 🧠 3. Organização por Responsabilidade

## pages/

Responsável pelas telas principais do sistema.

Exemplo:

- Listagem de clientes
- Cadastro de produto
- Tela de vendas (PDV)
- Relatórios

---

## components/

Componentes reutilizáveis:

- Botões
- Inputs
- Tabelas
- Layout (Sidebar, Header)

---

## services/

Responsável por comunicação com API.

- Centralizar Axios
- Adicionar interceptors
- Incluir token JWT automaticamente

---

## contexts/

Gerenciamento global de estado.

Inicialmente:

- AuthContext (usuário logado)
- Futuro: TenantContext

---

# Organização das pastas
frontend/
│
├── index.html
├── package.json
├── tsconfig.json
├── vite.config.ts
│
└── src/
│
├── assets/
│
├── pages/
│ ├── Login/
│ │ ├── LoginPage.tsx
│ │ └── styles.ts
│ │
│ ├── Clientes/
│ │ ├── ClienteListPage.tsx
│ │ └── ClienteFormPage.tsx
│ │
│ ├── Produtos/
│ │ ├── ProdutoListPage.tsx
│ │ └── ProdutoFormPage.tsx
│ │
│ ├── Vendas/
│ │ ├── PDVPage.tsx
│ │ └── VendaDetalhePage.tsx
│ │
│ └── Relatorios/
│ ├── VendasPeriodoPage.tsx
│ └── EstoquePage.tsx
│
├── components/
│ ├── layout/
│ │ ├── Sidebar.tsx
│ │ ├── Header.tsx
│ │ └── MainLayout.tsx
│ │
│ ├── forms/
│ │ ├── Input.tsx
│ │ ├── Select.tsx
│ │ └── FormContainer.tsx
│ │
│ ├── tables/
│ │ └── DataTable.tsx
│ │
│ └── ui/
│ ├── Button.tsx
│ ├── Modal.tsx
│ ├── Loader.tsx
│ └── Toast.tsx
│
├── services/
│ ├── api.ts
│ ├── authService.ts
│ ├── clienteService.ts
│ ├── produtoService.ts
│ ├── vendaService.ts
│ └── relatorioService.ts
│
├── models/
│ ├── Cliente.ts
│ ├── Produto.ts
│ ├── Venda.ts
│ └── Usuario.ts
│
├── contexts/
│ └── AuthContext.tsx
│
├── hooks/
│ └── useAuth.ts
│
├── routes/
│ ├── AppRoutes.tsx
│ └── PrivateRoute.tsx
│
├── utils/
│ ├── formatCurrency.ts
│ ├── formatDate.ts
│ └── constants.ts
│
├── App.tsx
└── main.tsx

# 🔐 4. Autenticação

Fluxo:

1. Usuário faz login
2. API retorna JWT
3. Token armazenado no localStorage
4. Axios envia token automaticamente
5. Rotas protegidas verificam autenticação

---

# 🚀 5. Roadmap por Sprint

## Sprint 1 – Base
- Criar projeto React + TS
- Configurar React Router
- Configurar Axios
- Criar layout base
- Criar tela de login

---

## Sprint 2 – Cadastros
- Tela de clientes
- Tela de produtos
- Tela de fornecedores
- Integração com API

---

## Sprint 3 – Estoque
- Tela de entrada de estoque
- Tela de consulta de estoque

---

## Sprint 4 – Vendas
- Criar tela de PDV
- Adicionar produtos à venda
- Calcular total automaticamente
- Finalizar venda

---

## Sprint 5 – Relatórios
- Tela de vendas por período
- Tela de contas a receber
- Dashboard simples

---

# 📏 6. Padrões Obrigatórios

- Componentização
- Separação entre página e componente
- Services separados por entidade
- Tipagem forte com TypeScript
- Não chamar API diretamente dentro do componente (usar service)
- Rotas protegidas

---

# 🎯 Objetivo Final

Frontend deve ser:

- Responsivo
- Modular
- Escalável
- Preparado para múltiplos módulos
- Preparado para SaaS multi-loja