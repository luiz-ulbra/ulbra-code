using System;

class IAC_CS_Codes{
    public static int Tela_Menu(){ 
        int ler;
        limpar();
        escreva("menu");
        escreva("[1] TABUADA");
        escreva("[2] MEDIA - ULBRA");
        escreva("[3] CALCULADORA");
        escreva("[4] IMC");
        escreva("[5] SAIR");
        ler = int.Parse(leia());
        return ler;
    }

    public static void Funcoes(int Comando){
        
        switch (Comando){
            case 1: 
                Tabuada();
                break;
            case 2: 
                MediaUlbra();
                break;
            case 3:  
                Calculadora();
                break;
            case 4:  
                IMC();
                break;
        }
    }

    public static void Main(){
       
        int Comando;

        
        do{
            Comando = Tela_Menu(); 

            if(Comando != 5 && Comando >= 1 && Comando <= 4){
                Funcoes(Comando); 
            }

        } while(Comando != 5);
    }

    
    public static void Tabuada(){ 
        int numero;
        string Comando = "";

        do{
            limpar();
            escreva("Digite o número a ser tabelado: ");
            numero = int.Parse(leia());

            escreva("");
            escreva("TABELA DO [" + numero + "]");

            for (int i = 0; i <= 10; i++){
                escreva(numero + " x " + i + " = " + numero*i); 
            }

            escreva("");

            escreva("Digite 'voltar' para voltar ao menu principal - ou qualquer outro para executar novamente");
            Comando = leia();

        } while(Comando != "voltar");
    }

    public static void MediaUlbra(){
        float G1, G2, Media;
        string Voltar;

        do{
            limpar();
            escreva("Digite sua nota da [G1]: ");
            G1 = float.Parse(leia());
            
            escreva("Digite sua nota da [G2]: ");
            G2 = float.Parse(leia());

            Media = (G1 + (G2 * 2))/3;

            escreva("");

            escreva("MEDIA FINAL: " + Media);
            if(Media >= 6){
                escreva("APROVADO NO SEMESTRE");
            } else{
                escreva("REPROVADO NO SEMESTRE");
            }

            escreva("Digite 'voltar' para voltar ao menu principal - ou qualquer outro para executar novamente");
            Voltar = leia();
        } while(Voltar != "voltar");
    }

    public static void Calculadora(){ 

        int Comando = 0;

        float N1 = 0;
        float N2 = 0;
        float Result = 0;

        string Oper = "";
        string Voltar = "";

       
        do{
            limpar();

            escreva("OPERAÇÕES DA CALCULADORA");
            escreva("[1] SOMAR");
            escreva("[2] DIMINUIR");
            escreva("[3] MULTIPLICAR");
            escreva("[4] DIVIDIR");
            escreva("[5] VOLTAR AO MENU PRINCIPAL");
            Comando = int.Parse(leia());

            if(Comando >= 1 && Comando <= 4){
                escreva ("Digite o 1 número: ");
                N1 = float.Parse(leia());

                escreva ("Digite o 2 número: ");
                N2 = float.Parse(leia());

                switch(Comando){
                    case 1:
                        Result = N1 + N2;
                        Oper = " + ";
                        break;
                    case 2:
                        Result = N1 - N2;
                        Oper = " - ";
                        break;
                    case 3:
                        Result = N1 * N2;
                        Oper = " x ";
                        break;
                    case 4:
                        Result = N1 / N2;
                        Oper = " / ";
                        break;
                }

                escreva(N1 + Oper + N2 + " = " + Result);
                escreva("");

                escreva("Digite 'voltar' para voltar ao menu principal - ou qualquer outro para executar novamente");
                Voltar = leia();
            } else if(Comando == 5){
                Voltar = "voltar";
            } else{
                escreva("Comando Inválido");
            }

        } while(Voltar != "voltar");
    }

    public static void IMC(){
        float Peso, Altura, IMC;
        string Sexo, Voltar;

        do{
            limpar();
            escreva("Digite seu peso: ");
            Peso = float.Parse(leia());

            escreva("Digite sua altura: ");
            Altura = float.Parse(leia());

            escreva("Digite seu sexo: [M] ou [F]");
            Sexo = leia();

        
            IMC = (Peso / (Altura * Altura));

            escreva("Seu IMC -> " + IMC);

            if(Sexo == "m" || Sexo == "M"){
                if(IMC < 20.7){
                    escreva("Abaixo do Peso!");
                } else if(IMC < 26.4){
                    escreva("Peso normal!");
                } else if(IMC < 27.8){
                    escreva("Marginalmente acima do peso!");
                } else if(IMC < 31.1){
                    escreva("Acima do Peso ideal!");
                } else{
                    escreva("Obeso!");
                }
            } else if(Sexo == "f" || Sexo == "F"){
                if(IMC < 19.1){
                    escreva("Abaixo do Peso!");
                } else if(IMC < 25.8){
                    escreva("Peso normal!");
                } else if(IMC < 27.3){
                    escreva(" acima do peso!");
                } else if(IMC < 32.3){
                    escreva("Acima do Peso ideal!");
                } else{
                    escreva("Obeso!");
                }
            }

            escreva("Digite 'voltar' para voltar ao menu principal - ou qualquer outro para executar novamente");
            Voltar = leia();
        } while(Voltar != "voltar");
    }






    static void escreva(string palavra){ 
        Console.WriteLine(palavra);
    }

    static string leia(){ 
        return Console.ReadLine();
    }

    static void parar(){ 
        Console.ReadLine();
    }

    static void limpar(){
        Console.Clear();
    }
}