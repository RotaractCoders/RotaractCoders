using RotaractCoders.Domain.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.Model
{
    public class Club
    {
        #region Constructors

        protected Club() { }

        public Club(int code, string name, string facebook, string email, District district)
        {
            Id = Guid.NewGuid();
            Code = code;
            Name = name;
            Facebook = facebook;
            Email = email;
            District = district;
        }

        #endregion

        #region Methods

        public Guid Id { get; private set; }

        public int Code { get; private set; }

        public string Name { get; private set; }

        public string Facebook { get; private set; }

        public string Email { get; private set; }

        public District District { get; private set; }

        public List<Project> Projects { get; private set; }

        #endregion

        #region Methods

        public bool IsValid()
        {
            return this.ScopeIsValid();
        }

        public bool AddProject(Project project)
        {
            if (!project.IsValid()) return false;

            Projects.Add(project);
            return true;
        }

        #endregion
    }
}
