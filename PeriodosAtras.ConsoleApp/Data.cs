using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Data
    {
        public static bool Enecessario = false;
        public string resultado = "";
        public DateTime dataParaComputar;
        public DateTime Atual;
        string[] dias = new string[4];

        public string escreverPorExtenso()
        {
            if (dataParaComputar > Atual)
            {
                return resultado = "Data no futuro";
            }
            else
            {
                return escreverDataPorExtenso();
            }
        }

        public string escreverDataPorExtenso()
        {                
            TimeSpan periodo = Atual - dataParaComputar;
            dias = periodo.ToString().Split('.',':');

            int ano = Convert.ToInt32(dias[0]) / 365;
            int mes = (Convert.ToInt32(dias[0]) % 365) / 30;
            int semana = (Convert.ToInt32(dias[0]) % 365) % 30 / 7;
            int dia = (Convert.ToInt32(dias[0]) % 365) % 30 % 7;

            VerificarTempo(ano, "ano", "anos", 1, mes, semana, dia);
            VerificarTempo(mes, "mes", "meses", 1, semana, dia, 0);
            VerificarTempo(semana, "semana", "semanas", 0, dia, 0 ,0);
            VerificarTempo(dia, "dia", "dias", 1 ,0 ,0 ,0);
            if (dias.Length == 3)
                dia = 0;            

            if (ano == 0 && mes == 0 && dia == 0 && semana == 0)
            {
                resultado = "";
                int hora = Convert.ToInt32(dias[0]);
                int minuto = Convert.ToInt32(dias[1]);
                int segundo = Convert.ToInt32(dias[2]);

                VerificarTempo(hora, "hora", "horas", 0, minuto, segundo, 0);
                VerificarTempo(minuto, "minuto", "minutos", 1, segundo, 0, 0);
                VerificarTempo(segundo, "segundo", "segundos", 1, 0, 0, 0);
            }
            return resultado +=" atrás";
        }

        private void VerificarTempo(int tempo, string singular, string plural, int genero, int primeiro, int segundo, int terceiro)
        {
            if (tempo != 0)
            {
                escreverNumero(tempo, genero);
                if (tempo == 1)
                    resultado += " " + singular;
                else
                    resultado += " "+ plural;
                resultado += colocarE(primeiro, segundo, terceiro);
            }
        }

        private string colocarE(int primeiro, int segundo, int terceiro)
        {
            if (primeiro != 0 || segundo != 0 || terceiro != 0)
            {
                return " e ";
            }
            else
                return "";
        }

        private void escreverNumero(int data, int genero)
        {
            char[] numeros = new char[1];
            string temp = data.ToString("00");
            numeros = temp.ToCharArray();
            double numB;
            double numC;
            try
            {
                temp = Convert.ToString(numeros[0]);
                numB = Convert.ToDouble(temp);
            }
            catch
            {
                numB = 0;
            }
            try
            {
                temp = Convert.ToString(numeros[1]);
                numC = Convert.ToDouble(temp);
            }
            catch
            {
                numC = 0;
            }

            if (numB == 1)
            {
                if (numC == 0) resultado += "dez";
                else if (numC == 1) resultado += "onze";
                else if (numC == 2) resultado += "doze";
                else if (numC == 3) resultado += "treze";
                else if (numC == 4) resultado += "quatorze";
                else if (numC == 5) resultado += "quinze";
                else if (numC == 6) resultado += "dezesseis";
                else if (numC == 7) resultado += "dezessete";
                else if (numC == 8) resultado += "dezoito";
                else if (numC == 9) resultado += "dezenove";
            }
            else if (numB == 2) resultado += "vinte";
            else if (numB == 3) resultado += "trinta";
            else if (numB == 4) resultado += "quarenta";
            else if (numB == 5) resultado += "cinquenta";
            else if (numB == 6) resultado += "sessenta";
            else if (numB == 7) resultado += "setenta";
            else if (numB == 8) resultado += "oitenta";
            else if (numB == 9) resultado += "noventa";

            if (numB != 1)
                if (numC == 1) 
                    if (genero == 1)
                        resultado += "um";
                    else
                        resultado += "uma";                              
                else if (numC == 2)
                    if (genero == 1)
                        resultado += "dois";
                    else
                        resultado += "duas";
                else if (numC == 3) resultado += "três";
                else if (numC == 4) resultado += "quatro";
                else if (numC == 5) resultado += "cinco";
                else if (numC == 6) resultado += "seis";
                else if (numC == 7) resultado += "sete";
                else if (numC == 8) resultado += "oito";
                else if (numC == 9) resultado += "nove";
        }
    }
}
