// classe para validar as regras de negocio do carro
public class ValidaCarro {
    
    // carro tiver algum erro naa validacao, retornar false
    // senao true
    public boolean validaCarro(Carro carro) throws Exception{
            
       
        if(carro.getCodigo() < 0 ){
          return false;
        }
        
        return true;
        
    }
}
