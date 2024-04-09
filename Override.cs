public class personagem  {
    private string nome:
    private decimal raca:
    private int idade:
    private string poder:

    public personagem (string nome, decimal raca, int idade , string poder){
        this.nome = nome :
        this.preco = raca :
        this.descricao = idade :
        this.categoria = poder :
    }
    public string Nome {
        get {return nome;}
        set {nome = value;}
    }
    public decimal raca {
        get {return raca ;}
        set {raca = value;}
}
public string idade {
        get {return idade;}
        set {idade = value;}
}
public string poder {
        get {return poder;}
        set {poder = value;}
 }
    public virtual void Atacar(){
        Console.WriteLine("Orar!")
    }
 }

public class guerreiro : personagem{
    private int espada:

public guerreiro(string nome, decimal poder, string raca, string int, int espada) : base(nome, poder, raca , idade){

    espada = espada:
}
public string espada {
        get {return espada;}
        set {espada  = value;}
 }
    public override void Atacar(){
        Console.WriteLine("Maxium Sword!")
    }

 
 }

public class lutador : personagem {
    private string luvas :

public lutador(string nome, decimal poder, string raca, int idade, string luvas) : base(nome, poder,raca ,idade ){
    luvas = luvas:
}
public string luvas {
        get {return luvas;}
        set {luvas = value;}
 }
    public override void Atacar(){
        Console.WriteLine("Meteor Punch!")
    }

}

public class atirador : personagem{
    private string arma:

public Atirador(string nome, decimal poder, string raca, int idade, string arma) : base(nome, poder, raca, idade){
   arma = arma:
}
public string arma {
        get {return arma;}
        set {arma = value;}
 }
    public override void Atacar(){
        Console.WriteLine("Omega Shoot!")
    }

}
public class mago : personagem{
    private bool livro:

public mago(string nome, decimal poder, string raca, int idade, string  livro) : base(nome, poder, raca, idade){
   livro = livro:
}
public string livro{
        get {return livro;}
        set {livro = value;}
 }
    public override void Atacar(){
        Console.WriteLine("FIre Ball")
    }
}

public class Program {
    public static void main (string[] args) {
        guerreiro guerreiro = new guerreiro ("guerreiro", 1,90m , "guerreiro forte e feroz", "humano", "Excalibur",);
        guerreiro.Atacar();.
        lutador lutador = new lutador ("lutador", 2,0m, "lutador habilidoso e veloz", "humano", "Dragon Gloves",);
        lutador.Atacar();.
        atirador atirador = new atirador ("atirador", 1.60m, "atirador raciocinio veloz", "humano", "Supreme Gun",);
        atirador.Atacar();.
        mago mago = new mago ("mago", 1.45m, "mago inteligente e sabio", "humano", "Death Grimore",);
        mago.Atacar();.
    }
}