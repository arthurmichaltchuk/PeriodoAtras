using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PeriodosAtras.ConsoleApp;

namespace TestesDatasAtras
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveRetonarUmDia()
        {
            Data data = new Data();
            data.Atual = new DateTime(2021, 5, 26, 0, 0, 0);
            data.dataParaComputar = new DateTime(2021, 5, 25, 0, 0, 0);
            Assert.AreEqual("um dia atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarDoisDias()
        {
            Data data = new Data();
            data.Atual = new DateTime(2021, 5, 26, 0, 0, 0);
            data.dataParaComputar = new DateTime(2021, 5, 24, 0, 0, 0);
            Assert.AreEqual("dois dias atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarUmaSemana()
        {
            Data data = new Data();
            data.Atual = new DateTime(2021, 5, 26, 0, 0, 0);
            data.dataParaComputar = new DateTime(2021, 5, 19, 0, 0, 0);
            Assert.AreEqual("uma semana atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarDoisMesesUmaSemana()
        {
            Data data = new Data();
            data.Atual = new DateTime(2021, 5, 26, 0, 0, 0);
            data.dataParaComputar = new DateTime(2021, 3, 20, 0, 0, 0);
            Assert.AreEqual("dois meses e uma semana atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarDoisMesesDoisDias()
        {
            Data data = new Data();
            data.Atual = new DateTime(2021, 5, 26, 0, 0, 0);
            data.dataParaComputar = new DateTime(2021, 3, 25, 0, 0, 0);
            Assert.AreEqual("dois meses e dois dias atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarDezAnos()
        {
            Data data = new Data();
            data.Atual = new DateTime(2021, 5, 26, 0, 0, 0);
            data.dataParaComputar = new DateTime(2011, 5, 29, 0, 0, 0);
            Assert.AreEqual("dez anos atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarUmAnoDoisMesesTresDias()
        {
            Data data = new Data();
            data.Atual = new DateTime(2022, 5, 27, 0, 0, 0);
            data.dataParaComputar = new DateTime(2021, 3, 25, 0, 0, 0);
            Assert.AreEqual("um ano e dois meses e três dias atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarTresHoras()
        {
            Data data = new Data();
            data.Atual = new DateTime(2022, 5, 27, 3, 0, 0);
            data.dataParaComputar = new DateTime(2022, 5, 27, 0, 0, 0);
            Assert.AreEqual("três horas atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarDuasHorasCinquentaMinutosQuatroSegundos()
        {
            Data data = new Data();
            data.Atual = new DateTime(2022, 5, 27, 2, 50, 4);
            data.dataParaComputar = new DateTime(2022, 5, 27, 0, 0, 0);
            Assert.AreEqual("duas horas e cinquenta minutos e quatro segundos atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarDataNoFuturo()
        {
            Data data = new Data();
            data.Atual = new DateTime(2022, 5, 27, 0, 0, 0);
            data.dataParaComputar = new DateTime(2023, 5, 27, 0, 0, 0);
            Assert.AreEqual("Data no futuro", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarUmaHora()
        {
            Data data = new Data();
            data.Atual = new DateTime(2022, 5, 27, 1, 0, 0);
            data.dataParaComputar = new DateTime(2022, 5, 27, 0, 0, 0);
            Assert.AreEqual("uma hora atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarQuarentaSegundos()
        {
            Data data = new Data();
            data.Atual = new DateTime(2022, 5, 27, 0, 0, 40);
            data.dataParaComputar = new DateTime(2022, 5, 27, 0, 0, 0);
            Assert.AreEqual("quarenta segundos atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarUmMinuto()
        {
            Data data = new Data();
            data.Atual = new DateTime(2022, 5, 27, 0, 1, 0);
            data.dataParaComputar = new DateTime(2022, 5, 27, 0, 0, 0);
            Assert.AreEqual("um minuto atrás", data.escreverPorExtenso());
        }

        [TestMethod]
        public void DeveRetonarCincoAnosDoisDias()
        {
            Data data = new Data();
            data.Atual = new DateTime(2020, 5, 26, 0, 1, 0);
            data.dataParaComputar = new DateTime(2015, 5, 27, 0, 0, 0);
            Assert.AreEqual("cinco anos e um dia atrás", data.escreverPorExtenso());
        }
    }
}
