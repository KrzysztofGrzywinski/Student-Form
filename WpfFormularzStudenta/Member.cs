using System;
using System.Collections.Generic;
struct Member
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Uczelnia { get; set; }
    public bool CzyElektrotechnika { get; set; }
    public DateTime DataPraktyki { get; set; }
    public List<string> Jezyki;
}