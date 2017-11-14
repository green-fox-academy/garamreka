using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TheReddit.Entities;

namespace TheReddit.Migrations
{
    [DbContext(typeof(RedditPostContext))]
    [Migration("20171114121256_AddDate")]
    partial class AddDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheReddit.Models.RedditPost", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.Property<int>("DownVote");

                    b.Property<string>("Title");

                    b.Property<int>("UpVote");

                    b.HasKey("Id");

                    b.ToTable("RedditPosts");
                });
        }
    }
}
