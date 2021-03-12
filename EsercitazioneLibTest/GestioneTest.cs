using Microsoft.VisualStudio.TestTools.UnitTesting;
using eserciziLib;


namespace EsercitazioneLibTest
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void ScontoTest()
        {
            double numero = 200;
            double scontoaspettato = 20;
            double scontoeffettivo = Gestione.Sconto(numero);
            Assert.AreEqual(scontoaspettato, scontoeffettivo);
        }
        [TestMethod]
        public void IncrementoTest()
        {
            double numero = 30;
            double incrementopercentuale = 50;
            double numeroaspettato = 45;
            double numeroeffettivo = Gestione.Incremento(numero, incrementopercentuale);
            Assert.AreEqual(numeroaspettato, numeroeffettivo);
        }
        [TestMethod]
        public void CalcololatoTest()
        {
            double area = 25;
            double latoaspettato = 5;
            double latoeffettivo = Gestione.Lato(area);
            Assert.AreEqual(latoaspettato, latoeffettivo);
        }
    }
}

       
