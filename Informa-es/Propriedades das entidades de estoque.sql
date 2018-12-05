
//cd_estoque_fornecedor
	fornecedor_id int(20), pk
	razao varchar(200)
	descricao varchar(200)
	bairro varchar(100)
	cep int(11)
	cidade varchar(100)
	cnpj varchar(20)
	email varchar(50)
	endereco varchar(50)
	ie varchar(50)
	razao_social varchar(150)
	numero varchar(20)
	uf varchar(2)
	telefone varchar(50)
	celular varchar(50)
	cadastro TIME  - data e hora

//cd_estoque_cliente
	cliente_id int(20)
	bairro varchar(50)
	celular varchar(50)
	numero varchar(20)
	cep varchar(11)
	cidade varchar(50)
	cpf varchar(50)
	data_nascimento DATE
	email varchar(50)
	endereco varchar(50)
	nome varchar(150)
	data_cadastro DATE
	hora_cadastro TIME
	rg int(11)
	sexo char //m e f
	telefone varchar(50)
	uf varchar(2)

//cd_estoque_usuario
	usuario_id int(20), PK
	funcionario_id int(20), FK
	senha varchar(32)
	permissao int(1)
	nome varchar(20)
	ativo int(1)

//cd_estoque_item_compra
	item_compra_id int(20), PK
	nota_compra_id int(20), FK
	produto_id int(20), Fk
	valor_total decimal(10,2)
	quantidade int(11)
	valor decimal(10,2)
	cadastro TIME  - data e hora

//cd_estoque_item_venda
	item_venda_id int(20), PK
	nota_venda_id int(20), FK
	produto_id int(20), FK
	valor decimal(10,2)
	valor_total decimal(10,2)
	quantidade decimal(10,2)
	cadastro TIME  - data e hora

//cd_estoque_produto
	produto_id int(20)
	nome varchar(50)
	descricao varchar(150)
	valor_compra decimal(10,2)
	quantidade int 11

//cd_estoque_nota_compra
	nota_compra_id int(20)
	num_nota int(20)
	data DATE
	valor_total_nota decimal(10,2)
	icms int(11)
	desconto decimal(10,2)
	funcionario_id int(20)
	fornecedor_id int(20)
	vencimento DATE
	chave_acesso int(11)
	ipi int(11)
	data_cadastro DATE
	hora_cadastro TIME

//cd_estoque_nota_venda
	nota_venda_id int(20)
	valor decimal(10,2)
	valor_total decimal(10,2)
	data DATE
	desconto decimal(10,2)
	data_cadastro DATE
	hora_cadastro TIME
	funcionario_id int(20)
	cliente_id int(20)

//cd_estoque_venda_prazo
	venda_prazo_id int(20)
	data_pagamento DATE
	quantidade_parcela int(11)
	data_vencimento DATE
	valor decimal(10,2)
	valor_pago decimal(10,2)
	nota_venda_id int(20)
	valor_restante decimal(10,2)
	cliente_id int(20)
