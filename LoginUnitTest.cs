namespace PruebasUnitarias
{
    public class Tests
    {
        Login ReservacionMesa;

        [SetUp]
        public void Setup()
        {
            ReservacionMesa= new Login();
        }

        [Test]
        public void ingresarUsuarioCorrecto()
        {
            string baseDatos = "usuario_1";
            string resultadoEsperado = "usuario_1";
            Assert.AreEqual(baseDatos, resultadoEsperado);
        }

        [Test]
        public void ingresarContraseñaCorrecta()
        {
            string baseDatos = "Contraseña_1";
            string resultadoEsperado = "Contraseña_1";
            Assert.AreEqual(baseDatos, resultadoEsperado);
        }

	[Test]
        public void ingresarCelularCorrecta()
        {
            string baseDatos = "5587652465";
            string resultadoEsperado = "5587652465";
            Assert.AreEqual(baseDatos, resultadoEsperado);
        }

	[Test]
        public void aceptarTerminosYcondicionesCorrecta()
        {
            string baseDatos = "No acepto";
            string resultadoEsperado = "acepto";
            Assert.AreEqual(baseDatos, resultadoEsperado);
        }

	[Test]
        public void ingresarNumeroTarjetaBancariaCorrecta()
        {
            int baseDatos = 1234567891;
            int resultadoEsperado = 1234567891;
            Assert.AreEqual(baseDatos, resultadoEsperado);
        }
    }
}