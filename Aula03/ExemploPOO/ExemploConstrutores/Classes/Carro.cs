using System;

namespace ExemploConstrutores
{
    class Carro
    {
        //Propriedade Estática -- Variável de Classe
        private static int contador = 0;

        //Propriedades da nossa classe
        private string marca;
        private string modelo;
        private int rodas;
        private double comprimento;
        private double largura;
        private bool arCondicionado;
        private string kitMultimidia; //Android Car + Carplay + tela 10", Radio CD MP3

        //Construtor(es)
        public Carro()
        {
            rodas = 4;
            largura = 173.2;
            comprimento = 409.3;
            marca = "ND";
            modelo = "ND";

            contador++;
        }

        public Carro(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.rodas = 4;
            largura = 173.2;
            comprimento = 409.3;

            contador++;
        }

        public Carro(double largura, double comprimento,string marca,string modelo)
        {
            rodas = 4;
            this.largura = largura;
            this.comprimento = comprimento;
            this.marca = marca;
            this.modelo = modelo;

            contador++;
        }

        //Métodos
        public string getInfoCarro()
        {
            return "*** Informação do carro:\n Rodas: " + rodas + 
                    "\n Largura: " + largura + 
                    "\n Comprimento: " + comprimento +
                    "\n Marca: " + marca +
                    "\n Modelo: " + modelo;
        }

        public void setExtras(bool arCondicionado, string kitMultimidia)
        {
            this.arCondicionado = arCondicionado;
            this.kitMultimidia = kitMultimidia;
        }

        public string getExtras()
        {
            return "****************\n Extras do Carro: \n " +
                    " - Ar Condicionado: " + (arCondicionado ? "Sim" : "Não") + " \n" +
                    " - Kit Multimídia: " + kitMultimidia; 
        }

        //Método para leitura do contador
        public static int contadorCarros() 
        {
            return contador;
        }
    }
}