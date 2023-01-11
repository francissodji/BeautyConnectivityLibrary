using ConnectivityLibrary.Dtos;
using ConnectivityLibrary.Models;
using ConnectivityLibrary.ModelsHelper;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Data
{
    public interface IConnectivityData
    {
        //Task CreateNewUser(string connectionStringName, UserLibrary user);
        Task CreateNewUser(string connectionStringName, RegisterLibrary register);
        Task<IEnumerable<UserLibrary>> GetAllUsers(string connectionStringName);
        Task<UserLibrary?> GetUserById(string connectionStringName, int id);
        Task<UserLibrary?> GetUserByEmail(string connectionStringName, string userEmail);
        Task<UserLibrary?> GetUserByUsername(string connectionStringName, string userName);
        Task<UserClientInCompanyLibrary?> GetLatestUserClientCreated(string connectionStringName, string userName);
        Task<UserAssociateInCompanyLibrary?> GetLatestUserAssociateCreated(string connectionStringName, string userName);

        Task DeleteUser(string connectionStringName, int id);
        Task UpdateUser(string connectionStringName, UserLibrary user);

        //************END USERS

        //****************************** CLIENT ************************
        Task CreateNewClient(string connectionStringName, ClientLibrary client);

        Task UpdateClient(string connectionStringName, int idClient, ClientLibrary client);

        Task<IEnumerable<ClientLibrary>> GetAllClientsByIdCompany(string connectionStringName, int idCompany);

        Task<ClientLibrary?> GetClientByIdUser(string connectionStringName, int id);

        Task<ClientLibrary?> GetClientByIdClient(string connectionStringName, int id);

        Task<ClientLibrary?> GetClientByCelClient(string connectionStringName, int idCompany, string celphone);

        //**************************END CLIENT *************************

        //****************************** ASSOCIATE ************************
        Task CreateNewAssociate(string connectionStringName, AssociateLibrary associate);

        Task<AssociateLibrary?> GetAssociateByIdUser(string connectionStringName, int id);

        Task<AssociateLibrary?> GetAssociateById(string connectionStringName, int id);
        //**************************END ASSOCIATE *************************


        //************************COMPANY *************************************
        Task CreateNewCompany(string connectionStringName, RegisterLibrary register);
        Task<CompanyLibrary?> GetCompanyById(string connectionStringName, int id);

        Task<CompanyLibrary?> GetCompanyBySubdomaine(string connectionStringName, string subdomaine);

        Task UpdateCompany(string connectionStringName, int id, CompanyLibrary company);
        //*********************************************************************


        //*********************** COMPANY-CLIENT ******************************
        Task CreateNewCompanyClient(string connectionStringName, CompanyClientLibrary companyClient);

        Task<CompanyClientLibrary?> GetCompanyClientByIdClient(string connectionStringName, int idClient);

        Task<UserClientInCompanyLibrary?> GetCompanyClientInfoByIdUser(string connectionStringName, int idUser);

        Task<UserClientInCompanyLibrary?> GetCompanyClientInfoByUsername(string connectionStringName, string username);
        //*********************************************************************


        //*********************** COMPANY-ASSOCIATE ******************************
        Task CreateNewCompanyAssociate(string connectionStringName, CompanyAssociateLibrary companyAssociate);

        Task<CompanyAssociateLibrary?> GetCompanyAssociateByIdAssociate(string connectionStringName, int idAssociate);

        Task<UserAssociateInCompanyLibrary?> GetCompanyAssociateInfoByIdUser(string connectionStringName, int idUser);

        Task<UserAssociateInCompanyLibrary?> GetCompanyAssociateInfoByUsername(string connectionStringName, string username);
        //*********************************************************************
    }
}