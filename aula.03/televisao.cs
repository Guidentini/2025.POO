namespace aula_03;
class Televisao
{
    public Televisao(float tamanho)
    {
        if(tamanho< TAMANHO_MINIMO )
        {
            throw new ArgumentOutOfRangeException($"o tamanho ({tamanho}) nao e suportado");
        }
        Tamanho=tamanho;
    }
    private int volume_maximo=100;
    private int volume_minimo=10;
    private int volume_padrao=35;
    


    // get permite que seja executado a leitura do valor atual da propriedade
    // set permite que seja atribuido um valor para a propriedade
    // as propriedades e metodos possuem modificadores de acesso 

    // public: visiveis a todo o projeto
    // internal: visivel somente no namespace
    // protected: visiveis somente na classe e nas classes que herdam
    // private: visivel somente na classe que foi criado 

    private const float TAMANHO_MINIMO=22;

    public float Tamanho { get; private set; }

   public int Estado { get; set; }
   
   public int Volume { get; private set; }

   public int Resolucao { get; set; }

   public int canal { get; set; }


   public void aumentarvolume()
{
    if(Volume<volume_maximo)
    {
     Volume++;
   }
   else
   {
    Console.WriteLine($"o volume da tv ({Volume}) esta no maximo");
   }
}
   public void abaixarvolume()
   {
    Volume--;
   }
}