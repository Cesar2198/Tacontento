select 
count(a.idPedido) as numeroPedidos,
year(a.fecha) anio,
sum(a.total) total,
c.usuario
from
pedidos a,
detallespedidos b,
usuarios c
where a.idPedido = b.idPedido and c.idUsuario = a.idUsuario
group by c.idUsuario and anio;

