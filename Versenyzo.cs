using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verseny;

internal class Versenyzo
{
    public string Nev { get; set; }
    public int SzulEv { get; set; }
    public string RajtSzam { get; set; }
    public bool Nem { get; set; }
    public string Kategoria { get; set; }
    public Dictionary<string, TimeSpan> VersenyIdo { get; set; }

    public int TotalTimeInSeconds => /*Casting =>*/(int)VersenyIdo.Values.Sum(ts => ts.TotalSeconds);

    public override string ToString() =>
        $"[{RajtSzam}] {Nev} {(Nem ? "Ferfi" : "Nő")} {Kategoria}";

    public Versenyzo(string sor)
    {
        var split = sor.Split(';');
        Nev = split[0];
        SzulEv = int.Parse(split[1]);
        RajtSzam = split[2];
        Nem = split[3] == "f";
        Kategoria = split[4];
        VersenyIdo = new()
        {
            {"swimming", TimeSpan.Parse(split[5])},
            {"1st depot", TimeSpan.Parse(split[6])},
            {"cycling", TimeSpan.Parse(split[7])},
            {"2nd depot", TimeSpan.Parse(split[8])},
            {"running", TimeSpan.Parse(split[9])},
        };
    }

}
