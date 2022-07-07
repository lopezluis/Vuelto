using Vuelto.Persistencia;
using Vuelto.Modelo;

namespace Vuelto.Aplicacion
{
    public class Almacenar
    {
        public Almacenar(double valorFractura, double pagoCliente, string descrVuelto)
        {
            using (var contexto = new ContextoDatos())
            {
                Transaccion transac = new Transaccion()
                {
                    ImporteFactura = valorFractura,
                    Vuelto = pagoCliente - valorFractura,
                    VueltoEntregado = descrVuelto
                };
                contexto.Transaccion.Add(transac);
                try
                {
                    contexto.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Excepcion en almacenamiento: " + ex.Message);
                }
            }
        }
    }
}
