namespace Patrones_Antipatrones.SOLID.OCP.Antipatron;

public class Notificacion
{
    public void Enviar(string mensaje, string tipo)
    {
        if (tipo == "correo")
        {
            // Enviar correo
        }
        else if (tipo == "sms")
        {
            // Enviar SMS
        }
    }
}
