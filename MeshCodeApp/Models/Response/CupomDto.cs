namespace MeshCodeApp.Models.Response
{
    public class CupomDto
    {

       public int EstablishmentId { get; set; }
       public decimal Value {  get; set; }    
       public decimal DescountPercent {  get; set; }    
       public string Name {  get; set; }   
       public string Image {  get; set; }  
       public DateTime CreatedAt {  get; set; }
       public DateTime DataInicio {  get; set; }
       public DateTime DataFim {  get; set; } 
       public bool Ativo {  get; set; }    
    }
}
