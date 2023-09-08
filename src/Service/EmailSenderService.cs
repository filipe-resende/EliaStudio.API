using Domain;
using Microsoft.Extensions.Configuration;

namespace Service
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly IConfiguration _configuration;

        public EmailSenderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void EmailSender(ClientInfo clientInfo)
        {
            try
            {
                var outlook = new Email(
                provedor: "smtp.office365.com",
                username: "filipedecastroresende@outlook.com",
                password: _configuration["PASSWORD_MAIL"]);

                outlook.SendEmail(
                emailsTo: new List<string> { "filipedecastroresende@gmail.com" },
                subject: $"[ORÇAMENTO] {clientInfo.nome} - {DateTime.Now}",
                body:
                $"Nome: <strong>{clientInfo.nome}</strong> <br>\n" +
                $"Emai: <strong>{clientInfo.email}</strong><br>\n" +
                $"Telefone: <strong>{clientInfo.telefone} </strong><br>\n" +
                $"Endereco: <strong>{clientInfo.endereco}</strong><br>\n" +
                $"Projeto de interiores:<strong> {(clientInfo.interiores ? "Sim" : "Não")}</strong><br>\n" +
                $"Projetos de interiores comercial:<strong> {(clientInfo.comercial ? "Sim" : "Não")}</strong><br>\n" +
                $"Projetos arquitetônico residencial e comercial:<strong> {(clientInfo.arquitetonico_residencial ? "Sim" : "Não")}</strong><br>\n" +
                $"Projeto legal junto a prefeitura:<strong> {(clientInfo.legalizacao ? "Sim" : "Não")}</strong><br>\n" +
                $"Estou comprando o imóvel:<strong> {(clientInfo.comprando ? "Sim" : "Não")}</strong><br>\n" +
                $"Vou receber as chaves:<strong> {(clientInfo.recebendo_chaves ? "Sim" : "Não")}</strong><br>\n" +
                $"Estou sem pressas:<strong> {(clientInfo.sem_pressa ? "Sim" : "Não")}</strong><br>\n" +
                $"Tenho pressa:<strong> {(clientInfo.tenho_pressa ? "Sim" : "Não")}</strong><br>\n" +
                $"Terreno vazio:<strong> {(clientInfo.terreno_vazio ? "Sim" : "Não")}</strong><br>\n" +
                $"Imóvel antigo:<strong> {(clientInfo.imovel_antigo ? "Sim" : "Não")}</strong><br>\n" +
                $"Casa ou apartamento recém entregue:<strong> {(clientInfo.recem_entregue ? "Sim" : "Não")}</strong><br>\n" +
                $"Pelo instagram:<strong> {(clientInfo.instagram ? "Sim" : "Não")}</strong><br>\n" +
                $"Indicação:<strong> {(clientInfo.indicacao ? "Sim" : "Não")}</strong><br>\n" +
                $"Visitei um projeto assinado por vocês:<strong> {(clientInfo.visitei ? "Sim" : "Não")}</strong><br>\n" +
                $"Outros:<strong> {(clientInfo.outros ? "Sim" : "Não")}</strong><br>\n" +
                $"Quantos metros tem o imóvel: {clientInfo.metros_imoveis} </strong><br>\n" +
                $"Em caso de projetos interiores - para quais ambientes seria o projeto: <strong> {clientInfo.quais_ambientes}</strong><br>\n"+
                $"Nos conte mais sobre seu objetivo: <strong> {clientInfo.seu_objetivo}</strong><br>\n",
                clientInfo.files);
            }
            catch(Exception e) 
            {
                throw;
            }

        }
    }
}
