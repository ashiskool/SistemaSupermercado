# Sistema de Supermercado — CRUD, Compras e Emissão de Nota

## Integrantes

- AISHA MARCELE DE CARVALHO NICIOLI - RA: 923102713
- BRUNA FRAGA - RA: 922200048
- FELIPE FEITOZA SILVA - RA: 923102713
- MELISSA ALVES DE BRITO GOMES - RA: 922200341
- MURILO HENRIQUE DA SILVA RAFAEL - RA: 924111139
- TAYANE CRISTINA DOS SANTOS MAURICIO - RA: 923101903

---

# Descrição do Sistema

Sistema desktop desenvolvido em C# com Windows Forms para gerenciamento de supermercado.

O sistema permite:

- Cadastro de produtos
- Atualização de produtos
- Exclusão de produtos
- Listagem de produtos
- Registro de vendas
- Carrinho de compras
- Emissão de nota fiscal simples
- Controle automático de estoque
- Cadastro de imagens dos produtos

---

# Tecnologias Utilizadas

- C#
- Windows Forms
- MySQL
- Visual Studio 2022
- .NET Framework 4.8

---

# Estrutura do Projeto

- FormCadastro → gerenciamento de produtos
- FormVendas → tela de vendas e carrinho
- FormNota → emissão da nota da compra
- Conexao.cs → conexão com banco de dados

---

# Banco de Dados

## Usuário padrão do MySQL

- Usuário: root
- Senha: root123

## Criação do banco

```sql
CREATE DATABASE supermercado;

USE supermercado;

CREATE TABLE produtos (
    codigo INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
    categoria VARCHAR(50),
    quantidade INT,
    preco DECIMAL(10,2),
    dataCadastro DATE,
    imagem VARCHAR(255)
);
```

---

# String de Conexão

```csharp
server=localhost;
database=supermercado;
uid=root;
pwd=root123;
```

---

# Como Executar o Projeto

1. Abrir o projeto no Visual Studio
2. Executar o script SQL no MySQL
3. Verificar a string de conexão no arquivo Conexao.cs
4. Executar o sistema

---

# Funcionalidades

- CRUD completo de produtos
- Integração com banco de dados
- Tela de vendas
- Carrinho de compras
- Nota fiscal simples
- Atualização automática do estoque
- Upload de imagens dos produtos

---

# Possíveis Problemas

Em alguns casos, o Visual Studio pode perder automaticamente os eventos dos componentes do Windows Forms.

Caso algum botão ou componente não funcione:

1. Selecione o componente no Designer
2. Abra a aba de propriedades
3. Clique no ícone de raio (Eventos)
4. Verifique se o evento está vinculado corretamente

## Exemplos de eventos

- Falha No botão Cadastrar Click → btnCadastrar_Click
- Falha no botão Excluir Click → btnExcluir_Click
- Falha no Botão Atualizar cadastro Click → btnAtualizar_Click
- Falha na integração das imagens, na aba pedido de vendas com SelectedIndexChanged → cmbProdutos_SelectedIndexChanged
- CellClick → dgvProdutos_CellClick

O evento `cmbProdutos_SelectedIndexChanged` é responsável por atualizar automaticamente a imagem do produto selecionado no PictureBox da tela de vendas.

Caso o campo esteja vazio, basta selecionar novamente a função correspondente.

---

# Observações

Projeto desenvolvido para fins acadêmicos.
