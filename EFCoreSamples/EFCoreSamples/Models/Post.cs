﻿namespace EFCoreSamples.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public bool IsDeleted { get; internal set; }
        public int TenantId { get; internal set; }
    }
}