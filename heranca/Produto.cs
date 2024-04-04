public class Produto {
    private string nome:
    private decimal preco:
    private string descricao:
    private string categoria:

    public Produto(string nome, decimal preco, string descricao, string categoria){
        this.nome = nome:
        this.preco = preco:
        this.descricao = descricao:
        this.categoria = categoria:
    }
    public string Nome {
        get {return nome;}
        set {nome = value;}
    }
    public decimal Preco {
        get {return preco;}
        set {preco = value;}
}
public string Descricao {
        get {return descricao;}
        set {descricao = value;}
}
public string Categoria {
        get {return categoria;}
        set {categoria = value;}
 }
}

public class ConsoleGame : Produto{
    private int armazenamento:

public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int armazenamento) : base(nome, preco, descricao, categoria){
    Armazenamento = armazenamento:
}
public string Armazenamento {
        get {return armazenamento;}
        set {armazenamento = value;}
 }
}

public class Jogo : Produto{
    private string genero:

public Jogo(string nome, decimal preco, string descricao, string categoria, string genero) : base(nome, preco, descricao, categoria){
    Genero = genero:
}
public string Genero {
        get {return genero;}
        set {genero = value;}
 }
}

public class Acessorio : Produto{
    private string tipo:

public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo) : base(nome, preco, descricao, categoria){
   Tipo = tipo:
}
public string Tipo {
        get {return tipo;}
        set {tipo = value;}
 }
}
public class Colecionavel : Produto{
    private bool edicaoLimitada:

public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada) : base(nome, preco, descricao, categoria){
   EdicaoLimitada = edicaolimitada:
}
public string EdicaoLimitada{
        get {return edicaoLimitada;}
        set {edicaoLimitada = value;}
 }
}

public class Program {
    public static void main (string[] args) {
        ConsoleGame consoleGame = new ConsoleGame ("PlayStation 3", 1.229 , "Console de Vídeo Game PlayStation 3","Console","1 Tera");
        Jogo jogo = new Jogo ("stardew valley", 24,90, "Jogo completo  stardew valley para Playstation 4", "jogo PS4", "aventura");
Produto produto;
produto = new Acessorio ("mouse redragon", 162.90, "mouse sem fio   da cor azul", "Acessório", "Tipo: mouse");
        Colecionavel colecionavel = new Colecionavel ("Figure do luffy", 130, "Boneco do luffy,  principal personagem de One Piece",
        " Colecionável", true);
    }
}