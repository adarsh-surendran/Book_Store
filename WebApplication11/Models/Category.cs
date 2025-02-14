﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public int Position { get; set; }
        public string CreatedAt { get; set; }
        public Category()
        {

        }
        public Category(int CId,string CName,string Des, string Img,string Sts,int Pos,string CrAt)
        {
            CategoryId = CId;
            CategoryName = CName;
            Description = Des;
            Image = Img;
            Status = Sts;
            Position = Pos;
            CreatedAt = CrAt;
        }
    }
}