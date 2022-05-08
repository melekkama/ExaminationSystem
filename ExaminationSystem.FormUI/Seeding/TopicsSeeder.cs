using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Contexts;
using ExaminationSystem.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace EExaminationSystem.FormUI.Seeding;

public class TopicsSeeder
{
    private readonly IConfiguration configuration;
    private readonly ApplicationDbContext context;

    public TopicsSeeder(IConfiguration configuration, ApplicationDbContext context)
    {
        this.configuration = configuration;
        this.context = context;
    }
    public void Seed()
    {
        if (!context.Topics.Any())
        {
            var topicNames = configuration.GetSection("Topics").Get<List<string>>();
            var topics = topicNames.Select(x => new Topic() { Name = x });
            context.AddRange(topics);
            context.SaveChanges();
        }
    }
}
