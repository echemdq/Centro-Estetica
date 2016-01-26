select p.profesional, lf.sesiones, lf.precioventa, ifnull((select preciocalculo from honorarios where idprofesionales=st.idprofesionales and idproductos=lf.idproductos),
lf.preciocalculo) as prueba, lf.precioventa * ifnull((select preciocalculo from honorarios where idprofesionales=st.idprofesionales and idproductos=lf.idproductos),
lf.preciocalculo) / 100 / lf.sesiones as pagoprofesional from serviciosturnos st 
left join servicios s on st.idservicios = s.idservicios
left join lineafactura lf on s.idlineafactura = lf.idlineafactura
left join profesionales p on st.idprofesionales = p.idprofesionales
where st.fecha = curdate() and asistencia = 1