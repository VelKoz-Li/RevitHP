﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitHP
{
    public class Model
    {

        public Model() { }
        public Model(int id, string mod_name, string mod_size, int catalogid, string md5, string identifying, String audit)
        {
            Id = id;
            Mod_Name = mod_name;
            Mod_Size = mod_size;
            CatalogId = catalogid;
            MD5 = md5;
            Identifying = identifying;
            Audit = audit;
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

        public int NameID { get; set; }
        public int nameid
        {
            get { return nameid; }
            set
            {
                if (this.NameID != value)
                {
                    this.nameid = value;
                }
            }
        }
        public String Audit { get; set; }
        public String audit
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

        public string Identifying { get; set; }
        public string identifying
        {
            get { return identifying; }
            set
            {
                if (this.Identifying != value)
                {
                    this.identifying = value;
                }

            }
        }

        public string DataTime { get; set; }
        public string datatime
        {
            get { return datatime; }
            set
            {
                if (this.DataTime != value)
                {
                    this.datatime = value;
                }
            }

        }

        public string Mod_Name { get; set; }
        public string mod_name
        {
            get { return mod_name; }
            set
            {
                if (this.Mod_Name != value)
                {
                    this.mod_name = value;
                }
            }
        }

        public string Mod_Size { get; set; }
        public string mod_size
        {
            get { return Mod_Size; }
            set
            {
                if (this.Mod_Size != value)
                {
                    this.mod_size = value;
                }
            }
        }

        public int CatalogId { get; set; }
        public int catalogid
        {
            get { return CatalogId; }
            set
            {
                if (this.CatalogId != value)
                {
                    this.catalogid = value;
                }
            }
        }

        public string md5 { get; set; }

        public string MD5
        {
            get { return md5; }
            set
            {
                if (this.MD5 != value)
                {
                    this.md5 = value;
                }
            }
        }

    }
}
