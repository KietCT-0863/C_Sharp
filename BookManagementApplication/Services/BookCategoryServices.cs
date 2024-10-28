﻿using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryServices
    {
        private BookCategoryRepository _bookCateRepo = new();

        public List<BookCategory> GetAllBookCategories() => _bookCateRepo.GetBookCategories();
    }
}
