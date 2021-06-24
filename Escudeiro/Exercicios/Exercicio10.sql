 insert into cliente(
      id,
      nome_cliente,
      razao_social,
      dt_cadastro,
      cnpj,
      telefone,
      cidade,
      estado)
    values (
      1,
      -- '0001', Campo incorreto, só remover ele volta a funcionar
      'AARONSON',
      'AARONSON FURNITURE LTDA',
      '2015-02-17',
      '17.807.928/0001-85',
      '(21) 8167-6584',
      'MARINGA',
      'PR'
    );