namespace Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Patron;

public class ProcesarPedidoPatron
{
    private readonly InventarioService _inventoryService;
    private readonly PedidoService _orderService;
    private readonly NotificacionService _notificationService;

    public ProcesarPedidoPatron()
    {
        _inventoryService = new InventarioService();
        _orderService = new PedidoService();
        _notificationService = new NotificacionService();
    }

    public void ProcessOrder()
    {
        var pedido = _orderService.GetPedido();
        if (_orderService.IsNewOrder(pedido))
        {
            _inventoryService.VerificarInventario(pedido);
            _orderService.UpdatePedido(pedido, "Procesado");
            _notificationService.EnviarConfirmacion(pedido);
        }
        else
        {
            _orderService.UpdatePedido(pedido, "Error");
        }
    }
}
