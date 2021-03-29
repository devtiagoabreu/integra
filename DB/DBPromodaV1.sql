CREATE TABLE tear (
  id INTEGER  NOT NULL   IDENTITY ,
  numero INTEGER  NOT NULL  ,
  ativo TINYINT  NOT NULL DEFAULT 1   ,
PRIMARY KEY(id));
GO




CREATE TABLE turno (
  id INTEGER  NOT NULL   IDENTITY ,
  descricao VARCHAR(50)  NOT NULL  ,
  ativo TINYINT  NOT NULL DEFAULT 1   ,
PRIMARY KEY(id));
GO




CREATE TABLE usuario (
  id INTEGER  NOT NULL  ,
  nome VARCHAR(60)    ,
  email VARCHAR(100)    ,
  login VARCHAR(30)  NOT NULL  ,
  senha VARCHAR(220)  NOT NULL  ,
  pass VARCHAR(220)  NOT NULL  ,
  dataCadastro DATETIME  NOT NULL DEFAULT getDate() ,
  ativo TINYINT  NOT NULL DEFAULT 1   ,
PRIMARY KEY(id));
GO




CREATE TABLE ordem (
  id INTEGER  NOT NULL   IDENTITY ,
  numero INTEGER  NOT NULL  ,
  descricao VARCHAR(200)    ,
  ativo TINYINT  NOT NULL DEFAULT 1   ,
PRIMARY KEY(id));
GO




CREATE TABLE operador (
  id INTEGER  NOT NULL   IDENTITY ,
  descricao VARCHAR(60)  NOT NULL  ,
  ativo TINYINT  NOT NULL DEFAULT 1 ,
  senha VARCHAR(10)  NOT NULL    ,
PRIMARY KEY(id));
GO




CREATE TABLE tearOrdem (
  id INTEGER  NOT NULL   IDENTITY ,
  ordem_id INTEGER  NOT NULL  ,
  tear_id INTEGER  NOT NULL  ,
  ativo TINYINT  NOT NULL DEFAULT 1 ,
  dataCadastro DATETIME  NOT NULL DEFAULT getdate()   ,
PRIMARY KEY(id)    ,
  FOREIGN KEY(tear_id)
    REFERENCES tear(id),
  FOREIGN KEY(ordem_id)
    REFERENCES ordem(id));
GO


CREATE INDEX tearOrdem_FKIndex1 ON tearOrdem (tear_id);
GO
CREATE INDEX tearOrdem_FKIndex2 ON tearOrdem (ordem_id);
GO


CREATE INDEX IFK_Rel_03 ON tearOrdem (tear_id);
GO
CREATE INDEX IFK_Rel_04 ON tearOrdem (ordem_id);
GO


CREATE TABLE producaoTecelagem (
  id INTEGER  NOT NULL   IDENTITY ,
  ordem_id INTEGER  NOT NULL  ,
  tear_id INTEGER  NOT NULL  ,
  operador_id INTEGER  NOT NULL  ,
  rpm INTEGER  NOT NULL DEFAULT 0 ,
  eficienciaTurnoA DECIMAL(3,2)  NOT NULL  ,
  eficienciaTurnoB DECIMAL(3,2)  NOT NULL  ,
  eficienciaTurnoC DECIMAL(3,2)  NOT NULL  ,
  eficienciaDia DECIMAL(3,2)  NOT NULL  ,
  eficienciaInst DECIMAL(3,2)    ,
  rolo INTEGER    ,
  obs VARCHAR(200)    ,
  dataCadastro DATETIME  NOT NULL DEFAULT getDate() ,
  dataUserInsert DATETIME  NOT NULL    ,
PRIMARY KEY(id)      ,
  FOREIGN KEY(operador_id)
    REFERENCES operador(id),
  FOREIGN KEY(tear_id)
    REFERENCES tear(id),
  FOREIGN KEY(ordem_id)
    REFERENCES ordem(id));
GO


CREATE INDEX producaoTecelagem_FKIndex2 ON producaoTecelagem (operador_id);
GO
CREATE INDEX producaoTecelagem_FKIndex4 ON producaoTecelagem (tear_id);
GO
CREATE INDEX producaoTecelagem_FKIndex3 ON producaoTecelagem (ordem_id);
GO


CREATE INDEX IFK_Rel_06 ON producaoTecelagem (operador_id);
GO
CREATE INDEX IFK_Rel_07 ON producaoTecelagem (tear_id);
GO
CREATE INDEX IFK_Rel_08 ON producaoTecelagem (ordem_id);
GO



