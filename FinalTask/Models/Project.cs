﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class Project
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string? Name { get; set; }
        [JsonPropertyName("note")] public string? Summary { get; set; }
        [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
        [JsonPropertyName("milestone_count")] public int MilestoneCount { get; set; }
        [JsonPropertyName("milestone_active_count")] public int MilestoneActiveCount { get; set; }
        [JsonPropertyName("run_count")] public int RunCount { get; set; }
        [JsonPropertyName("run_active_count")] public int RunActiveCount { get; set; }
        [JsonPropertyName("run_closed_count")] public int RunClosedCount { get; set; }
        [JsonPropertyName("session_count")] public int SessionCount { get; set; }
        [JsonPropertyName("session_active_count")] public int SessionActiveCount { get; set; }
        [JsonPropertyName("session_closed_count")] public int SessionClosedCount { get; set; }
        [JsonPropertyName("automation_source_count")] public int AutomationSourceCount { get; set; }
        [JsonPropertyName("automation_source_active_count")] public int AutomationSourceActiveCount { get; set; }
        [JsonPropertyName("automation_source_retired_count")] public int AutomationSourceRetiredCount { get; set; }
        [JsonPropertyName("automation_run_count")] public int AutomationRunCount { get; set; }
        [JsonPropertyName("automation_run_active_count")] public int AutomationRunActiveCount { get; set; }
        [JsonPropertyName("automation_run_completed_count")] public int AutomationRunCompletedCount { get; set; }
        [JsonPropertyName("created_at")] public string CreatedAt { get; set; }
        [JsonPropertyName("created_by")] public int CreatedBy { get; set; }
        [JsonPropertyName("updated_at")] public string UpdatedAt { get; set; }
        [JsonPropertyName("completed_at")] public string CompletedAt { get; set; }
    }
}
