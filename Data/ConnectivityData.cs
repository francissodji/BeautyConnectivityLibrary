using ConnectivityLibrary.Models;
using ConnectivityLibrary.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectivityLibrary.ModelsHelper;
using ConnectivityLibrary.Dtos;
using System.Net;

namespace ConnectivityLibrary.Data
{
    public class ConnectivityData : IConnectivityData
    {

        private readonly IConnectivitySqlDataAccess _dbConnect;


        public ConnectivityData(IConnectivitySqlDataAccess dbConnect)
        {
            _dbConnect = dbConnect;
        }

        //************************* USER ************************************

        //Get all users
        public Task<IEnumerable<UserLibrary>> GetAllUsers(string connectionStringName) =>
            _dbConnect.LaodData<UserLibrary, dynamic>("dbo.spUsers_GetAllUser", new { }, connectionStringName);


        //Get User By Id
        public async Task<UserLibrary?> GetUserById(string connectionStringName, int id)
        {
            var results = await _dbConnect.LaodData<UserLibrary, dynamic>(
                "dbo.spUsers_GetUserById",
                new { IdUser = id },
                connectionStringName);

            return results.FirstOrDefault();
        }

        //Get User by username
        public async Task<UserLibrary?> GetUserByEmail(string connectionStringName, string userEmail)
        {
            var results = await _dbConnect.LaodData<UserLibrary, dynamic>(
                "dbo.spUsers_GetUserByEmail",
                new { email = userEmail },
                connectionStringName);

            return results.FirstOrDefault();
        }

        //Get User by Username
        public async Task<UserLibrary?> GetUserByUsername(string connectionStringName, string username)
        {

            var results = await _dbConnect.LaodData<UserLibrary, dynamic>(
                "dbo.spUsers_GetUserByUsername",
                new { Username = username },
                connectionStringName);

            return results.FirstOrDefault();
        }


        //Create new user - Add user with everything associate
        public Task CreateNewUser(string connectionStringName, RegisterLibrary register) =>
            _dbConnect.SaveData("dbo.spUsers_CreateNewUser",
                                new
                                {
                                    register.Email,
                                    register.Username,
                                    register.Password,
                                    register.Role,
                                    register.Connectstate,
                                    register.FirstName,
                                    register.MiddleName,
                                    register.LastName,
                                    register.SubDomaine
                                },
                                connectionStringName);



        //Create new user
        /*
        public Task CreateNewUser(string connectionStringName, UserLibrary user) =>
            _dbConnect.SaveData("dbo.spUsers_CreateNewUser",
                                new
                                {
                                    user.Email,
                                    user.Username,
                                    user.PasswordHash,
                                    user.Role
                                },
                                connectionStringName);

        */

        //Update user
        public Task UpdateUser(string connectionStringName, UserLibrary user) =>
            _dbConnect.SaveData("dbo.spUsers_UpdateUser",
                               new { user.IdUser}, 
                               connectionStringName);


        //Delete user
        public Task DeleteUser(string connectionStringName, int id) =>
            _dbConnect.SaveData("dbo.spUsers_DeleteUser",
                               new { IdUser = id },
                               connectionStringName);


