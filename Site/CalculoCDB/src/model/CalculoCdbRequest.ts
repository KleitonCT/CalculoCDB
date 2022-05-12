export class CalculoCdbRequest {
    ValorInvestimento:number
    PrazoMeses:number

    constructor(ValorInvestimento: number, PrazoMeses: number) {
        this.ValorInvestimento = ValorInvestimento;
        this.PrazoMeses = PrazoMeses;
      }
  }