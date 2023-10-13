int [] numeros = new int [11];

for(int i= 0; i <=10;i++){
    numeros[i]=i;
    Console.WriteLine(numeros[i]);
}


string [] nombres = {"Tim", "Martin", "Nikki", "Sara"};

foreach(string nombre in nombres){
    Console.WriteLine(nombre);
}

bool [] alternados = new bool[10];

for(int i = 0; i < alternados.Length; i++){
    if(i ==0){
        alternados[i] = true;
    }else if(i%2!=0){
        alternados[i] = false;
    }else{
        alternados[i] = true;
    }
}

foreach(bool alterna in alternados){
    Console.WriteLine(alterna);
}



List<string> sabores = new List<string>();

sabores.Add("Vainilla");
sabores.Add("Chocolate");
sabores.Add("Naranja");
sabores.Add("Frutilla");
sabores.Add("Piña");

Console.WriteLine(sabores.Count);


Console.WriteLine(sabores[2]);

sabores.RemoveAt(2);

Console.WriteLine(sabores.Count);

Dictionary<string, string> helados = new Dictionary<string, string>();

string [] usuarios = {"alfredo", "matias", "diego"};
string [] saboreshelados = {"Vainilla","Chocolate","Naranja"};


foreach( string usuario in usuarios){
    Random rnd = new Random();
    int i = rnd.Next(0,3);
    helados.Add(usuario,saboreshelados[i]);
    
}


foreach(var helado in helados){
    Console.WriteLine($"{helado.Key}: {helado.Value} ");
}

