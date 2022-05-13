using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Contexts;
using ExaminationSystem.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace ExaminationSystem.FormUI.Seeding;

public class SigmaDateSeeder
{
    private readonly IConfiguration configuration;
    private readonly ApplicationDbContext context;

    public SigmaDateSeeder(IConfiguration configuration,ApplicationDbContext context)
    {
        this.configuration = configuration;
        this.context = context;
    }
    public void Seed()
    {
        var sigmaDate = context.SigmaDates.FirstOrDefault();
        if (sigmaDate != null) return;
        var dates = configuration.GetSection("SigmaDates").Get<List<int>>();
        sigmaDate = new SigmaDate
        {
            StepOneDate = dates.ElementAtOrDefault(0),
            StepTwoDate = dates.ElementAtOrDefault(1),
            StepThreeDate = dates.ElementAtOrDefault(2),
            StepFourDate = dates.ElementAtOrDefault(3),
            StepFiveDate = dates.ElementAtOrDefault(4),
            StepSixDate = dates.ElementAtOrDefault(5),
        };
        context.Add(sigmaDate);
        context.SaveChanges();
    }
}
