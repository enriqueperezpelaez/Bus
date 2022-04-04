CREATE TABLE TramoNoOptimo (
  IdRuta INTEGER   NOT NULL ,
  IdTramo INTEGER   NOT NULL ,
  Orden INTEGER    ,
  Longitud FLOAT    ,
  IdTramoOptimo INTEGER    ,
  IdLongitudOptima FLOAT      ,
PRIMARY KEY(IdRuta, IdTramo));

create procedure TramoOptimo is
begin
    delete TramoNoOptimo;
    insert into TramoNoOptimo (IdRuta,IdTramo,Orden,Longitud,IdTramoOptimo,IdLongitudOptima) 
    select RT.IdRuta,RT.IdTramo,RT.Orden,RT.Longitud,OP.IdTramo IdTramoOptimo,OP.Longitud LongitudOptima from 
        (select R.IdRuta,R.IdTramo,R.Orden,T.IdOrigen,T.IdDestino,T.Longitud from RutaTramo R inner join Tramo T on R.IdTramo=T.IdTramo) RT
    inner join
        (SELECT idtramo,idorigen,iddestino, longitud
        FROM (
          SELECT idtramo, idorigen, iddestino, longitud,dense_rank() over(partition by idorigen,iddestino order by longitud) rn
          FROM tramo
        )
        WHERE rn = 1) OP
    ON OP.IdOrigen=RT.IdOrigen and OP.IdDestino=RT.IdDestino and RT.Longitud>OP.Longitud;
end;