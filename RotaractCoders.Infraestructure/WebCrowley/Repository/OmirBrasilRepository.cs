using AngleSharp;
using AngleSharp.Dom;
using RotaractCoders.Common;
using RotaractCoders.Domain.Contracts.Infraestructure.API.Repository;
using RotaractCoders.Domain.Enums;
using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
                GetProjectRationale(simpleFields),
                GetProjectGeneralObjective(simpleFields),
                GetProjectSpecificObjective(simpleFields),
                GetProjectMainCategory(simpleFields),
                GetProjectOtherCategories(simpleFields),
                GetProjectStartDate(simpleFields),
                GetProjectEndDate(simpleFields),
                GetProjectCompletionDate(simpleFields),
                GetProjectProjectFinancials(simpleFields),
                GetProjectParticipants(simpleFields),
                GetProjectTargetAudience(simpleFields),
                GetProjectDisclosureMeans(simpleFields),
                GetProjectPartnerships(simpleFields),
                GetProjectSchedule(simpleFields),
                GetProjectDescription(simpleFields),
                GetProjectResults(simpleFields),
                GetProjectDifficulty(simpleFields),
                GetProjectKeyWords(simpleFields),
                GetProjectSummary(simpleFields));

            return project;
        }

        public void Dispose()
        {
            config = null;
        }

        #region GetByCode - private methods

        private static string GetProjectSummary(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Resumo")
                .FirstOrDefault();
        }

        private static string GetProjectKeyWords(List<IElement> listFields)
        {
            return GetValueOfSimpleField(listFields, "Palavras-Chave");
        }

        private static EnumDifficulty GetProjectDifficulty(List<IElement> listFields)
        {
            var difficulty = GetValueOfSimpleField(listFields, "Grau de Dificuldade")
                .ToLower();

            return (EnumDifficulty)Enum.Parse(typeof(EnumDifficulty), difficulty , true);
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
            var element = listFields
                .FirstOrDefault(x => x.QuerySelector("b")
                .InnerHtml
                .Contains("Cronograma de Atividades"))
                .NextElementSibling
                .QuerySelectorAll("tr");

            return element
                .Select(x => new Schedule(Convert.ToDateTime(x.Children[0].TextContent), x.Children[1].TextContent.Trim()))
                .ToList();
        }

        private static List<string> GetProjectPartnerships(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Parcerias");
        }

        private static List<string> GetProjectDisclosureMeans(List<IElement> listFields)
        {
            return GetValueOfListFields(listFields, "Meios de Divulgação")
                .Select(x => x
                    .Split(';')[0])
                .ToList();
        }

        private static string GetProjectTargetAudience(List<IElement> listFields)
        {
            return GetValueOfSimpleField(listFields, "Público Alvo");
        }

        private static List<EnumParticipant> GetProjectParticipants(List<IElement> listFields)
        {
            var result = GetValueOfSimpleField(listFields, "Quem trabalho no Projeto | Ação")
                .Split(new[] { "00" }, StringSplitOptions.None)
                .Where(x => x != string.Empty)
                .Select(x => x
                    .Substring(x.IndexOf(' '))
                    .Replace("-", string.Empty)
                    .Trim());

            return result
                .Select(x => (EnumParticipant)Enum.Parse(typeof(EnumParticipant), x.Replace(" ", string.Empty).Replace("á", "a"), true))
                .ToList();
        }

        private static List<ProjectFinancial> GetProjectProjectFinancials(List<IElement> listFields)
        {
            var element = listFields
                .FirstOrDefault(x => x.QuerySelector("b")
                .InnerHtml
                .Contains("Relatório Financeiro"))
                .NextElementSibling
                .QuerySelectorAll("tr");

            var result = new List<ProjectFinancial>();

            for (int i = 0; i < element.Count() - 1; i++)
            {
                result.Add(new ProjectFinancial(Convert.ToDateTime(element[i].Children[0].TextContent), element[i].Children[1].TextContent.Trim(), Convert.ToDecimal(element[i].Children[2].TextContent.Trim().Replace(",", "."))));
            }

            return result;
        }

        private static DateTime? GetProjectCompletionDate(List<IElement> listFields)
        {
            var result = new DateTime();

            if (DateTime.TryParse(GetValueOfSimpleField(listFields, "Data Finalização"), out result))
                return result;

            return null;
        }

        private static DateTime GetProjectEndDate(List<IElement> listFields)
        {
            return DateTime.Parse(GetValueOfSimpleField(listFields, "Data Fim"));
        }

        private static DateTime GetProjectStartDate(List<IElement> listFields)
        {
            return DateTime.Parse(GetValueOfSimpleField(listFields, "Data Início"));
        }

        private static List<EnumProjectCategory> GetProjectOtherCategories(List<IElement> listFields)
        {
            var category = GetValueOfSimpleField(listFields, "Outras Categorias");

            return new List<EnumProjectCategory>
            {
                (EnumProjectCategory)Enum.Parse(typeof(EnumProjectCategory), category, true)
            };
        }

        private static List<EnumProjectCategory> GetProjectMainCategory(List<IElement> listFields)
        {
            var category = GetValueOfSimpleField(listFields, "Categoria Principal");

            return new List<EnumProjectCategory>
            {
                (EnumProjectCategory)Enum.Parse(typeof(EnumProjectCategory), category, true)
            };
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
            return GetValueOfListFields(listFields, "Objetivo Especifíco")
                .Where(x => x != string.Empty)
                .ToList();
        }

        private static string GetProjectName(IHtmlCollection<IElement> title)
        {
            return title[0]
                .InnerHtml
                .Split('>')[1]
                .Trim();
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

            var result = element
                .Substring(element.IndexOf(':'))
                .Replace("\n", string.Empty)
                .Trim();

            result = new Regex(Regex.Escape(":"))
                .Replace(result, string.Empty, 1)
                .Trim();

            result = new Regex(Regex.Escape("-"))
                .Replace(result, string.Empty, 1)
                .Trim();

            return result;
        }

        private static List<string> GetValueOfListFields(List<IElement> simpleFields, string bText)
        {
            return simpleFields
                .FirstOrDefault(x => x.QuerySelector("b")
                .InnerHtml
                .Contains(bText))
                .NextElementSibling
                .QuerySelectorAll("p")
                .Select(x => new Regex(Regex.Escape("-"))
                    .Replace(x.TextContent
                        .Replace("\n", string.Empty) , string.Empty, 1)
                    .Trim())
                .ToList();
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