using System;
using System.ComponentModel;
using SQLite;

namespace Assignment2.Model
{
    [Table("ServiceUser")]
    public class ServiceUser : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        string serviceName;

        string gender;
        string name;
        string email;
        string username;
        string password;
        DateTime? dob;
        string phone;
        string cell;
        string picture;
        string address;

        public ServiceUser()
        {

        }

        public ServiceUser(string serName, ResultObject result, FilterData data)
        {
            serviceName = serName;

            if(data.Gender)
                gender = result.gender;
            if (data.Name)
                name = result.name.ToString();
            if (data.Email)
                email = result.email;
            if (data.Username)
                username = result.login.username;
            if (data.Password)
                password = result.login.password;
            if (data.Dob)
                dob = DateTime.Parse(result.dob.date);
            if (data.Phone)
                phone = result.phone;
            if (data.Cell)
                cell = result.cell;
            if (data.Picture)
                picture = result.picture.large;
            if (data.Address)
                address = result.location.ToString();
        }

        public string ServiceName
        {
            set
            {
                if (serviceName != value)
                {
                    serviceName = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ServiceName"));
                    }
                }
            }
            get
            {
                return serviceName;
            }
        }

        public string Gender
        {
            set
            {
                if (gender != value)
                {
                    gender = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
                    }
                }
            }
            get
            {
                return gender;
            }
        }
        public string Name
        {
            set
            {
                if (name != value)
                {
                    name = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }
            get
            {
                return name;
            }
        }
        public string Email
        {
            set
            {
                if (email != value)
                {
                    email = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                    }
                }
            }
            get
            {
                return email;
            }
        }
        public string Username
        {
            set
            {
                if (username != value)
                {
                    username = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Username"));
                    }
                }
            }
            get
            {
                return username;
            }
        }
        public string Password
        {
            set
            {
                if (password != value)
                {
                    password = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Password"));
                    }
                }
            }
            get
            {
                return password;
            }
        }
        public DateTime? Dob
        {
            set
            {
                if (dob != value)
                {
                    dob = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Dob"));
                    }
                }
            }
            get
            {
                return dob;
            }
        }
        public string Phone
        {
            set
            {
                if (phone != value)
                {
                    phone = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Phone"));
                    }
                }
            }
            get
            {
                return phone;
            }
        }
        public string Cell
        {
            set
            {
                if (cell != value)
                {
                    cell = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Cell"));
                    }
                }
            }
            get
            {
                return cell;
            }
        }
        public string Picture
        {
            set
            {
                if (picture != value)
                {
                    picture = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Picture"));
                    }
                }
            }
            get
            {
                return picture;
            }
        }
        public string Address
        {
            set
            {
                if (address != value)
                {
                    address = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Address"));
                    }
                }
            }
            get
            {
                return address;
            }
        }
    }
}