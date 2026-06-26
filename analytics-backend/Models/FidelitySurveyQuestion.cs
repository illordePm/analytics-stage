using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelitySurveyQuestion
{
    public int Id { get; set; }

    public int SurveyId { get; set; }

    public bool IsRequired { get; set; }

    public int QuestionType { get; set; }

    public int OrderNum { get; set; }

    public string Title { get; set; } = null!;

    public string? PublicDescription { get; set; }

    public int? SemanticValue { get; set; }

    public string? AdditionalData { get; set; }

    public virtual ICollection<FidelitySurveyQuestionsLang> FidelitySurveyQuestionsLangs { get; set; } = new List<FidelitySurveyQuestionsLang>();

    public virtual FidelitySurvey Survey { get; set; } = null!;
}
