# Sistema de Supermercado — CRUD, Compras e Emissão de Nota

## Integrantes
- AISHA MARCELE DE CARVALHO NICIOLI - RA: 923102713
- BRUNA FRAGA - RA: 922200048
- FELIPE FEITOZA SILVA - RA: 923102713
- MELISSA ALVES DE BRITO GOMES - RA: 922200341
- MURILO HENRIQUE DA SILVA RAFAEL - RA: 924111139
- TAYANE CRISTINA DOS SANTOS MAURICIO - RA: 923101903

---

## Descrição do Sistema

Sistema desktop desenvolvido em C# com Windows Forms para gerenciamento de supermercado.

O sistema permite:
- Cadastro de produtos
- Atualização de produtos
- Exclusão de produtos
- Listagem de produtos
- Registro de vendas
- Carrinho de compras
- Emissão de nota simples

---

## Tecnologias Utilizadas

- C#
- Windows Forms
- MySQL
- Visual Studio 2022
---

## Banco de Dados

### Criação do banco

- root123

```sql
CREATE DATABASE supermercado;

USE supermercado;

CREATE TABLE produtos (
    codigo INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
    categoria VARCHAR(50),
    quantidade INT,
    preco DECIMAL(10,2),
    dataCadastro DATE
);
```

ALTER TABLE produtos 
ADD COLUMN Imagem VARCHAR(255);

---

## Como Executar o Projeto

1. Abrir o projeto no Visual Studio
2. Executar o script SQL no MySQL
3. Verificar a string de conexão
4. Executar o sistema

---

## Funcionalidades

- CRUD completo de produtos
- Integração com banco de dados
- Tela de vendas
- Carrinho de compras
- Nota simples da compra

---

## Observações

Projeto desenvolvido para fins acadêmicos.
