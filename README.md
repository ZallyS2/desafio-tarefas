# 📝 API de Gerenciamento de Tarefas

Uma API RESTful desenvolvida em .NET para a trilha **DIO - API e Entity Framework**. Este projeto é um sistema simples de gerenciamento de tarefas que permite a organização da rotina através de operações CRUD (Criar, Ler, Atualizar, Deletar).

---

## 💻 Tecnologias Utilizadas

* **Linguagem**: C#
* **Framework**: .NET 8
* **Acesso a Dados**: Entity Framework Core
* **Banco de Dados**: MySQL
* **Testes**: Swagger (para documentação e testes dos endpoints)

---

## 🚀 Funcionalidades da API

A aplicação expõe uma série de endpoints para manipular os dados de tarefas. A classe principal `Tarefa` possui a seguinte estrutura:

| Propriedade | Tipo | Descrição |
| :--- | :--- | :--- |
| **Id** | `int` | Identificador único da tarefa. |
| **Titulo** | `string` | Título da tarefa. |
| **Descricao** | `string` | Descrição detalhada da tarefa. |
| **Data** | `DateTime` | Data para a qual a tarefa está agendada. |
| **Status** | `Enum` | Estado atual da tarefa (ex: `Pendente`, `Finalizado`). |

### **Endpoints**

| Método | Endpoint | Parâmetros | Descrição |
| :--- | :--- | :--- | :--- |
| `POST` | `/Tarefa` | - | Cria uma nova tarefa. |
| `GET` | `/Tarefa/{id}` | `id` | Retorna uma tarefa específica pelo seu ID. |
| `PUT` | `/Tarefa/{id}` | `id` | Atualiza uma tarefa existente pelo seu ID. |
| `DELETE` | `/Tarefa/{id}` | `id` | Deleta uma tarefa pelo seu ID. |
| `GET` | `/Tarefa/ObterTodos` | - | Retorna todas as tarefas cadastradas. |
| `GET` | `/Tarefa/ObterPorTitulo` | `titulo` | Retorna tarefas com base no título. |
| `GET` | `/Tarefa/ObterPorData` | `data` | Retorna tarefas com base na data. |
| `GET` | `/Tarefa/ObterPorStatus` | `status` | Retorna tarefas com base no status. |

---

## 🛠️ Como Executar o Projeto

1.  **Clone o Repositório**:
    ```bash
    git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)
    ```
2.  **Configurar a String de Conexão**:
    No arquivo `appsettings.json`, atualize a `ConnectionStrings` para apontar para seu banco de dados local.
3.  **Executar as Migrations**:
    Abra o terminal na pasta do projeto e execute os seguintes comandos para criar o banco de dados e a tabela `Tarefas`:
    ```bash
    dotnet ef database update
    ```
4.  **Executar a Aplicação**:
    ```bash
    dotnet run
    ```
    A API será iniciada e estará acessível geralmente em `https://localhost:7295/`.

---

## Feito com 💜 por Laila Zappiello

<a href='https://www.instagram.com/zzappiello.o/'><img src='https://img.shields.io/badge/-Instagram-%23E4405F?style=for-the-badge&logo=instagram&logoColor=white' /></a>
            <a href='mailto:lailazappiello90@gmail.com'><img src='https://img.shields.io/badge/Gmail-333333?style=for-the-badge&logo=gmail&logoColor=red' /></a>
            <a href='https://wa.me/5511981642627'><img src='https://img.shields.io/badge/WhatsApp-25D366?style=for-the-badge&logo=whatsapp&logoColor=white' /></a>
            <a href='https://www.linkedin.com/in/laila-zappiello/' target='_blank'><img src='https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white' target='_blank'></a> 
            <br><br>
            <p align='center'>
                🌌 <strong>'Em um lugar escuro estamos nós. E mais conhecimento ilumina nosso caminho.'</strong> – Star Wars
            </p>
            <p align='center'>
                <img src='https://github.com/zallih/Images/blob/main/Jedi%20grogu%F0%9F%92%9A.jpeg?raw=true' width='250px' />
            </p>
