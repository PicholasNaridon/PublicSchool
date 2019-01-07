using System.Data.Entity;

namespace PublicSchool.Database
{
    public class PublicSchoolDBInitializer : DropCreateDatabaseAlways<PublicSchoolDBContext>
    {
        protected override void Seed(PublicSchoolDBContext context)
        {
         
            base.Seed(context);
        }
    }
}