﻿namespace Bookify.Web.Core.ViewModles
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Max length cannot be more than 100 chr.")]
        public string Name { get; set; } = null!;

    }
}
