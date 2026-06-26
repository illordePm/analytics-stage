using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelitySurveyQuestionsLang
{
    public int SurveyQuestionId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? PublicDescription { get; set; }

    public string? AdditionalData { get; set; }

    public virtual FidelitySurveyQuestion SurveyQuestion { get; set; } = null!;
}
