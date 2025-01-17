﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953506_YATSYNA.Models
{
    public class ListViewModel<T> : List<T> where T : class
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }

        private ListViewModel(IEnumerable<T> items, int total, int current) : base(items)
        {
            TotalPages = total;
            CurrentPage = current;
        }

        public static ListViewModel<T> GetModel(IEnumerable<T> list, int current, int itemsPerPage)
        {
            var items = list.Skip((current - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            var total = (int)Math.Ceiling((double)list.Count() / itemsPerPage);
            return new ListViewModel<T>(items, total, current);
        }
    }
}
