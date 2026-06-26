using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelitySurveyResponse
{
    public int Id { get; set; }

    public int SurveyId { get; set; }

    public string AnswerCode { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string AnswersJson { get; set; } = null!;

    public DateTime DateSubmitted { get; set; }

    public virtual FidelitySurvey Survey { get; set; } = null!;
}
