namespace Vuelto.Aplicacion
{
    /****
     * # Clase Vuelto #
     * 
     * Es la encargada de realizar la lógica de negocio del proyecto.
     * 
     * Construye el string que será informado al usuario, mostrando cuantos y cuales billetes debe entregar de vuelto, a un determinado pago de un cliente.
     * 
     * ## Nota ##
     * 
     * No he empleando la posibilidad del agregado de miembros con parte de la funcionalidad del constructor,
     * para facilitar el mantenimiento del proyecto y su corrección/actualización si es necesario.
     ****/
    public class Vuelto
    {
        private string Importe;

        public Vuelto(double valord, double pagod)
        {
            if(valord <= 0)
            {
                this.Importe = "No existen productos con valores negativos o nulos.";
            }
            else
            {
                if (valord > pagod)
                {
                    this.Importe = "El cliente no entregó aún el monto completo.";
                }
                else
                {
                    double monedas001 = Math.Round(pagod - valord, 2);
                    if (monedas001 == 0)
                    {
                        this.Importe = "No hace falta entregar vuelto.";
                    }
                    else
                    {
                        double billetes100, billetes50, billetes20, billetes10, monedas050, monedas010, monedas005;
                        string descB100, descB50, descB20, descB10, descM050, descM010, descM005, descM001;
                        bool hayVuelto;
                        byte unidadesMonetariasRestantes;

                        billetes100 = Math.Round((monedas001 - Math.Round(monedas001 % 100.0d, 2)) / 100.0d);
                        monedas001 = Math.Round(monedas001 % 100.0d, 2);
                        billetes50 = Math.Round((monedas001 - Math.Round(monedas001 % 50.0d, 2)) / 50.0d);
                        monedas001 = Math.Round(monedas001 % 50.0d, 2);
                        billetes20 = Math.Round((monedas001 - Math.Round(monedas001 % 20.0d, 2)) / 20.0d);
                        monedas001 = Math.Round(monedas001 % 20.0d, 2);
                        billetes10 = Math.Round((monedas001 - Math.Round(monedas001 % 10.0d, 2)) / 10.0d);
                        monedas001 = Math.Round(monedas001 % 10.0d, 2);
                        monedas050 = Math.Round((monedas001 - Math.Round(monedas001 % 0.50d, 2)) / 0.50d);
                        monedas001 = Math.Round(monedas001 % 0.50d, 2);
                        monedas010 = Math.Round((monedas001 - Math.Round(monedas001 % 0.10d, 2)) / 0.10d);
                        monedas001 = Math.Round(monedas001 % 0.10d, 2);
                        monedas005 = Math.Round((monedas001 - Math.Round(monedas001 % 0.05d, 2)) / 0.05d);
                        monedas001 = Math.Round((monedas001 % 0.05d) / 0.01d);
                        descB100 = "";
                        descB50 = "";
                        descB20 = "";
                        descB10 = "";
                        descM050 = "";
                        descM010 = "";
                        descM005 = "";
                        descM001 = "";
                        unidadesMonetariasRestantes = 0;
                        if (billetes100 != 0)
                        {
                            descB100 = billetes100.ToString() + " billete" + ((billetes100 == 1) ? "" : "s") + " de R$ 100";
                            unidadesMonetariasRestantes++;
                        }
                        if (billetes50 != 0)
                        {
                            descB50 = billetes50.ToString() + " billete" + ((billetes50 == 1) ? "" : "s") + " de R$ 50";
                            unidadesMonetariasRestantes++;
                        }
                        if (billetes20 != 0)
                        {
                            descB20 = billetes20.ToString() + " billete" + ((billetes20 == 1) ? "" : "s") + " de R$ 20";
                            unidadesMonetariasRestantes++;
                        }
                        if (billetes10 != 0)
                        {
                            descB10 = billetes10.ToString() + " billete" + ((billetes10 == 1) ? "" : "s") + " de R$ 10";
                            unidadesMonetariasRestantes++;
                        }
                        if (monedas050 != 0)
                        {
                            descM050 = monedas050.ToString() + " moneda" + ((monedas050 == 1) ? "" : "s") + " de R$ 0,50";
                            unidadesMonetariasRestantes++;
                        }
                        if (monedas010 != 0)
                        {
                            descM010 = monedas010.ToString() + " moneda" + ((monedas010 == 1) ? "" : "s") + " de R$ 0,10";
                            unidadesMonetariasRestantes++;
                        }
                        if (monedas005 != 0)
                        {
                            descM005 = monedas005.ToString() + " moneda" + ((monedas005 == 1) ? "" : "s") + " de R$ 0,05";
                            unidadesMonetariasRestantes++;
                        }
                        if (monedas001 != 0)
                        {
                            descM001 = monedas001.ToString() + " moneda" + ((monedas001 == 1) ? "" : "s") + " de R$ 0,01";
                            unidadesMonetariasRestantes++;
                        }
                        this.Importe = "Entregar: ";
                        hayVuelto = false;
                        if (!string.IsNullOrEmpty(descB100))
                        {
                            this.Importe += descB100;
                            hayVuelto = true;
                            unidadesMonetariasRestantes--;
                        }
                        if (!string.IsNullOrEmpty(descB50))
                        {
                            if (hayVuelto)
                            {
                                this.Importe += ((unidadesMonetariasRestantes == 1) ? " y " : ", ");
                            }
                            this.Importe += descB50;
                            hayVuelto = true;
                            unidadesMonetariasRestantes--;
                        }
                        if (!string.IsNullOrEmpty(descB20))
                        {
                            if (hayVuelto)
                            {
                                this.Importe += ((unidadesMonetariasRestantes == 1) ? " y " : ", ");
                            }
                            this.Importe += descB20;
                            hayVuelto = true;
                            unidadesMonetariasRestantes--;
                        }
                        if (!string.IsNullOrEmpty(descB10))
                        {
                            if (hayVuelto)
                            {
                                this.Importe += ((unidadesMonetariasRestantes == 1) ? " y " : ", ");
                            }
                            this.Importe += descB10;
                            hayVuelto = true;
                            unidadesMonetariasRestantes--;
                        }
                        if (!string.IsNullOrEmpty(descM050))
                        {
                            if (hayVuelto)
                            {
                                this.Importe += ((unidadesMonetariasRestantes == 1) ? " y " : ", ");
                            }
                            this.Importe += descM050;
                            hayVuelto = true;
                            unidadesMonetariasRestantes--;
                        }
                        if (!string.IsNullOrEmpty(descM010))
                        {
                            if (hayVuelto)
                            {
                                this.Importe += ((unidadesMonetariasRestantes == 1) ? " y " : ", ");
                            }
                            this.Importe += descM010;
                            hayVuelto = true;
                            unidadesMonetariasRestantes--;
                        }
                        if (!string.IsNullOrEmpty(descM005))
                        {
                            if (hayVuelto)
                            {
                                this.Importe += ((unidadesMonetariasRestantes == 1) ? " y " : ", ");
                            }
                            this.Importe += descM005;
                            hayVuelto = true;
                            unidadesMonetariasRestantes--;
                        }
                        if (!string.IsNullOrEmpty(descM001))
                        {
                            if (hayVuelto)
                            {
                                this.Importe += ((unidadesMonetariasRestantes == 1) ? " y " : ", ");
                            }
                            this.Importe += descM001;
                        }
                        this.Importe += ".";
                    }
                }
            }
        }

        public string GetImporte()
        {
            return Importe;
        }
    }
}
