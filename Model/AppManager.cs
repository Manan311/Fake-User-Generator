using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Assignment2.Persistence;

namespace Assignment2.Model
{
    public class AppManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<ServiceUser> serviceUsers = new List<ServiceUser>();

        public AppManager()
        {
        }

        public bool ServiceUserEmpty
        {
            get
            {
                bool ans = (serviceUsers.Count == 0);
                return ans;
            }
        }

        public async Task InitServiceUser()
        {
            var database = await ServiceUserItemDatabase.Instance;

            serviceUsers = await database.GetItemsAsync();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("ServiceUserEmpty"));
            }
        }

        public async Task AddServiceUserAsync(ServiceUser s)
        {
            serviceUsers.Add(s);

            var database = await ServiceUserItemDatabase.Instance;
            await database.SaveItemAsync(s);
        }

        public async Task RemoveServiceUserAsync(ServiceUser s)
        {
            serviceUsers.Remove(s);

            var database = await ServiceUserItemDatabase.Instance;
            await database.DeleteItemAsync(s);
        }
    }
}
