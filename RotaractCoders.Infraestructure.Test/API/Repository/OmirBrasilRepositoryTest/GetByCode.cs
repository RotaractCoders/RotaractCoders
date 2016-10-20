using RotaractCoders.Domain.Enums;
using RotaractCoders.Domain.Model;
using RotaractCoders.Infraestructure.API.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace RotaractCoders.Infraestructure.Test.API.Repository.OmirBrasilRepositoryTest
{
    public class GetByCode : RepositoryBase
    {
        private Project project;

        public GetByCode()
        {
            project = GetDefaultProject();
        }

        [Fact]
        public void Success()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.True(result.IsValid());
            }
        }

        [Fact]
        public void Success_Name()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Name, result.Name);
            }
        }

        [Fact]
        public void Success_Club()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Club.Name, result.Club.Name);
                Assert.Equal(project.Club.Code, result.Club.Code);
                Assert.Equal(project.Club.Email, result.Club.Email);
                Assert.Equal(project.Club.Facebook, result.Club.Facebook);
                Assert.Equal(project.Club.District.Number, result.Club.District.Number);
            }
        }

        [Fact]
        public void Success_Rationale()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Rationale, result.Rationale);
            }
        }

        [Fact]
        public void Success_GeneralObjective()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.GeneralObjective, result.GeneralObjective);
            }
        }

        [Fact]
        public void Success_SpecificObjective()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.SpecificObjective, result.SpecificObjective);
            }
        }

        [Fact]
        public void Success_MainCategory()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.MainCategory, result.MainCategory);
            }
        }

        [Fact]
        public void Success_OtherCategories()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.OtherCategories, result.OtherCategories);
            }
        }

        [Fact]
        public void Success_StartDate()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.StartDate, result.StartDate);
            }
        }

        [Fact]
        public void Success_EndDate()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.EndDate, result.EndDate);
            }
        }

        [Fact]
        public void Success_CompletionDate()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.CompletionDate, result.CompletionDate);
            }
        }

        [Fact]
        public void Success_ProjectFinancials()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.ProjectFinancials.Count, result.ProjectFinancials.Count);

                for (int i = 0; i < result.ProjectFinancials.Count; i++)
                {
                    Assert.Equal(project.ProjectFinancials[i].Description, result.ProjectFinancials[i].Description);
                    Assert.Equal(project.ProjectFinancials[i].Date, result.ProjectFinancials[i].Date);
                }
            }
        }

        [Fact]
        public void Success_Participants()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Participants, result.Participants);
            }
        }

        [Fact]
        public void Success_TargetAudience()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.TargetAudience, result.TargetAudience);
            }
        }

        [Fact]
        public void Success_DisclosureMeans()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.DisclosureMeans, result.DisclosureMeans);
            }
        }

        [Fact]
        public void Success_Partnerships()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Partnerships, result.Partnerships);
            }
        }

        [Fact]
        public void Success_Schedule()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Schedule.Count, result.Schedule.Count);

                for (int i = 0; i < result.Schedule.Count; i++)
                {
                    Assert.Equal(result.Schedule[i].Date, project.Schedule[i].Date);
                    Assert.Equal(result.Schedule[i].Description, project.Schedule[i].Description);
                }
            }
        }

        [Fact]
        public void Success_Description()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Description, result.Description);
            }
        }

        [Fact]
        public void Success_Results()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Results, result.Results);
            }
        }

        [Fact]
        public void Success_Difficulty()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Difficulty, result.Difficulty);
            }
        }

        [Fact]
        public void Success_KeyWords()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.KeyWords, result.KeyWords);
            }
        }

        [Fact]
        public void Success_Summary()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(project.Code);

                Assert.Equal(project.Summary, result.Summary);
            }
        }
    }
}