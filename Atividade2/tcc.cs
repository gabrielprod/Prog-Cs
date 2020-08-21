
//Gabriel Pereira Rodrigues
using System;

namespace Atividade02 {
    class Program {

        static void Main(string[] args) {
            TCC tcc1 = new TCC("Politica e Mídia, a influencia da imprensa", "Tcc sobre a relevancia da da midia no desenvolvimento economico do pais ", "Politica");

            Aluno aluno1 = new Aluno("Fabio", "462299374");
            Professor prof1 = new Professor("Vania", "3434343", "Relacoes Exteriores");

            tcc1.addAluno(aluno1);
            tcc1.addTeacher(prof1);

            tcc1.showData();
        }

    }

    class Aluno {
        private string nomeAluno, cpfAluno;

        public Aluno() {

        }

        public Aluno(string nomeAluno, string cpfAluno) {
            this.nomeAluno = nomeAluno;
            this.cpfAluno = cpfAluno;
        }

        public void setNomeAluno(string nmAl) {
            nomeAluno = nmAl;
        }

        public string getNomeAluno() {
            return nomeAluno;
        }

        public void setCpfAluno(string cpf) {
            cpfAluno = cpf;
        }

        public string getCpfAluno() {
            return cpfAluno;
        }

    }

    class Professor {
        private string nomeProf, cpfProf, areaAt;

        public Professor() {

        }

        public Professor(string nomeProf, string cpfProf, string areaAt) {
            this.nomeProf = nomeProf;
            this.cpfProf = cpfProf;
            this.areaAt = areaAt;
        }

        public void setNomeProf(string stnprof) {
            nomeProf = stnprof;
        }

        public string getNomeProf() {
            return nomeProf;
        }

        public void setCpfProf(string cpf) {
            cpfProf = cpf;
        }

        public string getCpfProf() {
            return cpfProf;
        }

        public void setAreaProf(string areaProf) {
            areaAt = areaProf;
        }

        public string getAreaProf() {
            return areaAt;
        }

    }

    class TCC {
        private string titulo, resumo, area;

        Aluno aluno1;
        Professor prof1;

        public TCC() {

        }

        public TCC(string titulo, string resumo, string area) {
            this.titulo = titulo;
            this.resumo = resumo;
            this.area = area;
        }

        public void setTitulo(string title) {
            titulo = title;
        }
        public string getTitulo() {
            return titulo;
        }
        public void setResumo(string resum){
            resumo = resum;
        }
        public string getResumo(){
            return resumo;
        }
        public void setarea(string ar){
            area = ar;
        }
        public string getArea(){
            return area;
        }

        public void addAluno(Aluno al) {
            aluno1 = al;
        }

        public void addTeacher(Professor p1) {
            prof1 = p1;
        }

        public void showData() {
            Console.WriteLine("Titulo TCC : "+titulo);
            Console.WriteLine("Resumo : "+ resumo);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Nome Aluno : " + aluno1.getNomeAluno());
            Console.WriteLine("Cpf Aluno : " + aluno1.getCpfAluno());
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Nome Professor : " + prof1.getNomeProf());
            Console.WriteLine("Cpf Professor : " + prof1.getCpfProf());
            Console.WriteLine("Area do Professor : " + prof1.getAreaProf());
           
        }

    }

}

