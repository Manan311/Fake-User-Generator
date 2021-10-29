using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Assignment2.Model;

namespace Assignment2.Persistence
{
    public class ServiceUserItemDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<ServiceUserItemDatabase> Instance = new AsyncLazy<ServiceUserItemDatabase>(async () =>
        {
            var instance = new ServiceUserItemDatabase();
            CreateTableResult result = await Database.CreateTableAsync<ServiceUser>();
            return instance;
        });

        public ServiceUserItemDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<ServiceUser>> GetItemsAsync()
        {
            return Database.Table<ServiceUser>().ToListAsync();
        }

        public Task<int> SaveItemAsync(ServiceUser user)
        {
            if (user.ID != 0)
            {
                return Database.UpdateAsync(user);
            }
            else
            {
                return Database.InsertAsync(user);
            }
        }

        public Task<int> DeleteItemAsync(ServiceUser item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
