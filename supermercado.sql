create database supermercado;

use supermercado;

CREATE TABLE produtos (
    codigo INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
    categoria VARCHAR(50),
    quantidade INT,
    preco DECIMAL(10,2),
    dataCadastro DATE
);
SELECT * FROM produtos;