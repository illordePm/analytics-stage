using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelitySurvey
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string? Title { get; set; }

    public string? PublicDescription { get; set; }

    public string? SubmittedMessage { get; set; }

    public string? UniqueTransactionCodePrivateKey { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int BrandId { get; set; }

    public string? EmailTemplateId { get; set; }

    public int SubmitAction { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<FidelitySurveyQuestion> FidelitySurveyQuestions { get; set; } = new List<FidelitySurveyQuestion>();

    public virtual ICollection<FidelitySurveyResponse> FidelitySurveyResponses { get; set; } = new List<FidelitySurveyResponse>();

    public virtual ICollection<FidelitySurveysLang> FidelitySurveysLangs { get; set; } = new List<FidelitySurveysLang>();
}
