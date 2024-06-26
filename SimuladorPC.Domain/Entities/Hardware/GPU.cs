﻿using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities.Hardware;

public class Gpu : Componente
{
    public int Comprimento_Cm { get; private set; }
    public float Peso_Kg { get; private set; }
    public int QtdMemoriaEmGb { get; private set; }
    public int PortasDisplayPort { get; private set; }
    public int PortasHdmi { get; private set; }
    public int QtdCoolers { get; private set; }
    public int PotenciaRecomendadaEmWatts { get; private set; }
    public int FrequenciaBaseMhz { get; private set; }
    public int FrequenciaMaxMhz { get; private set; }
    public int PontuacaoPassMarkG3D { get; private set; }
    public virtual IList<Tecnologias> TecnologiasSuportadas { get; private set; }
    public VersaoPcie VersaoPcie { get; private set; }
    public double Comprimento { get; set; }
}
