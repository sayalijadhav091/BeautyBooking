﻿namespace BeautyBooking.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<IndexCategoryViewModel> Categories { get; set; }

        public IEnumerable<IndexBlogPostViewModel> BlogPosts { get; set; }
    }
}
