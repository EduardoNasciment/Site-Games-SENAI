﻿namespace SM_Horarios;

public class Firm
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public string? AccessCode { get; set; }
    public string? Password { get; set; }

    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    public ICollection<MarkedTime>? MarkedTime { get; set; }
}
