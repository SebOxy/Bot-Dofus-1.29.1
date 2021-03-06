﻿using Bot_Dofus_1._29._1.Protocolo.Enums;

namespace Bot_Dofus_1._29._1.Protocolo.Extensiones
{
    public static class CadenasAmigables
    {
        public static string cadena_Amigable(this EstadoCuenta estado)
        {
            switch (estado)
            {
                case EstadoCuenta.CONECTANDO:
                    return "Conectando";
                case EstadoCuenta.DESCONECTADO:
                    return "Desconectando";
                case EstadoCuenta.INTERCAMBIO:
                    return "Intercambiando";
                case EstadoCuenta.LUCHANDO:
                    return "En combate";
                case EstadoCuenta.RECOLECTANDO:
                    return "Recolectando";
                case EstadoCuenta.MOVIMIENTO:
                    return "Desplazando";
                case EstadoCuenta.CONECTADO_INACTIVO:
                    return "Inactivo";
                case EstadoCuenta.ALMACENAMIENTO:
                    return "En almacenamiento";
                case EstadoCuenta.HABLANDO:
                    return "En dialogo";
                case EstadoCuenta.COMPRANDO:
                    return "Comprando";
                case EstadoCuenta.VENDIENDO:
                    return "Vendiendo";
                case EstadoCuenta.REGENERANDO_VIDA:
                    return "Regenerando Vida";
                default:
                    return "-";
            }
        }

        public static string get_Substring_Seguro(this string texto, int inicio, int longitud) => texto.Length <= inicio ? " " : texto.Length - inicio <= longitud ? texto.Substring(inicio) : texto.Substring(inicio, longitud);
        public static string Truncar(this string texto, int maxima_longitud) => texto.Length <= maxima_longitud ? texto : $"{texto.Substring(0, maxima_longitud)}...";
    }
}