        public async Task<UserClientInCompanyLibrary?> GetLatestUserClientCreated(string connectionStringName, string username)
        {
            var results = await _dbConnect.LaodData<UserClientInCompanyLibrary, dynamic>(
                                                                                    "dbo.spCompaniesClients_GetUserClientInCompanyByUsername",
                                                                                    new { username },
                                                                                    connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<UserAssociateInCompanyLibrary?> GetLatestUserAssociateCreated(string connectionStringName, string username)
        {
            var results = await _dbConnect.LaodData<UserAssociateInCompanyLibrary, dynamic>(
                                                                                    "dbo.spCompaniesAssociates_GetUserAssociateInCompanyByUsername",
                                                                                    new { username },
                                                                                    connectionStringName);

            return results.FirstOrDefault();
        }

        //***************************END USER********************************

        //*************************** CLIENT ****************************************
        public Task<IEnumerable<ClientLibrary>> GetAllClientsByIdCompany(string connectionStringName, int idCompany) =>
            _dbConnect.LaodData<ClientLibrary, dynamic>("dbo.spClients_GetAllClientByIdCompany",
                                                        new
                                                        {
                                                            IdCompany = idCompany
                                                        }, 
                                                        connectionStringName);

        public Task CreateNewClient(string connectionStringName, ClientLibrary client) =>
            _dbConnect.SaveData("dbo.spClient_CreateNewClient",
                                new
                                {
                                    client.FnameClient,
                                    client.MnameClient,
                                    client.LnameClient,
                                    client.CelClient,
                                    client.EmailClient,
                                    //client.StreetClient,
                                    //client.StateClient,
                                    //client.CountyClient,
                                    //client.ZipCodeClient,
                                    client.IdUser
                                },
                                connectionStringName);

        public Task UpdateClient(string connectionStringName, int idClient, ClientLibrary client) =>
            _dbConnect.SaveData("dbo.spClients_UpdateClient",
                                new
                                {
                                    idClient,
                                    client.FnameClient,
                                    client.MnameClient,
                                    client.LnameClient,
                                    client.PhoneClient,
                                    client.CelClient,
                                    client.DOBClient,
                                    client.SexClient,
                                    client.StreetClient,
                                    client.CountyClient,
                                    client.ZipCodeClient,
                                    client.StateClient,
                                    client.EmailClient

                                },
                                connectionStringName);

        public async Task<ClientLibrary?> GetClientByIdClient(string connectionStringName, int id)
        {
            var results = await _dbConnect.LaodData<ClientLibrary, dynamic>(
                "dbo.spClients_GetClientByIdClient",
                new { IdClient = id },
                connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<ClientLibrary?> GetClientByIdUser(string connectionStringName,  int id)
        {
            var results = await _dbConnect.LaodData<ClientLibrary, dynamic>(
                "dbo.spClients_GetClientByIdUser",
                new { id },
                connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<ClientLibrary?> GetClientByCelClient(string connectionStringName, int idCompany, string celphone)
        {
            var results = await _dbConnect.LaodData<ClientLibrary, dynamic>(
                                                                                    "dbo.spClients_GetClientByCellPhone",
                                                                                    new
                                                                                    {
                                                                                        IdCompany = idCompany,
                                                                                        celPhone = celphone
                                                                                    },
                                                                                    connectionStringName);

            return results.FirstOrDefault();
        }
        //*************************** END CLIENT *************************************


        //*************************** ASSOCIATE ****************************************
        public Task CreateNewAssociate(string connectionStringName, AssociateLibrary associate) =>
            _dbConnect.SaveData("dbo.spAssociate_CreateNewAssociate",
                                new
                                {
                                    associate.FnameAssociate,
                                    associate.MnameAssociate,
                                    associate.LnameAssociate,
                                    associate.CelAssociate,
                                    associate.EmailAssociate,
                                    associate.StreetAssociate,
                                    associate.StateAssociate,
                                    associate.CountyAssociate,
                                    associate.ZipCodeAssociate,
                                    associate.IdUser
                                },
                                connectionStringName);

        public async Task<AssociateLibrary?> GetAssociateById(string connectionStringName, int id)
        {
            var results = await _dbConnect.LaodData<AssociateLibrary, dynamic>(
                "dbo.spAssociates_GetAssociateById",
                new { id },
                connectionStringName);

            return results.FirstOrDefault();
        }


        public async Task<AssociateLibrary?> GetAssociateByIdUser(string connectionStringName, int id)
        {
            var results = await _dbConnect.LaodData<AssociateLibrary, dynamic>(
                "dbo.spAssociates_GetAssociateByIdUser",
                new { id },
                connectionStringName);

            return results.FirstOrDefault();
        }
        //*************************** END CLIENT *************************************


        //**************************** COMPANY ***************************************

            //The creation of a new company include the creation of the user-owner (first user)
            //All the fields here are required
        public Task CreateNewCompany(string connectionStringName, RegisterLibrary register) =>
            _dbConnect.SaveData("dbo.spCompanies_CreateNewCompany",
                                new
                                {
                                    register.Email,
                                    register.Username,
                                    register.Password,
                                    register.Role,
                                    register.Connectstate,
                                    register.FirstName,
                                    register.MiddleName,
                                    register.LastName,
                                    register.SubDomaine,
                                    register.DesignationComp,
                                    register.SuperAdminPW

                                },
                                connectionStringName);

        public async Task<CompanyLibrary?> GetCompanyById(string connectionStringName, int id)
        {
            var results = await _dbConnect.LaodData<CompanyLibrary, dynamic>(
                                                                "dbo.spCompanies_GetCompanyById",
                                                                new { id },
                                                                connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<CompanyLibrary?> GetCompanyBySubdomaine(string connectionStringName, string subdomaine)
        {
            var results = await _dbConnect.LaodData<CompanyLibrary, dynamic>(
                                                    "dbo.spCompanies_GetCompanyBySubdomaine",
                                                    new { Subdomaine = subdomaine },
                                                    connectionStringName);

            return results.FirstOrDefault();
        }

        public Task UpdateCompany(string connectionStringName, int id, CompanyLibrary company) =>
            _dbConnect.SaveData("dbo.spCompanies_UpdateCompany",
                                new
                                {
                                    id,
                                    company.AcronymComp,
                                    company.DesignationComp,
                                    company.PhoneOffice,
                                    company.PhoneOwner,
                                    company.IdOwnerBraider,
                                    company.PartPayeBraid,
                                    company.CostHairDeduct,
                                    company.CostTakeDown,
                                    company.IdMainRegister,
                                    company.StateTaxOnSale,
                                    company.StateTaxOnBraiding,
                                    company.StreetComp,
                                    company.CountyComp,
                                    company.ZipcodeComp,
                                    company.StateComp,
                                    company.EmailComp,
                                    company.WebsiteComp,
                                    company.SubDomaine,
                                    company.CreationDate,
                                    company.DateWorkMond,
                                    company.DateWorkTues,
                                    company.DateWorkWed,
                                    company.DateWorkThur,
                                    company.DateWorkFrid,
                                    company.DateWorkSatu,
                                    company.DateWorkSund,
                                    company.TimeWorkBegin,
                                    company.TimeWorkEnd,
                                    company.AcceptPartialPay,
                                    company.PercentPayPartialPay,
                                    company.AmountPayPartialPay,
                                    company.MaxBraider,
                                    company.GalleryImageRepos
                                },
                                connectionStringName);

        //**************************** END COMPANIES *********************************

        //*********************** COMPANY-CLIENT ******************************
        //Create new Company-Client
        public Task CreateNewCompanyClient(string connectionStringName, CompanyClientLibrary companyClient) =>
            _dbConnect.SaveData("dbo.spCompaniesClients_CreateNewCompClient",
                                new
                                {
                                    companyClient.IdCompany,
                                    companyClient.IdClient
                                },
                                connectionStringName);


        // Get CompanyClient By idClient
        public async Task<CompanyClientLibrary?> GetCompanyClientByIdClient(string connectionStringName, int idClient)
        {
            var results = await _dbConnect.LaodData<CompanyClientLibrary, dynamic>(
                                            "dbo.spCompaniesClients_GetCompanyByIdClient",
                                            new { idClient = idClient },
                                            connectionStringName);

            return results.FirstOrDefault();
        }

        //Get Company-Client Info by IdUser
        public async Task<UserClientInCompanyLibrary?> GetCompanyClientInfoByIdUser(string connectionStringName, int idUser)
        {
            var results = await _dbConnect.LaodData<UserClientInCompanyLibrary, dynamic>(
                                                                            "dbo.spCompaniesClients_GetUserClientInCompanyByIdUser",
                                                                            new { idUser },
                                                                            connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<UserClientInCompanyLibrary?> GetCompanyClientInfoByUsername(string connectionStringName, string username)
        {
            var results = await _dbConnect.LaodData<UserClientInCompanyLibrary, dynamic>(
                                                                    "dbo.spCompaniesClients_GetUserClientInCompanyByUsername",
                                                                    new { username },
                                                                    connectionStringName);

            return results.FirstOrDefault();
        }
        //**************************************************************************

        //*********************** COMPANY-ASSOCIATE ********************************
        //Create new company associate
        public Task CreateNewCompanyAssociate(string connectionStringName, CompanyAssociateLibrary companyAssociate) =>

            _dbConnect.SaveData("dbo.spCompaniesAssociates_CreateNewCompAssociate",
                                new
                                {
                                    companyAssociate.IdCompany,
                                    companyAssociate.IdAssociate
                                },
                                connectionStringName);


        //Get Company-Associate by IdAssociate
        public async Task<CompanyAssociateLibrary?> GetCompanyAssociateByIdAssociate(string connectionStringName, int idAssociate)
        {
            var results = await _dbConnect.LaodData<CompanyAssociateLibrary, dynamic>(
                                                                        "dbo.spCompaniesAssociates_GetCompanyByIdAssociate",
                                                                        new { idAssociate = idAssociate },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }


        //Get Company-Associate Info by IdUser
        public async Task<UserAssociateInCompanyLibrary?> GetCompanyAssociateInfoByIdUser(string connectionStringName, int idUser)
        {
            var results = await _dbConnect.LaodData<UserAssociateInCompanyLibrary, dynamic>(
                                                                        "dbo.spCompaniesAssociates_GetUserAssociateInCompanyByIdUser",
                                                                        new { IdUser = idUser },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<UserAssociateInCompanyLibrary?> GetCompanyAssociateInfoByUsername(string connectionStringName, string username)
        {
            var results = await _dbConnect.LaodData<UserAssociateInCompanyLibrary, dynamic>(
                                                                        "dbo.spCompaniesAssociates_GetUserAssociateInCompanyByUsername",
                                                                        new { username },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }



        //**************************************************************************
    }
}
