﻿namespace LearningApi.Models {
    public class Comment {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; } // navigation property (entityframework is done automatically, used to manually be done using "fluent api")
        public Stock? Stock { get; set; } // nav property allows us to tap into the exact Stock properties in this comment model ex. Stock.CompanyName can be done
    }
}
