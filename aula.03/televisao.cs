namespace aula_03;
class Televisao
{
    public Televisao(float tamanho)
    {
        Tamanho=tamanho;

    }


    // get permite que seja executado a leitura do valor atual da propriedade
    // set permite que seja atribuido um valor para a propriedade
    // as propriedades e metodos possuem modificadores de acesso 

    // public: visiveis a todo o projeto
    // internal: visivel somente no namespace
    // protected: visiveis somente na classe e nas classes que herdam
    // private: visivel somente na classe que foi criado 

    public float Tamanho { get; private set; }

   public int Estado { get; set; }
   
   public int Volume { get; set; }

   public int Resolucao { get; set; }

   public int canal { get; set; }
}