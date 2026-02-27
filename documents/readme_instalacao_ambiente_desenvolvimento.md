# 📦 Ambiente de Desenvolvimento

Este documento descreve tudo que o desenvolvedor precisa ter instalado em sua máquina para executar o projeto corretamente.

---

# ✅ Pré-requisitos

Antes de iniciar o projeto, instale os seguintes softwares:

## 1️⃣ Git

Responsável pelo versionamento de código.

🔗 Download:
https://git-scm.com/downloads

Após instalar, verifique no terminal:

```bash
git --version
```

---

## 2️⃣ .NET SDK 9.0

Necessário para rodar a API Backend.

🔗 Download:
https://dotnet.microsoft.com/download

Após instalar, verifique:

```bash
dotnet --version
```

Deve retornar a versão 9.0.x

---

## 3️⃣ Node.js (Última versão LTS)

Necessário para rodar o Frontend (React + Vite).

🔗 Download:
https://nodejs.org/

Após instalar, verificar:

```bash
node -v
npm -v
```

---

## 4️⃣ MySQL Server

Banco de dados utilizado pelo sistema.

🔗 Download:
https://dev.mysql.com/downloads/mysql/

Durante a instalação:

- Definir senha para o usuário root
- Manter porta padrão (3306)

---

## 5️⃣ MySQL Workbench

Ferramenta gráfica para gerenciamento do banco de dados.

🔗 Download:
https://dev.mysql.com/downloads/workbench/

Utilizado para:

- Criar banco manualmente
- Executar scripts SQL
- Visualizar tabelas

---

## 6️⃣ Visual Studio Code

Editor recomendado para o projeto.

🔗 Download:
https://code.visualstudio.com/

### Extensões recomendadas:

- C#
- ES7+ React/Redux Snippets
- MySQL
- Prettier
- Thunder Client (para testar API)

---

# 🚀 Passos Após Instalação

## Backend

```bash
dotnet restore
dotnet ef database update
dotnet run
```

## Frontend

```bash
npm install
npm run dev
```

---

# 🔧 Configuração do Banco de Dados

No arquivo `appsettings.json`, configurar a string de conexão:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=NomeDoBanco;user=root;password=SUA_SENHA"
}
```

---

# 📌 Observações Importantes

- Certifique-se de que o MySQL esteja rodando
- Verifique se a porta 3306 não está bloqueada
- Sempre executar `npm install` ao baixar o projeto
- Sempre executar `dotnet restore` ao baixar o projeto

---

# 🧠 Requisitos Mínimos da Máquina

- 8GB de RAM recomendado
- Windows 10/11, Linux ou macOS
- 10GB livres em disco

---

# 📞 Suporte

Em caso de erro na configuração do ambiente, verifique as versões instaladas com:

```bash
git --version
dotnet --version
node -v
npm -v
```

Se persistir, entre em contato com o time de desenvolvimento.

---

✅ Ambiente pronto para desenvolvimento 🚀

