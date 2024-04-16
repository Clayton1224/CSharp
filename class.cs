using System;

public class Personagem {
    private string nome;
    private int nivel;
    private double pontuacao;
    private double vida;
    private double forca;
    private double agilidade;
    private double inteligencia;
    private string[] armasEquipamentos;

    public Personagem(string nome, int nivel, double pontuacao, double vida, double forca, double agilidade, double inteligencia, string[] armasEquipamentos) {
        this.nome = nome;
        this.nivel = nivel;
        this.pontuacao = pontuacao;
        this.vida = vida;
        this.forca = forca;
        this.agilidade = agilidade;
        this.inteligencia = inteligencia;
        this.armasEquipamentos = armasEquipamentos;
    }

    public string GetNome() {
        return nome;
    }

    public void SetNome(string nome) {
        this.nome = nome;
    }

    public int GetNivel() {
        return nivel;
    }

    public void SetNivel(int nivel) {
        this.nivel = nivel;
    }

    public double GetPontuacao() {
        return pontuacao;
    }

    public void SetPontuacao(double pontuacao) {
        this.pontuacao = pontuacao;
    }

    public double GetVida() {
        return vida;
    }

    public double GetForca() {
        return forca;
    }

    public void SetForca(double forca) {
        this.forca = forca;
    }

    public double GetAgilidade() {
        return agilidade;
    }

    public void SetAgilidade(double agilidade) {
        this.agilidade = agilidade;
    }

    public double GetInteligencia() {
        return inteligencia;
    }

    public void SetInteligencia(double inteligencia) {
        this.inteligencia = inteligencia;
    }

    public string[] GetArmasEquipamentos() {
        return armasEquipamentos;
    }

    public void Mover(string direcao, double distancia) {
        Console.WriteLine($"{nome} está se movendo na direção {direcao} por {distancia} passos.");
    }

    public void Atacar(Personagem alvo) {
        Console.WriteLine($"{nome} está atacando {alvo.GetNome()}.");
    }

    public void ReceberDano(double dano) {
        vida -= dano;
        if (vida <= 0) {
            Morrer();
        } else {
            Console.WriteLine($"{nome} recebeu {dano} de dano. Vida restante: {vida}");
        }
    }

    public void UsarHabilidade(string habilidade, Personagem alvo) {
        Console.WriteLine($"{nome} está usando a habilidade {habilidade} em {alvo.GetNome()}.");
    }

    public void SubirDeNivel() {
        nivel++;
        Console.WriteLine($"{nome} subiu para o nível {nivel}!");
    }

    private void Morrer() {
        Console.WriteLine($"{nome} morreu.");
    }
}

class Program {
    static void Main(string[] args) {
        string[] armasSonic = {"multi-attack", "Super speed", "hiper speed", "mega attack", "hiper speed attack"};
        string[] armasShadow = {"super speed", "mega attack", "hiper speed", "attack speed", "attack dark"};

        Personagem sonic = new Personagem("Sonic", 1, 0, 100, 90, 80, 100, armasSonic);
        Personagem shadow = new Personagem("Shadow", 1, 0, 100, 70, 65, 85, armasShadow);

        Console.WriteLine("Personagem Herói");
        Console.WriteLine($"Nome: {sonic.GetNome()}");
        Console.WriteLine($"Nível: {sonic.GetNivel()}");
        Console.WriteLine($"Pontuação do Sonic: {sonic.GetPontuacao()}");
        Console.WriteLine($"Vida: {sonic.GetVida()}");
        Console.WriteLine($"Força: {sonic.GetForca()}");
        Console.WriteLine($"Agilidade: {sonic.GetAgilidade()}");
        Console.WriteLine($"Inteligência: {sonic.GetInteligencia()}");
        Console.WriteLine($"Armas e Equipamentos: {string.Join(", ", sonic.GetArmasEquipamentos())}");
        Console.WriteLine();

        Console.WriteLine("------------------------------");
        Console.WriteLine();

        Console.WriteLine("Personagem Inimigo");
        Console.WriteLine($"Nome: {shadow.GetNome()}");
        Console.WriteLine($"Nível: {shadow.GetNivel()}");
        Console.WriteLine($"Pontuação do Shadow: {shadow.GetPontuacao()}");
        Console.WriteLine($"Vida: {shadow.GetVida()}");
        Console.WriteLine($"Força: {shadow.GetForca()}");
        Console.WriteLine($"Agilidade: {shadow.GetAgilidade()}");
        Console.WriteLine($"Inteligência: {shadow.GetInteligencia()}");
        Console.WriteLine($"Armas e Equipamentos: {string.Join(", ", shadow.GetArmasEquipamentos())}");
        Console.WriteLine();

        Console.WriteLine("------------------------------");
        Console.WriteLine();

        sonic.Mover("norte", 10);
        shadow.Mover("sul", 10);
        sonic.Atacar(shadow);
        sonic.UsarHabilidade("multi-attack", shadow);
        shadow.ReceberDano(58);
        sonic.SetPontuacao(58);

        Console.WriteLine($"Pontuação do Sonic: {sonic.GetPontuacao()}.");

        shadow.SetPontuacao(38);
        Console.WriteLine($"Pontuação do shadow: {shadow.GetPontuacao()}");

        sonic.UsarHabilidade("ultra attack", shadow);
        shadow.ReceberDano(999);

        sonic.SetPontuacao(100);
        Console.WriteLine($"Pontuação do sonic: {sonic.GetPontuacao()}");

        sonic.SubirDeNivel();
        Console.ReadLine();
    }
}
