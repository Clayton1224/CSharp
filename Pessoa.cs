public class Pessoa {  
    private string nome:
private int idade:
private string cpf:

public Pessoa(string,nome, int idade , string cpf) {  
      }
      nome = nome;
      idade = idade;.
      CPF = cpf;
      { public string nome {  
        get{ return nome;} 
        set{ nome =  value;}
      }
      public int idade{ 
        get{ return nome;}
        set{ idade = value;}
      }
      public string CPF{ 
        get { return idade;}
        set{ cpf = value;}
      }
}

public class Estudante : Pessoa { 
    private string curso;

    public Estudante(string nome, int idade, string cpf, string curso) : base(nome, idade, cpf) { 
        curso = curso;
    }

    public string Curso{ 
        get { return curso; }
        set { curso=value; }
    }
}

public class Funcionario: Pessoa { 
    private double salario;

    public double Bonus() { 
        return salario *0.1;
    }

    public Funcionario(string nome, int idade, string cpf, double salario) : base(nome,idade,cpf){ 
        salario=salario
    }

    public string salario { 
        get{ return salario; }
        set { salario=value; }

               }
          }