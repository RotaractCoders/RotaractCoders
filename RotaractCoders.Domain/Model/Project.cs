using RotaractCoders.Domain.Enums;
using RotaractCoders.Domain.Scopes;
using System;
using System.Collections.Generic;

namespace RotaractCoders.Domain.Model
{
    public class Project
    {
        #region Construtores

        protected Project() { }

        public Project(
            int code,
            Club club, 
            string name, 
            string rationale, 
            List<string> generalObjective, 
            List<string> specificObjective, 
            List<EnumProjectCategory> mainCategory, 
            List<EnumProjectCategory> otherCategories,
            DateTime startDate,
            DateTime endDate,
            DateTime? completionDate,
            List<ProjectFinancial> projectFinancials,
            List<EnumParticipant> participants,
            string targetAudience,
            List<string> disclosureMeans,
            List<string> partnerships,
            List<Schedule> schedule,
            string description,
            string results,
            EnumDifficulty difficulty,
            string keyWords,
            string summary
            )
        {
            Id = Guid.NewGuid();
            Code = code;
            Club = club;
            Name = name;
            Rationale = rationale;
            GeneralObjective = generalObjective;
            SpecificObjective = specificObjective;
            MainCategory = mainCategory;
            OtherCategories = otherCategories;
            StartDate = startDate;
            EndDate = endDate;
            CompletionDate = completionDate;
            ProjectFinancials = projectFinancials;
            Participants = participants;
            TargetAudience = targetAudience;
            DisclosureMeans = disclosureMeans;
            Partnerships = partnerships;
            Schedule = schedule;
            Description = description;
            Results = results;
            Difficulty = difficulty;
            KeyWords = keyWords;
            Summary = summary;
        }

        #endregion

        #region Propriedades

        public Guid Id { get; private set; }

        public int Code { get; private set; }

        public string Name { get; private set; }

        public string Rationale { get; private set; }

        public List<string> GeneralObjective { get; private set; }

        public List<string> SpecificObjective { get; private set; }

        public List<EnumProjectCategory> MainCategory { get; private set; }

        public List<EnumProjectCategory> OtherCategories { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public DateTime? CompletionDate { get; private set; }

        public List<ProjectFinancial> ProjectFinancials { get; private set; }

        public List<EnumParticipant> Participants { get; private set; }

        public string TargetAudience { get; private set; }

        public List<string> DisclosureMeans { get; private set; }

        public List<string> Partnerships { get; private set; }

        public List<Schedule> Schedule { get; private set; }

        public string Description { get; private set; }

        public string Results { get; private set; }

        public EnumDifficulty Difficulty { get; private set; }

        public string KeyWords { get; private set; }

        public string Summary { get; private set; }

        public Club Club { get; private set; }

        #endregion

        #region Methods

        public bool IsValid()
        {
            return this.ScopeIsValid();
        }

        #endregion
    }
}