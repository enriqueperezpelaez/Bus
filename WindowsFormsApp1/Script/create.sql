CREATE TABLE Parada (
  IdParada INTEGER   NOT NULL ,
  Codigo VARCHAR(10)    ,
  Descripcion VARCHAR(100)    ,
  Latitud FLOAT    ,
  Longitud FLOAT      ,
PRIMARY KEY(IdParada));

CREATE TABLE Tramo (
  IdTramo INTEGER   NOT NULL ,
  IdOrigen INTEGER   NOT NULL ,
  IdDestino INTEGER   NOT NULL ,
  Codigo VARCHAR(10)    ,
  Longitud FLOAT    ,
  Duracion FLOAT      ,
PRIMARY KEY(IdTramo)    ,
  FOREIGN KEY(IdOrigen) REFERENCES Parada(IdParada),
  FOREIGN KEY(IdDestino) REFERENCES Parada(IdParada));

CREATE INDEX Tramo_FKOrigen ON Tramo (IdOrigen);
CREATE INDEX Tramo_FKDestino ON Tramo (IdDestino);

CREATE TABLE Ruta (
  IdRuta INTEGER   NOT NULL ,
  Codigo VARCHAR(10)    ,
  Descripcion VARCHAR(100)      ,
PRIMARY KEY(IdRuta));

CREATE TABLE RutaTramo (
  IdRuta INTEGER   NOT NULL ,
  IdTramo INTEGER   NOT NULL ,
  Orden INTEGER   NOT NULL   ,
PRIMARY KEY(IdRuta, IdTramo, Orden)    ,
  FOREIGN KEY(IdTramo) REFERENCES Tramo(IdTramo),
  FOREIGN KEY(IdRuta) REFERENCES Ruta(IdRuta));

CREATE INDEX RutaTramo_FKTramo ON RutaTramo (IdTramo);
CREATE INDEX RutaTramo_FKRuta ON RutaTramo (IdRuta);



CREATE TABLE TramoNoOptimo (
  IdRuta INTEGER   NOT NULL ,
  IdTramo INTEGER   NOT NULL ,
  Orden INTEGER    ,
  Longitud FLOAT    ,
  IdTramoOptimo INTEGER    ,
  IdLongitudOptima FLOAT      ,
PRIMARY KEY(IdRuta, IdTramo));