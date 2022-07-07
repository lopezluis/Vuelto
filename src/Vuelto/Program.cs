using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Modo de empleo: En la url introduzca: http://localhost:5251/vuelto/<importe de factura>/<pago de cliente>");
app.MapGet("/vuelto/{valorProducto}/{pagoCliente}", (string valorProducto, string pagoCliente) =>
{
    // TODO: Agregar logger
    double valor;
    try
    {
        valor = Convert.ToDouble(valorProducto);
    }
    catch (Exception)
    {
        throw new ArgumentException(nameof(valorProducto));
    }
    double pago;
    try
    {
        pago = Convert.ToDouble(pagoCliente);
    }
    catch (Exception)
    {
        throw new ArgumentException(nameof(pagoCliente));
    }
    Vuelto.Aplicacion.Vuelto vuelto = new Vuelto.Aplicacion.Vuelto(valor, pago);
    string descrVuelto = vuelto.GetImporte();
    Vuelto.Aplicacion.Almacenar almacenar = new Vuelto.Aplicacion.Almacenar(valor, pago, descrVuelto);
    return descrVuelto;
});

app.Run();
