using Microsoft.AspNetCore.Http;

namespace Domain
{
    public class ClientInfo
    {
        private readonly HttpRequest _request;
     
        public ClientInfo(HttpRequest request)
        {
            _request = request;
        }

        public string nome => _request.Form["nome"];
        public string email => _request.Form["email"];
        public string telefone => _request.Form["telefone"];
        public string endereco => _request.Form["endereco"];
        public bool interiores => _request.Form["interiores"].Equals("true");
        public bool comercial => _request.Form["comercial"].Equals("true");
        public bool arquitetonico_residencial => _request.Form["arquitetonico_residencial"].Equals("true");
        public bool legalizacao => _request.Form["legalizacao"].Equals("true");
        public bool comprando => _request.Form["comprando"].Equals("true");
        public bool recebendo_chaves => _request.Form["recebendo_chaves"].Equals("true");
        public bool sem_pressa => _request.Form["sem_pressa"].Equals("true");
        public bool tenho_pressa => _request.Form["tenho_pressa"].Equals("true");
        public bool terreno_vazio => _request.Form["terreno_vazio"].Equals("true");
        public bool imovel_antigo => _request.Form["imovel_antigo"].Equals("true");
        public bool recem_entregue => _request.Form["recem_entregue"].Equals("true");
        public bool habitando => _request.Form["habitando"].Equals("true");
        public bool instagram => _request.Form["instagram"].Equals("true");
        public bool indicacao => _request.Form["indicacao"].Equals("true");
        public bool visitei => _request.Form["visitei"].Equals("true");
        public bool outros => _request.Form["outros"].Equals("true");
        public string metros_imoveis => _request.Form["metros_imoveis"];
        public string seu_objetivo => _request.Form["seu_objetivo"];
        public string quais_ambientes => _request.Form["quais_ambientes"];
        public IFormFileCollection files => _request.Form.Files;
    }
}
