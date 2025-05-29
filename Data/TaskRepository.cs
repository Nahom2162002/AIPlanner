using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TaskRepository;

public class TaskContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;ConnectRetryCount=0")
    }
}

public class Task
{
    public int TaskId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public bool IsCompleted { get; set; } 
}

public class Query
{
    using (var db = new TaskContext()) {
        var blogs = await db.Tasks.Where(b => b.IsCompleted).OrderBy(b => b.Title).ToListAsync();
    }
}

public class Save
{
    var task = new TaskRepository { Url = "http://sample.com" };
    db.Tasks.Add(task);
    await db.SaveChangesAsync();
}