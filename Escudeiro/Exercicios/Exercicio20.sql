 CREATE TABLE cliente (
	id        INT NOT NULL,
	nome      varchar(100) NOT NULL,
	telefone  varchar(40)  NULL,
	email     varchar(60)  NULL,
	PRIMARY KEY (id)
);

CREATE INDEX idx_cliente ON cliente(id);


create table endereco (
	id        INT NOT NULL,
	rua  	  varchar(100) NOT NULL,
	cidade    varchar(30) NOT NULL,
	estado    varchar(2) NOT NULL,
	bairro    varchar(50) NOT NULL,
	PRIMARY KEY (id)
);

CREATE INDEX idx_endereco ON endereco(id);

create table cliente_endereco(
	id_cliente INT NOT NULL,
	id_endereco INT NOT NULL,
	constraint cliente_endereco_pk primary key (id_cliente, id_endereco),
	constraint cliente_endereco_cliente_fk foreign key (id_cliente) references cliente(id),
	constraint cliente_endereco_endereco_fk foreign key (id_endereco) references endereco(id)
);

 CREATE TABLE usuario (
	id        INT NOT NULL,
	nome      varchar(100) NOT NULL,
	PRIMARY KEY (id)
);

CREATE INDEX idx_usuario ON usuario(id);

create table usuario_endereco(
	id_usuario INT NOT NULL,
	id_endereco INT NOT NULL,
	constraint usuario_endereco_pk primary key (id_usuario, id_endereco),
	constraint usuario_endereco_usuario_fk foreign key (id_usuario) references usuario(id),
	constraint usuario_endereco_endereco_fk foreign key (id_endereco) references endereco(id)
);

 CREATE TABLE fornecedor (
	id        INT NOT NULL,
	nome      varchar(100) NOT NULL,
	PRIMARY KEY (id)
);
CREATE INDEX idx_fornecedor ON fornecedor(id);

create table fornecedor_endereco(
	id_fornecedor INT NOT NULL,
	id_endereco INT NOT NULL,
	constraint fornecedor_endereco_pk primary key (id_fornecedor, id_endereco),
	constraint fornecedor_endereco_fornecedor_fk foreign key (id_fornecedor) references fornecedor(id),
	constraint fornecedor_endereco_endereco_fk foreign key (id_endereco) references endereco(id)
);

 CREATE TABLE funcionario (
	id        INT NOT NULL,
	nome      varchar(100) NOT NULL,
	PRIMARY KEY (id)
);
CREATE INDEX idx_funcionario ON funcionario(id);

create table funcionario_endereco(
	id_funcionario INT NOT NULL,
	id_endereco INT NOT NULL,
	constraint usuario_funcionario_pk primary key (id_funcionario, id_endereco),
	constraint funcionario_endereco_funcionario_fk foreign key (id_funcionario) references funcionario(id),
	constraint funcionario_endereco_endereco_fk foreign key (id_endereco) references endereco(id)
);