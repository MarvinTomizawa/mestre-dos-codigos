# Dado que temos as duas tabelas abaixo:
```sql
    CREATE TABLE cliente (
            id        INT NOT NULL,
            nome      varchar(100) NOT NULL,
            cpf       varchar(30)  NOT NULL,
            telefone  varchar(40)  NULL,
            dtcriacao date,
            email     varchar(60)  NULL,
            PRIMARY KEY (id));

        CREATE TABLE vendas (
            id         int NOT NULL PRIMARY KEY,
            code       int NOT NULL,
            totalvenda float,
            dt_venda   date
            clienteID  int FOREIGN KEY REFERENCES cliente(id));
```

# Como existe um relacionamento entre as duas tabelas, assinale a consulta que irá ter a melhor performance e que está correta:

Opção 4:
```SQL
    SELECT c.nome, c.email
    FROM cliente c, vendas v
    WHERE dt_venda > '01/01/2019'
    AND v.clienteID = c.id
    ORDER BY c.nome, c.dtcriacao
```

![](Exercicio17.png)