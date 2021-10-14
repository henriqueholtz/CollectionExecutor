using CollectionExecutor.Model;
using CollectionExecutor.Persistence.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CollectionExecutorDbContext>();
var app = builder.Build();

#region GET
app.MapGet("/", () => "Welcome to Home endpoint from CollectionExecutor.API");

app.MapGet("/collections", (CollectionExecutorDbContext dbContext) => {
    return dbContext.Collections.ToList();
});

app.MapGet("/requests", (CollectionExecutorDbContext dbContext) => {
    return dbContext.Requests.ToList();
});
#endregion

#region POST

app.MapPost("/populate", (CollectionExecutorDbContext dbContext) =>
{
    dbContext.Collections.AddRange(new List<Collection> { 
        new Collection { Name = "Collection A", CreatedDate = DateTime.Now },
        new Collection { Name = "Collection B", CreatedDate = DateTime.Now },
    });

    dbContext.Requests.AddRange(new List<Request> {
        new Request { Name = "Request A1", CollectionId = 1 },
        new Request { Name = "Request B1", CollectionId = 1 },
    });
    dbContext.SaveChanges();
});
#endregion

app.Run();
