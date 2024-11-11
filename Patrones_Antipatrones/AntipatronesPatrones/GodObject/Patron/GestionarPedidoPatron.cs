using Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Entidades;
using Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Patron;

namespace Patrones_Antipatrones.AntipatronesPatrones.GodObject.Patron;

public class GestionarPedidoPatron
{
    private readonly IInventarioService _inventoryService;
    private readonly INotificacionService _notificationService;
    private readonly IPagoService _paymentService;
    private readonly IFacturaService _invoiceService;

    public GestionarPedidoPatron(
        IInventarioService inventoryService, 
        INotificacionService notificationService, 
        IPagoService paymentService, 
        IFacturaService invoiceService)
    {
        _inventoryService = inventoryService;
        _notificationService = notificationService;
        _paymentService = paymentService;
        _invoiceService = invoiceService;
    }

    public void ProcessOrder(Pedido pedido)
    {
        _inventoryService.UpdateInventario(pedido);
        _notificationService.EnviarNotificacion(pedido);
        _paymentService.ProcesarPago(pedido);
        _invoiceService.GenerarFactura(pedido);
    }
}
