internal class Program
{
    class Musico{
        public string Nombre {get; set;}
        //metodo
        public Musico (string n){Nombre= n;}

        public void Saluda() => Console.WriteLine($"Hola soy {Nombre}");
        public /*virtual*/ void toca() => Console.WriteLine($"{Nombre} tocando su instrumento");

    }
    class Bajista:Musico{ public string bajo{get;set;}
    
    public Bajista(string n , string b): base(n){ //ejecutar el constructor pasando parametros

        bajo = b;
    }
        public /*override*/ new void toca()
        {
            Console.WriteLine($"{Nombre} esta tocando su bajo de la marca {bajo}");
        }
    }
     class Guitarrista:Musico{ public string guitarra{get;set;}
    
    public Guitarrista (string n , string g): base(n){ //ejecutar el constructor pasando parametros

        guitarra = g;
    }
        public /*override*/ new void toca()
        {
            Console.WriteLine($"{Nombre} esta tocando su guitarra de la marca {guitarra}");
        }
    }
    private static void Main(string[] args)
    {
        List<Musico> Thedoors = new List<Musico>();
        Thedoors.Add(new Musico("Jim Morrison"));
        Thedoors.Add(new Bajista("Flea" , "fender"));
        Thedoors.Add(new Guitarrista("Jimmi Hendrix" , "fender"));
        foreach (var m in Thedoors){
        m.Saluda();
        }
        foreach (var m in Thedoors)
        {
                m.toca();

        }
         
        Musico Jim = new Musico("Jim Morrison");
        Jim.Saluda();
        Jim.toca();

        Bajista flea = new Bajista ("Flea", "Fender");
        flea.Saluda();
        flea.toca();
    }
}