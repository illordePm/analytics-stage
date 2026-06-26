using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelitySurveysLang
{
    public int SurveyId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? PublicDescription { get; set; }

    public string? SubmittedMessage { get; set; }

    public virtual FidelitySurvey Survey { get; set; } = null!;
}
