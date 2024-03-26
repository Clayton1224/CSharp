using System;

class Comida{  
    //atributos 
    private string nome;
    private string cor;
    private int idade;
    private double altura;
    private char genero;
//construtor
public personagem(string nome,string cor,int idade, double altura,char genero){  
    this.nome = nome;
    this.cor = cor;
    this.idade = idade;
    this.altura = altura;
    this.genero = genero;
      }
      //metodos
      public void infoComida() { 
        console.writeline($"nome:{nome},idade:{idade},altura:{altura},genero:{genero}")
         }
        private void correr(){  
            console.writeline("correndo.");
          }
          private void pular(){  
            console.writeline("pulando.")
               }
             }    
             class cozidao: Comida {  

                public cozidao() { 
                    this.nome ="cozidao";
                    this.cor ="marrom";
                    this.idade =400;
                    this.altura =3,0;
                    this.genero = "M";
                    public void superDelicioso() {  
                        console.writeline("cozidão esta usando seu cheiro.")
                          } 
                      }  
                }

                  class farofa: Comida {  

                public farofa() { 
                    this.nome ="farofa";
                    this.cor ="amarela";
                    this.idade =200;
                    this.altura =1.0;
                    this.genero = "F";
                    public void superDelicioso() {  
                        console.writeline("farofa com sua textura.")
                          } 
                      }  
                }

                class program {  
                    static void main(string[] args) {  
                        cozidao cozidao - new cozidao();
                        farofa farofa - new farofa();
                        console.writeline($"nome:{cozidao,cozidao},cor:{cozidao,marrom}, idade:{cozidao,300},altura:{cozidao,3,0},genero:{cozidao,M}");

                        cozidao.cheiro();
                        cozidao.sabor();
                        cozidao.superdelicioso();
                       
                        console.writeline();
                         console.writeline($"nome:{farofa,farofa},cor:{farofa,amarela}, idade:{farofa,200},altura:{farofa,1,0},genero:{farofa,F}");

                        farofa.textura();
                        farofa.sabor();
                        farofa.superdelicioso();
                       