SELECT p.pa_numero, pa_fecha, cu_nombre, depa_debe, depa_haber 
FROM conta_bd.detalle_partida dp, conta_bd.cuenta c, conta_bd.partida p
where dp.cu_codigo=c.cu_codigo and p.pa_numero=dp.pa_numero
order by c.cu_codigo;