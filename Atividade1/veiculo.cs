using System;

namespace Atividade1_slide02{
    class Veiculo{
        private string model;
        private int year;
        private double price;

        public Veiculo(string model,int year,double price){
            this.model = model; 
            this.year = year;
            this.price = price;
        }

        public void setModel(string mdl){
            model = mdl;
        }

        public void setYear(int yr){
            year = yr;
        }

        public void setPrice(double prc){
            price = prc;
        }

        public string getModel(){
            return model;
        }

        public int getYear(){
            return year;
        }

        public double getPrice(){
            return price;
        }

        public void decreasePrice(double dcprice){
            price -= dcprice;
            
        }

    }
}