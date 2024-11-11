using Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Entidades;

namespace Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Patron;

public class PedidoService
{
    public Pedido GetPedido()
    { /* Lógica para obtener el pedido */ return new Pedido(); }
    public bool IsNewOrder(Pedido pedido)
    { return pedido.Status == "Nuevo"; }
    public void UpdatePedido(Pedido pedido, string estado)
    { /* Lógica de actualización */ }
}
