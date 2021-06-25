-- Feito com postgres

CREATE TYPE lending_type AS ENUM (
	'borrow',
	'lend');

CREATE TYPE purchase_status AS ENUM (
	'not_payed',
	'payed',
	'refunded');

CREATE TYPE weekday AS ENUM (
	'segunda',
	'terca',
	'quarta',
	'quinta',
	'sexta',
	'sabado',
	'domingo');
	
CREATE TABLE public.investment_user (
	id uuid NOT NULL,
	username varchar(100) NOT NULL,
	"password" varchar(100) NOT NULL,
	email varchar(150) NOT NULL,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	id_refer_friend uuid NULL,
	CONSTRAINT investment_user_pk PRIMARY KEY (id),
	CONSTRAINT investment_user_fk FOREIGN KEY (id_refer_friend) REFERENCES investment_user(id)
);

CREATE INDEX idx_investment_user ON investment_user(id);

CREATE TABLE public.purchase_type (
	id uuid NOT NULL,
	name varchar(100) NOT NULL,
	created_by uuid NOT NULL,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	CONSTRAINT purchase_type_pk PRIMARY KEY (id)
);

CREATE INDEX idx_investment_user ON investment_user(id);

CREATE TABLE public.card (
	id uuid NOT NULL,
	"number" numeric NOT NULL,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	bank_name varchar(100) NOT NULL,
	user_id uuid NOT NULL,
	CONSTRAINT card_pk PRIMARY KEY (id),
	CONSTRAINT card_fk FOREIGN KEY (user_id) REFERENCES investment_user(id)
);

CREATE INDEX idx_card ON "card"(id);

CREATE TABLE public.credit_card (
	id uuid NOT NULL,
	"limit" money NOT NULL,
	name varchar(100) NOT NULL,
	created_at timestamp(0) NOT NULL,
	updated_at timestamp(0) NULL,
	card_id uuid NOT NULL,
	deleted_at timestamp(0) NULL,
	close_day int2 NOT NULL,
	payment_day int2 NOT NULL,
	CONSTRAINT credit_card_pk PRIMARY KEY (id),
	CONSTRAINT credit_card_fk FOREIGN KEY (card_id) REFERENCES card(id)
);

CREATE INDEX idx_investment_user ON investment_user(id);

CREATE TABLE public.debit_card (
	id uuid NOT NULL,
	card_id uuid NOT NULL,
	name varchar(100) NOT NULL,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	CONSTRAINT debit_card_pk PRIMARY KEY (id),
	CONSTRAINT debit_card_fk FOREIGN KEY (card_id) REFERENCES card(id)
);

CREATE INDEX idx_debit_card ON debit_card(id);

CREATE TABLE public.income (
	id uuid NOT NULL,
	name varchar(100) NOT NULL,
	value money NOT NULL,
	created_at timestamp(0) NOT NULL,
	status purchase_status NOT NULL,
	"day" int2 NOT NULL,
	"month" int2 NOT NULL,
	"year" int2 NOT NULL,
	weekday weekday NOT NULL,
	card_id uuid NOT NULL,
	CONSTRAINT income_pk PRIMARY KEY (id),
	CONSTRAINT income_fk FOREIGN KEY (card_id) REFERENCES debit_card(id)
);

CREATE INDEX idx_income ON income(id);

CREATE TABLE public.person (
	id uuid NOT NULL,
	account_id uuid NULL,
	created_by uuid NOT NULL,
	name varchar(100) NOT NULL,
	contact varchar(100) NOT NULL,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	CONSTRAINT person_pk PRIMARY KEY (id),
	CONSTRAINT person_fk FOREIGN KEY (account_id) REFERENCES investment_user(id)
);

CREATE INDEX idx_person ON person(id);

CREATE TABLE public.purchase (
	id uuid NOT NULL,
	name varchar(100) NOT NULL,
	card_id uuid NOT NULL,
	value money NOT NULL,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	type_id uuid NOT NULL,
	status purchase_status NOT NULL,
	"month" int2 NOT NULL,
	"day" int2 NOT NULL,
	"year" int2 NOT NULL,
	weekday weekday NOT NULL,
	CONSTRAINT purchase_pk PRIMARY KEY (id),
	CONSTRAINT purchase_fk FOREIGN KEY (type_id) REFERENCES purchase_type(id),
	CONSTRAINT purchase_fk_1 FOREIGN KEY (card_id) REFERENCES card(id)
);

CREATE INDEX idx_investment_user ON investment_user(id);

CREATE TABLE public.reserve (
	id uuid NOT NULL,
	user_id uuid NOT NULL,
	value money NOT NULL,
	"name" varchar(100) NOT null,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	CONSTRAINT reserve_pk PRIMARY KEY (id),
	CONSTRAINT reserve_fk FOREIGN KEY (user_id) REFERENCES investment_user(id)
);

CREATE INDEX idx_reserve ON reserve(id);

CREATE TABLE public.reserve_type (
	reserve_id uuid NOT NULL,
	purchase_type uuid NOT NULL,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	CONSTRAINT reserve_type_pk PRIMARY KEY (reserve_id, purchase_type),
	CONSTRAINT reserve_type_fk FOREIGN KEY (purchase_type) REFERENCES purchase_type(id),
	CONSTRAINT reserve_type_fk_1 FOREIGN KEY (reserve_id) REFERENCES reserve(id)
);

CREATE TABLE public.lending (
	id uuid NOT NULL,
	person_id uuid NOT NULL,
	"name" varchar(100) NOT NULL,
	value money NOT NULL,
	"type" lending_type NOT NULL,
	created_at timestamp(0) NOT NULL,
	deleted_at timestamp(0) NULL,
	status purchase_status NOT NULL,
	"day" int2 NOT NULL,
	"month" int2 NOT NULL,
	"year" int2 NOT NULL,
	card_id uuid NOT NULL,
	weekday weekday NOT NULL,
	CONSTRAINT lending_pk PRIMARY KEY (id),
	CONSTRAINT lending_card_fk FOREIGN KEY (card_id) REFERENCES card(id),
	CONSTRAINT lending_fk FOREIGN KEY (person_id) REFERENCES person(id)
);

CREATE INDEX idx_lending ON lending(id);