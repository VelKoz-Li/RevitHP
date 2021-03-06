﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitHP
{
    public class CataItem : INotifyPropertyChanged
    {
        public CataItem(string name, int id,string newname,int audit)
        {
            Name = name;
            Id = id;
            NewName = newname;
            Children = new ObservableCollection<CataItem>();
        }
        public CataItem()
        {
            Children = new ObservableCollection<CataItem>();
        }
        public int ParentID
        {
            get
            {
                if (Parent != null)
                    return Parent.Id;
                else
                    return 0;
            }
            set
            {
                if (this.ParentID != value)
                {
                    this.ParentID = value;
                }
                }
        }
        public string Audit { get; set; }
        public string audit
        {
            get { return audit; }
            set
            {
                if (this.Audit != value)
                {
                    this.audit = value;
                }
            }
        }


        public int Id { get; set; }
        public int id
        {
            get { return id; }
            set
            {
                if (this.Id != value)
                {
                    this.id = value;
                }
            }
        }


        public int NameId { get; set; }
        public int nameid
        {
            get { return nameid; }
            set
            {
                if (this.NameId != value)
                {
                    this.nameid = value;
                }
            }
        }

        public string Name { get; set; }
        public string name
        {
            get { return Name; }
            set
            {
                if (this.Name != value)
                {
                    this.Name = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public string NewName { get; set; }

        public string newname
        {
            get { return NewName; }
            set
            {
                if (this.NewName != value)
                {
                    this.NewName = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("NewName"));
                }
            }
        }


        public CataItem Parent { get; set; }
        public ObservableCollection<CataItem> Children { get; set; }
        public ObservableCollection<CataItem> children
        {
            get
            {
                return Children;
            }
            set
            {
                if (this.Children != value)
                {
                    this.Children = value;
                    //OnPropertyChanged("Children");
                }
            }
        }
      public event PropertyChangedEventHandler PropertyChanged = delegate { };
      public  enum Stater { Input=0,Delete=1,Update=2}
      public int Identifying { get; set; }
    }
}
