using System;
using System.Collections.Generic;

namespace CQRS_and_Repository_Pattern.Database.Model.Entities;

public partial class PcuMstGender
{
    public int GEND_ID { get; set; }
    public string? GEND_CODE { get; set; }
    public string? GEND_NAME_TH { get; set; }
    public string? GEND_NAME_EN { get; set; }
    public string? IS_ACTIVE { get; set; }
    public string? CREATED_BY { get; set; }
    public DateTime? CREATED_DATE { get; set; }
    public string? UPDATED_BY { get; set; }
    public DateTime? UPDATED_DATE { get; set; }
}
