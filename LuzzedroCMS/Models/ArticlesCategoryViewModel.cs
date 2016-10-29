﻿using LuzzedroCMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuzzedroCMS.Models
{
    public class ArticlesCategoryViewModel
    {
        public IQueryable<Article> Articles { get; set; }
        public string Category { get; set; }
    }
}