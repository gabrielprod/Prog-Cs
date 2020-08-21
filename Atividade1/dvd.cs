using System;

namespace atividade1_dvd{

 
    class Dvd{
        private string cod;
        private string titulo;
        private string genero;
        private string artista;
        private int anolanc;
        private double precoCompra;
        private double precoVenda;
        private string status;

        public Dvd(string codg, string titl,string gener , string arts,int anol,double preC,double preV,string sts){
            cod = codg;
            titulo = titl;
            genero = gener;
            artista = arts;
            anolanc = anol;
            precoCompra = preC;
            precoVenda = preV;
            status = sts;
        }

        public void vender(string cd){
            if(cod == cd){
                status = "Vendido";
                precoVenda = null;
            }
            
        }

        public void devolver(string cdgo){
            status = "Disponivel";
        }

        public void setPreco(double prc){
            precoVenda = prc;
        }

        public void setAno(int nvano){
            anolanc = nvano;
        }

        public double getPreco(){
            return precoVenda;
        }
        public string getArtista(){
            return artista;
        } 
        public string getStatus(){
            return status;
        }
        

    }
}