using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvreportReinyeccionBalanceModel : ModelBase
    {
        public DateTime? FechaGrupo { get; set; }
        public string PeriodoOperacional { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public decimal? VolumenPulpaM3dia { get; set; }
        public decimal? DensidadPulpaTonm3 { get; set; }
        public decimal? MasaPulpaTondia { get; set; }
        public decimal? SolidoSalmPct { get; set; }
        public decimal? VolSalmPulpM3dia { get; set; }
        public decimal? DensidadSalmPulTonm3 { get; set; }
        public decimal? MasaSalmPulpTondia { get; set; }
        public decimal? VolSalPulpM3dia { get; set; }
        [Required] public decimal DensidadSalPulpTonm3 { get; set; }
        public decimal? SalPulpTondia { get; set; }
        public decimal? KSalmPct { get; set; }
        public decimal? NaSalmPct { get; set; }
        public decimal? MgSalmPct { get; set; }
        public decimal? CaSalmPct { get; set; }
        public decimal? So4SalmPct { get; set; }
        public decimal? LiSalmPct { get; set; }
        public decimal? ClSalmPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? KSalmTon { get; set; }
        public decimal? NaSalmTon { get; set; }
        public decimal? MgSalmTon { get; set; }
        public decimal? CaSalmTon { get; set; }
        public decimal? So4SalmTon { get; set; }
        public decimal? LiSalmTon { get; set; }
        public decimal? ClSalmTon { get; set; }
        public decimal? H3bo3Ton { get; set; }
        public decimal? KSolPct { get; set; }
        public decimal? NaSolPct { get; set; }
        public decimal? MgSolPct { get; set; }
        public decimal? CaSolPct { get; set; }
        public decimal? So4SolPct { get; set; }
        public decimal? LiSolPct { get; set; }
        public decimal? ClSolPct { get; set; }
        public decimal? H3bo3SolPct { get; set; }
        public decimal? KSolTon { get; set; }
        public decimal? NaSolTon { get; set; }
        public decimal? MgSolTon { get; set; }
        public decimal? CaSolTon { get; set; }
        public decimal? So4SolTon { get; set; }
        public decimal? LiSolTon { get; set; }
        public decimal? ClSolTon { get; set; }
        public decimal? H3bo3SolTon { get; set; }
        public decimal? EvapAreaExpuestaM3dia { get; set; }
        public decimal? EvapAreaImpM3dia { get; set; }
        public decimal? MasaEvaporadaTotalM3dia { get; set; }
        public decimal? MasaPrecipitadaTondia { get; set; }
        public decimal? MasaPrecipitadaNaTondia { get; set; }
        public decimal? MasaPrecipitadaClTondia { get; set; }
        public decimal? MasaFinalReinyeccionTondia { get; set; }
        public decimal? SalmueraInfiltradaM3dia { get; set; }
        public decimal? DensidadSalmInfiltradaTonm3 { get; set; }
        public decimal? MasaFinalDpsTondia { get; set; }
        public decimal? KSalmBmPct { get; set; }
        public decimal? NaSalmBmPct { get; set; }
        public decimal? MgSalmBmPct { get; set; }
        public decimal? CaSalmBmPct { get; set; }
        public decimal? So4SalmBmPct { get; set; }
        public decimal? LiSalmBmPct { get; set; }
        public decimal? ClSalmBmPct { get; set; }
        public decimal? H3bo3SalmBmPct { get; set; }
        public decimal? KDpsBmPct { get; set; }
        public decimal? NaDpsBmPct { get; set; }
        public decimal? MgDpsBmPct { get; set; }
        public decimal? CaDpsBmPct { get; set; }
        public decimal? So4DpsBmPct { get; set; }
        public decimal? LiDpsBmPct { get; set; }
        public decimal? ClDpsBmPct { get; set; }
        public decimal? H3bo3DpsBmPct { get; set; }
        public decimal? KSalmBmTon { get; set; }
        public decimal? NaSalmBmTon { get; set; }
        public decimal? MgSalmBmTon { get; set; }
        public decimal? CaSalmBmTon { get; set; }
        public decimal? So4SalmBmTon { get; set; }
        public decimal? LiSalmBmTon { get; set; }
        public decimal? ClSalmBmTon { get; set; }
        public decimal? H3bo3SalmBmTon { get; set; }
        public decimal? KDpsBmTon { get; set; }
        public decimal? NaDpsBmTon { get; set; }
        public decimal? MgDpsBmTon { get; set; }
        public decimal? CaDpsBmTon { get; set; }
        public decimal? So4DpsBmTon { get; set; }
        public decimal? LiDpsBmTon { get; set; }
        public decimal? ClDpsBmTon { get; set; }
        public decimal? H3bo3DpsBmTon { get; set; }
        public decimal? KDesbTon { get; set; }
        public decimal? NaDesbTon { get; set; }
        public decimal? MgDesbTon { get; set; }
        public decimal? CaDesbTon { get; set; }
        public decimal? So4DesbTon { get; set; }
        public decimal? LiDesbTon { get; set; }
        public decimal? ClDesbTon { get; set; }
        public decimal? H3bo3DesbTon { get; set; }
        public decimal? KDesbPct { get; set; }
        public decimal? NaDesbPct { get; set; }
        public decimal? MgDesbPct { get; set; }
        public decimal? CaDesbPct { get; set; }
        public decimal? So4DesbPct { get; set; }
        public decimal? LiDesbPct { get; set; }
        public decimal? ClDesbPct { get; set; }
        public decimal? H3bo3DesbPct { get; set; }
    }
}