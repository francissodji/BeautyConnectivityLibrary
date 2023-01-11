namespace ConnectivityLibrary.DbAccess
{
    public interface IConnectivitySqlDataAccess
    {
        Task<IEnumerable<T>> LaodData<T, U>(string storedProcedure, U parameters, string connectionStringName = "Default");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName = "Default");
    }
}