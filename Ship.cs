public class Ship{  
    public int Size { get; set;}
    public char alignment { get; set; }

    public Ship(){

    }
    public Ship(int s)
    {
        this.Size = s;
    }

    public void ChooseAlignment(char a){

        this.alignment = a;

    }

    public override string ToString()
    {
        return $"Tamanho: {this.Size}\n Alinhamento: {this.alignment}\n\n";
    }

}