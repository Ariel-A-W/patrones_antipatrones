using Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Entidades;

namespace Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Antipatron;

public class ProcesarPedidoAntipatron
{
    public void ProcesarPediro()
    {
        var pedido = GetPedido();
        if (pedido.Status == "Nuevo")
        {
            // Logica compleja aquí
            VerificarInventario(pedido);
            UpdatePedido(pedido, "Procesado");
            EnviarConfirmacion(pedido);
        }
        else
        {
            // Otras condiciones y lógica que hacen que 
            // el código sea difícil de seguir
            UpdatePedido(pedido, "Error");
        }
    }

    private void VerificarInventario(Pedido pedido)
    { /* Lógica compleja */ }
    private void UpdatePedido(Pedido pedido, string estado)
    { /* Lógica compleja */ }
    private void EnviarConfirmacion(Pedido pedido)
    { /* Lógica compleja */ }
    private Pedido GetPedido()
    { /* Lógica para obtener el pedido */ return new Pedido(); }
}
