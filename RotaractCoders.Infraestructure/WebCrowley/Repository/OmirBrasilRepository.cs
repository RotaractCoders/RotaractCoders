using AngleSharp;
using AngleSharp.Dom;
using RotaractCoders.Domain.Contracts.Infraestructure.API.Repository;
using RotaractCoders.Domain.Enums;
using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RotaractCoders.Infraestructure.WebCroley.Repository
{
    public class OmirBrasilRepository : IOmirBrasilRepository
    {
        private IConfiguration config;

        public OmirBrasilRepository()
        {
            config = Configuration.Default.WithDefaultLoader();
        }

        public Project GetByCode(int code)
        {
            var omirBrasilUrl = $"http://projetos.omirbrasil.org.br/exibe_projetos.php?ID_PROJETO={code}";

            var document = BrowsingContext.New(config).OpenAsync(omirBrasilUrl).Result;

            var title = document.QuerySelectorAll(".Titulo");
            var tableTr = document.QuerySelectorAll("#projetoprincipal tr");

            var simpleFields = tableTr.Where(x => x.QuerySelectorAll("b").Length > 0).ToList();
            var listFields = tableTr.Where(x => x.QuerySelectorAll("b").Length == 0).ToList();

            var district = new District(GetDistrictNumber(title));

            var club = new Club(
                GetClubCode(document),
                GetClubName(title),
                GetClubFacebook(simpleFields),
                GetClubEmail(simpleFields),
                district);

            var project = new Project(
                code,
                club,
                GetProjectName(title),
                GetProjectRationale(listFields),
                GetProjectGeneralObjective(listFields),
                GetProjectSpecificObjective(listFields),
                GetProjectMainCategory(listFields),
                GetProjectOtherCategories(listFields),
                GetProjectStartDate(listFields),
                GetProjectEndDate(listFields),
                GetProjectCompletionDate(listFields),
                GetProjectProjectFinancials(),
                GetProjectParticipants(listFields),
                GetProjectTargetAudience(listFields),
                GetProjectDisclosureMeans(listFields),
                GetProjectPartnerships(listFields),
                GetProjectSchedule(listFields),
                GetProjectDescription(listFields),
                GetProjectResults(listFields),
                GetProjectDifficulty(listFields),
                GetProjectKeyWords(listFields),
                GetProjectSummary(listFields));

            return project;
        }

        public void Dispose()
        {
            config = null;
        }

        #region GetByCode - private methods

        private static string GetProjectSummary(List<IElement> listFields)
        {
            return GetValueOfSimpleFieldTable(listFields, "Resumo");
        }

        private static string GetProjectKeyWords(List<IElement> listFields)
        {
            return GetValueOfSimpleFieldTable(listFields, "Palavras-Chave");
        }

        private static EnumDifficulty GetProjectDifficulty(List<IElement> listFields)
        {
            return (EnumDifficulty)(object)GetValueOfSimpleFieldTable(listFields, "Grau de Dificuldade");
        }

        private static string GetProjectResults(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Resultados Qualitativos e Quantitativos")
                .FirstOrDefault();
        }

        private static string GetProjectDescription(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Descrição")
                .FirstOrDefault();
        }

        private static List<Schedule> GetProjectSchedule(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Cronograma de Atividades")
                .Select(x => new Schedule(DateTime.Now, ""))
                .ToList();
        }

        private static List<string> GetProjectPartnerships(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Parcerias");
        }

        private static List<string> GetProjectDisclosureMeans(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Meios de Divulgação");
        }

        private static string GetProjectTargetAudience(List<IElement> listFields)
        {
            return GetValueOfSimpleFieldTable(listFields, "Público Alvo");
        }

        private static List<EnumParticipant> GetProjectParticipants(List<IElement> listFields)
        {
            return GetValueOfSimpleFieldTable(listFields, "Quem trabalho no Projeto | Ação")
                .Split('<')
                .Select(x => EnumParticipant.Rotaract)
                .ToList();
        }

        private static List<ProjectFinancial> GetProjectProjectFinancials()
        {
            return new List<ProjectFinancial>();
        }

        private static DateTime GetProjectCompletionDate(List<IElement> listFields)
        {
            return DateTime.Parse(GetValueOfSimpleFieldTable(listFields, "Data Finalização"));
        }

        private static DateTime GetProjectEndDate(List<IElement> listFields)
        {
            return DateTime.Parse(GetValueOfSimpleFieldTable(listFields, "Data Fim"));
        }

        private static DateTime GetProjectStartDate(List<IElement> listFields)
        {
            return DateTime.Parse(GetValueOfSimpleFieldTable(listFields, "Data Início"));
        }

        private static List<EnumProjectCategory> GetProjectOtherCategories(List<IElement> listFields)
        {
            return GetValueOfSimpleFieldTable(listFields, "Outras Categorias")
                .Select(x => (EnumProjectCategory)x)
                .ToList();
        }

        private static List<EnumProjectCategory> GetProjectMainCategory(List<IElement> listFields)
        {
            return GetValueOfSimpleFieldTable(listFields, "Categoria Principal")
                .Select(x => (EnumProjectCategory)x)
                .ToList();
        }

        private static string GetProjectRationale(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Justificativa")
                .FirstOrDefault();
        }

        private static List<string> GetProjectGeneralObjective(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Objetivo Geral");
        }

        private static List<string> GetProjectSpecificObjective(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Objetivo Especifíco");
        }

        private static string GetProjectName(IHtmlCollection<IElement> title)
        {
            return string.Empty;
        }

        private static string GetDistrictNumber(IHtmlCollection<IElement> title)
        {
            return title[1]
                            .InnerHtml
                            .Substring(title[1].InnerHtml.LastIndexOf('.'))
                            .Replace(".", string.Empty)
                            .Trim();
        }

        private static int GetClubCode(IDocument document)
        {
            return int.Parse(document
                            .QuerySelector("#projetoprincipal tr a")
                            .Attributes
                            .FirstOrDefault(x => x.Name == "href")
                            .Value
                            .Split('\'')[1]);
        }

        private static string GetClubFacebook(List<IElement> simpleFields)
        {
            return GetValueOfSimpleField(simpleFields, "Facebook do Clube");
        }

        private static string GetClubEmail(List<IElement> simpleFields)
        {
            return GetValueOfSimpleField(simpleFields, "E-mail do Clube");
        }

        private static string GetValueOfSimpleField(List<IElement> simpleFields, string bText)
        {
            var element = simpleFields
                            .FirstOrDefault(x => x.QuerySelector("b")
                            .InnerHtml
                            .Contains(bText))
                            .TextContent;

            return element
                .Substring(element.IndexOf(':'))
                .Replace(":", string.Empty)
                .Replace("\n", string.Empty)
                .Trim();
        }

        private static string GetValueOfSimpleFieldTable(List<IElement> simpleFields, string bText)
        {
            var element = simpleFields
                            .FirstOrDefault(x => x.QuerySelector("b")
                            .InnerHtml
                            .Contains(bText))
                            .TextContent;

            return element
                .Substring(element.IndexOf(':'))
                .Replace(":", string.Empty)
                .Replace("\n", string.Empty)
                .Trim();
        }

        private static List<string> GetValueOfListFields(List<IElement> simpleFields, string bText)
        {
            var element = simpleFields
                            .FirstOrDefault(x => x.QuerySelector("b")
                            .InnerHtml
                            .Contains(bText))
                            .TextContent;

            element = element
                .Substring(element.IndexOf(':'))
                .Replace(":", string.Empty)
                .Replace("\n", string.Empty)
                .Trim();

            return new List<string>();
        }

        private static string GetClubName(IHtmlCollection<IElement> title)
        {
            return title[1]
                            .InnerHtml
                            .Substring(0, title[1].InnerHtml.LastIndexOf('-'))
                            .Trim();
        }

        #endregion
    }
}