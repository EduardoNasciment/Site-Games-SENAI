﻿namespace SM_Horarios;

public class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public int AccessCode { get; set; }
    public string? Password { get; set; }

    public ICollection<Firm>? Firm { get; set; }
    public ICollection<MarkedTime>? MarkedTime { get; set; }
}
