using Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Entidades;

namespace Patrones_Antipatrones.AntipatronesPatrones.GodObject.Antipatron;

public class ObjetoDiosAntipatron
{
    public void GestionarPedido(Pedido pedido)
    {
        // Manejo del pedido
        UpdateInventario(pedido);
        EnviarNotificacion(pedido);
        ProcesarPago(pedido);
        GenerarFactura(pedido);
    }

    private void UpdateInventario(Pedido pedido) 
    { /* Actualiza inventario */ }
    private void EnviarNotificacion(Pedido pedido) 
    { /* Envia notificación */ }
    private void ProcesarPago(Pedido pedido) 
    { /* Procesa pago */ }
    private void GenerarFactura(Pedido pedido) 
    { /* Genera factura */ }
}
