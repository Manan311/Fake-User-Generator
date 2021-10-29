using System;
using System.ComponentModel;

namespace Assignment2.Model
{
    public class FilterData: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        bool gender;
        bool name;
        bool email;
        bool username;
        bool password;
        bool dob;
        bool phone;
        bool cell;
        bool picture;
        bool address;

        public bool Gender
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
        public bool Name
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
        public bool Email
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
        public bool Username
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
        public bool Password
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
        public bool Dob
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
        public bool Phone
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
        public bool Cell
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
        public bool Picture
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
        public bool Address
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

        public bool Empty()
        {
            return !(gender ||
                name ||
                email ||
                username ||
                password ||
                dob ||
                phone ||
                cell ||
                picture ||
                address);
        }
    }
}